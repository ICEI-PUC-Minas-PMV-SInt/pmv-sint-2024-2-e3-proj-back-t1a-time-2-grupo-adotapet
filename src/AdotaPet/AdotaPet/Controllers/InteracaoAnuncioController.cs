using AdotaPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdotaPet.Controllers
{
    public class InteracaoAnuncioController : Controller
    {

        private readonly AppDbContext _context;
        public InteracaoAnuncioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Like(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anuncio = await _context.FindAsync<Anuncio>(id);
            if (anuncio == null)
            {
                return NotFound();
            }

            // TODO: TEMPORARIO ATE TER LOGIN IMPLEMENTADO
            Usuario firstUser = await _context.Usuarios.FirstAsync();

            InteracaoAnuncio interacaoAnuncio = new InteracaoAnuncio();
            interacaoAnuncio.UsuarioId = firstUser.Id;
            interacaoAnuncio.AnuncioId = anuncio.Id;
            interacaoAnuncio.InteracaoId = 1;

            _context.InteracaoAnuncio.Add(interacaoAnuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AnunciosController.Index));
        }

    }

}
