#pragma checksum "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1422f37c0d387e3d03fca22ff7ea414575088e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\SpartaBenchwork\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SpartaBenchwork\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1422f37c0d387e3d03fca22ff7ea414575088e38", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bfb94a69d3bcf02ab06cdfb7bb317a0565293e", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your shopping cart</h2>
<h4>Here are the delicious pies in your shopping cart.</h4>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Selected amount</th>
            <th>Pie</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
         foreach (var line in Model.ShoppingCart.ShoppingCartItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
#nullable restore
#line 18 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
                                   Write(line.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 19 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
                                 Write(line.Pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 20 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
                                  Write(line.Pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 22 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
                Write((line.Amount * line.Pie.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 31 "C:\SpartaBenchwork\BethanysPieShop\Views\ShoppingCart\Index.cshtml"
           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
