using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiTiendaPos.Models
{
    public class Cliente
    {   
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Correo { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }
        
        public List<Venta> Ventas { get; set; } = new();

    }
}
