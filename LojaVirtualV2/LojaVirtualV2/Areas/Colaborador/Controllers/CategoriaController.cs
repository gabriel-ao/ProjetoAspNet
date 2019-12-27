using LojaVirtualV2.Libraries.Filtro;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtualV2.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    //TODO - Hibilitar verificação de login
    //[ColaboradorAutorizacao]
    public class CategoriaController : Controller
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index(int? pagina)
        {
            var categorias = _categoriaRepository.ObterTodosCategorias(pagina);
            return View(categorias);
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a=>new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.Cadastrar(categoria);

                TempData["MSG_S"] = "Registro salvo com sucesso!";

                return RedirectToAction(nameof(Index));

            }

            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Where(a => a.Id != Id). Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria, int Id)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.Atualizar(categoria);

                TempData["MSG_S"] = "Registro salvo com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Where(a => a.Id != Id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Excluir (int Id)
        {
            return View();
        }
    }
}