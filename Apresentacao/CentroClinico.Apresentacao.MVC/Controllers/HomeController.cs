using CentroClinico.Apresentacao.MVC.Models;
using CentroClinico.Dominio.Entidades;
using CentroClinico.Infra.Banco.EF;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CentroClinico.Apresentacao.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EFContext Contexto { get; set; }

        public HomeController(ILogger<HomeController> logger, EFContext contexto)
        {
            _logger = logger;
            Contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(MVLogin login)
        {

            if (ModelState.IsValid)
            {
                Usuario usuario = Contexto.Usuarios.FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
                if (usuario == null)
                {
                    ModelState.AddModelError("", "Usuário ou senha inválidos");
                    return View();
                }

                if (!usuario.Ativo)
                {
                    ModelState.AddModelError("", "Usuário inativo, por favor verifique seu e-mail");                    
                    return View();
                }

                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Email),
                    new Claim(ClaimTypes.Role, usuario.Perfil.ToString())
                };

                ClaimsIdentity identidadeDeUsuario = new ClaimsIdentity(claims, usuario.Email);
                ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);
                AuthenticationProperties propriedadesDeAutenticacao = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                    IsPersistent = false
                };

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
                return RedirectToAction("Index", "Home");

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
