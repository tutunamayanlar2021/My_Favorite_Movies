#pragma checksum "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de10df4ad35c5b2c1f5ce808fab390dad6b784c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de10df4ad35c5b2c1f5ce808fab390dad6b784c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd26d39bc1a2a8c0ce23398f52764c0579a75f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de10df4ad35c5b2c1f5ce808fab390dad6b784c3418", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 5 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link href=""/css/Style.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de10df4ad35c5b2c1f5ce808fab390dad6b784c4971", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
Write(RenderSection("header", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n \r\n    \r\n    <div class=\"container mt-3 \">\r\n");
#nullable restore
#line 15 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
         if (IsSectionDefined("list"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\" row\">\r\n                <div class=\" col-md-3\">");
#nullable restore
#line 18 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
                                  Write(RenderSection("list", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <div class=\" col-md-9\"> ");
#nullable restore
#line 19 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
                                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n    ");
#nullable restore
#line 37 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591