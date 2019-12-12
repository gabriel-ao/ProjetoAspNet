using LojaVirtualV2.Libraries.Login;
using LojaVirtualV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace LojaVirtualV2.Libraries.Filtro
{
    /*
    *   Tipos de Filtros:
    *   autorizacao
    *   recurso
    *   acao
    *   execucao
    *   resultado
    */


    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _loginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginCliente = (LoginCliente) context.HttpContext.RequestServices.GetService(typeof(LoginCliente));

            Cliente cliente = _loginCliente.GetCliente();

            if (cliente == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado mother fuck!" };

            }
        }
    }
}
