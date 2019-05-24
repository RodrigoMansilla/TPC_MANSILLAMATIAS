using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalledeVenta
    {
        // Clase todavia sin terminar 
        public int CodVenta { get; set; }
        public Producto producto { get; set; }
        public decimal CantidadVendida { get; set; } //ya que si vendo 2 kilos y medio de pescado en int no entra
        public decimal Total { get; set; } // para meter la totalidad de la factura
        public DateTime FechaVenta { get; set; }
        // aca tendria que tener los datos de la empresa 
    }
}
