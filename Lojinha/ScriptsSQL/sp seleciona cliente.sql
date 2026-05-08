use dblojinha;


create procedure [dbo].[seleciona_cliente]
	@filtro varchar(100) = null
as 
begin 
	if @filtro is null 
		select * from Clientes
	else
		select * from Clientes
		where Nome like '%' + @filtro + '%'
		or Email like '%' + @filtro + '%'
		or Telefone like '%' + @filtro + '%'
end

