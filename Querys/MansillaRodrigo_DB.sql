-- NUEVA 

create database MansillaRodrigo_DB
go

create table Categorias (
Id int primary key not null, 
Nombre varchar(50) not null,
Estado bit not null default 1
)

create table Marcas(
Id int primary key not null,
Nombre varchar(50) not null,
Estado bit not null default 1 
)


create table Productos (
ID int not null primary key,
Nombre varchar(30) not null,
IdCategoria int foreign key references categorias(Id),
IdMarca int foreign key references marcas(Id),
Stock int not null, 
StockMinimo int not null, 
PrecioCompra decimal(8,2) not null,
PrecioVenta decimal(8,2) not null, 
Ganancia decimal(8,2) not null,
Estado bit not null default 1 
) 

create table Compras(
IdCompra int primary key not null,
IdProducto int not null foreign key references Productos(ID),
Cantidad decimal(8,2) not null,
PrecioCompra decimal(8,2) not null,
PrecioVenta decimal(8,2) not null,
Ganancia decimal(8,2) not null,
Estado bit not null default 1 
)
Alter table Compras add FCompra date not null


create procedure Sp_AgregarProducto(
@nom varchar(100),
@idcat int,
@idmarca int,
@stm int
)
as 
begin  
insert into Productos (Id,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*)from productos)+1,@nom,@idcat,@idmarca,0,@stm,0,0,0,1)
end 

create procedure SPModificarProducto(
@aydi int,
@Nom varchar(30),
@stm int,
@Mar int,
@idcat int
)
as
begin
update Productos set Nombre = @Nom, StockMinimo = @stm, IdMarca = @Mar, IdCategoria = @idcat where Productos.ID = @aydi;
end 


create procedure SPAgregarCategoria(
@Nombre varchar(30)
)
as
begin 
insert into categorias (Id,Nombre,Estado) values ((select count(*) from categorias)+1,@Nombre,1)
end 

exec SPAgregarCategoria 'Roberto'

create procedure SPEliminarCategorias(
@aydi int
)
as
begin 
update Categorias set Estado = 0 where Id = @aydi
end 

create procedure SPModificarProducto2(
@Nom varchar(30),
@stock int,
@preciocompra decimal(8,2),
@precioventa decimal(8,2)
)
as
begin
update Productos set PrecioCompra = @preciocompra, PrecioVenta = @precioventa, Stock = Stock + @stock, Ganancia =  @precioventa - @preciocompra where  Nombre like @Nom
end 

create procedure SPAgregarCompra( 
@nom varchar(30), -- EL NOMBRE SIEMPRE VA EXISTIR POR QUE LO ELIJE DE UN COMBOBOX, NI HACE FALTA VERIFICAR EL MISMO. 
@cant int,
@PC decimal(8,2),
@PV decimal(8,2)
)
as
begin
declare @aux int, @aux2 int -- DECLARO VARIABLES LOCALES 
select @aux=id from Productos where Nombre like @nom -- OBTENGO EN VARIABLE EL ID DEL PRODUCTO QUE LLEGA DE LA APP
select @aux2 = count(*) from compras  -- CUENTO LAS COMPRAS QUE TENGO EN LA BASE DE DATOS 
select @aux2 = @aux2 + 1 -- LE SUMO 1 A LAS COMPRAS 
insert into Compras (IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,FCompra)values (@aux2,@aux,@cant,@PC,@PV,@PV-@PC,GETDATE())
end


select *from Compras
