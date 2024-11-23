using AdotaPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdotaPet.Controllers
{
    public class AnunciosController : Controller
    {
        private readonly AppDbContext _context;
        public AnunciosController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<ActionResult> Index() 
        {
            var dados = await _context.Anuncios.Where((anuncio) => anuncio.Status == 0).ToListAsync();

            return View(dados);
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

                // TODO: TEMPORARIO ATE TER LOGIN IMPLEMENTADO
                Usuario firstUser = await _context.Usuarios.FirstAsync();
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
    }
}
