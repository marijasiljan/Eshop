#pragma checksum "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8ed1f91753614999763022d1ad8ea6f63b4b26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetOrderDetails), @"mvc.1.0.view", @"/Views/Order/GetOrderDetails.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\_ViewImports.cshtml"
using EShopAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\_ViewImports.cshtml"
using EShopAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8ed1f91753614999763022d1ad8ea6f63b4b26", @"/Views/Order/GetOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396d7ca17155cc730aadda06544609acf309e746", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_GetOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShopAdminApp.Models.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
 for (var i = 0; i < Model.Products.ToList().Count; i++)
{
    var item = Model.Products[i].Product; // Model.Products == Order.Products

    if (i % 3 == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 15 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem;\">\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 449, "\"", 473, 1);
#nullable restore
#line 18 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
WriteAttributeValue("", 455, item.ProductImage, 455, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
                                Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n");
#nullable restore
#line 24 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"

        if (i % 3 == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("</div>\n");
#nullable restore
#line 28 "C:\Users\PC\Desktop\reservEshop-master\EShopAdminApp\EShopAdminApp\Views\Order\GetOrderDetails.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShopAdminApp.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591