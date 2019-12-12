using LojaVirtualV2.Database;
using LojaVirtualV2.Models;
using LojaVirtualV2.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtualV2.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private LojaVirtualContext _banco;

        public ClienteRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            _banco.Add(cliente);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            // um metodo sendo chamado dentro do outro
            _banco.Remove(ObterCliente(Id));
            _banco.SaveChanges();
        }

        public Cliente Login(string Email, string Senha)
        {
            return _banco.Clientes.Where(C => C.Email == Email && C.Senha == Senha).FirstOrDefault();
        }

        public Cliente ObterCliente(int Id)
        {
            return _banco.Clientes.Find(Id);
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _banco.Clientes.ToList();
        }

    }
}
