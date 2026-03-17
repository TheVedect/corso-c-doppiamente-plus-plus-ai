CREATE TABLE IF NOT exists Clienti (
	id INT PRIMARY KEY,
	nome VARCHAR(100)
)Engine = InnoDB; #Per fare il match delle relazioni: non lo fa veramente in automatico, quindi meglio scriverlo

CREATE TABLE IF NOT exists Prenotazioni (
	id INT PRIMARY KEY,
	descrizione TEXT,
    id_cliente INT,
	FOREIGN KEY (id_cliente) REFERENCES Clienti(id)
)Engine = InnoDB;

INSERT INTO Clienti(id,nome)
VALUES
	(1,"Mario"),
    (2,"Ciccio"),
    (3,"Luigi"),
    (4,"Waluigi");
    
INSERT INTO Prenotazioni (id,descrizione,id_cliente)
VALUES
	(100,"Sono Mario e voglio 2 pizze",1),
    (101,"Sono Ciccio e voglio un panino enorme",2),
    (102,"Mario, ho PAURA",3);
    
SELECT Clienti.nome, Prenotazioni.descrizione, Prenotazioni.id_cliente
FROM  Clienti LEFT JOIN Prenotazioni ON Clienti.id = Prenotazioni.id_cliente;