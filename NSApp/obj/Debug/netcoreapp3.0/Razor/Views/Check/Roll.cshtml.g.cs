#pragma checksum "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc073b268ad25cd8f5b5cbd0a77ef2add5bfcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Check_Roll), @"mvc.1.0.view", @"/Views/Check/Roll.cshtml")]
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
#line 1 "D:\Projekty\Nauka\NS_APP\NSApp\Views\_ViewImports.cshtml"
using NSApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekty\Nauka\NS_APP\NSApp\Views\_ViewImports.cshtml"
using NSApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc073b268ad25cd8f5b5cbd0a77ef2add5bfcb3", @"/Views/Check/Roll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b657c21ee14c802cee180abd10637661c09aca70", @"/Views/_ViewImports.cshtml")]
    public class Views_Check_Roll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
  
    ViewData["Title"] = "RollData";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Roll Data\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h3>Values</h3>\r\n        <ul class=\"list-group list-group-horizontal\">\r\n");
#nullable restore
#line 13 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
             foreach (int value in Model.NaturalRollValues)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">");
#nullable restore
#line 15 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                       Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                Poziom Trudności [numerycznie]\r\n                <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 21 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                                        Write(Model.DifficultyLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                Modyfikator Poziomu Trudności\r\n                <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 25 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                                        Write(Model.DifficultyModifier);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </li>
        </ul>
        <div class=""row"">
            <ul class=""list-group"">
                <li class=""list-group-item d-flex justify-content-between align-items-center"">
                    Imię postaci
                    <span class=""badge badge-primary badge-pill"">");
#nullable restore
#line 32 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                                            Write(Model.Hero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                    Wartość Atrybutu\r\n                    <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 36 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                                            Write(Model.Hero.AttributeValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n                <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                    Wartość Umiejętności\r\n                    <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 40 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
                                                            Write(Model.Hero.SkillValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1879, "\"", 1918, 1);
#nullable restore
#line 47 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
WriteAttributeValue("", 1886, Url.ActionLink("Index","Check"), 1886, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Kolejny Test</a>\r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1978, "\"", 2023, 1);
#nullable restore
#line 48 "D:\Projekty\Nauka\NS_APP\NSApp\Views\Check\Roll.cshtml"
WriteAttributeValue("", 1985, Url.ActionLink("Roll","Check", Model), 1985, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Przerzut</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
