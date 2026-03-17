USE ufficio;
SELECT * FROM ufficio.aula;

ALTER TABLE aula 		#Questo comando mi permette di modificare una tabella
ADD email varchar(50); 	#In questo caso aggiunge un campo nuovo

ALTER TABLE aula
MODIFY COLUMN email text;	#Mi permette di modificare il datatype di una colonna

ALTER TABLE aula
DROP COLUMN email;			#Mi permette di eliminare la colonna

UPDATE aula SET nome = "Kassandra" WHERE id = 3;	#Update consente la modifica del dato stesso, basta che esista la chiave primaria