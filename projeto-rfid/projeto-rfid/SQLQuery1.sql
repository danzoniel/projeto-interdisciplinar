drop table professor
drop table materia
drop table sala
drop table horario
drop table aula
drop table curso
drop table aluno
drop table frequencia


CREATE TABLE professor (
id int NOT NULL PRIMARY KEY,
nome varchar(255) NOT NULL,
imagem varbinary(max),
)

Create TABLE materia (
id int NOT NULL,
nome varchar(255) NOT NULL,
id_professor int NOT NULL,
PRIMARY KEY (nome),
FOREIGN KEY (id_professor) REFERENCES professor(id)
)

Create TABLE sala (
id int NOT NULL,
numero_sala int NOT NULL  PRIMARY KEY
)

create TABLE horario (
id int NOT NULL,
horario_aula time NOT NULL PRIMARY KEY
)

create TABLE aula (
id int NOT NULL,
horario_aula datetime NOT NULL,
nome_materia_fk varchar(255) NOT NULL,
numero_sala_fk int NOT NULL,
id_prof_fk int NOT NULL,
PRIMARY KEY (nome_materia_fk, numero_sala_fk, id_prof_fk),
FOREIGN KEY (numero_sala_fk) REFERENCES sala (numero_sala),
FOREIGN KEY (nome_materia_fk) REFERENCES materia (nome),
FOREIGN KEY (id_prof_fk) REFERENCES professor (id)
)

create TABLE curso (
id int NOT NULL,
nome_curso varchar(255) NOT NULL,
periodo varchar(255) NOT NULL,
semestre int NOT NULL,
 PRIMARY KEY (nome_curso, periodo, semestre)
)
select * from curso
insert into curso (id, nome_curso, periodo, semestre) values (1, 'EC', 'Noturno', 5)

create TABLE aluno (
id int NOT NULL,
nome_aluno varchar(255) NOT NULL,
nome_curso_fk varchar(255) NOT NULL,
periodo_curso_fk varchar(255) NOT NULL, --Noturno ou matutino
semestre_curso_fk int NOT NULL,
senha varchar(255) NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (nome_curso_fk, periodo_curso_fk, semestre_curso_fk) REFERENCES curso (nome_curso, periodo, semestre)
)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk,senha) values (1, 'Aquiles', 'EC', 'Noturno', 5, 'jakE')
delete from aluno
select * from aluno

create TABLE frequencia (
id_aluno_fk int NOT NULL,
nome_curso_fk varchar(255) NOT NULL,
periodo_curso_fk bit NOT NULL,
semestre_curso_fk int NOT NULL,
nome_materia_fk varchar(255) NOT NULL,
id_prof_fk int NOT NULL,
quantidade_faltas int,
PRIMARY KEY (id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk),
FOREIGN KEY (id_aluno_fk, nome_curso_fk, periodo_curso_fk, semestre_curso_fk) REFERENCES aluno (id, nome_curso_fk, periodo_curso_fk, semestre_curso_fk),
FOREIGN KEY (nome_materia_fk, id_prof_fk) REFERENCES materia (nome, id_professor)
)

/*SP GERAL */

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
 @id int ,
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

/* CRUD PROFESSOR */

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

select * from professor

/* SP ALUNOS */

create procedure spInsert_Aluno
(
 @id int,
 @nome_aluno  varchar(max) ,
 @nome_curso_fk varchar(max),
 @periodo_curso_fk varchar(max),
 @semestre_curso_fk int,
 @senha varchar(25)
)
as
begin
 insert into aluno (Id,nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk,senha) 
 values (@id,@nome_aluno, @nome_curso_fk, @periodo_curso_fk, @semestre_curso_fk,@senha)
end
GO

execute spInsert_Aluno 3,'Jake','EC',1,5,1


create procedure spUpdate_Aluno
(
 @id int,
 @nome_aluno  varchar(max) ,
 @nome_curso_fk varchar(max),
 @periodo_curso_fk varchar(max),
 @semestre_curso_fk int,
 @senha varchar(255)
)
as
begin
 update aluno set nome_aluno = @nome_aluno, 
 nome_curso_fk = @nome_curso_fk,
 periodo_curso_fk = @periodo_curso_fk,
 semestre_curso_fk = @semestre_curso_fk,
 senha = @senha where id = @id
end
GO

select * from aluno

/* CRUD MATÉRIA */

create procedure spInsert_Materia
(
 @id int,
 @nome varchar(max) ,
 @id_professor int
)
as
begin
 insert into materia (Id, nome, id_professor) values (@id, @nome , @id_professor)
end
GO

create procedure spUpdate_Materia
(
 @id int,
 @nome varchar(max) ,
 @id_professor int
)
as
begin
 update materia set nome = @nome , id_professor = @id_professor where Id = @id 
end
GO

/* CRUD CURSO */

create procedure spInsert_Curso
(
 @id int,
 @nome_curso varchar(max),
 @periodo varchar(max),
 @semestre int
)
as
begin
 insert into curso (Id, nome_curso, periodo, semestre) values (@id, @nome_curso , @periodo, @semestre)
end
GO

create procedure spUpdate_Curso
(
 @id int,
 @nome_curso varchar(max),
 @periodo varchar(max),
 @semestre int
)
as
begin
 update curso set nome_curso = @nome_curso, periodo = @periodo, semestre = @semestre where Id = @id 
end
GO

/* CRUD SALA */

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

/* CRUD AULA */

create procedure spInsert_Aula
(
 @id int,
 @horario_aula datetime,
 @nome_materia_fk varchar(255),
 @numero_sala_fk int,
 @id_prof_fk int
)
as
begin
 insert into aula (Id, horario_aula, nome_materia_fk, numero_sala_fk, id_prof_fk) values (@id, @horario_aula, @nome_materia_fk, @numero_sala_fk, @id_prof_fk)
end
GO

create procedure spUpdate_Aula
(
 @id int,
 @horario_aula datetime,
 @nome_materia_fk varchar(255),
 @numero_sala_fk int,
 @id_prof_fk int
)
as
begin
 update aula set horario_aula = @horario_aula, nome_materia_fk = @nome_materia_fk, numero_sala_fk = @numero_sala_fk, id_prof_fk = @id_prof_fk where Id = @id 
end
GO

