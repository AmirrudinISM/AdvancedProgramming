#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db68f4f994cbcc541cb46716e288f1a1b235f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Learn_BodyMassIndex2Result), @"mvc.1.0.view", @"/Views/Learn/BodyMassIndex2Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db68f4f994cbcc541cb46716e288f1a1b235f4b", @"/Views/Learn/BodyMassIndex2Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Learn_BodyMassIndex2Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC1036.Models.Person>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/BMI.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1db68f4f994cbcc541cb46716e288f1a1b235f4b3969", async() => {
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
            WriteLiteral("\r\n<p><label>Name:</label> ");
#nullable restore
#line 3 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>Gender:</label> ");
#nullable restore
#line 4 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                     Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>Weight:</label> ");
#nullable restore
#line 5 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                     Write(Model.Weight.ToString("n1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>Height:</label> ");
#nullable restore
#line 6 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                     Write(Model.Height.ToString("n2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>Do you smoke? </label> ");
#nullable restore
#line 7 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                            Write(Model.Smoking);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>Vaccination status:</label> ");
#nullable restore
#line 8 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                                 Write(Model.Vaccinated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>BMI:</label> ");
#nullable restore
#line 9 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                  Write(Model.Bmi.ToString("n1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><label>BMI Class:</label> ");
#nullable restore
#line 10 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Learn\BodyMassIndex2Result.cshtml"
                        Write(Model.BmiClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC1036.Models.Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
