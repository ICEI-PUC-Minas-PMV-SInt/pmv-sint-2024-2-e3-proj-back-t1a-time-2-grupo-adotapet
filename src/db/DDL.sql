-- Criação do banco de dados 
CREATE DATABASE AdotaPet;
USE AdotaPet;

-- Criando as tabelas do banco de dados
CREATE TABLE Usuario (
Cod_usuario char(3) PRIMARY KEY,
 Nome char(40)
 );

CREATE TABLE Anuncio (
	Cod_usuario char(3) PRIMARY KEY,
    Nome char(40)
    );

CREATE TABLE Pet (
	Cod_Pet char(3) PRIMARY KEY,
    Nome_Pet char(40),
    Anuncio char(3),
    Usuario char(3),
    Contato char(13),
    CONSTRAINT FK_Pet_Anuncio foreign key (Anuncio) REFERENCES Anuncio(Cod_usuario)
    );

CREATE TABLE Contato (
Cod_usuario char(13) PRIMARY KEY,
	Telefone varchar(11),
    Email varchar(40)
    );

ALTER TABLE Pet
ADD CONSTRAINT FK_Pet_Usuario FOREIGN KEY (Usuario) REFERENCES Usuario(Cod_usuario);

ALTER TABLE Pet
ADD CONSTRAINT FK_Pet_Contato FOREIGN KEY (Contato) REFERENCES Contato(Cod_usuario);
