USE biblioteca;
SELECT * FROM biblioteca.libreria_libri
WHERE autore = "George Orwell";

SELECT * FROM biblioteca.libreria_libri
WHERE anno > 1958;

SELECT * FROM biblioteca.libreria_libri
WHERE anno BETWEEN 1928 and 1969;

SELECT * FROM biblioteca.libreria_libri
WHERE titolo LIKE "%c%";

SELECT * FROM biblioteca.libreria_libri
WHERE titolo LIKE "L%";

SELECT * FROM biblioteca.libreria_libri
WHERE anno = (SELECT MIN(anno) FROM biblioteca.libreria_libri);

SELECT * FROM biblioteca.libreria_libri
WHERE anno = (SELECT MAX(anno) FROM biblioteca.libreria_libri);