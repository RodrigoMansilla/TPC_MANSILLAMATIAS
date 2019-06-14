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
        public override string ToString()
        {
            return Nombre;
        }

    }
}

