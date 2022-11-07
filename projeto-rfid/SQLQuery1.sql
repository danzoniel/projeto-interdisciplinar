CREATE TABLE Alunos (
Id int NOT NULL PRIMARY KEY,
nome varchar(50) NULL,
mensalidade decimal (18, 2) NULL,
cidadeId int NULL,
DataNascimento datetime NULL
)

select * from Alunos

insert into Alunos (Id, nome, mensalidade, cidadeId, DataNascimento) Values (1, 'Daniel', 1300, 01, 31/07/1998)