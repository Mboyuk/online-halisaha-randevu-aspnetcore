#pragma checksum "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd09afed50354405edacd005957ed5df7ab8ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Halisaharezerve_GetHalisahaPage), @"mvc.1.0.view", @"/Views/Halisaharezerve/GetHalisahaPage.cshtml")]
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
#nullable restore
#line 1 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd09afed50354405edacd005957ed5df7ab8ca6", @"/Views/Halisaharezerve/GetHalisahaPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459ca0ba387cb0b83881ee36990c0763016b8547", @"/Views/_ViewImports.cshtml")]
    public class Views_Halisaharezerve_GetHalisahaPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RezervationListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/halisahaImage/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div>\r\n    <div class=\"rezervation-page-cover\">\r\n        <div class=\"rezervation-cover\">\r\n            <div class=\"rezervation-info\">\r\n                <h2>");
#nullable restore
#line 7 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
               Write(ViewBag.Url.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <span>Halı saha puanı: ");
#nullable restore
#line 8 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                  Write(ViewBag.AvgPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <p style=\"text-align:left;\">Halı saha mesajı: <span class=\"yellow\">");
#nullable restore
#line 9 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                                                              Write(ViewBag.Url.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
            </div>
            <div class=""rezervation-table-div"">
                <table class=""table table-bordered rezervation-table"">
                    <thead>
                        <tr>
                            <th scope=""col"">Saat/Tarih</th>
                            <th scope=""col"">");
#nullable restore
#line 16 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 17 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 21 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 22 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                       Write(ViewBag.Dates[6]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                          
                            var culture = new CultureInfo("de-DE");
                            DateTime date = DateTime.Now;

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                         foreach (var item in ViewBag.aa)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td >");
#nullable restore
#line 35 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                Write(item[0].time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                 foreach (var item2 in item)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                     if (item2.isEmpty)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"rezervation-table-data-full\">DOLU</td>\r\n");
#nullable restore
#line 44 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"rezervation-table-data\">\r\n                                            <a class=\"table-link\"");
            BeginWriteAttribute("href", "\r\n                                    href=\"", 2397, "\"", 2538, 11);
            WriteAttributeValue("", 2441, "/halisaha/", 2441, 10, true);
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 2451, ViewBag.Url.City, 2451, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2468, "/", 2468, 1, true);
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 2469, ViewBag.Url.Id, 2469, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2484, "/", 2484, 1, true);
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 2485, ViewBag.Url.Slug, 2485, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2502, "/", 2502, 1, true);
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 2503, item2.date, 2503, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2514, "/", 2514, 1, true);
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 2515, item2.time, 2515, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2526, "/reservation", 2526, 12, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                                                                                                                        Write(ViewBag.Url.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </td>\r\n");
#nullable restore
#line 51 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                     



                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    


                    </tbody>
                </table>
            </div>
        </div>
        <div class=""rezervation-slider-prop"">
            <div class=""rezervation-slider"" style=""margin-bottom: 20px;"">
                <div>                 
                    <div >
                        <div id=""carouselExampleCaptions"" class=""carousel slide"" data-bs-ride=""carousel"">
                            <div class=""carousel-indicators"">
");
#nullable restore
#line 76 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                 for (int i = 0; i < @ViewBag.Images.Count; i++)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\" data-bs-target=\"#carouselExampleCaptions\" data-bs-slide-to=\"");
#nullable restore
#line 79 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"\r\n                                    aria-current=\"true\" aria-label=\"Slide \"></button>\r\n");
#nullable restore
#line 81 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n                            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 89 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                 if(ViewBag.Images.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"carousel-item active \">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fd09afed50354405edacd005957ed5df7ab8ca616283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 95 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                 for (int i = 0; i < @ViewBag.Images.Count; i++)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                     if (i == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"carousel-item active \">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fd09afed50354405edacd005957ed5df7ab8ca618537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4876, "~/halisahaImage/", 4876, 16, true);
#nullable restore
#line 101 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
AddHtmlAttributeValue("", 4892, ViewBag.Images[i], 4892, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 104 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"carousel-item \">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fd09afed50354405edacd005957ed5df7ab8ca620741", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5240, "~/halisahaImage/", 5240, 16, true);
#nullable restore
#line 108 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
AddHtmlAttributeValue("", 5256, ViewBag.Images[i], 5256, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 111 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions""
                                data-bs-slide=""prev"">
                                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                <span class=""visually-hidden"">Previous</span>
                            </button>
                            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions""
                                data-bs-slide=""next"">
                                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                <span class=""visually-hidden"">Next</span>
                            </button>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""rezervation-prop"">
");
#nullable restore
#line 133 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                 foreach (var property in ViewBag.Properties)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                     if((Model.SelectedProperties.Any(i=>i==property.PropertyName)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <i style=\"color: green; font-size:20px;\" class=\"fas fa-check-square\"></i>\r\n                        ");
#nullable restore
#line 139 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 141 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                        
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <i style=\"color: red;font-size:20px;\" class=\"fas fa-window-close\"></i>  \r\n                        ");
#nullable restore
#line 146 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                   Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 148 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                        
                       
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                             
                  
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 165 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
     foreach (var item in ViewBag.Comments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comment-cover container row\">\r\n            <div class=\"comment col-9\">\r\n                ");
#nullable restore
#line 169 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
           Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"comment-info col-3\">\r\n                <div>\r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fd09afed50354405edacd005957ed5df7ab8ca627339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7917, "~/img/", 7917, 6, true);
#nullable restore
#line 174 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
AddHtmlAttributeValue("", 7923, item.ImgUrl, 7923, 12, false);

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
            WriteLiteral("\r\n                    \r\n                </div>\r\n                <div><a");
            BeginWriteAttribute("href", " href=\"", 8008, "\"", 8035, 2);
            WriteAttributeValue("", 8015, "/user/", 8015, 6, true);
#nullable restore
#line 177 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 8021, item.NickName, 8021, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 177 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                               Write(item.NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                \r\n                <div>\r\n                    ");
#nullable restore
#line 180 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
               Write(item.point);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 181 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                     for (int i = 0; i < item.point; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-star yellow\"></i>\r\n");
#nullable restore
#line 184 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 190 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
</div>
<div style="" flex-flow: column wrap;""  class=""container "">
    <div class=""row"">
        <div class=""col"">
            <nav aria-label=""Page navigation example"">
                <ul style=""justify-content: center;""  class=""pagination"">

");
#nullable restore
#line 199 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                     for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                    {
                        
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 9284, "\"", 9348, 2);
            WriteAttributeValue("", 9292, "page-item", 9292, 9, true);
#nullable restore
#line 210 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue(" ", 9301, Model.PageInfo.CurrentPage==i+1?"active":"", 9302, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9404, "\"", 9484, 8);
            WriteAttributeValue("", 9411, "/halisaha/", 9411, 10, true);
#nullable restore
#line 211 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 9421, ViewBag.Url.City, 9421, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9438, "/", 9438, 1, true);
#nullable restore
#line 211 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 9439, ViewBag.Url.Id, 9439, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9454, "/", 9454, 1, true);
#nullable restore
#line 211 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 9455, ViewBag.Url.Slug, 9455, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9472, "?page=", 9472, 6, true);
#nullable restore
#line 211 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
WriteAttributeValue("", 9478, i+1, 9478, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 212 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 215 "C:\Users\boyuk\OneDrive\Masaüstü\halisahaapp\halisahaapp.webui\Views\Halisaharezerve\GetHalisahaPage.cshtml"
                    


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezervationListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
