use Negocios2020
go

create or alter proc sp_add_cliente
@cod varchar(5),
@nombre varchar(60),
@dir varchar(80),
@idpais char(3),
@fono varchar(24)
As
insert tb_clientes Values(@cod,@nombre,@dir,@idpais,@fono)
go

create or alter proc sp_update_cliente
@cod varchar(5),
@nombre varchar(60),
@dir varchar(80),
@idpais char(3),
@fono varchar(24)
As
Update tb_clientes 
Set nombrecia=@nombre,direccion=@dir,idpais=@idpais,telefono=@fono
Where idcliente=@cod
go

create or alter proc sp_search_cliente
@cod varchar(5)
As
Select top 1 * from tb_clientes
Where IdCliente=@cod
go

create or alter proc sp_clientes
As
Select * from tb_clientes
go

create or alter proc sp_paises
As
Select * from tb_paises
go

create or alter proc sp_clientes
As
Select * from tb_clientes
go

create or alter proc sp_paises
As
Select * from tb_paises
go