#Isso é um comentário

#DDL -> CREATE, ALTER, DROP /ddl= D aTaD efinition L anguage u linguagem de definicao dos dados
#Criar um banco de dados	
CREATE DATABASE primeiro_bd;

#Selecionar um banco de dados
USE primeiro_bd;

#Excluir um banco de dados
#DROP DATABASE primeiro_bd;

#Criar uma tabela no BD
/*CREATE TABLE pessoas(
	nome_do_campo TIPO(TAM DO TIPO) PROPRIEDADES
):
#Criar uma tabela no BD
CREATE TABLE pessoas
NOT NULL = não obrigatório
SnakeCase = _
CamelCase = PrimeiraLetraMaiuscila*/

CREATE TABLE `pessoas` ( #Crase nao obgrigatória
	`ID_pessoa` INT NOT NULL AUTO_INCREMENT, #PrimaryKey / identidade unica
	`nome` VARCHAR(80) NOT NULL, #NOT NULL = não permite nulo / Obrigatório
	`data_nasc` DATE NOT NULL, #AAAA-MM-DD usado dessa forma para contas / ordenar
	`cpf` BIGINT(11) NOT NULL UNIQUE, #UNIQUE = UNICO
	`altura` DOUBLE,
	`telefone` BIGINT(10) NULL, #NULL = permite nulo
	`celular` BIGINT(11) NULL,
	`email` VARCHAR(100) NOT NULL,
	`estado` CHAR(2) NULL DEFAULT 'SP', #Preenche o campo com "SP" caso deixe nulo
	PRIMARY KEY(`ID_pessoa`)
)	
