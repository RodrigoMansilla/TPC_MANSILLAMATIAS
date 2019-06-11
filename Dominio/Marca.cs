using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public bool Estado { get; set; } 

    }
    /*create table Marcas(
Id int primary key not null,
Nombre varchar(50) not null,
Estado bit not null default 1 
)
*/
}
