using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiTiendaPos.Models
{
    public class DetalleVenta
    {   
        public int Id { get; set; }
        public int VentaId { get; set; }
        public Venta Venta{ get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; }

    }
}
