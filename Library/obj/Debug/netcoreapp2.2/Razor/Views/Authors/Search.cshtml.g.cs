#pragma checksum "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da762409abe848d828a5d7e9ee8304e4d07f225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Search), @"mvc.1.0.view", @"/Views/Authors/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Search.cshtml", typeof(AspNetCore.Views_Authors_Search))]
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
#line 4 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da762409abe848d828a5d7e9ee8304e4d07f225", @"/Views/Authors/Search.cshtml")]
    public class Views_Authors_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(86, 18, true);
            WriteLiteral("\n<h1>SEARCH</h1>\n\n");
            EndContext();
#line 9 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
            BeginContext(128, 40, true);
            WriteLiteral("  <p> No authors match this search </p>\n");
            EndContext();
#line 12 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(177, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 16 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
     foreach(Author author in Model)
    {

#line default
#line hidden
            BeginContext(227, 11, true);
            WriteLiteral("      <li> ");
            EndContext();
            BeginContext(239, 78, false);
#line 18 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
      Write(Html.ActionLink($"{author.AuthorName}", "Details", new {id = author.AuthorId}));

#line default
#line hidden
            EndContext();
            BeginContext(317, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(321, 17, false);
#line 18 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
                                                                                        Write(author.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(338, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 19 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
    }

#line default
#line hidden
            BeginContext(350, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 21 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
}

#line default
#line hidden
            BeginContext(360, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(364, 43, false);
#line 22 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
Write(Html.ActionLink("Back to authors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(407, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(416, 43, false);
#line 23 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
Write(Html.ActionLink("Add new Author", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(468, 40, false);
#line 24 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Authors/Search.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(508, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
