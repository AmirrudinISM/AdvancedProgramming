#pragma checksum "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9e2a23765b10d3a32ca9fadb2a9a8b304ce99c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Learn_BodyMassIndex1Result), @"mvc.1.0.view", @"/Views/Learn/BodyMassIndex1Result.cshtml")]
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
#line 1 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\_ViewImports.cshtml"
using MVC1036;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\_ViewImports.cshtml"
using MVC1036.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9e2a23765b10d3a32ca9fadb2a9a8b304ce99c", @"/Views/Learn/BodyMassIndex1Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    public class Views_Learn_BodyMassIndex1Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Name: ");
#nullable restore
#line 1 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml"
    Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Weight: ");
#nullable restore
#line 2 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml"
      Write(ViewBag.Weight.ToString("n1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Height: ");
#nullable restore
#line 3 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml"
      Write(ViewBag.Height.ToString("n2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>BMI: ");
#nullable restore
#line 4 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml"
   Write(ViewBag.Bmi.ToString("n1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>BMI Class: ");
#nullable restore
#line 5 "C:\Users\Amirrudin\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\MVC1036\Views\Learn\BodyMassIndex1Result.cshtml"
         Write(ViewBag.BmiClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
