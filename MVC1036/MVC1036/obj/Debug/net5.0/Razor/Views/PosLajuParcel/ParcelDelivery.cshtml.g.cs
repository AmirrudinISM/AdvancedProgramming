#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f127480a2466030bb96f8b79545cc3dedcd6be0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PosLajuParcel_ParcelDelivery), @"mvc.1.0.view", @"/Views/PosLajuParcel/ParcelDelivery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f127480a2466030bb96f8b79545cc3dedcd6be0f", @"/Views/PosLajuParcel/ParcelDelivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PosLajuParcel_ParcelDelivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC1036.Models.PosLajuParcel>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f127480a2466030bb96f8b79545cc3dedcd6be0f3408", async() => {
                WriteLiteral("\r\n    <title>Pos Laju Form</title>\r\n    \r\n");
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
            WriteLiteral(" \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f127480a2466030bb96f8b79545cc3dedcd6be0f4423", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
     using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>Sender Information</h5>\r\n        <div class=\"row\">\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 13 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.SenderName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 14 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.SenderName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.SenderName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p class=\"col-md-6\">\r\n                <label>");
#nullable restore
#line 18 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.SenderAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 19 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.SenderAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.SenderAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"row\">\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 25 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.SenderPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 26 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.SenderPhone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.SenderPhone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 30 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.SenderEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 31 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.SenderEmail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n");
                WriteLiteral("        <h5>Receiver Information</h5>\r\n        <div class=\"row\">\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 38 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.ReceiverName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 39 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.ReceiverName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 40 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.ReceiverName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p class=\"col-md-6\">\r\n                <label>");
#nullable restore
#line 43 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.ReceiverAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 44 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.ReceiverAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.ReceiverAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"row\">\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 50 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.ReceiverPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 51 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.ReceiverPhone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 52 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.ReceiverPhone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 55 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.ReceiverEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 56 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.TextBoxFor(x => x.ReceiverEmail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n");
                WriteLiteral("        <h5>Parcel Information</h5>\r\n        <div class=\"row\">\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 63 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.IndexWeight));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 64 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.DropDownListFor(x => x.IndexWeight, new SelectList(Model.DictWeight, "Key", "Value"), "Select weight:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 65 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.IndexWeight, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p class=\"col-md-4\">\r\n                <label>");
#nullable restore
#line 68 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
                  Write(Html.DisplayNameFor(x => x.IndexZone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                ");
#nullable restore
#line 69 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.DropDownListFor(x => x.IndexZone, new SelectList(Model.DictZone, "Key", "Value"), "Select zone:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 70 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"
           Write(Html.ValidationMessageFor(x => x.IndexZone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <br />\r\n        <p>\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\" />\r\n        </p>\r\n");
#nullable restore
#line 77 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\ParcelDelivery.cshtml"

    }

#line default
#line hidden
#nullable disable
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
