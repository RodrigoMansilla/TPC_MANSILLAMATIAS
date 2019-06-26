using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int ID { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime FNac { get; set; }
        public DateTime FAlta { get; set; }
        public string CalleYNumero { get; set; }
        public Cp cp { get; set; }

    }
}
