using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;

namespace MiTiendaPos.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Propiedad de navegación: una categoría tiene muchos productos
        public List<Producto> Productos { get; set; } = new();
    }

    
}
