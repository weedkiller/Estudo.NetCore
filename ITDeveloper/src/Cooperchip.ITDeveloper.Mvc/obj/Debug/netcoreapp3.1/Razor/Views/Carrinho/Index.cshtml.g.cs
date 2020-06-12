#pragma checksum "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972763158bfcbef6544ebde42ffc9ddfc841124f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972763158bfcbef6544ebde42ffc9ddfc841124f", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3e663f05881c1a02705e8d4fa32659c73b82bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Carrinho de Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h3>\r\n        ");
#nullable restore
#line 10 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h3>

    <div class=""panel panel-heading"">
        <h3>Carrinho de Compras</h3>
    </div>

    <div class=""panel panel-body"">
        <table class=""table table-hover"">
            <caption>Produtos no Carrinho</caption>
            <thead>
                <tr>
                    <th>Produtos</th>
                    <th>Valor</th>
                    <th>Estoque</th>
                    <th>Validade</th>
                    <th>Tem em Estoque</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                 foreach (var prod in Model.Produtos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Validade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.TemEmEstoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 39 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td><strong>Total: </strong></td>\r\n                    <td>");
#nullable restore
#line 44 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(Model.TotalCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
