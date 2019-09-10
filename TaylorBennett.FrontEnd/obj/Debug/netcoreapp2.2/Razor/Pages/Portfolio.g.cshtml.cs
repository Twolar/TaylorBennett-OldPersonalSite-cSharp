#pragma checksum "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7dce661b343ca5df54fe659435f119af438dbf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaylorBennett.FrontEnd.Pages.Pages_Portfolio), @"mvc.1.0.razor-page", @"/Pages/Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Portfolio.cshtml", typeof(TaylorBennett.FrontEnd.Pages.Pages_Portfolio), null)]
namespace TaylorBennett.FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\_ViewImports.cshtml"
using TaylorBennett.FrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7dce661b343ca5df54fe659435f119af438dbf1", @"/Pages/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5b74e033812da4e88ceabd1cfdce2e845ce217", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Portfolio : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
            BeginContext(75, 400, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Portfolio</h1>
    <p>Below is a list of all my projects. 
    <br />They are in order from top to bottom, based on when they were last updated.
    <br />(this page pulls all public repositories from my <a href=""https://github.com/twolar"" target=""_blank"">Github</a> via Github's API)</p>
</div>

<div class=""row justify-content-center"">
");
            EndContext();
#line 15 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
     foreach (var repo in Model.GitHubRepos.Reverse())
    {

#line default
#line hidden
            BeginContext(538, 207, true);
            WriteLiteral("        <div class= \"p-3 text-center\">\r\n            <div class=\"card shadow session h-100\">\r\n                <div class=\"card-header\">\r\n                    <h5 class=\"card-title\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 745, "\"", 766, 1);
#line 21 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
WriteAttributeValue("", 752, repo.html_url, 752, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(767, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(785, 9, false);
#line 21 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
                                                            Write(repo.name);

#line default
#line hidden
            EndContext();
            BeginContext(794, 251, true);
            WriteLiteral("</a>\r\n                    </h5>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <ul class=\"list-inline mb-0\">\r\n                        <li class=\"list-inline-item\">\r\n                            <a>Last Updated: ");
            EndContext();
            BeginContext(1046, 44, false);
#line 27 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
                                        Write(repo.updated_at.ToString("dd MMM yyyy H:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 132, true);
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li class=\"list-inline-item\">\r\n                            <a>Created: ");
            EndContext();
            BeginContext(1223, 38, false);
#line 30 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
                                   Write(repo.created_at.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 90, true);
            WriteLiteral("</a>\r\n                        </li>\r\n\r\n                    </ul>\r\n</div>\r\n</div>\r\n</div>\r\n");
            EndContext();
#line 37 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
}

#line default
#line hidden
            BeginContext(1354, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel>)PageContext?.ViewData;
        public PortfolioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
