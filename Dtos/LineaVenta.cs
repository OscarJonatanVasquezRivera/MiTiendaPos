using System;
using System.Collections.Generic;
using System.Text;

namespace MiTiendaPos.Dtos
{
    public class LineaVenta
    {   
        public int ProductoId { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;

    }
}
