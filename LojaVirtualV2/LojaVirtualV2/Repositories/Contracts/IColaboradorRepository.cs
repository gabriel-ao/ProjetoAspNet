using LojaVirtualV2.Models;
using System.Collections.Generic;
using X.PagedList;

namespace LojaVirtualV2.Repositories.Contracts
{
    public interface IColaboradorRepository
    {
        Colaborador login(string Email, string Senha);

        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void Excluir(int Id);

        Colaborador ObterColaborador(int Id);
        IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);

    }
}
