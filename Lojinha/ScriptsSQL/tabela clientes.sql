use dblojinha;

create table Clientes (
[Codigo] [int] identity (1,1) not null, 
	Nome varchar(100),
	Email varchar(100),
	Telefone varchar(20),
constraint [pk_Clientes] primary key clustered
(
	[codigo]
	) on [primary]
) on [primary]
go

insert into Clientes(Nome, Email, Telefone)
values('salomao', 'aura@gmail.com', '6992999999')

insert into Clientes(Nome, Email, Telefone)
values('tucunaré', 'peixe@gmail.com', '6967676767')


select * from Clientes
