#pragma checksum "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\Home\_Drinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e781c7f73406e7c469ca09aa93d5df60df003ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Drinks), @"mvc.1.0.view", @"/Views/Home/_Drinks.cshtml")]
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
#line 1 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\_ViewImports.cshtml"
using PartialsSessionsLecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\_ViewImports.cshtml"
using PartialsSessionsLecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e781c7f73406e7c469ca09aa93d5df60df003ee", @"/Views/Home/_Drinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b2b1b3637664553be740195341b7031202e498", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Drinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Drink>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>IsHot</th>\r\n    </tr>\r\n");
#nullable restore
#line 8 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\Home\_Drinks.cshtml"
      
        foreach(Drink d in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 12 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\Home\_Drinks.cshtml"
               Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 13 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\Home\_Drinks.cshtml"
               Write(d.IsHot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\PartialsSessionsLecture\Views\Home\_Drinks.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Drink>> Html { get; private set; }
    }
}
#pragma warning restore 1591