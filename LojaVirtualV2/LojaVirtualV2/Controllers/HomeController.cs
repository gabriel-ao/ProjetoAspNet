using LojaVirtualV2.Database;
using LojaVirtualV2.Libraries.Email;
using LojaVirtualV2.Libraries.Filtro;
using LojaVirtualV2.Libraries.Login;
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
        private LoginCliente _loginCliente;
        private INewsletterRepository _repositoryNewsletter;
        private IClienteRepository _repositoryCliente;

        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository newletterRepository, LoginCliente loginCliente)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsletter = newletterRepository;
            _loginCliente = loginCliente;
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
            Cliente clienteDB =_repositoryCliente.Login(cliente.Email, cliente.Senha);


            if(clienteDB != null)
            {
                _loginCliente.Login(clienteDB);

                return new RedirectResult(Url.Action(nameof(Painel)));

            }
            else
            {
                ViewData["MSG_E"] = "Usuario não encontrado, verifique e-mail e senha digitado!";

                return View();

            }

        }

        [HttpGet]
        [ClienteAutorizacao]
        public IActionResult Painel()
        {
            return new ContentResult()
            {   
                Content =
                "Este é o painel do cliente"
            };
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
