#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb72b79c7bc36c5521e2facfc0a88f12f0ceb91c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PosLajuParcel_Details), @"mvc.1.0.view", @"/Views/PosLajuParcel/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb72b79c7bc36c5521e2facfc0a88f12f0ceb91c", @"/Views/PosLajuParcel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PosLajuParcel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC1036.Models.PosLajuParcel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PosLaju.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb72b79c7bc36c5521e2facfc0a88f12f0ceb91c4200", async() => {
                WriteLiteral("\r\n    <title>Pos Laju Invoice</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb72b79c7bc36c5521e2facfc0a88f12f0ceb91c4501", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb72b79c7bc36c5521e2facfc0a88f12f0ceb91c6383", async() => {
                WriteLiteral("\r\n    <p>\r\n        <label>Parcel Id:</label>\r\n        ");
#nullable restore
#line 9 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ViewId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Date and Time:</label>\r\n        ");
#nullable restore
#line 13 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ViewDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <h5>Sender Information</h5>\r\n    <p>\r\n        <label>Sender name:</label>\r\n        ");
#nullable restore
#line 19 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.SenderName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Sender address:</label>\r\n        ");
#nullable restore
#line 23 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.SenderAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Sender phone:</label>\r\n        ");
#nullable restore
#line 27 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.SenderPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Sender email:</label>\r\n        ");
#nullable restore
#line 31 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.SenderEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <h5>Receiver Information</h5>\r\n    <p>\r\n        <label>Receiver name:</label>\r\n        ");
#nullable restore
#line 36 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ReceiverName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Receiver address:</label>\r\n        ");
#nullable restore
#line 40 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ReceiverAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Receiver phone:</label>\r\n        ");
#nullable restore
#line 44 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ReceiverPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Receiver email:</label>\r\n        ");
#nullable restore
#line 48 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.ReceiverEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <h5>Parcel Information</h5>\r\n    <p>\r\n        <label>Weight:</label>\r\n        ");
#nullable restore
#line 53 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.DictWeight[Model.IndexWeight]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Zone:</label>\r\n        ");
#nullable restore
#line 57 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.DictZone[Model.IndexZone]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        <label>Amount:</label>\r\n        ");
#nullable restore
#line 61 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.DisplayFor(x => x.Amount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 64 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\Details.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC1036.Models.PosLajuParcel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
