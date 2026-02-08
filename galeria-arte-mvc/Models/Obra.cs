using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace galeria_arte_mvc.Models
{
    public class Obra
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El título de la obra es obligatorio.")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El estilo de la obra es requerido.")]
        public string  Estilo { get; set; }

        public string? UrlImagen { get; set; }

        //[ForeignKey("Artista")]
        //public string AritstaId { get; set; }

        [NotMapped]
        public Artista? Artista { get; set; }

        public List<Exposicion> ExposicionesObras { get; set; }
    }
}
