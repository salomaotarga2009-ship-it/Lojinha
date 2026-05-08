use dblojinha;
go




create procedure [dbo].[exclui_cliente]
	@codigo int
as
	delete from Clientes where codigo = @codigo
