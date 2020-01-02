using LojaVirtualV2.Libraries.Login;
using LojaVirtualV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace LojaVirtualV2.Libraries.Filtro
{
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginColaborador _loginColaborador;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));

            Colaborador colaborador = _loginColaborador.GetColaborador();

            if (colaborador == null)
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);

            }
        }
    }
}
