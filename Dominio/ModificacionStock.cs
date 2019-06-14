using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModificacionStock
    {

        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad {get; set;}
        public string Comentarios { get; set; }
        public string NameProduct { get; set; }
        public bool estado { get; set; }
        public DateTime FechaModificacion { get; set; }
        /*
Create table ModiStock(
Id int not null primary key,
idProducto int not null foreign key references Productos(ID),
Cantidad int not null,
Comentario varchar(30) null,
FechaModificacion date not null,
estado bit null default 1 
)*/
    }
}
