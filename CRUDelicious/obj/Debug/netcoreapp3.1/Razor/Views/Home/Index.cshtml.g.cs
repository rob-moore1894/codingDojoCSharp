#pragma checksum "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b5810a46eb2bc2504b345a023861b0b2f48d95"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b5810a46eb2bc2504b345a023861b0b2f48d95", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4 mt-4 mb-4"">Welcome to CRUDelicious</h1>
    <div class=""row mt-4"">
        <div class=""col-8"">
            <p>Check out some recent dishes!</p><hr>
        </div>
        <div class=""col-4"">
            <a href=""new""><u>Add a Dish</u></a>
        </div>
    </div>
    <div class=""row mt-4"">
        <div class=""col-8"">
");
#nullable restore
#line 17 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
              
                foreach(Dish d in ViewBag.AllDishes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p><a");
            BeginWriteAttribute("href", " href=\"", 544, "\"", 560, 1);
#nullable restore
#line 20 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 551, d.DishId, 551, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
                                      Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> by ");
#nullable restore
#line 20 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
                                                     Write(d.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 21 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CRUDelicious\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
