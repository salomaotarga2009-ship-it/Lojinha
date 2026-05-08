use dblojinha;
go
--if exists(select name from sysobjects
--	where name = 'insere_cliente' and type='P')
--drop procedure insere_cliente

create procedure [dbo].[insere.cliente]
	@codigo int output,
	@nome varchar(100), 
	@email varchar(100),
	@telefone varchar(20)
as
	insert into Clientes(nome, email, telefone)
	values(@nome, @email, @telefone)
set @codigo = (select @@identity) 