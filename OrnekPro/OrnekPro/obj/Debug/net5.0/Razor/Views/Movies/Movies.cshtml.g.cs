#pragma checksum "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e82fc2aae6168d802e0145693a005b559977362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Movies), @"mvc.1.0.view", @"/Views/Movies/Movies.cshtml")]
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
#line 1 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e82fc2aae6168d802e0145693a005b559977362", @"/Views/Movies/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a17d2f07903c34cdfb2eee3f916ffd4c19ce14", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 4 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
Write(localizer["Film Listesi"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n\r\n<div id=\"Filmler\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
     if (Model.Movie.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
         foreach (var movie in Model.Movie)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
       Write(await Html.PartialAsync("_movie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
                                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
         

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"  alet alert-danger\">");
#nullable restore
#line 20 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
                                    Write(localizer["Film Bulunamadı"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 21 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("list", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("        ");
#nullable restore
#line 26 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Movies\Movies.cshtml"
   Write(await Component.InvokeAsync("Turler"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
