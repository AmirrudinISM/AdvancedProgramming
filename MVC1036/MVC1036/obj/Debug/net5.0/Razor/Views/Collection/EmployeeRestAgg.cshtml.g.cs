#pragma checksum "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79415fb505e1b1a7de76b85559173f7c02edfb10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection_EmployeeRestAgg), @"mvc.1.0.view", @"/Views/Collection/EmployeeRestAgg.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79415fb505e1b1a7de76b85559173f7c02edfb10", @"/Views/Collection/EmployeeRestAgg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7297e87b78009d64c1ecd96917b4bbbfa7114a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Collection_EmployeeRestAgg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC1036.Models.Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>List of Employees</h3>\r\n\r\n<p>Total employees: ");
#nullable restore
#line 5 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
               Write(ViewBag.CountAll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Total female employees: ");
#nullable restore
#line 6 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
                      Write(ViewBag.CountFemale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Total male employees: ");
#nullable restore
#line 7 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
                    Write(ViewBag.CountMale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Average salary: ");
#nullable restore
#line 8 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
              Write(ViewBag.AverageSalary.ToString("c2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Average salary male: ");
#nullable restore
#line 9 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
                   Write(ViewBag.AverageSalaryMale.ToString("c2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Average salary female: ");
#nullable restore
#line 10 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
                     Write(ViewBag.AverageSalaryFemale.ToString("c2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>


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
#line 24 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
      int row = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
     foreach (var employee in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.Campus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
           Write(employee.Salary.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Amirr\Documents\Projects\AdvancedProgramming\MVC1036\MVC1036\Views\Collection\EmployeeRestAgg.cshtml"
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
