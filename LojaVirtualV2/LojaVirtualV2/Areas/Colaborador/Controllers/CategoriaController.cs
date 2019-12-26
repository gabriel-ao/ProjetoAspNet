using LojaVirtualV2.Libraries.Filtro;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult Index()
        {
            List<Categoria> categorias = _categoriaRepository.ObterTodosCategorias().ToList();
            return View(categorias);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria)
        {
            //TODO - Implementar
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Excluir (int Id)
        {
            return View();
        }
    }
}