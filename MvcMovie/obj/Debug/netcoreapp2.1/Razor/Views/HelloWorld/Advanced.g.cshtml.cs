#pragma checksum "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a60a762ec574b0f348933407f37caf2a6c7301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Advanced), @"mvc.1.0.view", @"/Views/HelloWorld/Advanced.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Advanced.cshtml", typeof(AspNetCore.Views_HelloWorld_Advanced))]
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
#line 1 "C:\websites\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\websites\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a60a762ec574b0f348933407f37caf2a6c7301", @"/Views/HelloWorld/Advanced.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Advanced : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
  
    ViewData["Title"] = "Advanced";
    var message = ViewData["Message"];
    var numTimes = ViewData["NumTimes"];
    var id = ViewData["ID"];
    var currentTime = ViewData["CurrentTime"]; 
    var currentUrl = ViewData["CurrentUrl"]; 
    var currentUrlAbs = ViewData["CurrentUrlAbs"];     

#line default
#line hidden
            BeginContext(309, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(316, 17, false);
#line 11 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(333, 96, true);
            WriteLiteral("</h2>\r\n\r\n<p>This is the Advanced template, it contains some test concepts!</p>\r\n\r\n\r\n<p>Message: ");
            EndContext();
            BeginContext(430, 7, false);
#line 16 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
       Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(437, 13, true);
            WriteLiteral("</p>\r\n<p>ID: ");
            EndContext();
            BeginContext(451, 2, false);
#line 17 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
  Write(id);

#line default
#line hidden
            EndContext();
            BeginContext(453, 26, true);
            WriteLiteral("</p>\r\n<p>Number of Times: ");
            EndContext();
            BeginContext(480, 8, false);
#line 18 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
               Write(numTimes);

#line default
#line hidden
            EndContext();
            BeginContext(488, 12, true);
            WriteLiteral("</p>\r\n<ul>\r\n");
            EndContext();
#line 20 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
     for (int i = 0; i < (int)numTimes; i++) {

#line default
#line hidden
            BeginContext(548, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(561, 7, false);
#line 21 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
       Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(568, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
    }

#line default
#line hidden
            BeginContext(582, 76, true);
            WriteLiteral("</ul>\r\n<p>Current Time (using simple service to demo dependency injection): ");
            EndContext();
            BeginContext(659, 11, false);
#line 24 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
                                                                Write(currentTime);

#line default
#line hidden
            EndContext();
            BeginContext(670, 54, true);
            WriteLiteral("</p>\r\n<p>Current Url (from Url.Action URL generator): ");
            EndContext();
            BeginContext(725, 10, false);
#line 25 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
                                           Write(currentUrl);

#line default
#line hidden
            EndContext();
            BeginContext(735, 63, true);
            WriteLiteral("</p>\r\n<p>Current URL Absolute (from Url.Action URL generator): ");
            EndContext();
            BeginContext(799, 13, false);
#line 26 "C:\websites\MvcMovie\Views\HelloWorld\Advanced.cshtml"
                                                    Write(currentUrlAbs);

#line default
#line hidden
            EndContext();
            BeginContext(812, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
