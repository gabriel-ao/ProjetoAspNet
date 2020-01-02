using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtualV2.Libraries.Lang;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LojaVirtualV2.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaboradorRepository;
        public ColaboradorController(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }
        
        public IActionResult Index(int? pagina)
        {
            IPagedList<Models.Colaborador>  colaboradores = _colaboradorRepository.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }

        //cadastrar 
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _colaboradorRepository.Cadastrar(colaborador);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        // atualizar 
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Models.Colaborador colaborador, int Id)
        {
            return View();
        }

        public IActionResult Excluir(int Id)
        {
            return View();
        }


    }
}