use dblojinha;


create table Vendas (
[Codigo] [int] identity (1,1) not null, 
	Data datetime,
	Quantidade int,
	Faturado bit,
	CodigoCliente int,
	CodigoProduto int, 
constraint [pk_Vendas] primary key clustered
(
	[codigo]
	) on [primary], constraint [fk_Codigo_Cliente] foreign key 
	(
	[CodigoCliente]
	)references [Clientes] ([Codigo]
),
Constraint [fk_Codigo_Produto] foreign key 
(
	[CodigoProduto]
) references [Produtos] (
	[Codigo]
	)
) on [primary]
go 
