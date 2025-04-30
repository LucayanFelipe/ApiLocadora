# ApiLocadora

CREATE DATABASE locadora_db;
use locadora_db;




CREATE TABLE genres(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE studios(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    distribuidor VARCHAR(255) NOT NULL
);

CREATE TABLE films(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    data_lancamento DATE NOT NULL,
    diretor VARCHAR(255) NOT NULL,
    descricao VARCHAR(255) NOT NULL,
    avaliacao DOUBLE NOT NULL
   /* id_genero_fk INT,
    id_estudio_fk INT,
    FOREIGN KEY (id_genero_fk) REFERENCES genre(id),
    FOREIGN KEY (id_estudio_fk) REFERENCES studio(id)
    /*genre e studio*/
);



insert into genres values(1,"infantil");
insert into studios values(1,"quintal da vovo", "walt disney");
insert into films values(1, "frozen", "2000-12-24","johan director",
"moça gelada frio brrr", "10");

select * from films;


