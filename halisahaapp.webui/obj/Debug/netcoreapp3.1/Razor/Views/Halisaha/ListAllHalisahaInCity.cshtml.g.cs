#pragma checksum "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ff2bb2c472be8396cd80d729858483163c3d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Halisaha_ListAllHalisahaInCity), @"mvc.1.0.view", @"/Views/Halisaha/ListAllHalisahaInCity.cshtml")]
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
#line 3 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\_ViewImports.cshtml"
using halisahaapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\_ViewImports.cshtml"
using halisahaapp.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\_ViewImports.cshtml"
using halisahaapp.webui.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ff2bb2c472be8396cd80d729858483163c3d8f", @"/Views/Halisaha/ListAllHalisahaInCity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459ca0ba387cb0b83881ee36990c0763016b8547", @"/Views/_ViewImports.cshtml")]
    public class Views_Halisaha_ListAllHalisahaInCity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HalisahaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
 if (Model.Halisahas.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <h2>Bu şehirde halı saha bulunmamaktadır.</h2>\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-top: 100px; "" class=""container c"">
    <table class=""table table-striped sort-table table-hover"">
        <thead>
            <tr>
                <th>Halısahalar</th>
                <th>Puan</th>
                <th>Fiyat</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
             foreach (var item in Model.Halisahas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"align-items: center;\">\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 669, 6);
            WriteAttributeValue("", 629, "/halisaha/", 629, 10, true);
#nullable restore
#line 26 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
WriteAttributeValue("", 639, item.City, 639, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 649, "/", 649, 1, true);
#nullable restore
#line 26 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
WriteAttributeValue("", 650, item.Id, 650, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 658, "/", 658, 1, true);
#nullable restore
#line 26 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
WriteAttributeValue("", 659, item.Slug, 659, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
                   Write(item.AvgPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaha\ListAllHalisahaInCity.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HalisahaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
