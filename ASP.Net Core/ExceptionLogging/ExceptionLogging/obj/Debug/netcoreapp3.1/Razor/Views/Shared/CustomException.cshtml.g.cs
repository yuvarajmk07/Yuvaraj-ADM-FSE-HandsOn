#pragma checksum "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\Shared\CustomException.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc34d97156c186234da8e499add413b47f02afb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomException), @"mvc.1.0.view", @"/Views/Shared/CustomException.cshtml")]
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
#line 1 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\_ViewImports.cshtml"
using ExceptionLogging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\_ViewImports.cshtml"
using ExceptionLogging.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc34d97156c186234da8e499add413b47f02afb0", @"/Views/Shared/CustomException.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5781dc8efa6c988539e8e5374c256ab22e0c774", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomException : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Custom Error</h1>\r\n");
#nullable restore
#line 2 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\Shared\CustomException.cshtml"
  
    Exception ex = ViewData["HandleException"] as Exception;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\Shared\CustomException.cshtml"
Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>");
#nullable restore
#line 6 "C:\Users\Uvi\Documents\VStudio 2019\ASP.Net Core\ExceptionLogging\ExceptionLogging\Views\Shared\CustomException.cshtml"
Write(ex.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
