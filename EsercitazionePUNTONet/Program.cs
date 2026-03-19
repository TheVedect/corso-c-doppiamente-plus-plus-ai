using Microsoft.ML;
using Microsoft.ML.Data;
using ScottPlot;
// Classe principale
class Program {
   static void Main() {
        var context = new MLContext(seed: 69420);

        // --- 2. Caricamento Dati ---
        Console.WriteLine("Caricamento dati in corso...");
        IDataView dataView = context.Data.LoadFromTextFile<FilmData>("disneymovietotalgross.csv", hasHeader: true, allowQuoting: true, separatorChar: ',');
        var trainTestSplit = context.Data.TrainTestSplit(dataView, testFraction: 0.2);

        // --- 3. Pipeline di Trasformazione e Training ---
        // Gli algoritmi ML leggono solo numeri. Dobbiamo convertire le stringhe in vettori numerici (OneHotEncoding).
        var pipeline = context.Transforms.CustomMapping<FilmData, FilmData>((input, output) => {
            output.MovieTitle = input.MovieTitle;
            output.Year = float.Parse(input.DateReleased.Substring(input.DateReleased.Length - 4));
            output.Genre = input.Genre;
            output.MPAARating = input.MPAARating;
            output.TotalGross = input.TotalGross;
        }, "YearReleasedEncoded")
            .Append(context.Transforms.Categorical.OneHotEncoding("GenreEncoded", nameof(FilmData.Genre)))
            .Append(context.Transforms.Categorical.OneHotEncoding("MPAARatingEncoded", nameof(FilmData.MPAARating)))
            .Append(context.Transforms.Concatenate("Features", "Year", "GenreEncoded", "MPAARatingEncoded"))
            .Append(context.Regression.Trainers.FastTree()); // Algoritmo basato su alberi di decisione

        Console.WriteLine("Addestramento del modello...");
        var model = pipeline.Fit(trainTestSplit.TrainSet);

        // --- 4. Valutazione ---
        var predictions = model.Transform(trainTestSplit.TestSet);
        var metrics = context.Regression.Evaluate(predictions);
        Console.WriteLine($"Metriche Modello:\n - R-Squared: {metrics.RSquared:0.##}\n - MAE (Errore Medio): {metrics.MeanAbsoluteError:0.##} $");

        // --- 5. Visualizzazione con ScottPlot ---
        VisualizzaRisultati(context, model, trainTestSplit.TestSet);
        
        // --- 6. Previsione con un nuovo dato ---
        var predictionEngine = context.Model.CreatePredictionEngine<FilmData, FilmPrediction>(model);

        var mariohopaura = new FilmData { 
            MovieTitle = "Mario, ho PAURA", 
            DateReleased = "12/12/2012", 
            Genre = "Comedy", 
            MPAARating = "PG"
        };
        var prediction = predictionEngine.Predict(mariohopaura);
        Console.WriteLine($"Previsione costo per il nuovo film: {prediction.PredictedTotalGross:0.##} $");

        
    }

    static void VisualizzaRisultati(MLContext context, ITransformer model, IDataView testData) {
        // Estraiamo i dati per il grafico (primi 50 campioni)
        var predictionsRaw = model.Transform(testData);
        var predictedEnumerable = context.Data.CreateEnumerable<FilmPrediction>(predictionsRaw, reuseRowObject: false).Take(50).ToArray();
        var actualEnumerable = context.Data.CreateEnumerable<FilmData>(testData, reuseRowObject: false).Take(50).ToArray();

        double[] indices = Enumerable.Range(0, 50).Select(x => (double)x).ToArray();
        double[] actuals = actualEnumerable.Select(x => (double)x.TotalGross).ToArray();
        double[] predicts = predictedEnumerable.Select(x => (double)x.PredictedTotalGross).ToArray();

        // --- NUOVA SINTASSI SCOTTPLOT 5 ---
        var plt = new ScottPlot.Plot(); // In SP5 le dimensioni si passano nel Save()

        // Add.Scatter ora restituisce un oggetto "Scatter"
        var s1 = plt.Add.Scatter(indices, actuals);
        s1.Label = "Reale";
        s1.Color = Colors.Blue;

        var s2 = plt.Add.Scatter(indices, predicts);
        s2.Label = "Predetto";
        s2.Color = Colors.Red;

        // Titoli e Label
        plt.Title("Confronto Prezzi Assicurazione: Reale vs Predetto");
        plt.XLabel("Paziente (Campione)");
        plt.YLabel("Costo ($)");

        // La legenda ora si attiva così
        plt.ShowLegend();

        // Il salvataggio specifica qui la risoluzione
        plt.SavePng("RisultatoML.png", 800, 600);
    
        Console.WriteLine("Grafico generato con successo: RisultatoML.png");
    }
}
