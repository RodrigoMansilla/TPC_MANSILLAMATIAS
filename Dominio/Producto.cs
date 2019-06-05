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
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Ganancia { get; set; }
        public string Marca { get; set; }
        public int stock1 { get; set; }
        public int StockMinimo { get; set; }
        public string Comentarios { get; set; } // cuando se ingrese un producto por 1ª vez podrian en el comentario "Ingrese del productos" 
        public bool Estado { get; set; }
       // public List<string> Mas{ get; set; }
        public Categoria Categoria { get; set; }

    }
}

/*create table Productos (
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
*/
