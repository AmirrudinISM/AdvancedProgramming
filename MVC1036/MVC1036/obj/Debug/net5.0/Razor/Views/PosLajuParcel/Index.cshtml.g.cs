#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38235a0000f2015bc6b19d8e68c56f867f1a0800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PosLajuParcel_Index), @"mvc.1.0.view", @"/Views/PosLajuParcel/Index.cshtml")]
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
#line 1 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\_ViewImports.cshtml"
using MVC1036;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\_ViewImports.cshtml"
using MVC1036.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38235a0000f2015bc6b19d8e68c56f867f1a0800", @"/Views/PosLajuParcel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PosLajuParcel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC1036.Models.PosLajuParcel>>
    #nullable disable
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
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38235a0000f2015bc6b19d8e68c56f867f1a08003390", async() => {
                WriteLiteral("\r\n        <title>Parcel List</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38235a0000f2015bc6b19d8e68c56f867f1a08004402", async() => {
                WriteLiteral("\r\n        <h5>Parcel List</h5>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
      Write(Html.ActionLink("Create", "ParcelDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        \r\n");
#nullable restore
#line 11 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
         using (Html.BeginForm("SearchIndex", "PosLajuParcel", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>\r\n                <label>Search by parcel id or sender name:</label>\r\n                ");
#nullable restore
#line 14 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
           Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Search\" />\r\n                ");
#nullable restore
#line 16 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
           Write(Html.ActionLink("Back to Full List", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n");
#nullable restore
#line 18 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
            } 

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>");
#nullable restore
#line 22 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.ViewId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.ViewDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 24 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.SenderName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 25 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.SenderPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 26 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.ReceiverName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 27 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.ReceiverAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 28 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.ReceiverPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 29 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.DictWeight));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 30 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 31 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
               Write(Html.DisplayNameFor(x => x));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
             foreach (var x in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.ViewId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.ViewDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.SenderName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.SenderPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.ReceiverName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.ReceiverAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.ReceiverPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.DictWeight[x.IndexWeight]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.DisplayFor(y => x.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = x.ViewId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 47 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = x.ViewId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 48 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = x.ViewId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 49 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
                   Write(Html.ActionLink("Mail", "SendMail", new { id = x.ViewId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC1036.Models.PosLajuParcel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
