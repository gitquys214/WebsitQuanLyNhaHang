#pragma checksum "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f633a0acefa1aab58caf63fb181b6d2d9a60d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang__DonHangChiTiet), @"mvc.1.0.view", @"/Views/DonHang/_DonHangChiTiet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f633a0acefa1aab58caf63fb181b6d2d9a60d3c", @"/Views/DonHang/_DonHangChiTiet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814d8766e4fd3c8d43a1b7cd4ed5822b0bd44d38", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang__DonHangChiTiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASMC5.Models.DonHangChiTiet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
  
    var ls = ViewBag.dhct;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.VAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.ThanhTienChuaThue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.ThanhTienCoThue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Tên món\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
 foreach (var item in ls) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f633a0acefa1aab58caf63fb181b6d2d9a60d3c6668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 970, "~/Images/", 970, 9, true);
#nullable restore
#line 39 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
AddHtmlAttributeValue("", 979, item.MonAn.Image, 979, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.VAT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.ThanhTienChuaThue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.ThanhTienCoThue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.GhiChu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
           Write(item.MonAn.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\HP\OneDrive\Máy tính\ASMFinal\ASMC5\ASMC5\Views\DonHang\_DonHangChiTiet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASMC5.Models.DonHangChiTiet>> Html { get; private set; }
    }
}
#pragma warning restore 1591