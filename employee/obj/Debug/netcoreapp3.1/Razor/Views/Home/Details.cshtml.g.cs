#pragma checksum "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8312a4ab1869ac3aabc4335a4d7eae32c0c71765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8312a4ab1869ac3aabc4335a4d7eae32c0c71765", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a950edb8f6e49afcb1b9bde284c7daaeb547a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top imagethumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
  
    ViewData["Title"] = "Details";
    var photopath = "~/Images/"+@Model.Employee.PhotoPath;

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    <h1 class=\"m-4\">\n        ");
#nullable restore
#line 8 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h1>\n</center>\n\n<div>\n    <div class=\"row justify-content-center m-3\">\n        <div class=\"col-sm-8\">\n            <div class=\"card\">\n                <div class=\"card-header\">\n                    <h3>");
#nullable restore
#line 17 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
                   Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                </div>\n                <div class=\"card-body text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8312a4ab1869ac3aabc4335a4d7eae32c0c717655706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
                                                      WriteLiteral(photopath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h4>Employee Id: ");
#nullable restore
#line 21 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
                                Write(Model.Employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <h4>Employee Name: ");
#nullable restore
#line 22 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
                                  Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <h4>Employee Department: ");
#nullable restore
#line 23 "/home/goli/Desktop/code/employee/employee/employee/Views/Home/Details.cshtml"
                                        Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                </div>\n                <div class=\"card-footer text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8312a4ab1869ac3aabc4335a4d7eae32c0c717658786", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1001, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n                </div>\n                </div>\n            </div>\n        </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
