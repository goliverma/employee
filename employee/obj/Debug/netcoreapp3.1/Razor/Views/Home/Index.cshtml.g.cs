#pragma checksum "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ede50039e8f9de1cdaa039b81e3e01d5d728cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/goli/Desktop/code/employee/employee/employee/Views/_ViewImports.cshtml"
using employee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/goli/Desktop/code/employee/employee/employee/Views/_ViewImports.cshtml"
using employee.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/goli/Desktop/code/employee/employee/employee/Views/_ViewImports.cshtml"
using employee.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/goli/Desktop/code/employee/employee/employee/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ede50039e8f9de1cdaa039b81e3e01d5d728cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833b27e26bcf02066cc2bbd038525c8561500c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-deck\">\n");
#nullable restore
#line 7 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Index.cshtml"
     foreach (Employee item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Index.cshtml"
   Write(await Html.PartialAsync("EmployeeList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Index.cshtml"
                                                      ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script src=\"/js/CustomScript.js\"></script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
