USE MASTER;
DROP DATABASE aula;
CREATE DATABASE aula;
GO
USE aula

CREATE TABLE funcionario(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50),
	endereco NVARCHAR(80),
	telefone NVARCHAR(20),
	documento NVARCHAR(20),
	salario FLOAT,
	bairro NVARCHAR(30),
	cidade NVARCHAR(20),
	estado NVARCHAR(20)
);

CREATE TABLE cliente(
	pk_id INT PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(50),
	endereco NVARCHAR(80),
	telefone NVARCHAR(20),
	documento NVARCHAR(20),
	fk_funcionario INT REFERENCES funcionario(pk_id),
);
/*DROP PROCEDURE retornarClientes*/
GO
CREATE PROCEDURE retornarClientes AS select * from cliente
GO
retornarClientes
GO
CREATE PROCEDURE retornarClientesById @id INT AS select * from cliente where @id = pk_id
GO
retornarClientesById 3
GO
INSERT INTO cliente(nome, endereco, telefone) VALUES ('wesley safadao', 'avenida caititu', '89898989', '4894894')