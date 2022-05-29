using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.Autor.Modelo;
using TiendaServicios.Api.Autor.Persistencia;

namespace TiendaServicios.Api.Autor.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CantanteController : ControllerBase
    {
        private readonly ContextoCantante _context;
        public CantanteController(ContextoCantante contexto)
        {
            _context = contexto;
        }
        [HttpPut]
        public async Task<bool> EditarRegistro(Cantante cantante)
        {
            _context.Update(cantante);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost]
        public async Task<bool> AgregarNuevoRegistro(Cantante cantante)
        {
            _context.Add(cantante);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarNuevoRegistro(int IdCantante)
        {
            var registro = _context.AutoresCanciones.FirstOrDefault(x => x.IdCantante == IdCantante);
            if (registro == null)
                return NotFound();
            return Ok();
        }
        public static void Main()
        {
            System.Console.WriteLine("BUENASSS");
        }

    }
}
