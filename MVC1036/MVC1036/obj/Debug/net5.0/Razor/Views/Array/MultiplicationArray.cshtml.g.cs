#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d01e70754aa5232c91a136eab8713213bbabbe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Array_MultiplicationArray), @"mvc.1.0.view", @"/Views/Array/MultiplicationArray.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d01e70754aa5232c91a136eab8713213bbabbe1", @"/Views/Array/MultiplicationArray.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Array_MultiplicationArray : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Multiplication Table</p>\r\n\r\n<table width=\"100%\" border=\"1\">\r\n    <tr align=\"center\" style=\"font-weight: bold\">\r\n        <td>X</td>\r\n");
#nullable restore
#line 6 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
         for (int i = 1; i <= 12; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 7 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 8 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
     for (int i = 1; i <= 12; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr align=\"center\">\r\n            <td style=\"font-weight: bold\">");
#nullable restore
#line 13 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 14 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
             for (int j = 1; j <= 12; j++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 15 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
               Write(ViewBag.Multiplications[i, j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 16 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Array\MultiplicationArray.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
