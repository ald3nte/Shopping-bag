#pragma checksum "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\ShoppingBag\ShoppingBagItemsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e47b52df68d812a468af200097d2b4a44420424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingBag_ShoppingBagItemsList), @"mvc.1.0.view", @"/Views/ShoppingBag/ShoppingBagItemsList.cshtml")]
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
#line 1 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\_ViewImports.cshtml"
using Shopping_bag;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\_ViewImports.cshtml"
using Shopping_bag.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\_ViewImports.cshtml"
using Shopping_bag.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e47b52df68d812a468af200097d2b4a44420424", @"/Views/ShoppingBag/ShoppingBagItemsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2fa3f4228466463feb140448903522dbf75cf60", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingBag_ShoppingBagItemsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingBag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Koszyk:</h1>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\ShoppingBag\ShoppingBagItemsList.cshtml"
             foreach (var @product in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 11 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\ShoppingBag\ShoppingBagItemsList.cshtml"
               Write(product.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p> ");
#nullable restore
#line 11 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\ShoppingBag\ShoppingBagItemsList.cshtml"
                                         Write(product.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 13 "C:\Users\sjsha\Documents\Project\Projekty Git\Shopping-bag\Shopping-bag\Views\ShoppingBag\ShoppingBagItemsList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingBag> Html { get; private set; }
    }
}
#pragma warning restore 1591
