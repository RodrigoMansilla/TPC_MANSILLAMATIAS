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
        public bool Estado { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
