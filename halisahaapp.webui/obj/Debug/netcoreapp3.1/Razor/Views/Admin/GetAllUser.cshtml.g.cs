#pragma checksum "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6532cdda7e23acc8adbdbcfa1d544944cc430d12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllUser), @"mvc.1.0.view", @"/Views/Admin/GetAllUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6532cdda7e23acc8adbdbcfa1d544944cc430d12", @"/Views/Admin/GetAllUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459ca0ba387cb0b83881ee36990c0763016b8547", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>İsim</th>\r\n                <th>Soyisim</th>\r\n                <th>Eposta</th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 22 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Admin\GetAllUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591