#pragma checksum "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bec045d4aa882483a99c83958df35f06edac1a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bec045d4aa882483a99c83958df35f06edac1a3", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/\"><u>Home</u></a>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4 mt-4 mb-4\">");
#nullable restore
#line 7 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2 class=\"display-4 mt-4 mb-4\">");
#nullable restore
#line 8 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
                               Write(Model.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <hr>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<p><strong>Calories: </strong>");
#nullable restore
#line 13 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
                         Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br>\r\n<p><strong>Tastiness: </strong>");
#nullable restore
#line 15 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
                          Write(Model.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"row justify-content-around\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 433, "\"", 461, 2);
            WriteAttributeValue("", 440, "/delete/", 440, 8, true);
#nullable restore
#line 18 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
WriteAttributeValue("", 448, Model.DishId, 448, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 504, "\"", 530, 2);
            WriteAttributeValue("", 511, "/edit/", 511, 6, true);
#nullable restore
#line 19 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Show.cshtml"
WriteAttributeValue("", 517, Model.DishId, 517, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Edit</a>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
