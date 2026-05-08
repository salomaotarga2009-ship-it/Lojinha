use dblojinha;


create procedure [dbo].[altera.cliente]
	@codigo int output,
	@nome varchar(100), 
	@email varchar(100),
	@telefone varchar(20)
as
	update Clientes set nome = @nome, email = @email, telefone = @telefone
	where codigo = @codigo


