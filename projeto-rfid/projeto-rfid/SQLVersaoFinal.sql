--Table Creation START**************************************************************************************************************

CREATE TABLE professor (
id int NOT NULL,
nome varchar(255) NOT NULL,
imagem varbinary(max),
PRIMARY KEY (nome)
)

Create TABLE materia (
id int NOT NULL,
nome varchar(255) NOT NULL,
nome_professor varchar(255) NOT NULL,
PRIMARY KEY (nome),
FOREIGN KEY (nome_professor) REFERENCES professor (nome)
)

Create TABLE sala (
id int NOT NULL,
numero_sala int NOT NULL
PRIMARY KEY (numero_sala)
)

CREATE TABLE aula (
id int NOT NULL,
horario_aula datetime NOT NULL,
nome_materia_fk varchar(255) NOT NULL,
numero_sala_fk int NOT NULL,
nome_professor varchar(255) NOT NULL,
PRIMARY KEY (nome_materia_fk, nome_professor, horario_aula),
FOREIGN KEY (numero_sala_fk) REFERENCES sala (numero_sala),
FOREIGN KEY (nome_materia_fk) REFERENCES materia (nome),
FOREIGN KEY (nome_professor) REFERENCES professor (nome)
)

create TABLE curso (
id int NOT NULL,
nome_curso varchar(255) NOT NULL,
periodo varchar(255) NOT NULL,
 PRIMARY KEY (nome_curso, periodo)
)

create TABLE aluno (
id int NOT NULL,
nome_aluno varchar(255) NOT NULL,
nome_curso_fk varchar(255) NOT NULL,
periodo_curso_fk varchar(255) NOT NULL, --Noturno ou matutino
semestre_curso_fk int NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (nome_curso_fk, periodo_curso_fk) REFERENCES curso (nome_curso, periodo)
)

create table Login (
Id int not null PRIMARY KEY,
SenhaHash varchar(255) not null, 
FOREIGN KEY (Id) REFERENCES aluno (Id)
)

create TABLE presenca (
id int NOT NULL,
id_aluno_fk int NOT NULL,
nome_curso_fk varchar(255) NOT NULL,
periodo_curso_fk varchar(255) NOT NULL,
semestre_curso_fk int NOT NULL,
nome_materia_fk varchar(255) NOT NULL,
horario_aula datetime NOT NULL,
nome_professor varchar(255) NOT NULL,
situacaopresenca varchar(255),
PRIMARY KEY (id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk),
FOREIGN KEY (nome_curso_fk, periodo_curso_fk) REFERENCES curso (nome_curso, periodo),
FOREIGN KEY (id_aluno_fk) REFERENCES aluno (id),
FOREIGN KEY (nome_materia_fk) REFERENCES materia (nome),
FOREIGN KEY (nome_professor) REFERENCES professor (nome),
)
--Table Creation END**************************************************************************************************************

--Inserts START**********************************************************************************************************************

--Insert PROFESSOR START***
INSERT INTO professor (id, nome) VALUES (1, 'Eduardo')
INSERT INTO professor (id, nome) VALUES (2, 'Cabrini')
INSERT INTO professor (id, nome) VALUES (3, 'Calvo')
INSERT INTO professor (id, nome) VALUES (4, 'Vianello')
select * from professor
--Insert PROFESSOR END***

--Insert SALA START***
INSERT INTO sala (id, numero_sala) VALUES (1, 70)
INSERT INTO sala (id, numero_sala) VALUES (2, 71)
INSERT INTO sala (id, numero_sala) VALUES (3, 72)
INSERT INTO sala (id, numero_sala) VALUES (4, 73)
INSERT INTO sala (id, numero_sala) VALUES (5, 74)
INSERT INTO sala (id, numero_sala) VALUES (6, 75)
INSERT INTO sala (id, numero_sala) VALUES (7, 76)
INSERT INTO sala (id, numero_sala) VALUES (8, 77)
select * from sala
--Insert SALA END***

--Insert CURSO START***
INSERT INTO curso (id, nome_curso, periodo) VALUES (1, 'Engenharia da Computação', 'Matutino')
INSERT INTO curso (id, nome_curso, periodo) VALUES (2, 'Engenharia da Computação', 'Noturno')
INSERT INTO curso (id, nome_curso, periodo) VALUES (3, 'Engenharia de Alimentos', 'Noturno')
INSERT INTO curso (id, nome_curso, periodo) VALUES (4, 'Engenharia de Alimentos', 'Matutino')
INSERT INTO curso (id, nome_curso, periodo) VALUES (5, 'Administração', 'Matutino')
INSERT INTO curso (id, nome_curso, periodo) VALUES (6, 'Administração', 'Noturno')
select * from curso
--Insert CURSO END***

--Insert ALUNO START***
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) values (1, 'Eduardo', 'Engenharia da Computação', 'Noturno', 5)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) values (2, 'Catarina', 'Engenharia da Computação', 'Noturno', 5)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) values (3, 'Milena', 'Engenharia da Computação', 'Noturno', 5)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) values (4, 'Daniel', 'Engenharia da Computação', 'Noturno', 5)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) values (082200059, 'Aquiles', 'Engenharia da Computação', 'Noturno', 5)
select * from aluno
--Insert ALUNO END***

--Insert LOGIN START***
insert into login (Id, SenhaHash) values (1, '123')
insert into login (Id, SenhaHash) values (2, '345')
insert into login (Id, SenhaHash) values (3, '678')
insert into login (Id, SenhaHash) values (4, '123')
insert into login (Id, SenhaHash) values (082200059, 'Admin23')
select * from login
--Insert LOGIN START***

--Insert MATERIA START***
insert into materia(id, nome, nome_professor) values (1, 'BD', 'Eduardo')
insert into materia(id, nome, nome_professor) values (2, 'LP1', 'Eduardo')
insert into materia(id, nome, nome_professor) values (3, 'MC', 'Cabrini')
insert into materia(id, nome, nome_professor) values (4, 'FETRANS', 'Calvo')
select * from materia
--Insert MATERIA END***

--Insert AULA START***
insert into aula (id, horario_aula, nome_materia_fk, numero_sala_fk, nome_professor) values (1, '2022-11-21 19:05', 'BD', 70, 'Eduardo')
insert into aula (id, horario_aula, nome_materia_fk, numero_sala_fk, nome_professor) values (2, '2022-11-21 21:05', 'LP1', 71, 'Eduardo')
insert into aula (id, horario_aula, nome_materia_fk, numero_sala_fk, nome_professor) values (3, '2022-11-23 19:05', 'FETRANS', 72, 'Calvo')
insert into aula (id, horario_aula, nome_materia_fk, numero_sala_fk, nome_professor) values (4, '2022-11-23 21:05', 'MC', 73, 'Cabrini')
select * from aula
--Insert AULA END***

--Insert PRESENCA START***
insert into presenca (id, id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk, nome_materia_fk, horario_aula, nome_professor, situacaopresenca) values (1, 1, 'Engenharia da Computação', 'Noturno', 5, 'BD', '2022-11-21 19:05', 'Eduardo', '1' )
insert into presenca (id, id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk, nome_materia_fk, horario_aula, nome_professor, situacaopresenca) values (2, 2, 'Engenharia da Computação', 'Noturno', 5, 'LP1', '2022-11-21 21:05', 'Eduardo', '1' )
insert into presenca (id, id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk, nome_materia_fk, horario_aula, nome_professor, situacaopresenca) values (3, 3, 'Engenharia da Computação', 'Noturno', 5, 'MC', '2022-11-21 19:05', 'Cabrini', '1' )
insert into presenca (id, id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk, nome_materia_fk, horario_aula, nome_professor, situacaopresenca) values (4, 4, 'Engenharia da Computação', 'Noturno', 5, 'FETRANS', '2022-11-21 19:05', 'Calvo', '1' )
select * from presenca
--Insert PRESENCA END***

--INSERTS END**************************************************************************************************************

--SP General START**************************************************************************************************************
create procedure spDelete
(
 @id int ,
 @tabela varchar(max)
)
as
begin
 declare @sql varchar(max);
 set @sql = ' delete ' + @tabela +
 ' where id = ' + cast(@id as varchar(max))
 exec(@sql)
end
GO

create procedure spConsulta
(
 @id int,
 @tabela varchar(max)
)
as
begin
 declare @sql varchar(max);
 set @sql = 'select * from ' + @tabela +
 ' where id = ' + cast(@id as varchar(max))
 exec(@sql)
end
GO

create procedure spListagem
(
 @tabela varchar(max),
 @ordem varchar(max))
as
begin
 exec('select * from ' + @tabela +
 ' order by ' + @ordem)
end
GO

create procedure spProximoId
(@tabela varchar(max))
as
begin
 exec('select isnull(max(id) +1, 1) as MAIOR from '
 +@tabela)
end
GO

--SP Gegeral END**************************************************************************************************************

--SP PROFESSOR START**********************************************************************************************************
create procedure spInsert_Professor
(
 @id int,
 @nome varchar(max) ,
 @imagem varbinary(max)
)
as
begin
 insert into professor (Id, Nome, Imagem) values (@id, @nome , @imagem)
end
GO

create procedure spUpdate_Professor
(
 @id int,
 @nome varchar(max),
 @imagem varbinary(max)
)
as
begin
 update professor set Nome = @nome , imagem=@imagem where Id = @id 
end
GO
--SP PROFESSOR END**********************************************************************************************************

--SP SALA START**********************************************************************************************************
create procedure spInsert_Sala
(
 @id int,
 @numero_sala int
)
as
begin
 insert into sala (Id, numero_sala) values (@id, @numero_sala)
end
GO

create procedure spUpdate_Sala
(
 @id int,
 @numero_sala int
)
as
begin
 update sala set numero_sala = @numero_sala where Id = @id 
end
GO
--SP SALA END**********************************************************************************************************

--SP CURSO START**********************************************************************************************************
create procedure spInsert_Curso
(
 @id int,
 @nome_curso varchar(max),
 @periodo varchar(max)
)
as
begin
 insert into curso (Id, nome_curso, periodo) values (@id, @nome_curso , @periodo)
end
GO


create procedure spUpdate_Curso
(
 @id int,
 @nome_curso varchar(max),
 @periodo varchar(max)
)
as
begin
 update curso set nome_curso = @nome_curso, periodo = @periodo where Id = @id 
end
GO
--SP CURSO END**********************************************************************************************************

--SP MATERIA START**********************************************************************************************************
create procedure spInsert_Materia
(
 @id int,
 @nome varchar(max) ,
 @nome_professor varchar(max)
)
as
begin
 insert into materia (Id, nome, nome_professor) values (@id, @nome, @nome_professor)
end
GO

create procedure spUpdate_Materia
(
 @id int,
 @nome varchar(max) ,
 @nome_professor varchar(max)
)
as
begin
 update materia set nome = @nome , nome_professor = @nome_professor where Id = @id 
end
GO
--SP MATERIA START**********************************************************************************************************

--SP AULA START**********************************************************************************************************
create procedure spInsert_Aula
(
 @id int,
 @horario_aula datetime,
 @nome_materia_fk varchar(255),
 @numero_sala_fk int,
 @nome_professor varchar(255)
)
as
begin
 insert into aula (Id, horario_aula, nome_materia_fk, numero_sala_fk, nome_professor) values (@id, @horario_aula, @nome_materia_fk, @numero_sala_fk, @nome_professor)
end
GO

create procedure spUpdate_Aula
(
 @id int,
 @horario_aula datetime,
 @nome_materia_fk varchar(255),
 @numero_sala_fk int,
 @nome_professor varchar(255)
)
as
begin
 update aula set horario_aula = @horario_aula, nome_materia_fk = @nome_materia_fk, numero_sala_fk = @numero_sala_fk, nome_professor = @nome_professor where Id = @id 
end
GO
--SP AULA END**********************************************************************************************************


--SP AULA PRESENCA**********************************************************************************************************
create procedure spInsert_Presenca
(
 @id int,
 @id_aluno_fk int,
 @nome_curso_fk varchar(255),
 @periodo_curso_fk varchar(255),
 @semestre_curso_fk int,
 @nome_materia_fk varchar(255),
 @horario_aula datetime,
 @nome_professor varchar(255),
 @situacaopresenca varchar(255)
)
as
begin
 insert into presenca (Id, id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk, nome_materia_fk, horario_aula, nome_professor, situacaopresenca)
 values (@Id, @id_aluno_fk, @nome_curso_fk, @periodo_curso_fk, @semestre_curso_fk, @nome_materia_fk, @horario_aula, @nome_professor, @situacaopresenca)
end
GO

 
create procedure spUpdate_Presenca
(
 @id int,
 @id_aluno_fk int,
 @nome_curso_fk varchar(255),
 @periodo_curso_fk varchar(255),
 @semestre_curso_fk int,
 @nome_materia_fk varchar(255),
 @horario_aula datetime,
 @nome_professor varchar(255),
 @situacaopresenca varchar(255)
)
as
begin
 update presenca set id_aluno_fk = @id_aluno_fk, nome_curso_fk = @nome_curso_fk, periodo_curso_fk = @periodo_curso_fk, semestre_curso_fk = @semestre_curso_fk, nome_materia_fk = @nome_materia_fk, 
 horario_aula = @horario_aula, nome_professor = @nome_professor, situacaopresenca = @situacaopresenca where Id = @id 
end
GO
--SP AULA PRESENCA**********************************************************************************************************

/* FILTRO AVANÇADO ALUNO */

Create procedure spConsultaAvancadaAlunos
(
@nome_curso_fk varchar(max),
@periodo_curso_fk varchar(max))
as
begin

select * from aluno
where aluno.nome_curso_fk like '%' + @nome_curso_fk + '%' and
	aluno.periodo_curso_fk like '%' + @periodo_curso_fk + '%'
end


/* FILTRO AVANÇADO PRESENÇA */

Create procedure spConsultaAvancadaPresenca
(
@nome_curso_fk varchar(max),
@semestre_curso_fk int,
@dataInicial datetime,
@dataFinal datetime)
as
begin
		declare @categIni int
		declare @categFim int

		set @categIni = case @semestre_curso_fk when 0 then 0 else @semestre_curso_fk end
		set @categFim = case @semestre_curso_fk when 0 then 999999 else @semestre_curso_fk end

select * from presenca
where presenca.nome_curso_fk like '%' + @nome_curso_fk + '%' and
	presenca.semestre_curso_fk between @categIni and @categFim and
	presenca.horario_aula between @dataInicial and @dataFinal
end

