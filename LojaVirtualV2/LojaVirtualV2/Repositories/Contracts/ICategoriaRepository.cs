using LojaVirtualV2.Models;
using System.Collections.Generic;

namespace LojaVirtualV2.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        //CRUD
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        IEnumerable<Categoria> ObterTodosCategorias();
    }
}
