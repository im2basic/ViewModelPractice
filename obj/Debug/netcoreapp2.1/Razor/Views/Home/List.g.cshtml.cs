#pragma checksum "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8140b0a85b8d537df353ef3673d58d7cd10fc95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml"
using ViewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8140b0a85b8d537df353ef3673d58d7cd10fc95", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147e23ca4f5315fe200c88601892203f60461b1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 167, true);
            WriteLiteral("<ul>\r\n    <li><a href=\"/\">Home</a></li>\r\n    <li><a href=\"/num\">Num</a></li>\r\n    <li><a href=\"/list\">List</a></li>\r\n    <li><a href=\"/user\">User</a></li>\r\n</ul>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml"
  
    foreach(var p in @Model)
    {

#line default
#line hidden
            BeginContext(255, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(268, 11, false);
#line 14 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml"
       Write(p.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(279, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(281, 10, false);
#line 14 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml"
                    Write(p.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(291, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 15 "C:\Users\basic\Desktop\codingDojo\c#\Asp\ViewModel\Views\Home\List.cshtml"
    }

#line default
#line hidden
            BeginContext(308, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591