using AdotaPet.Models;
using AdotaPet.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace AdotaPet.Controllers
{
    [Authorize]
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

        public async Task<ActionResult> LikedList()
        {

            string idLoggedUser = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "";
            Usuario? firstUser = await _context.Usuarios.Where((user) => user.Id.ToString() == idLoggedUser).FirstOrDefaultAsync();
            if (firstUser == null)
            {
                return NotFound();
            }

            //var dados = await _context.Anuncios.Where((anuncio) => anuncio.Status == 0).ToListAsync();
            var dados = await _context.InteracaoAnuncio.Where((interacao) => interacao.UsuarioId == firstUser.Id && interacao.InteracaoId == 1).Include(e => e.Anuncio).ToListAsync();

            List<AnuncioInteracaoViewModel> anuncios = [];

            for (int i = 0; i < dados.Count; i++)
            {
              AnuncioInteracaoViewModel anuncioCompleto = new AnuncioInteracaoViewModel();

                anuncioCompleto.Anuncio = dados[i].Anuncio;
                anuncioCompleto.TemLike = true;

                anuncios.Add(anuncioCompleto);
            }

            return View(anuncios);
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

            string idLoggedUser = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "";
            Usuario? firstUser = await _context.Usuarios.Where((user) => user.Id.ToString() == idLoggedUser).FirstOrDefaultAsync();
            if (firstUser == null)
            {
                return NotFound();
            }

            var interaction = await _context.InteracaoAnuncio.Where((e) => e.UsuarioId == firstUser.Id && e.AnuncioId == id && e.InteracaoId == 1).ToListAsync();
            if (!interaction.IsNullOrEmpty())
            {
                _context.InteracaoAnuncio.Remove(interaction.First());
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LikedList));
            }


            InteracaoAnuncio interacaoAnuncio = new InteracaoAnuncio();
            interacaoAnuncio.UsuarioId = firstUser.Id;
            interacaoAnuncio.AnuncioId = anuncio.Id;
            interacaoAnuncio.InteracaoId = 1;

            _context.InteracaoAnuncio.Add(interacaoAnuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(LikedList));
        }


        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ReportedList()
        {

            string idLoggedUser = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "";
            Usuario? firstUser = await _context.Usuarios.Where((user) => user.Id.ToString() == idLoggedUser).FirstOrDefaultAsync();
            if (firstUser == null)
            {
                return NotFound();
            }

            //var dados = await _context.Anuncios.Where((anuncio) => anuncio.Status == 0).ToListAsync();
            var dados = await _context.InteracaoAnuncio.Where((interacao) => interacao.InteracaoId == 2).Include(e => e.Anuncio).ToListAsync();

            List<AnuncioInteracaoViewModel> anuncios = [];

            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i].Anuncio.Status != StatusAnuncio.Deletado){
                AnuncioInteracaoViewModel anuncioCompleto = new AnuncioInteracaoViewModel();

                anuncioCompleto.Anuncio = dados[i].Anuncio;
                    //anuncioCompleto.TemLike = true;

                    anuncios.Add(anuncioCompleto);
                }
            }

            return View(anuncios);
        }

    }

}
