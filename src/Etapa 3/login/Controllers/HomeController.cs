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

        // Exibir p�gina de login
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
                HttpContext.Session.SetString("UserName", usuario.Nome); // Salvando nome na sess�o
                return RedirectToAction("Index", "Home"); // Redireciona para a p�gina inicial ap�s login
            }

            // Caso falhe
            ModelState.AddModelError("", "Nome de usu�rio ou senha inv�lidos.");
            return View();
        }

        // Exibir p�gina de registro
        public IActionResult Register()
        {
            return View();
        }

        // Processar o registro de um novo usu�rio
        [HttpPost]
        public async Task<IActionResult> Register(Usuario usuario, string ConfirmSenha)
        {
            if (ModelState.IsValid)
            {
                // Verificar se as senhas coincidem
                if (usuario.Senha != ConfirmSenha)
                {
                    ModelState.AddModelError("", "As senhas n�o coincidem.");
                    return View(usuario);
                }

                // Criptografar a senha antes de salvar no banco
                usuario.SetSenha(usuario.Senha);
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); // Redireciona para a p�gina de login ap�s o registro
            }
            return View(usuario);
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName"); // Remover o nome de usu�rio da sess�o
            return RedirectToAction("Index", "Login"); // Redireciona para a p�gina de login
        }
    }
}
