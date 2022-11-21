/*
drop table professor
drop table materia
drop table sala
drop table horario
drop table aula
drop table curso
drop table aluno
drop table frequencia


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
numero_sala int NOT NULL  PRIMARY KEY
)

CREATE TABLE aula (
id int NOT NULL,
horario_aula datetime NOT NULL,
nome_materia_fk varchar(255) NOT NULL,
numero_sala_fk int NOT NULL,
nome_professor varchar(255) NOT NULL,
PRIMARY KEY (nome_materia_fk, numero_sala_fk, nome_professor, horario_aula),
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
select * from curso
insert into curso (id, nome_curso, periodo) values (1, 'EC', 'Noturno')

create TABLE aluno (
id int NOT NULL,
nome_aluno varchar(255) NOT NULL,
nome_curso_fk varchar(255) NOT NULL,
periodo_curso_fk varchar(255) NOT NULL, --Noturno ou matutino
semestre_curso_fk int NOT NULL,
senha varchar(255) NOT NULL,
PRIMARY KEY (id),
FOREIGN KEY (nome_curso_fk, periodo_curso_fk) REFERENCES curso (nome_curso, periodo)
)
insert into aluno (id, nome_aluno, nome_curso_fk, periodo_curso_fk, semestre_curso_fk,senha) values (1, 'Aquiles', 'EC', 'Noturno', 5, 'jakE')
delete from aluno
select * from aluno

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

create procedure spListagemProfessor
(
 professor varchar(max),
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

execute spInsert_Aluno 2,'Jake','EC',1,5,1


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

/* CRUD CURSO */

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


/* CRUD PRESENÇA */

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

