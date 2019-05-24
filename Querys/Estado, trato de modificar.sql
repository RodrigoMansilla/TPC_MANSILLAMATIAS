use Mansilla_DB
go

declare @des1 varchar(100), @pc decimal(8,2), @pv decimal(8,2), @gan decimal(8,2), @stock int, @stm int, @com varchar(100), @Mr varchar(30), @idcat int
set @des1='Lola'
set @pc=5.4
set @pv=7.1
set @gan=41.25
set @stock=54
set @stm=4
set @com='Desdebasededatos'
set @Mr='Otro'
set @idcat=2

 

update Productos set Descripcion='Hola', PrecioCompra = 5.4, PrecioVenta =7.1, Ganancia = 5.4, stock1 = 14, StockMinimo = 5, Comentarios = 'Hola', Marca = 'MiMarca', IdCategoria = 2 where ID = 16

alter table Productos add Estado bit

update Productos set Estado = 1 

update Productos set Estado = 0 where ID = 14

select *from Productos
