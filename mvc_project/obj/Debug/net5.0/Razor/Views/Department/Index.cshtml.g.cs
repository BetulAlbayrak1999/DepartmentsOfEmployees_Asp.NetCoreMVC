#pragma checksum "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1aa8c24f23b662bd5ae2fe5e7f893df874facf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\_ViewImports.cshtml"
using mvc_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
using mvc_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1aa8c24f23b662bd5ae2fe5e7f893df874facf", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291e31b91ce9ef81dab6f2331e836eaf1ff193a", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>DepartmentName</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
           Write(x.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
           Write(x.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 485, "\"", 536, 2);
            WriteAttributeValue("", 492, "/Department/DeleteDepartment/", 492, 29, true);
#nullable restore
#line 22 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
WriteAttributeValue("", 521, x.DepartmentId, 521, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 644, 2);
            WriteAttributeValue("", 603, "/Department/GetDepartment/", 603, 26, true);
#nullable restore
#line 23 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
WriteAttributeValue("", 629, x.DepartmentId, 629, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 705, "\"", 756, 2);
            WriteAttributeValue("", 712, "/Department/DepartmentDetail/", 712, 29, true);
#nullable restore
#line 24 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
WriteAttributeValue("", 741, x.DepartmentId, 741, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\" style=\"background-color:#ffd800\">Details</a></th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Department\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Department/newDepartment/\" class=\"btn btn-primary\">new Department</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
