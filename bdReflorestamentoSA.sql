CREATE DATABASE bdReflorestamentoSA
GO

USE bdReflorestamentoSA
GO

CREATE TABLE Usuario(
	codUsuario INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nome		VARCHAR(50) NOT NULL,
	telefone	CHAR(11) NOT NULL,
	cpf			CHAR(11) NOT NULL,
	email		VARCHAR(50) NOT NULL,
	loginUs		VARCHAR(25) NOT NULL,
	senhaUs		VARCHAR(6)  NOT NULL,
	tipoUsuario  INT NOT NULL
);

CREATE TABLE Reflorestamento(
	codCalculo	INT  IDENTITY(1,1) PRIMARY KEY ,
	ano			INT ,
	estado		CHAR(2) ,
	numArvoresCortadas INT ,
	volumeM3		   INT  ,
	arvoresARepor	   INT ,
	valorAPagar		   INT );


SELECT * FROM Usuario
SELECT * FROM Reflorestamento

INSERT INTO Usuario (nome,telefone,cpf,email,loginUs,senhaUs,tipoUsuario)
	VALUES('Admnistrador','34331031','01848246641','tfleao07@gmail.com','admin','adm123','1')
-- DROP TABLE Usuario
-- DROP TABLE Reflorestamento


-- DROP DATABASE bdReflorestamentoSA	
-- use master


