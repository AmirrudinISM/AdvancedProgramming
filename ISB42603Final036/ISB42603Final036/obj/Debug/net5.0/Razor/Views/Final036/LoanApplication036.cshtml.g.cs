#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5918a3636dbff15ff44293d7eb73c42f1056e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Final036_LoanApplication036), @"mvc.1.0.view", @"/Views/Final036/LoanApplication036.cshtml")]
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
#line 1 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\_ViewImports.cshtml"
using ISB42603Final036;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\_ViewImports.cshtml"
using ISB42603Final036.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5918a3636dbff15ff44293d7eb73c42f1056e10", @"/Views/Final036/LoanApplication036.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfca43116d0a877b7254f9d64818ee67435f630", @"/Views/_ViewImports.cshtml")]
    public class Views_Final036_LoanApplication036 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISB42603Final036.Models.HousingLoan>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5918a3636dbff15ff44293d7eb73c42f1056e103436", async() => {
                WriteLiteral("\r\n    <title>Loan Application Form</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5918a3636dbff15ff44293d7eb73c42f1056e104446", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
     using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>Loan Application Form</h5>\r\n");
                WriteLiteral("        <p>\r\n            <label>");
#nullable restore
#line 11 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.CustomerID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 12 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.CustomerID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.CustomerID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 16 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 17 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 21 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 22 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.Gender, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 26 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.CreditStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 27 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.CreditStatus, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.CreditStatus, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 31 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.Principal));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 32 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.Principal, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.Principal, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 36 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
              Write(Html.DisplayNameFor(x => x.NumberOfYears));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            ");
#nullable restore
#line 37 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.TextBoxFor(x => x.NumberOfYears, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"
       Write(Html.ValidationMessageFor(x => x.NumberOfYears, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <br />\r\n        <p>\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\" />\r\n        </p>\r\n");
#nullable restore
#line 44 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\ISB42603Final036\ISB42603Final036\Views\Final036\LoanApplication036.cshtml"



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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISB42603Final036.Models.HousingLoan> Html { get; private set; }
    }
}
#pragma warning restore 1591
