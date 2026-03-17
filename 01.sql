CREATE DATABASE IF NOT exists ufficio;	#IF NOT exists mi permette di non avere un errore
										#e quindi non bloccare il programma

USE ufficio;						    #Devo dire di star usando tale DB

CREATE TABLE IF NOT exists aula(
	id int not null, #non può essere nullo
    nome varchar(30),
    cognome varchar(30),
    cell bigint unique, #non può essere ripetuto
    ruolo varchar(50)
);

INSERT INTO aula(id, nome, cognome, cell, ruolo) #Inserisce elementi
VALUES											 #Values è un continuativo, quindi non serve il punto e virgola
	(1, "Marcello", "Improta", 3930381388, "Docente bello"),
	(2, "Augusto", "Biscica", 3947298458, "Capo-elettricista"),
    (3, "Cassandra", "Python", 3749384719, "Dirigente");