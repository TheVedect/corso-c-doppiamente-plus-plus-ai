CREATE DATABASE IF NOT exists biblioteca;

USE biblioteca;

CREATE TABLE IF NOT exists libreria_libri_autogen(
	id int NOT NULL auto_increment,	#Mi permette di creare indici sequenziali in automatico
    titolo varchar(50),
    autore varchar(50),
    anno int,
    PRIMARY KEY(id)					#Questo imposta quale è la chiave primaria
);

INSERT INTO libreria_libri_autogen(titolo,autore,anno)	#Dato che id è autogenerato, non lo devo mettere
VALUES
	("Lo straniero",						"Albert Camus", 					1942),
    ("Alla ricerca del tempo perduto",		"Marcel Proust",					1927),
    ("Il processo",							"Franz Kafka",						1925),
    ("Il piccolo principe",					"Antoine de Saint-Exupéry",			1943),
	("La condizione umana",					"André Malraux",					1933),
	("Viaggio al termine della notte",		"Louis-Ferdinand Céline",			1932),
	("Furore",								"John Steinbeck", 					1939),
	("Per chi suona la campana",			"Ernest Hemingway", 				1940),
	("Il grande Meaulnes",					"Alain-Fournier",					1913),
	("La schiuma dei giorni",				"Boris Vian",						1947);
	