#pragma checksum "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\Num.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd632cf30f01d6b2c68c76a240734b568072f6b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Num), @"mvc.1.0.view", @"/Views/Home/Num.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Num.cshtml", typeof(AspNetCore.Views_Home_Num))]
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
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#line 2 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\_ViewImports.cshtml"
using ViewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd632cf30f01d6b2c68c76a240734b568072f6b6", @"/Views/Home/Num.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147e23ca4f5315fe200c88601892203f60461b1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Num : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 195, true);
            WriteLiteral("<ul>\r\n    <li><a href=\"/\">Home</a></li>\r\n    <li><a href=\"/num\">Num</a></li>\r\n    <li><a href=\"/list\">List</a></li>\r\n    <li><a href=\"/user\">User</a></li>\r\n</ul>\r\n<h1>Here are some numbers</h1>\r\n");
            EndContext();
#line 9 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\Num.cshtml"
  
    foreach(var p in @Model)
    {

#line default
#line hidden
            BeginContext(250, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(263, 1, false);
#line 12 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\Num.cshtml"
       Write(p);

#line default
#line hidden
            EndContext();
            BeginContext(264, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 13 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\Num.cshtml"
    }

#line default
#line hidden
            BeginContext(281, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591