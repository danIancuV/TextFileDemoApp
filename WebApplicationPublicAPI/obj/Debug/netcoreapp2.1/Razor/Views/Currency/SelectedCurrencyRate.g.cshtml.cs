#pragma checksum "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e7863907b29249ea8cea04ebc836406b35431c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currency_SelectedCurrencyRate), @"mvc.1.0.view", @"/Views/Currency/SelectedCurrencyRate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currency/SelectedCurrencyRate.cshtml", typeof(AspNetCore.Views_Currency_SelectedCurrencyRate))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
#line 1 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\_ViewImports.cshtml"
using WebApplicationPublicAPI;

#line default
#line hidden
#line 2 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\_ViewImports.cshtml"
using WebApplicationPublicAPI.Models;

#line default
#line hidden
#line 2 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e7863907b29249ea8cea04ebc836406b35431c", @"/Views/Currency/SelectedCurrencyRate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd578b3fe75660adbeea76776fd5b9a322353f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Currency_SelectedCurrencyRate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
  
    ViewData["Title"] = "Selected Currencies";
    List<string> currencyList = ViewBag.listofcurrencies;

#line default
#line hidden
            BeginContext(183, 32, true);
            WriteLiteral("\r\n<h2>Select currencies</h2>\r\n\r\n");
            EndContext();
#line 11 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
 using (Html.BeginForm("SelectedCurrencyRate", "Currency", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(296, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(401, 29, false);
#line 17 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
               Write(Html.Label("Choose currency"));

#line default
#line hidden
            EndContext();
            BeginContext(430, 139, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(570, 86, false);
#line 24 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
               Write(Html.DropDownList("selectedCurrency", new SelectList(currencyList), "Select currency"));

#line default
#line hidden
            EndContext();
            BeginContext(656, 151, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <input type=\"submit\" value=\"GetRate\" class=\"btn btn-primary\" /><br>\r\n");
            EndContext();
#line 31 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
}

#line default
#line hidden
            BeginContext(810, 28, true);
            WriteLiteral("<p><span style=\"color: red\">");
            EndContext();
            BeginContext(839, 13, false);
#line 32 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
                       Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(852, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
            BeginContext(866, 20, false);
#line 33 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
Write(Html.Label("Value:"));

#line default
#line hidden
            EndContext();
            BeginContext(886, 44, true);
            WriteLiteral("\r\n<input type=\"number\" , name=\"selectedRate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 930, "\"", 959, 1);
#line 34 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\SelectedCurrencyRate.cshtml"
WriteAttributeValue("", 938, ViewBag.selectedRate, 938, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(960, 14, true);
            WriteLiteral(" readonly>\r\n\r\n");
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
