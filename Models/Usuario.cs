using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiTiendaPos.Models
{
    public class Usuario
    {   
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; }

        [MaxLength(30)]
        public string Rol { get; set; }

        public List<Venta> Ventas { get; set; } = new();
    }
}
