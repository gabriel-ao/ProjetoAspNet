#pragma checksum "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5441875cd94ab6e4500ee5e9211b825155e75ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contato.cshtml", typeof(AspNetCore.Views_Home_Contato))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\_ViewImports.cshtml"
using LojaVirtualV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5441875cd94ab6e4500ee5e9211b825155e75ef", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816eed92de902cb8b0a899dd4f902922402c6c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ContatoAcao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";
    LojaVirtualV2.Models.Contato contato =(LojaVirtualV2.Models.Contato) ViewData["CONTATO"];

#line default
#line hidden
            BeginContext(140, 1271, true);
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> 
                </div> 
            </aside>
            ");
            WriteLiteral("<aside class=\"col-sm-6\">\r\n\r\n                <h4 class=\"subtitle-doc\">\r\n                    # Contato\r\n                </h4>\r\n                <div>\r\n\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n");
            EndContext();
#line 43 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
            BeginContext(1503, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(1567, 27, false);
#line 45 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                                                          Write(Html.Raw(ViewData["MSG_S"]));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                            }                            

#line default
#line hidden
            BeginContext(1659, 30, true);
            WriteLiteral("                            \r\n");
            EndContext();
#line 48 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
            BeginContext(1781, 62, true);
            WriteLiteral("                                <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(1844, 27, false);
#line 50 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 51 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
            BeginContext(1908, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1938, 2387, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea28946c04541e78c92f0084f777442", async() => {
                BeginContext(1997, 602, true);
                WriteLiteral(@"

                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome"" placeholder=""""
                                               required=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2599, "\"", 2644, 1);
#line 62 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
WriteAttributeValue("", 2607, contato != null ? contato.Nome :"", 2607, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2645, 630, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" id=""email"" class=""form-control"" name=""email"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                         value=\"", 3275, "\"", 3364, 1);
#line 73 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
WriteAttributeValue("", 3325, contato != null ? contato.Email : "", 3325, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3365, 570, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%"">");
                EndContext();
                BeginContext(3937, 36, false);
#line 82 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Views\Home\Contato.cshtml"
                                                                                                                      Write(contato != null ? contato.Texto : "");

#line default
#line hidden
                EndContext();
                BeginContext(3974, 344, true);
                WriteLiteral(@"</textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4325, 158, true);
            WriteLiteral("\r\n                        </div> \r\n                    </article> \r\n\r\n                </div> \r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
