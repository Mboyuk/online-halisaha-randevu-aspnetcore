#pragma checksum "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\User\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e2394b35a9fc46ce6d907984ee68fea204c540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserProfile), @"mvc.1.0.view", @"/Views/User/UserProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e2394b35a9fc46ce6d907984ee68fea204c540", @"/Views/User/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459ca0ba387cb0b83881ee36990c0763016b8547", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div style=\" height:100px; background-color: #1C1D1F\"");
            BeginWriteAttribute("class", " class=\"", 68, "\"", 76, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"row mt-3\">.</div>\r\n    <div class=\"container\">\r\n          <h2 style=\"color: white;\">");
#nullable restore
#line 6 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\User\UserProfile.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 6 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\User\UserProfile.cshtml"
                                                 Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n  \r\n</div>\r\n\r\n<div class=\"container mt-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <span>Email: </span>\r\n            <h4>");
#nullable restore
#line 15 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\User\UserProfile.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11e2394b35a9fc46ce6d907984ee68fea204c5405416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 503, "~/img/", 503, 6, true);
#nullable restore
#line 18 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\User\UserProfile.cshtml"
AddHtmlAttributeValue("", 509, Model.ImgUrl, 509, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
