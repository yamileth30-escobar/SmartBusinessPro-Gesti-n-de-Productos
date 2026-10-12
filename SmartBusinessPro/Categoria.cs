using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBusinessPro
{
    /// <summary>Entidad que representa la tabla Categorias.</summary>
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; } = "";

        [MaxLength(250)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }

        // Relación 1 a muchos: una categoría tiene varios productos
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}

