#pragma checksum "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc298566acf21d089a757d9905c9c4afd5ec8295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc298566acf21d089a757d9905c9c4afd5ec8295", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced103e06a9bde9292177bf0e25ad13795228c74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 109, true);
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
            EndContext();
            BeginContext(126, 10, false);
#line 6 "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(136, 127, true);
            WriteLiteral(";\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                <small>\r\n                    ");
            EndContext();
            BeginContext(264, 25, false);
#line 9 "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
               Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(289, 117, true);
            WriteLiteral("\r\n                </small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">\r\n        ");
            EndContext();
            BeginContext(407, 17, false);
#line 15 "C:\Users\DELL LATITUDE i5\Source\Repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(424, 24, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591