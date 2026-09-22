using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiTiendaPos.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        // Propiedad de navegación: una categoría tiene muchos productos
        public List<Producto> Productos { get; set; } = new();
    }

    
}
