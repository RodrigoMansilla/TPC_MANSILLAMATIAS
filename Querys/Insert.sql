use MansillaRodrigo3_DB 
go

insert into Categorias (Nombre,Estado) values ('Celulares y Smartphones',1)
insert into Categorias (Nombre,Estado) values ('Computacion',1)
insert into Categorias (Nombre,Estado) values ('Electrónica, Audio y Video',1)
insert into Categorias (Nombre,Estado) values ('Cámaras y Accesorios',1)
insert into Categorias (Nombre,Estado) values ('Consolas y Videojuegos',1)
insert into Categorias (Nombre,Estado) values ('TVs',1)

 insert into marcas (Nombre,Estado) values ('Samsung',1)
 insert into marcas (Nombre,Estado) values ('Motorola',1)
 insert into marcas (Nombre,Estado) values ('Asus',1)
 insert into marcas (Nombre,Estado) values ('Intel',1)
 insert into marcas (Nombre,Estado) values ('Sony',1)
 insert into marcas (Nombre,Estado) values ('Sennheiser',1)
 insert into marcas (Nombre,Estado) values ('Philips',1)
 insert into marcas (Nombre,Estado) values ('Kodak',1) 
  insert into marcas (Nombre,Estado) values ('Nikon',1) 


 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Celular G6',1,2,0,10,0,0,0,1)
 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Procesador I9',2,4,0,3,0,0,0,1)
 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Auricular Sennheiser Mx585',3,6,0,30,0,0,0,1)
 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Nikon Reflex D3500',4,9,0,2,0,0,0,1)
 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Playstation 4 Pro 2tb',5,5,0,1,0,0,0,1)
 insert into Productos (Nombre,IdCategoria,IdMarca,Stock,StockMinimo,PrecioCompra,PrecioVenta,Ganancia,Estado) values ('Smart Tv Philips 32 Hd ',6,7,0,1,0,0,0,1)
 
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (1,5,10000,13200,13200-10000,1,GETDATE())
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (2,10,11000,15750,15750-11000,1,GETDATE())
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (3,50,700,1350,1350-700,1,GETDATE())
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (4,5,10000,13200,13200-10000,1,GETDATE())
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (5,10,11000,15750,15750-11000,1,GETDATE())
 insert into Compras (IdProducto,Cantidad,PrecioCompra,PrecioVenta,Ganancia,Estado,FCompra) values (6,50,700,1350,1350-700,1,GETDATE())
  
 insert into Provincias (Nombre) values ('Buenos Aires')
 insert into Provincias (Nombre) values ('Catamarca')
 insert into Provincias (Nombre) values ('Chaco')
 insert into Provincias (Nombre) values ('Chubut')
 insert into Provincias (Nombre) values ('Córdoba')
 insert into Provincias (Nombre) values ('Corrientes')
 insert into Provincias (Nombre) values ('Entre Ríos')
 insert into Provincias (Nombre) values ('Formosa')
 insert into Provincias (Nombre) values ('Jujuy')
 insert into Provincias (Nombre) values ('La Pampa')
 insert into Provincias (Nombre) values ('La Rioja')
 insert into Provincias (Nombre) values ('Mendoza')
 insert into Provincias (Nombre) values ('Misiones')
 insert into Provincias (Nombre) values ('Neuquén')
 insert into Provincias (Nombre) values ('Río Negro')
 insert into Provincias (Nombre) values ('Salta')
 insert into Provincias (Nombre) values ('San Juan')
 insert into Provincias (Nombre) values ('San Luis')
 insert into Provincias (Nombre) values ('Santa Cruz')
 insert into Provincias (Nombre) values ('Santa Fe')
 insert into Provincias (Nombre) values ('Santiago del Estero')
 insert into Provincias (Nombre) values ('Tierra del Fuego')
 insert into Provincias (Nombre) values ('Tucumán')

insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1607,'VILLA ADELINA','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1621,'BENAVIDEZ','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1617,'PACHECO','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1648,'TIGRE','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1611,'DON TORCUATO','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1641,'ACASSUSO','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1643,'BECAR','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1609,'BOULOGNE ','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1640,'MARTINEZ','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1642,'SAN ISIDRO','Buenos Aires', 1)
insert into Cp (CodigoPostal,Partido,Provincia,estado) values (1619,'GARIN','Buenos Aires', 1)


insert into clientes values (10000,1607,'Rodrigo','Mansilla',1530205065,'rodrigo@ro.com',123,getdate(),'Reconquista 1366',getdate(),1)
insert into clientes values (20000,1621,'Roberto','Sanchez',1530235405,'roberto@sa.com',456,getdate(),'Godoy Cruz 132',getdate(),1)
insert into clientes values (30000,1640,'Gladys','Fernandes',1530542141,'gladys@fe.com',789,getdate(),'Calle 4 N 54',getdate(),1)

exec SPModificarProducto2 'Celular G6',10,10,20
exec SPModificarProducto2 'Procesador I9',3,1000,20000
exec SPModificarProducto2 'Auricular Sennheiser Mx585',40,1500,20000
exec SPModificarProducto2 'Nikon Reflex D3500',7,1580,2700
exec SPModificarProducto2 'Playstation 4 Pro 2tb',9,9999,13200
exec SPModificarProducto2 'Smart Tv Philips 32 Hd',17,6300,9200





 
 



 







