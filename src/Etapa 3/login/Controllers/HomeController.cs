using Microsoft.AspNetCore.Mvc;
using projeto_adotapet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace projeto_adotapet.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // Exibir página de login
        public IActionResult Index()
        {
            return View();
        }

        // Processar o login
        [HttpPost]
        public async Task<IActionResult> Index(string nome, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Nome == nome);

            if (usuario != null && usuario.VerificarSenha(senha))
            {
                // Login bem-sucedido
                HttpContext.Session.SetString("UserName", usuario.Nome); // Salvando nome na sessão
                return RedirectToAction("Index", "Home"); // Redireciona para a página inicial após login
            }

            // Caso falhe
            ModelState.AddModelError("", "Nome de usuário ou senha inválidos.");
            return View();
        }

        // Exibir página de registro
        public IActionResult Register()
        {
            return View();
        }

        // Processar o registro de um novo usuário
        [HttpPost]
        public async Task<IActionResult> Register(Usuario usuario, string ConfirmSenha)
        {
            if (ModelState.IsValid)
            {
                // Verificar se as senhas coincidem
                if (usuario.Senha != ConfirmSenha)
                {
                    ModelState.AddModelError("", "As senhas não coincidem.");
                    return View(usuario);
                }

                // Criptografar a senha antes de salvar no banco
                usuario.SetSenha(usuario.Senha);
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); // Redireciona para a página de login após o registro
            }
            return View(usuario);
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName"); // Remover o nome de usuário da sessão
            return RedirectToAction("Index", "Login"); // Redireciona para a página de login
        }
    }
}
