#pragma checksum "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a105467c9a88ef55490ad4eb3ffa678a1c0095f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EstadoGrave_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EstadoGrave/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a105467c9a88ef55490ad4eb3ffa678a1c0095f8", @"/Views/Shared/Components/EstadoGrave/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EstadoGrave_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.Extentions.ViewComponents.Helpers.ContadorEstadoPaciente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 98, "\"", 127, 1);
#nullable restore
#line 3 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
WriteAttributeValue("", 106, Model.ClassContainer, 106, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"panel-heading\">\r\n        <h4 class=\"panel-title\">");
#nullable restore
#line 5 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
                           Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"panel-body pt0\">\r\n        <div class=\"progressbar-stats-1\">\r\n            <div class=\"stats\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 356, "\"", 378, 1);
#nullable restore
#line 10 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
WriteAttributeValue("", 364, Model.IconeLg, 364, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                <div class=\"stats-number\" data-from=\"0\" data-to=");
#nullable restore
#line 11 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
                                                           Write(Model.Parcial);

#line default
#line hidden
#nullable disable
            WriteLiteral(">0</div>\r\n            </div>\r\n            <div class=\"progress animated-bar flat transparent progress-bar-xs mb10 mt0\">\r\n                <div class=\"progress-bar progress-bar-white\" role=\"progressbar\" data-transitiongoal=");
#nullable restore
#line 14 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
                                                                                               Write(Model.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral("></div>\r\n            </div>\r\n            <div class=\"comparison\">\r\n                <p class=\"mb0\"><i");
            BeginWriteAttribute("class", " class=\"", 800, "\"", 822, 1);
#nullable restore
#line 17 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
WriteAttributeValue("", 808, Model.IconeSm, 808, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 17 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoGrave\Default.cshtml"
                                                         Write(Model.Percentual);

#line default
#line hidden
#nullable disable
            WriteLiteral("% sobre o total</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.Extentions.ViewComponents.Helpers.ContadorEstadoPaciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
