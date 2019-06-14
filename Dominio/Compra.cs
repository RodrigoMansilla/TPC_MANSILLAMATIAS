using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; } 
        public decimal Ganancia { get; set; } 
        public bool Estado { get; set; } 
        public DateTime FCompra { get; set; }

    }
}
