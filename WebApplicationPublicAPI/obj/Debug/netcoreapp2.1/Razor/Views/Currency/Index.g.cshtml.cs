#pragma checksum "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518f4ac11590a052ce5669c82355242d5af82ad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currency_Index), @"mvc.1.0.view", @"/Views/Currency/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currency/Index.cshtml", typeof(AspNetCore.Views_Currency_Index))]
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
#line 1 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\_ViewImports.cshtml"
using WebApplicationPublicAPI;

#line default
#line hidden
#line 2 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\_ViewImports.cshtml"
using WebApplicationPublicAPI.Models;

#line default
#line hidden
#line 1 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
using Microsoft.CodeAnalysis.Host;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518f4ac11590a052ce5669c82355242d5af82ad9", @"/Views/Currency/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd578b3fe75660adbeea76776fd5b9a322353f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Currency_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RateDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(107, 330, true);
            WriteLiteral(@"
<h2>Currency Rates</h2>

<table>
    <thead>
        <tr>
            <th>
                <h4>Currency</h4>
            </th>
            <th>
                <h4>-------</h4>
            </th>
            <th>
                <h4>Value</h4>
            </th>
        </tr>
    </thead>
    <tbody id=""table"">
");
            EndContext();
#line 25 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(486, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(535, 39, false);
#line 29 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
           Write(Html.DisplayFor(valueItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(574, 92, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(667, 40, false);
#line 34 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
           Write(Html.DisplayFor(valueItem => item.Value));

#line default
#line hidden
            EndContext();
            BeginContext(707, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "D:\App\TextFileDemoApp\WebApplicationPublicAPI\Views\Currency\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(754, 109, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<button id=\"next\" , value=\"add\" class=\"btn btn-primary btn-sm\">NEXT>>></button>\r\n\r\n");
            EndContext();
            BeginContext(863, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1d6c87da844a09a254d0a9be809256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(911, 1283, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    var page = 1;
    $(""#next"").on('click',
        function() {
            $.ajax({
                type: 'GET',
                url: '/currency/getjsonrates/',
                data: { ""page"": page },
                dataType: 'json',
                success: function(data) {
                    if (data != null) {
                        for (var i = 0; i < data.length; i++) {
                            var tr = (
                                `<tr><td>${data[i].name}</td><td>
                                    </td><td>${data[i].value}</td></tr>`
                            );
                            $(""tr:odd"").css(""background-color"", ""#F0F8FF"");
                            $(""#table"").append(tr);
                            
                        }
                        page++;
                    }
                },
                beforeSend: function() {
                    $(""#progress"").show();
                },
            ");
            WriteLiteral(@"    complete: function() {
                    $(""#progress"").hide();
                },
                error: function() {
                    alert(""Error while retrieving data!"");
                }
            });
        });
</script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RateDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591