#pragma checksum "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ba8baefb7f0904aca0f79376e990bb68fcfc9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Persona.Pages_Persona_Detail), @"mvc.1.0.razor-page", @"/Pages/Persona/Detail.cshtml")]
namespace FrontEnd.Pages.Persona
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
#line 1 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ba8baefb7f0904aca0f79376e990bb68fcfc9c", @"/Pages/Persona/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
  
    ViewData["Title"]="Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Detalle de persona</h1>\r\n\r\n<div>\r\n    <hr/>\r\n    <div class=\"row\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 13 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 16 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Persona.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 19 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 22 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Persona.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 25 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 28 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Persona.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 31 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 34 "E:\MINTIC2022\Ciclo_3\Programación\Empresa\frontend\Pages\Persona\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Persona.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>            \r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ba8baefb7f0904aca0f79376e990bb68fcfc9c6338", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
