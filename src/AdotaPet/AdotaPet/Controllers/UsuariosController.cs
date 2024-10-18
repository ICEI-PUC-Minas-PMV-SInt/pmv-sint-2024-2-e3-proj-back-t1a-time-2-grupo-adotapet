using AdotaPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdotaPet.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();
            return View(dados);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
