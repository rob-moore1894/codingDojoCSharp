#pragma checksum "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879e13b8abd533c11e0afacb495aa076996dd639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneInterest), @"mvc.1.0.view", @"/Views/Home/OneInterest.cshtml")]
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
#line 1 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\_ViewImports.cshtml"
using CSExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\_ViewImports.cshtml"
using CSExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879e13b8abd533c11e0afacb495aa076996dd639", @"/Views/Home/OneInterest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f3be8551f88d7b82537e0073706a0651e15726", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneInterest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/join"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row justify-content-around\">\r\n    <h1>");
#nullable restore
#line 3 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
   Write(ViewBag.OneInterest.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879e13b8abd533c11e0afacb495aa076996dd6394170", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 168, "\"", 189, 1);
#nullable restore
#line 5 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
WriteAttributeValue("", 176, ViewBag.User, 176, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"InterestId\"");
                BeginWriteAttribute("value", " value=\"", 239, "\"", 278, 1);
#nullable restore
#line 6 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
WriteAttributeValue("", 247, ViewBag.OneInterest.InterestId, 247, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"submit\" value=\"Join\" class=\"btn btn-outline-success\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container p-2\">\r\n    <h3>Event Coordinator: <em>");
#nullable restore
#line 12 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
                          Write(ViewBag.IntPart.Coordinator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></h3>\r\n    <h3>Description:</h3>\r\n    <div>\r\n        <p>");
#nullable restore
#line 15 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
      Write(ViewBag.OneInterest.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <h3>Participants:</h3>\r\n    <ul>\r\n");
#nullable restore
#line 19 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
          
            foreach(InterestHistory a in ViewBag.IntPart.InterestHistory){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><em>");
#nullable restore
#line 21 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
                   Write(a.Participant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></li>\r\n");
#nullable restore
#line 22 "C:\Users\Rob\Desktop\Coding Dojo\CSHARP_stack\CSExam\Views\Home\OneInterest.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
