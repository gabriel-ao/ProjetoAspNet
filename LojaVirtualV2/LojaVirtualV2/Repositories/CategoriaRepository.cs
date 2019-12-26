using LojaVirtualV2.Database;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtualV2.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        LojaVirtualContext _banco;

        public CategoriaRepository(LojaVirtualContext banco)
        {
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

        public IEnumerable<Categoria> ObterTodosCategorias()
        {
            return _banco.Categorias.ToList();
        }
    }
}
