USE Mansilla_DB
GO

SELECT *FROM Productos
---SELECT *FROM 

use Mansilla_DB
go

create table Productos (
         ID int identity not null,
         Descripcion varchar(100) null, 
         PrecioCompra decimal (8,2) not null, 
         PrecioVenta decimal (8,2) not null,
         Ganancia decimal (8,2) not null,
         stock1 int null, 
		 StockMinimo int null, 
		 Comentarios varchar(100) null, 
         Marca varchar(30) null
)
select *from Productos

--- poner not null stock1, stockminimo, comentarios marca descripcion, 
create table Categorias (
	ID int not null primary key,
	IdProducto int not null foreign key references Productos 

)