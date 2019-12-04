using LojaVirtualV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtualV2.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);
           // return new ContentResult() { Content = "<h1>Produto -> Visualizar</h1>", ContentType = "text/html" };
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox one X",
                Descricao = "Jogue em 4K",
                Valor = 2000.00M
            };
        }
    }
}
