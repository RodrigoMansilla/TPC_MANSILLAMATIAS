create database Mansilla_DB
go

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
ALTER TABLE Productos ADD PRIMARY KEY (ID);
alter table Productos add Estado bit
alter table Productos add IdCategoria int foreign key references Categorias (ID) not null

create table Categorias (
	ID int not null primary key,
	Nombre varchar(50) not null
)