#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002cbf9fe94ad92bd933c7be8f23aab4837bd288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection_EmployeeListAdd), @"mvc.1.0.view", @"/Views/Collection/EmployeeListAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002cbf9fe94ad92bd933c7be8f23aab4837bd288", @"/Views/Collection/EmployeeListAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Collection_EmployeeListAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC1036.Models.Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>List of Employees</h3>

<table border=""1"" width=""100%"">
    <tr>
        <th>#</th>
        <th>Emp Id</th>
        <th>Name</th>
        <th>Gender</th>
        <th>Position</th>
        <th>Start Date</th>
        <th>Campus</th>
        <th>Salary</th>
    </tr>
");
#nullable restore
#line 16 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
      int row = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
     foreach (var employee in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.Campus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
           Write(employee.Salary.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeListAdd.cshtml"
        row++;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC1036.Models.Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
