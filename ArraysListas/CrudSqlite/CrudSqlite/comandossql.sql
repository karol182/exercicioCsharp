-- DDL, DML, DQL
-- DDL -> Data Definition Language (Create, DROP
-- DML -> Data Manipulation Language (Insert,Update, Delete)
-- DQL -> Data Query Language (SELECT)

-- DQL
select * from frutas;

-- DML - INSERT
INSERT INTO frutas (nomeFruta)
VALUES
("Uva");

-- DML - UPDATE
UPDATE frutas SET nomeFruta = 'Uva' WHERE nomeFruta = 'Banana';

-- DML - DELETE
DELETE FROM frutas WHERE nomeFruta == 'Uva';

-- DQL
SELECT nomeFruta FROM frutas
UNION 
SELECT count (*) from frutas ORDER by nomeFruta asc limit 4;