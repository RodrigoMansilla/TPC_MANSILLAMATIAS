use Mansilla_DB
go

alter table Productos add Estado bit

update Productos set Estado = 1 

update Productos set Estado = 0 where ID = 14


-- Procedimiento almacenado para agregar categorias 

create procedure SPAgregarCategoria(
@Nombre varchar (50)
)
as
begin 
insert into Categorias (Nombre) values (@Nombre)
end 

alter table categorias add Estado bit

-- Procedimiento almacenado para Editar Productos

create procedure SPModificarProducto(
@aydi int, 
@des1 varchar(100),
@pc	Decimal(8,2), 
@pv decimal(8,2),	
@gan decimal(8,2),
@stock int,
@stm int, 
@com varchar(100), 
@Mr varchar(30), 
@idcat int
)
as
begin 
update Productos set Descripcion = @des1, PrecioCompra = @pc, PrecioVenta = @pv, Ganancia = @gan, stock1 = @stock, StockMinimo = @stm, Comentarios = @com, Marca = @Mr, IdCategoria = @idcat where Productos.ID = @aydi
end 













 