"# crud-c-" 
SQL Server
Crie o Banco de Dados: 
CREATE DATABASE AgendaContatos;
Use o Banco de Dados Criado:
USE AgendaContatos;
Crie a Tabela de Contatos:
CREATE TABLE Contatos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100),
    Email NVARCHAR(100),
    DataCadastro DATETIME
);

