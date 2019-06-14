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

        public override string ToString()
        {
            return Nombre;
        }
    }
    
}
