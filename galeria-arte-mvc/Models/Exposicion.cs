using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace galeria_arte_mvc.Models
{
    public class Exposicion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la exposición es obligatorio.")]
        public string Nombre { get; set; }

        [Required (ErrorMessage = "La fecha de inicio es obligatoria.")]
        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria.")]
        [Display(Name = "Fecha de Fin")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public List<Obra> ObrasExpuestas { get; set; } = new List<Obra>();
    }
}
