#pragma checksum "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f9ad779218725b4fa999d1626b6c8b8ecc57bb7f8c657f1bb4fed5636febb69a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticlesFromFeed), @"mvc.1.0.view", @"/Views/Home/ArticlesFromFeed.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f9ad779218725b4fa999d1626b6c8b8ecc57bb7f8c657f1bb4fed5636febb69a", @"/Views/Home/ArticlesFromFeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ArticlesFromFeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArticlesFromFeed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/flatpickr/dist/flatpickr.min.css"">
<script src=""https://cdn.jsdelivr.net/npm/flatpickr""></script>
<!-- Bootstrap CSS -->
<link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"">
<!-- Datepicker CSS -->
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker3.min.css"" rel=""stylesheet"">
<!-- jQuery -->
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<!-- Bootstrap JS -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
<!-- Datepicker JS -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ad779218725b4fa999d1626b6c8b8ecc57bb7f8c657f1bb4fed5636febb69a4891", async() => {
                WriteLiteral("\r\n\r\n    <!-- Datepicker pour startDate -->\r\n    <div class=\"input-group date\" data-provide=\"datepicker\">\r\n        <input type=\"text\" name=\"startDate\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1054, "\"", 1100, 1);
#nullable restore
#line 20 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 1062, ViewBag.start?.ToString("yyyy-MM-dd"), 1062, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-addon"">
            <span class=""glyphicon glyphicon-th""></span>
        </div>
    </div>

    <!-- Datepicker pour endDate -->
    <div class=""input-group date"" data-provide=""datepicker"">
        <input type=""text"" name=""endDate"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1395, "\"", 1439, 1);
#nullable restore
#line 28 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 1403, ViewBag.end?.ToString("yyyy-MM-dd"), 1403, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""input-group-addon"">
            <span class=""glyphicon glyphicon-th""></span>
        </div>
    </div>
    <div class=""content-container-fluid"">

        <div class=""row"">

            <div class=""cols-sample-area"">

                <div class=""frame"">

                    <div class=""control"">

                        <ej:DateTimePicker ID=""DateTimePicker1"" runat=""server""");
                BeginWriteAttribute("Value", " Value=\"", 1852, "\"", 1896, 1);
#nullable restore
#line 43 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 1860, ViewBag.end?.ToString("yyyy-MM-dd"), 1860, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" Width=""180px"">

                        </ej:DateTimePicker>

                    </div>

                </div>

            </div>

        </div>

    </div>

    <!-- Champ caché pour passer le feedId -->
    <input type=""hidden"" name=""feedId""");
                BeginWriteAttribute("value", " value=\"", 2160, "\"", 2183, 1);
#nullable restore
#line 58 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 2168, ViewBag.FeedId, 2168, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <!-- Bouton pour soumettre le formulaire -->\r\n    <input type=\"submit\" value=\"Filter\" class=\"btn btn-primary\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
AddHtmlAttributeValue("", 829, Url.Action("ArticlesFromFeed", "Home"), 829, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ad779218725b4fa999d1626b6c8b8ecc57bb7f8c657f1bb4fed5636febb69a9841", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"feedId\"");
                BeginWriteAttribute("value", " value=\"", 2418, "\"", 2441, 1);
#nullable restore
#line 69 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 2426, ViewBag.FeedId, 2426, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Reload</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 74 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Aucun article disponible.</p>\r\n");
#nullable restore
#line 77 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 81 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
         foreach (var article in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 mb-4\">\r\n                <div class=\"card\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2797, "\"", 2824, 1);
#nullable restore
#line 85 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 2803, article.ThumbnailUrl, 2803, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2825, "\"", 2856, 3);
            WriteAttributeValue("", 2831, "Image", 2831, 5, true);
            WriteAttributeValue(" ", 2836, "pour", 2837, 5, true);
#nullable restore
#line 85 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue(" ", 2841, article.Title, 2842, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 2954, "\"", 2974, 1);
#nullable restore
#line 87 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
WriteAttributeValue("", 2961, article.Link, 2961, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
                                                                  Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 88 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
                                        Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <small>Publié le: ");
#nullable restore
#line 89 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
                                     Write(article.PublicationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <br />\r\n                        <small>Auteur: ");
#nullable restore
#line 91 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
                                  Write(article.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 95 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 97 "C:\Users\SAIF\source\repos\WebApplication1\WebApplication1\Views\Home\ArticlesFromFeed.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
