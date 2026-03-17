CREATE TABLE Utenti (
	id INT PRIMARY KEY,
	nome VARCHAR(100),
	email VARCHAR(100)
)Engine = InnoDB; #Per fare il match delle relazioni: non lo fa veramente in automatico, quindi meglio scriverlo

CREATE TABLE Profili (
	id INT PRIMARY KEY,
	biografia TEXT,
	FOREIGN KEY (id) REFERENCES Utenti(id)
)Engine = InnoDB;

INSERT INTO Utenti(id,nome,email)
VALUES
	(1,"Mario","mario@email.it"),
    (2,"Ciccio","ciccio@email.it"),
    (3,"Luigi","luigi@email.it");
    
INSERT INTO Profili(id,biografia)
VALUES
	(1,"Sono Mario e sono un idraulico"),
    (2,"Mangio panini"),
    (3,"Sono Luigi e sono il fratello di Mario");
    
SELECT utenti.nome, utenti.email, profili.biografia
FROM  utenti INNER JOIN profili WHERE utenti.id = profili.id;
