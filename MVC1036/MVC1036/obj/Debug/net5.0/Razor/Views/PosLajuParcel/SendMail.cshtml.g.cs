#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\SendMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e271fec6464d964cc2424cd9d4187061268a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PosLajuParcel_SendMail), @"mvc.1.0.view", @"/Views/PosLajuParcel/SendMail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e271fec6464d964cc2424cd9d4187061268a7c", @"/Views/PosLajuParcel/SendMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    public class Views_PosLajuParcel_SendMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC1036.Models.PosLajuParcel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>");
#nullable restore
#line 3 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\SendMail.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 4 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\SendMail.cshtml"
Write(Html.Raw(ViewBag.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\PosLajuParcel\SendMail.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC1036.Models.PosLajuParcel> Html { get; private set; }
    }
}
#pragma warning restore 1591
