using LojaVirtualV2.Models;
using Newtonsoft.Json;

namespace LojaVirtualV2.Libraries.Login
{
    public class LoginColaborador
    {

        private string Key = "Login.Colaborador";
        private Sessao.Sessao _sessao;
        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Colaborador colaborador)
        {
            //serializar
            string colaboradorString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, colaboradorString);
        }

        public Colaborador GetColaborador()
        {
            //deserializar
            if (_sessao.Existe(Key))
            {
                string colaboradorJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Colaborador>(colaboradorJSONString);
            }
            return null;
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
