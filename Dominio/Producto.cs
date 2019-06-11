using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Ganancia { get; set; }
        public bool Estado { get; set; }
       // public List<string> Mas{ get; set; }
        

    }
}

/*create table Productos (
create table Productos (
ID int not null primary key,
Nombre varchar(30) not null,
IdCategoria int foreign key references categorias(Id),
IdMarca int foreign key references marcas(Id),
Stock int not null, 
StockMinimo int not null, 
PrecioCompra decimal(8,2) not null,
PrecioVenta decimal(8,2) not null, 
Ganancia decimal(8,2) not null
) 
)
*/
