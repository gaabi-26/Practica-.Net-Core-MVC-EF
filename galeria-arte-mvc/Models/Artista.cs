using System.ComponentModel.DataAnnotations;

namespace galeria_arte_mvc.Models
{
    public class Artista
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El nombre del artista es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del artista no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El país del artista es obligatorio.")]
        [StringLength(50, ErrorMessage = "El país del artista no puede exceder los 50 caracteres.")]
        [Display(Name = "País")]
        public string Pais { get; set; }
    }
}
