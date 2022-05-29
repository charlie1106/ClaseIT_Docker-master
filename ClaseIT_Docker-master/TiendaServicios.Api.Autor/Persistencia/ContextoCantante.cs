using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Persistencia
{
    public class ContextoCantante:DbContext
    {
        public ContextoCantante(DbContextOptions<ContextoCantante> options) : base(options)
        {

        }

        public DbSet<Cantante> AutoresCanciones { get; set; }

        public DbSet<GradoMusical> GradosMusicales { get; set; }

    }
}
