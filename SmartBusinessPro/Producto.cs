using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBusinessPro
{
    /// <summary>Entidad que representa la tabla Productos.</summary>
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        // Llave foránea hacia Categorias
        public int CategoriaId { get; set; }

        [Required, MaxLength(150)]
        public string Nombre { get; set; } = "";

        [Column(TypeName = "decimal(12,2)")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        [MaxLength(100)]
        public string Proveedor { get; set; }

        public bool Activo { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public Categoria Categoria { get; set; }

        // Solo para mostrar en el DataGridView (no es una columna de la tabla)
        [NotMapped]
        public string CategoriaNombre => Categoria?.Nombre ?? "";
    }
}