using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtualV2.Libraries.Login;
using LojaVirtualV2.Models;
using Newtonsoft.Json;

namespace LojaVirtualV2.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Cliente cliente)
        {
            //serializar
            string clienteString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key, clienteString);
        }

        public Cliente GetCliente()
        {
            //deserializar
            if (_sessao.Existe(Key))
            {
                string clienteJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJSONString);
            }
            return null;
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
