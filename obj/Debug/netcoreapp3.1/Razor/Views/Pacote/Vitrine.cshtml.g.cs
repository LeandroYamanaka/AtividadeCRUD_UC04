#pragma checksum "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2fdad9e6c7578be40cfe3a620f1715f0a102e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_Vitrine), @"mvc.1.0.view", @"/Views/Pacote/Vitrine.cshtml")]
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
#line 1 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\_ViewImports.cshtml"
using Atividade_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
using Atividade_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2fdad9e6c7578be40cfe3a620f1715f0a102e9", @"/Views/Pacote/Vitrine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d462a169bb18cfd2e5b15a2cccdd2b5e800796f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacote_Vitrine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
  
    ViewData["Title"] = "Vitrine";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"vitrine\">\r\n    <h3>Vitrine de Pacotes</h3>\r\n    <div class=\"pacotes\">\r\n\r\n\r\n");
#nullable restore
#line 13 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
         foreach (Pacote x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <style>\r\n                .pacotes-box {\r\n                    height: 290px;\r\n                }\r\n            </style>\r\n            <div class=\"pacotes-box\">\r\n                <p>Destino: ");
#nullable restore
#line 21 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                       Write(x.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Partida: ");
#nullable restore
#line 22 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                       Write(x.Partida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Saída: ");
#nullable restore
#line 23 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                     Write(x.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Retorno: ");
#nullable restore
#line 24 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                       Write(x.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>R$ ");
#nullable restore
#line 25 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                 Write(x.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Usuário: ");
#nullable restore
#line 26 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
                       Write(x.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a href=\"#\">Adicionar ao Carrinho</a></p>\r\n            </div>\r\n");
#nullable restore
#line 29 "E:\Users\leand\Documents\TI Senac\Módulo Estruturar e implementar banco de dados\Atividade 2\Views\Pacote\Vitrine.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacote>> Html { get; private set; }
    }
}
#pragma warning restore 1591
