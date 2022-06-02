using System.ComponentModel.DataAnnotations;

namespace AgendaTallerV4.Modelos
{
    public class Contacto
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string Telefono { get; set; }

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creación")]

        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Debe completar la categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
