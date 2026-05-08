use dblojinha;

create table Produtos (
[Codigo] [int] identity (1,1) not null, 
	Nome varchar(100),
	Preco decimal(10,2),
	Estoque int,
constraint [pk_Produtos] primary key clustered
(
	[codigo]
	) on [primary]
) on [primary]
go

insert into Produtos(Nome, Preco, Estoque)
values('Computador Gamer', 10099.00, 22)

update Produtos set Nome = 'teclado ajazz' where codigo = 3;

select * from Produtos 


