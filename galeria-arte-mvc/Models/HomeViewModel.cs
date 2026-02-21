namespace galeria_arte_mvc.Models
{
    public class HomeViewModel
    {
        public List<Obra> Obras { get; set; } = new List<Obra>();
        public List<Exposicion> Exposiciones { get; set; } = new List<Exposicion>();
    }
}
