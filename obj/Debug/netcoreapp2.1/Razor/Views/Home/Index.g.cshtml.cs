#pragma checksum "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28d42098102cd2c97fb94db4197fd4de384c6e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\_ViewImports.cshtml"
using Csharp_CRUDelicious;

#line default
#line hidden
#line 1 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
using Csharp_CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28d42098102cd2c97fb94db4197fd4de384c6e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0274729559a360c221af32b9769650c0930fd933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "CRUDelicius";

#line default
#line hidden
            BeginContext(102, 452, true);
            WriteLiteral(@"
<div class=""container"">
    <h1><b>Welcome to CRUDelicius</b></h1>
    <div class=""add"">
        <a href=""/new"" class=""btn btn-primary"">Add a Dish</a>
    </div>
    <div class=""dishlist"" class=""scrollbar"" id=""style-2"" class=""force-overflow"">
        <table class=""table table-borderless"">
            <div class=""sticky"">
                <h5>Check out some recent dishes!</h5>
                <hr>
            </div>
            <tbody>
");
            EndContext();
#line 19 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
              foreach (Dish dish in @Model){

#line default
#line hidden
            BeginContext(600, 60, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"col\"><a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 660, "\"", 681, 2);
            WriteAttributeValue("", 668, "/", 668, 1, true);
#line 21 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 669, dish.DishId, 669, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(684, 9, false);
#line 21 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
                                                        Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(693, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(702, 9, false);
#line 21 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
                                                                          Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(711, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "C:\Users\Valued Customer\Documents\CodingDojo\C#_stack\Csharp_CRUDelicious\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(775, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
