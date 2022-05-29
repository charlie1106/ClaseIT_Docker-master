using System.ComponentModel.DataAnnotations;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class GradoMusical
    {
        [Key]
        public int IdEscuelaMusica { get; set; }
        //public AutorLibro AutorLibro { get; set; }
        public string NombreEscuela { get; set; }
        public DateTime FechaGrado { get; set; }
        public string GradosMusicales { get; set; }
    }
}
