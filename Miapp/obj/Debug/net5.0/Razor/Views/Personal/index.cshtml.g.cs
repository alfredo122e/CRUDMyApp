#pragma checksum "D:\AppCrud\Views\Personal\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f7e1dfc0adfcad007a7e0bf4506c43033812846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_index), @"mvc.1.0.view", @"/Views/Personal/index.cshtml")]
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
#line 1 "D:\AppCrud\Views\_ViewImports.cshtml"
using Miapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AppCrud\Views\_ViewImports.cshtml"
using Miapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f7e1dfc0adfcad007a7e0bf4506c43033812846", @"/Views/Personal/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82440f5d36790b4a6a21cb56c8d38226d1749a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Persona>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\AppCrud\Views\Personal\index.cshtml"
  
    ViewData["Title"] = "Sobre mí";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f7e1dfc0adfcad007a7e0bf4506c430338128464206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f7e1dfc0adfcad007a7e0bf4506c430338128465318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""p-3 mb-2 bg-secondary text-white"">
<div class=""text-center"">
<div class=""alert alert-secondary"" role=""alert"">
  <h1>Datos personales</h1>
</div>
</div>


<div class=""card text-white bg-dark mb-3"" style=""width: 20rem;"">
  <img src=""img/01.jpeg"" class=""card-img-top"" alt=""Mi imagen"">
  <div class=""card-body"">
    <div class=""text-left"">
    <p class=""card-text"">
");
            WriteLiteral("\n\n");
#nullable restore
#line 23 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.nombre, "NOMBRE: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\AppCrud\Views\Personal\index.cshtml"
                                   Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n");
#nullable restore
#line 24 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.apellido, "APELLIDO: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\AppCrud\Views\Personal\index.cshtml"
                                       Write(Model.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n");
#nullable restore
#line 25 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.edad, "EDAD: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "D:\AppCrud\Views\Personal\index.cshtml"
                               Write(Model.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n");
#nullable restore
#line 26 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.edad, "CORREO ELECTRÓNICO: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "D:\AppCrud\Views\Personal\index.cshtml"
                                             Write(Model.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br><br>\n");
#nullable restore
#line 27 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.edad, "TELÉFONO: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "D:\AppCrud\Views\Personal\index.cshtml"
                                   Write(Model.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n");
#nullable restore
#line 28 "D:\AppCrud\Views\Personal\index.cshtml"
Write(Html.LabelFor(m=>m.edad, "DIRECCIÓN: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "D:\AppCrud\Views\Personal\index.cshtml"
                                    Write(Model.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\n</p>\n  </div>\n  </div>\n</div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
