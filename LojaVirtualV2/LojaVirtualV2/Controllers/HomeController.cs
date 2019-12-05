using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualV2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            string nome = HttpContext.Request.Form["nome"];
            string email = HttpContext.Request.Form["email"];
            string texto = HttpContext.Request.Form["texto"];

            return new ContentResult() { Content = string.Format("Dados recebidos com sucesso!<br/> Nome: {0}<br/> E-mail: {1}<br/> Texto: {2}", nome, email, texto), ContentType="text/html" };
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult carrinhoCompras()
        {
            return View();
        }
    }
}
