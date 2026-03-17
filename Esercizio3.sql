CREATE TABLE Studenti (
	matricola INT PRIMARY KEY,
	nome VARCHAR(100)
)Engine = InnoDB; #Per fare il match delle relazioni: non lo fa veramente in automatico, quindi meglio scriverlo

CREATE TABLE Matricole (
	matricola INT PRIMARY KEY,
	biografia TEXT,
    email_universitaria varchar(50),
	FOREIGN KEY (matricola) REFERENCES Studenti(matricola)
)Engine = InnoDB;

INSERT INTO Studenti(matricola,nome)
VALUES
	(1758952,"Mario"),
    (1837462,"Ciccio"),
    (1593827,"Luigi");
    
INSERT INTO Matricole(matricola,biografia,email_universitaria)
VALUES
	(1758952,"Viva il tubo con le due manopole","mario@email.it"),
    (1837462,"Bello che è mangiare","ciccio@email.it"),
    (1593827,"Mario, ho PAURA","luigi@email.it");
    
SELECT Studenti.matricola, Studenti.nome, Matricole.biografia, Matricole.email_universitaria
FROM  Studenti INNER JOIN Matricole WHERE Studenti.matricola = Matricole.matricola;