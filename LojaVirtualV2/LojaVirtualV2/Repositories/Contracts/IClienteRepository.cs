using LojaVirtualV2.Models;
using System.Collections.Generic;

namespace LojaVirtualV2.Repositories.Contracts
{
    public interface IClienteRepository
    {

        Cliente Login(string Email, string Senha);
        
        //CRUD
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int Id);
        Cliente ObterCliente(int Id);
        IEnumerable<Cliente> ObterTodosClientes();


    }
}
