USE host1323541_sbd06;

CREATE TABLE tab_capitals
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  population  INT NOT NULL
);

CREATE TABLE tab_countries
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  capital_id  INT NOT NULL,
  population INT NOT NULL,
  area DOUBLE NOT NULL ,
  part_of_the_world VARCHAR(100) NOT NULL,
  FOREIGN KEY (capital_id) REFERENCES tab_capitals(id)
  ON UPDATE NO ACTION
  ON DELETE NO ACTION
);

CREATE TABLE tab_cities
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  population  INT NOT NULL,
  country_id INT NOT NULL,
  FOREIGN KEY (country_id) REFERENCES tab_countries(id)
  ON UPDATE NO ACTION
  ON DELETE NO ACTION
);

-- Ввод тестовых данных

INSERT INTO tab_capitals(name, population)
VALUES ('Moscow',12632409);
INSERT INTO tab_capitals(name, population)
VALUES ('Riga',614618);
INSERT INTO tab_capitals(name, population)
VALUES ('Buenos Aires',3063728);
INSERT INTO tab_capitals(name, population)
VALUES ('Vatican City',825);
INSERT INTO tab_capitals(name, population)
VALUES ('Washington',705749);
INSERT INTO tab_capitals(name, population)
VALUES ('Reykjavik',134010);
INSERT INTO tab_capitals(name, population)
VALUES ('Beijing',21893095);
INSERT INTO tab_capitals(name, population)
VALUES ('Nairobi',5545000);

INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Russia',1,145478097,17125191,'Europe');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Latvia',2,1893700,64589,'Europe');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Argentina',3,45605826,2780400,'South America');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Vatican',4,825,0.44,'Europe');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('USA',5,332278200,9826675,'Northern America');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Iceland',6,368590,103125,'Europe');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('China',7,1442965000,9596961,'Asia');
INSERT INTO tab_countries(name, capital_id, population, area, part_of_the_world)
VALUES ('Kenya',8,54985698,580367,'Africa');

INSERT INTO tab_cities(name, population, country_id)
VALUES ('Saint Petersburg',5376672,1);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Novosibirsk',1620162,1);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Daugavpils',80627,2);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Liepaja',67964,2);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Cordova',1329604,3);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Rosario',1193605,3);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Vatican City',825,4);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('New York City',8405837,5);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Los Angeles',3990456,5);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Koupavogur',33045,6);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Habnarfjordur',28085,6);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Shanghai',24870895,7);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Chongqing',32054159,7);
INSERT INTO tab_cities(name, population, country_id)
VALUES ('Mombasa',1200000,8);
