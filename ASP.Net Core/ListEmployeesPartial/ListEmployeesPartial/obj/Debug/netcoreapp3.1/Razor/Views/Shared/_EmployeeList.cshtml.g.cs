#pragma checksum "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c254977958797388e88883d329cd7554d15ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeList), @"mvc.1.0.view", @"/Views/Shared/_EmployeeList.cshtml")]
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
#line 1 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\_ViewImports.cshtml"
using ListEmployeesPartial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\_ViewImports.cshtml"
using ListEmployeesPartial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c254977958797388e88883d329cd7554d15ad8", @"/Views/Shared/_EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ec5e1220d5ff1a18af30fc7fd1911d2565e998", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ListEmployeesPartial.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Employees</h2>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
 foreach (Employee i in Model)
{
    if (i.IsPermanent == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 9 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                             Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 10 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                             Write(i.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\"><b>");
#nullable restore
#line 11 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                                Write(i.IsPermanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 17 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                             Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 18 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                             Write(i.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 19 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"
                             Write(i.IsPermanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ListEmployeesPartial\ListEmployeesPartial\Views\Shared\_EmployeeList.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ListEmployeesPartial.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591