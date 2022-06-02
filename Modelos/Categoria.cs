using System.ComponentModel.DataAnnotations;

namespace AgendaTallerV4.Modelos
{
    public class Categoria
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creación")]

        public DateTime FechaCreacion { get; set; }
    }
}

