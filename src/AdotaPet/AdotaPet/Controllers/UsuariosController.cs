using AdotaPet.Models;
using AdotaPet.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace AdotaPet.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.Where((user)=> user.Status!= StatusUsuario.Inativo).ToListAsync();
            return View(dados);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(UsuarioPessoaViewModel usuarioData)
        {
           Usuario? verificaEmail = await _context.Usuarios.Where((e) => e.Email == usuarioData.Usuario.Email).FirstOrDefaultAsync();
            if (verificaEmail != null && verificaEmail.Status==StatusUsuario.Ativo){
                ModelState.AddModelError("Usuario.Email", "Esse e-mail já está em uso.");
                return View(usuarioData);
            }else if(verificaEmail != null && verificaEmail.Status == StatusUsuario.Inativo)
            {
                ModelState.AddModelError("Usuario.Email", "Esse e-mail está vinculado a uma conta desativada entre em contato para reativarmos sua conta ou tente outro e-mail.");
                return View(usuarioData);
            }

            if (!User.Identity.IsAuthenticated)
            {
                usuarioData.Usuario.Perfil = Perfil.User;
            }

            if (ModelState.IsValid)
            {
                usuarioData.Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioData.Usuario.Senha);
                _context.Usuarios.Add(usuarioData.Usuario);
                await _context.SaveChangesAsync();
                Usuario createdUser = await _context.Usuarios.FirstAsync((e) => e.Email == usuarioData.Usuario.Email);
                usuarioData.Pessoa.Usuario = createdUser;
                _context.Pessoas.Add(usuarioData.Pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(usuarioData);
        }

        public  IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {

             var dados = await (
             from u in _context.Usuarios
             join p in _context.Pessoas on u.Id equals p.UsuarioId
             where (u.Email == usuario.Email)
             select new UsuarioPessoaViewModel
             {
                 Pessoa = p,
                 Usuario = u

             }).Where((e) => e.Usuario.Email == usuario.Email).FirstAsync();

            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Usuario.Senha);

            if (senhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Pessoa.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Usuario.Id.ToString()),
                    new Claim(ClaimTypes.Role, dados.Usuario.Perfil.ToString())
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();

            }

            return View();
        }

        public async Task<IActionResult> Logout () 
        { 
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios"); 
        }   


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await (
             from u in _context.Usuarios
             join p in _context.Pessoas on u.Id equals p.UsuarioId
             where (u.Id == id)
             select new UsuarioPessoaViewModel
             {
                 Pessoa = p,
                 Usuario = u

             }).Where((e)=> e.Usuario.Id == id).FirstAsync();
        
            if(dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UsuarioPessoaViewModel usuarioData)
        {
            if(id != usuarioData.Usuario.Id)
            {
                return NotFound();
            }
            if (!_context.Usuarios.Where((e) => e.Email == usuarioData.Usuario.Email&& usuarioData.Usuario.Id !=e.Id).IsNullOrEmpty())
            {
                ModelState.AddModelError("Usuario.Email", "Esse e-mail já está em uso.");
                return View(usuarioData);
            }
            if (ModelState.IsValid)
            {
                usuarioData.Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioData.Usuario.Senha);
                _context.Usuarios.Update(usuarioData.Usuario);
                _context.Pessoas.Update(usuarioData.Pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await (
             from u in _context.Usuarios
             join p in _context.Pessoas on u.Id equals p.UsuarioId
             where (u.Id == id)
             select new UsuarioPessoaViewModel
             {
                 Pessoa = p,
                 Usuario = u

             }).Where((e) => e.Usuario.Id == id).FirstAsync();

            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = await _context.Usuarios.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = await _context.Usuarios.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }
            dados.Status = StatusUsuario.Inativo;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
