using Microsoft.ML.Data;

public class FilmData {
    [LoadColumn(0)] public string MovieTitle;
    [LoadColumn(1)] public string DateReleased; // Verrà trasformato in numeri
    [LoadColumn(2)] public string Genre;
    [LoadColumn(3)] public string MPAARating;
    [LoadColumn(4), ColumnName("Label")] public float TotalGross; // Il Target
    [LoadColumn(1)] public float Year;
}

public class FilmPrediction {
    [ColumnName("Score")] public float PredictedTotalGross;
}