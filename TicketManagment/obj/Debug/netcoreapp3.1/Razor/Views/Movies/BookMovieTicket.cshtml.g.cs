#pragma checksum "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8943f16dbe0432a59d6be18cb1660f9cb6807f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_BookMovieTicket), @"mvc.1.0.view", @"/Views/Movies/BookMovieTicket.cshtml")]
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
#line 1 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\_ViewImports.cshtml"
using TicketManagment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\_ViewImports.cshtml"
using TicketManagment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8943f16dbe0432a59d6be18cb1660f9cb6807f61", @"/Views/Movies/BookMovieTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5701e8cdf9988283ad4dcb2767df26f74711659", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_BookMovieTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Domain.Models.Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/TicketManagment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8943f16dbe0432a59d6be18cb1660f9cb6807f615190", async() => {
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
            WriteLiteral("\r\n\r\n<h1 class=\"pb-4 mb-2\">");
#nullable restore
#line 10 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
                 Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container\"> \r\n    <div class=\"row\">\r\n        <div class=\"col-8 embed-responsive embed-responsive-16by9 px-5\">\r\n            <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 471, "\"", 499, 1);
#nullable restore
#line 14 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
WriteAttributeValue("", 477, Model.MovieTrailerUrl, 477, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""560""  height=""315"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        </div>
    </div>
    <div class=""row py-5"">
        
      
            <img class=""w-25""");
            BeginWriteAttribute("src", " src=\"", 799, "\"", 825, 1);
#nullable restore
#line 20 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
WriteAttributeValue("", 805, Model.movieImageUrl, 805, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n       \r\n        <div class=\"col-md-4\">\r\n            <p>");
#nullable restore
#line 23 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
          Write(Model.MovieDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Genre: </strong>");
#nullable restore
#line 24 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
                                  Write(Model.MovieGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Rating:</strong> ");
#nullable restore
#line 25 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
                                   Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>


<table class=""table py-2"" id=""TicketsTable"">
    <thead>
        <tr>
            <th>
                Time: 
            </th>
            <th>
                Price:
            </th>
             <th>
                
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 46 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
 foreach (var ticket in @Model.Tickets) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <strong>");
#nullable restore
#line 49 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
                   Write(Html.DisplayFor(modelItem => ticket.dateTime.DayOfWeek));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong> <br>\r\n                <p>");
#nullable restore
#line 50 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
              Write(ticket.dateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
#nullable restore
#line 51 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
           Write(Html.DisplayFor(modelItem => ticket.dateTime.Hour));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>:</span>");
#nullable restore
#line 51 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => ticket.dateTime.Minute));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
           Write(Html.DisplayFor(modelItem => ticket.TicketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"text-secondary\">Ден.</span>\r\n            </td>\r\n            <td>\r\n                    <a class=\"text-decoration-none text-white btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1997, "\"", 2042, 2);
            WriteAttributeValue("", 2004, "/Tickets/AddToCart?ticketId=", 2004, 28, true);
#nullable restore
#line 57 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
WriteAttributeValue("", 2032, ticket.Id, 2032, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Book</a>\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\nisiz\OneDrive\Desktop\ISTicketManagmentSystem\TicketManagment\TicketManagment\Views\Movies\BookMovieTicket.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943f16dbe0432a59d6be18cb1660f9cb6807f6112501", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943f16dbe0432a59d6be18cb1660f9cb6807f6113601", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943f16dbe0432a59d6be18cb1660f9cb6807f6114701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Domain.Models.Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
