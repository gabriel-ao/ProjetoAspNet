#pragma checksum "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feca1c0864d35dfc127087c977780a95afd15a11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Categoria/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index))]
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
#line 3 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtualV2.Models;

#line default
#line hidden
#line 4 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feca1c0864d35dfc127087c977780a95afd15a11", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bff88212304e9096729373e742fb60b726a3c6f", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtualV2.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 24, true);
            WriteLiteral("\r\n<h1>Categoria</h1>\r\n\r\n");
            EndContext();
            BeginContext(128, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82b848bef73462e8b9f7f89e7756961", async() => {
                BeginContext(178, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(191, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(231, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(267, 27, false);
#line 12 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                              Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
            EndContext();
            BeginContext(294, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(303, 61, true);
            WriteLiteral("\r\n<!-- if para verificar se existe dados para paginação -->\r\n");
            EndContext();
#line 16 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(390, 469, true);
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th scope=""col"">Código</th>
                    <th scope=""col"">Nome</th>
                    <th scope=""col"">Categoria</th>
                    <th scope=""col"">Ações</th>
                </tr>
            </thead>
            <tbody>
                <!-- Foreach utilizado para puxar todos os dados da pagelist -->
");
            EndContext();
#line 30 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                 foreach (Categoria categoria in Model)
                {

#line default
#line hidden
            BeginContext(935, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1002, 12, false);
#line 33 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                   Write(categoria.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1050, 14, false);
#line 34 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 36 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                             if (categoria.CategoriaPai != null)
                            {

#line default
#line hidden
            BeginContext(1198, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(1237, 25, false);
#line 38 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                 Write(categoria.CategoriaPai.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1262, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1266, 27, false);
#line 38 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                              Write(categoria.CategoriaPai.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 39 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1398, 49, true);
            WriteLiteral("                                <span>--</span>\r\n");
            EndContext();
#line 43 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1478, 93, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1571, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daaed604b8ac4123820afd4ca38629ad", async() => {
                BeginContext(1652, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                        WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1695, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30dc56a4a0c45528b55ab6aef7d39d2", async() => {
                BeginContext(1771, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                      WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1782, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 52 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1861, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1920, 85, false);
#line 57 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
            EndContext();
#line 57 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                                                          
}
else
{

#line default
#line hidden
            BeginContext(2019, 46, true);
            WriteLiteral("    <span> Nenhum registro cadastrado</span>\r\n");
            EndContext();
#line 62 "Z:\GitHub\ProjetoAspNet\LojaVirtualV2\LojaVirtualV2\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2068, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtualV2.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
