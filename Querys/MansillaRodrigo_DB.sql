use master
go

drop database MansillaRodrigo_DB
create database MansillaRodrigo_DB
go

use MansillaRodrigo_DB
go

-- CREACION DE TABLAS

create table Categorias (
Id int primary key not null,
Nombre varchar(50) not null,
Estado bit not null default 1
)
go

create table Marcas(
Id int primary key not null,
Nombre varchar(50) not null,
Estado bit not null default 1
)
go

create table Productos (
ID int not null primary key,
Nombre varchar(30) not null unique,
IdCategoria int foreign key references categorias(Id),
IdMarca int foreign key references marcas(Id),
Stock int not null,
StockMinimo int not null,
PrecioCompra decimal(8,2) not null,
PrecioVenta decimal(8,2) not null,
Ganancia decimal(8,2) not null,
Estado bit not null default 1
)
go

create table Compras(
IdCompra int primary key not null,
IdProducto int not null foreign key references Productos(ID),
Cantidad decimal(8,2) not null,
PrecioCompra decimal(8,2) not null,
PrecioVenta decimal(8,2) not null,
Ganancia decimal(8,2) not null,
Estado bit not null default 1
)
go

Alter table Compras add FCompra date not null
go

Create table ModiStock(
Id int not null primary key,
idProducto int not null foreign key references Productos(ID),
Cantidad int not null,
Comentario varchar(30) null,
FechaModificacion date not null,
estado bit null default 1 ,
NameProduct varchar(30) null
)
go

create table Provincias (
id int not null primary key,
Nombre varchar(35) not null
)
go

create table Cp(
CodigoPostal int not null primary key,
Partido varchar(35) not null,
Provincia varchar(35) not null,
estado bit null
)

go

create table Clientes (
ID int not null,
DNI int not null primary key,
Cp int not null foreign key references Cp(CodigoPostal),
Nombre varchar(35) not null,
Apellido varchar(35) not null,
Telefono int not null,
correo varchar(55) not null unique,
Contrasenia varchar(40) not null,
Fnac date not null,
calle varchar(50) not null,
FAlta date not null,
Estado bit null
)    
go

create table Usuarios(
Id int not null primary key,
LoginName varchar(50) not null,
Pass varchar(50) not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Cargo varchar(50) not null,
Correo varchar(50) not null unique,
)
go 

-- CREACION DE PROCEDIMIENTOS

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
go

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
go

create procedure SPAgregarCategoria(
@Nombre varchar(30)
)
as
begin
insert into categorias (Id,Nombre,Estado) values ((select count(*) from categorias)+1,@Nombre,1)
end
go

create procedure SPEliminarCategorias(
@aydi int
)
as
begin
update Categorias set Estado = 0 where Id = @aydi
end
go

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
go

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
insert into Compras (IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,FCompra)values (@aux2,@aux,@cant,@PC,@PV,@PV-@PC,getdate())
end
go


create procedure SPAgregarModificacionSTock(
@name varchar(30),
@cant int,
@Coment varchar(30)
)
as
begin
declare @aux int
select  @aux = id from Productos where Nombre like @name
insert into ModiStock (Id,idProducto,Cantidad,Comentario,FechaModificacion,estado,NameProduct) values ((select count(*) from ModiStock)+1,@aux,@cant,@Coment,GETDATE(),1,@name)
end
go

create procedure SPUpdateProductos(
@name varchar(30),
@cant int,
@Coment varchar(30)
)
as
begin
declare @aux int
select  @aux = id from Productos where Nombre like @name
update Productos set Stock=Stock+(@cant) where Nombre like @name
end
go

create procedure SPAgregarCP(
@codigo int,
@par varchar(35),
@pv varchar(35)
)
as
begin
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (@codigo,@par,@pv,1)
end
go

create procedure Sp_AgregarCliente(
@dn int,
@part int,
@nom varchar(40),
@ap varchar(40),
@tl int,
@co varchar(40),
@pass varchar(40),
@fn date, 
@cn varchar(40)
)
as
begin
insert into Clientes (ID, DNI, Cp ,Nombre, Apellido,Telefono, correo,Contrasenia ,Fnac, calle, FAlta, Estado) values ((select count(*) from Clientes)+1,@dn,@part,@nom,@ap,@tl,@co,@pass,@fn,@cn,GETDATE(),1)
end 
go

create procedure DameProductos(
@id int
)
as
begin
select *from productos where id = @id
end
go


create trigger ro on clientes
after insert 
as 
begin 
insert into usuarios values ((select count(*) from Usuarios)+1,(select correo from inserted),(select Contrasenia from inserted),(select Nombre from inserted),(select Apellido from inserted),'Cliente',(select correo from inserted))  
end 
go

use MansillaRodrigo_DB
go

select * from Productos
go

create procedure SpCarrito(
@aydi int, 
@cant int
)
as
begin 
select p.Nombre, p.PrecioVenta, (select p.Estado *@cant ) as cantidad, (select p.PrecioVenta * @cant) as Subtotal from Productos as p where ID = @aydi
end
go

