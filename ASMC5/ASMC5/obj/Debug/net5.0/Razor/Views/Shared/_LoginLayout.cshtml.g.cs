#pragma checksum "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\Shared\_LoginLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e626312577634065d9d278466310488742ce1450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginLayout), @"mvc.1.0.view", @"/Views/Shared/_LoginLayout.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\_ViewImports.cshtml"
using ASMC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\_ViewImports.cshtml"
using ASMC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e626312577634065d9d278466310488742ce1450", @"/Views/Shared/_LoginLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814d8766e4fd3c8d43a1b7cd4ed5822b0bd44d38", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e626312577634065d9d278466310488742ce14503276", async() => {
                WriteLiteral("\r\n    <title>Login ~ VIX FOOD</title>\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>");
#nullable restore
#line 9 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\Shared\_LoginLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("-Login</title>\r\n    <!-- Bootstrap CSS -->\r\n    ");
#nullable restore
#line 11 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\Shared\_LoginLayout.cshtml"
Write(RenderSection("css", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e626312577634065d9d278466310488742ce14505209", async() => {
                WriteLiteral("\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 584, "\"", 751, 18);
                WriteAttributeValue("", 592, "container>", 592, 10, true);
#nullable restore
#line 15 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\Shared\_LoginLayout.cshtml"
WriteAttributeValue("\r\n        ", 602, RenderBody(), 612, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("\r\n    ", 625, "</div>", 631, 12, true);
                WriteAttributeValue("\r\n    ", 637, "<!--", 643, 10, true);
                WriteAttributeValue(" ", 647, "Optional", 648, 9, true);
                WriteAttributeValue(" ", 656, "JavaScript", 657, 11, true);
                WriteAttributeValue(" ", 667, "-->", 668, 4, true);
                WriteAttributeValue("\r\n    ", 671, "<!--", 677, 10, true);
                WriteAttributeValue(" ", 681, "jQuery", 682, 7, true);
                WriteAttributeValue(" ", 688, "first,", 689, 7, true);
                WriteAttributeValue(" ", 695, "then", 696, 5, true);
                WriteAttributeValue(" ", 700, "Popper.js,", 701, 11, true);
                WriteAttributeValue(" ", 711, "then", 712, 5, true);
                WriteAttributeValue(" ", 716, "Bootstrap", 717, 10, true);
                WriteAttributeValue(" ", 726, "JS", 727, 3, true);
                WriteAttributeValue(" ", 729, "-->", 730, 4, true);
                WriteAttributeValue("\r\n    ", 733, "<script", 739, 13, true);
                WriteAttributeValue(" ", 746, "src=", 747, 5, true);
                EndWriteAttribute();
                WriteLiteral(@"https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
    ");
#nullable restore
#line 23 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\Shared\_LoginLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
