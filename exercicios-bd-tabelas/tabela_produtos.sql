CREATE DATABASE `produtos_bd`;

USE `produtos_bd`; 

CREATE TABLE `produtos` (
	`cod_produto` INT(8) NOT NULL,
	`descricao_produto` VARCHAR(50) NOT NULL,
	`perecivel` BOOL NULL DEFAULT false,
	`data_val` DATE NULL,
	`detalhes` VARCHAR(255) NULL,
	`foto_produto` BLOB NULL,
	PRIMARY KEY (`cod_produto`)
);