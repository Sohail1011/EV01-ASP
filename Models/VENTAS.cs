using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EV01.Models
{
    public class VENTAS
    {
        public int NroVentas { get; set; }
        public DateTime FechaVentas { get; set; }
        public string Medicamento { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe {
            get {
                return Precio * Cantidad;
            }
        }
    }
}
