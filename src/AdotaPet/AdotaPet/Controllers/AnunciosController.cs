using AdotaPet.Models;
using AdotaPet.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net.NetworkInformation;
using System.Security.Claims;
namespace AdotaPet.Controllers
{
    [Authorize]
    public class AnunciosController : Controller
    {
        private readonly AppDbContext _context;
        public AnunciosController(AppDbContext context) 
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<ActionResult> Index() 
        {
            var dados = await _context.Anuncios.Where((anuncio) => anuncio.Status == 0).ToListAsync();

            List<AnuncioInteracaoViewModel> anuncios = [];

            string idLoggedUser = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            for (int i = 0; i < dados.Count; i++){
                var temDenuncia = await _context.InteracaoAnuncio.Where((e) => e.UsuarioId.ToString() == idLoggedUser && e.AnuncioId == dados[i].Id && e.InteracaoId == 2).ToListAsync();
                if (temDenuncia.IsNullOrEmpty())
                {
                    var temLike = await _context.InteracaoAnuncio.Where((e) => e.UsuarioId.ToString() == idLoggedUser && e.AnuncioId == dados[i].Id && e.InteracaoId == 1).ToListAsync();

                    AnuncioInteracaoViewModel anuncioCompleto = new AnuncioInteracaoViewModel();

                    anuncioCompleto.Anuncio = dados[i];
                    anuncioCompleto.TemLike = !temLike.IsNullOrEmpty();

                    anuncios.Add(anuncioCompleto);
                }
            }

            return View(anuncios);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Anuncio anuncio)
        {
            if(ModelState.IsValid) {
                anuncio.Status = StatusAnuncio.Publicado;
                anuncio.DataPostagem = DateTime.Now;

                string idLoggedUser = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "";
                Usuario? firstUser = await _context.Usuarios.Where((user)=>user.Id.ToString() == idLoggedUser).FirstOrDefaultAsync();
                if (firstUser == null)
                {
                    return NotFound();
                }

                anuncio.UsuarioId= firstUser.Id;

                _context.Anuncios.Add(anuncio); 
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(anuncio);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.FindAsync<Anuncio>(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int? id, Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Anuncios.Update(anuncio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [AllowAnonymous]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.FindAsync<Anuncio>(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.FindAsync<Anuncio>(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.FindAsync<Anuncio>(id);

            if (dados == null)
            {
                return NotFound();
            }
            dados.Status = StatusAnuncio.Deletado;
            _context.Anuncios.Update(dados);
            //_context.Anuncios.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
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

            var interaction = await _context.InteracaoAnuncio.Where((e)=> e.UsuarioId == firstUser.Id && e.AnuncioId == id && e.InteracaoId == 1).ToListAsync();
            if (!interaction.IsNullOrEmpty())
            {
                _context.InteracaoAnuncio.Remove(interaction.First());
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            InteracaoAnuncio interacaoAnuncio = new InteracaoAnuncio();
            interacaoAnuncio.UsuarioId = firstUser.Id;
            interacaoAnuncio.AnuncioId = anuncio.Id;
            interacaoAnuncio.InteracaoId = 1;

            _context.InteracaoAnuncio.Add(interacaoAnuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Report(int? id)
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

            var interaction = await _context.InteracaoAnuncio.Where((e) => e.UsuarioId == firstUser.Id && e.AnuncioId == id && e.InteracaoId == 2).ToListAsync();
            if (!interaction.IsNullOrEmpty())
            {
                _context.InteracaoAnuncio.Remove(interaction.First());
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            InteracaoAnuncio interacaoAnuncio = new InteracaoAnuncio();
            interacaoAnuncio.UsuarioId = firstUser.Id;
            interacaoAnuncio.AnuncioId = anuncio.Id;
            interacaoAnuncio.InteracaoId = 2;

            _context.InteracaoAnuncio.Add(interacaoAnuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
