#database escola
CREATE DATABASE bd_escola


#Tabela Escola
CREATE TABLE escola(
    `cod_escola` INT(11) NOT NULL PRIMARY KEY,
    `nome` VARCHAR(200) NOT NULL
);

#Tabela Sala
CREATE TABLE sala(
    `numero_sala` INT(11) NOT NULL PRIMARY KEY,
    `nome` VARCHAR(100) NOT NULL
);

#Tabela Turma
CREATE TABLE turma(
    `cod_turma` INT(11) NOT NULL PRIMARY KEY,
    `modulo` INT(10) NOT NULL,
    `nome` VARCHAR(100) NOT NULL,
   	`periodo` VARCHAR (100) NOT NULL,
    `data_ingresso` DATE NOT NULL, 
    `FK_cod_escola` INT(11) NOT NULL,
    `FK_numero_sala` INT(11) NOT NULL,

    CONSTRAINT `FK_escola` FOREIGN KEY (`FK_cod_escola`) REFERENCES escola(`cod_escola`),
    CONSTRAINT `FK_sala` FOREIGN KEY (`FK_numero_sala`) REFERENCES sala(`numero_sala`)
);


#Tabela Professor 
CREATE TABLE professor(
    `matricula` INT(5) NOT NULL PRIMARY KEY,
    `cpf` INT(11) NOT NULL,
    `nome` VARCHAR(200) NOT NULL,
    `formacao` VARCHAR(200) NOT NULL
);

#Tabela turma_professor
CREATE TABLE turma_professor(
    `FK_matricula` INT(5) NOT NULL,
    `FK_cod_turma` INT(11) NOT NULL,

    CONSTRAINT `FK_professor` FOREIGN KEY (`FK_matricula`) REFERENCES professor(`matricula`),
    CONSTRAINT `FK_turma` FOREIGN KEY (`FK_cod_turma`) REFERENCES turma(`cod_turma`)
);