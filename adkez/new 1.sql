CREATE DATABASE IF NOT EXISTS allatkert;

USE allatkert;

CREATE TABLE IF NOT EXISTS emlosok
(
	azonosito INT(11) NOT NULL AUTO_INCREMENT ,
	nev VARCHAR(30) NOT NULL ,
	PRIMARY KEY (azonosito)
)ENGINE = InnoDb;

CREATE TABLE gondozok
(
	hozzarendelt_allat VARCHAR(8) NOT NULL AUTO_INCREMENT ,
	nev VARCHAR(25) NOT NULL ,
	PRIMARY KEY (hozzarendelt_allat)
)ENGINE = InnoDb;