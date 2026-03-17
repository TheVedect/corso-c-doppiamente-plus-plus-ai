CREATE DATABASE IF NOT exists biblioteca;

USE biblioteca;

CREATE TABLE IF NOT exists libreria_libri(
	id int,
    titolo varchar(50),
    autore varchar(50),
    anno int
);

INSERT INTO libreria_libri(id,titolo,autore,anno)
VALUES
	(1, 	"Lo straniero",						"Albert Camus", 					1942),
    (2,		"Alla ricerca del tempo perduto",	"Marcel Proust",					1927),
    (3,		"Il processo",						"Franz Kafka",						1925),
    (4,		"Il piccolo principe",				"Antoine de Saint-Exupéry",			1943),
	(5,		"La condizione umana",				"André Malraux",					1933),
	(6,		"Viaggio al termine della notte",	"Louis-Ferdinand Céline",			1932),
	(7,		"Furore",							"John Steinbeck", 					1939),
	(8,		"Per chi suona la campana",			"Ernest Hemingway", 				1940),
	(9,		"Il grande Meaulnes",				"Alain-Fournier",					1913),
	(10, 	"La schiuma dei giorni",			"Boris Vian",						1947),
	(11,	"Il secondo sesso",					"Simone de Beauvoir",				1949),
	(12,	"Aspettando Godot",					"Samuel Beckett", 					1952),
	(13,	"L'essere e il nulla",				"Jean-Paul Sartre", 				1943),
	(14,	"Il nome della rosa",				"Umberto Eco",						1980),
	(15,	"Arcipelago Gulag",					"Aleksandr Solženicyn", 			1973),
	(16,	"Paroles",							"Jacques Prévert",					1946),
	(17,	"Alcools",							"Guillaume Apollinaire",			1913),
	(18,	"Il loto blu",						"Hergé",							1936),
	(19,	"Diario di Anna Frank",				"Anna Frank",						1947),
	(20,	"Tristi tropici",					"Claude Lévi-Strauss",				1955),
	(21,	"Il mondo nuovo",					"Aldous Huxley",					1932),
	(22,	"1984",								"George Orwell",					1949),
	(23,	"Asterix il gallico",				"René Goscinny e Albert Uderzo",	1959),
	(24,	"La cantatrice calva",				"Eugène Ionesco",					1952),
	(25,	"Tre saggi sulla teoria sessuale",	"Sigmund Freud",					1905),
	(26,	"L'opera al nero",					"Marguerite Yourcenar",				1968),
	(27,	"Lolita",							"Vladimir Nabokov",					1955),
	(28,	"Ulisse",							"James Joyce",						1922),
	(29,	"Il deserto dei Tartari",			"Dino Buzzati",						1940),
	(30,	"I falsari",						"André Gide", 						1925);
    
    