using LojaVirtualV2.Database;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtualV2.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        IConfiguration _conf;
        LojaVirtualContext _banco;

        public CategoriaRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
            _conf = configuration;
            _banco = banco;
        }

        public void Atualizar(Categoria categoria)
        {
            _banco.Update(categoria);
            _banco.SaveChanges();
        }

        public void Cadastrar(Categoria categoria)
        {
            _banco.Add(categoria);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            // um metodo sendo chamado dentro do outro
            _banco.Remove(ObterCategoria(Id));
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int Id)
        {
            return _banco.Categorias.Find(Id);
        }

        public IPagedList<Categoria> ObterTodosCategorias(int? pagina)
        {
            int RegistroPorPagina = _conf.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;
            return _banco.Categorias.Include(a=>a.CategoriaPai).ToPagedList<Categoria>(NumeroPagina, RegistroPorPagina);
        }

        public IEnumerable<Categoria> ObterTodosCategorias()
        {
            return _banco.Categorias;
        }
    }
}
