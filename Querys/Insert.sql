use MansillaRodrigo_DB 
go

insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'Celulares y Smartphones',1)
insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'Computacion',1)
insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'Electrónica, Audio y Video',1)
insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'Cámaras y Accesorios',1)
insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'Consolas y Videojuegos',1)
insert into Categorias (Id,Nombre,Estado) values ((select count(*) from Categorias)+1,'TVs',1)

 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Samsung',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Motorola',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Asus',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Intel',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Sony',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Sennheiser',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Philips',1)
 insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Kodak',1) 
  insert into marcas (Id,Nombre,Estado) values ((select count(*) from Marcas)+1,'Nikon',1) 


 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Celular G6',1,2,0,10,0,0,0,1)
 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Procesador I9',2,4,0,3,0,0,0,1)
 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Auricular Sennheiser Mx585',3,6,0,30,0,0,0,1)
 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Nikon Reflex D3500',4,9,0,2,0,0,0,1)
 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Playstation 4 Pro 2tb',5,5,0,1,0,0,0,1)
 insert into Productos (ID,Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ((select count(*) from Productos)+1,'Smart Tv Philips 32 Hd ',6,7,0,1,0,0,0,1)
 
 insert into Compras (IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values ((select count(*) from Compras)+1,1,5,10000,13200,13200-10000,1,GETDATE())
 insert into Compras (IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values ((select count(*) from Compras)+1,6,10,11000,15750,15750-11000,1,GETDATE())
 insert into Compras (IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values ((select count(*) from Compras)+1,3,50,700,1350,1350-700,1,GETDATE())



 







