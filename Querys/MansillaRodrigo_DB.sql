-- NUEVA 

create database MansillaRodrigo_DB
go

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

select *from compras
select c.Cantidad, c.PrecioCompra, c.PrecioVenta, c.Ganancia, c.FCompra from Productos as p inner join compras as c on c.IdProducto = p.ID



