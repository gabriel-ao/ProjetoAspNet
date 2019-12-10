using LojaVirtualV2.Database;
using LojaVirtualV2.Libraries.Email;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LojaVirtualV2.Controllers
{
    public class HomeController : Controller
    {
        private INewsletterRepository _repositoryNewsletter;

        private IClienteRepository _repositoryCliente;
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository newletterRepository)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsletter = newletterRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewLetterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _repositoryNewsletter.Cadastrar(newsletter);

                TempData["MSG_S"] = "E-mail cadastrado! Agora você vai receber promoções especiais no seu e-mail! Fiquei atento as novidades";

                return View();

                
            }
            else
            {
                return View();
            }
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {

            try
            {
                Contato contato = new Contato();

                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];


                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if (isValid)
                {
                    ContatoEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }
                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }

            }
            catch (Exception Ex)
            {
                ViewData["MSG_E"] = "Erro, tente novamente mais tarde";

                //TODO - Implementar Log        
            }

            return View("Contato");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Cliente cliente)
        {
            if(cliente.Email == "gabriel-ao@hotmail.com" && cliente.Senha == "1234")
            {

                HttpContext.Session.Set("ID", new byte[] { 52 });
                HttpContext.Session.SetString("Email", cliente.Email);
                HttpContext.Session.SetInt32("Idade", 23);

                var cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddHours(1);
                HttpContext.Response.Cookies.Append("Login", "testando com bode", cookieOptions);

                return new ContentResult() { Content = "Logado!" };

            }
            else
            {
                return new ContentResult() { Content = "Não logado" };
            }
            
        }

        [HttpGet]
        public IActionResult Painel()
        {
            byte[] UsuarioID;

            if (HttpContext.Session.TryGetValue("ID", out UsuarioID))
            {
                return new ContentResult() { Content = "Usuario " + UsuarioID[0] + ". Logado!"};
            }
            else
            {
                return new ContentResult() { Content = "Não logado!" };
            }
        }


        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //TODO - implementar redirecionamentos diferentes (painel, carrinho de compra rtc).


                return View(nameof(CadastroCliente));
                // TODO - gravar no banco
            }
            else
            {
                return View();
            }
        }

        public IActionResult carrinhoCompras()
        {
            return View();
        }
    }
}
