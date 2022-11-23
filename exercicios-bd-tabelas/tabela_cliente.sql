CREATE DATABASE `clientes_bd`;

USE `clientes_bd`;

CREATE TABLE `clientes` (
	`cod_cliente` INT(8) NOT NULL AUTO_INCREMENT,
	`nome_cliente` VARCHAR(50) NOT NULL,
	`endereco_cliente` VARCHAR(40) NOT NULL,
	`cidade` VARCHAR(30) NOT NULL,
	`estado` CHAR(2) NOT NULL,
	`cep` INT(8) NOT NULL ,
	PRIMARY KEY(`cod_cliente`)
);
