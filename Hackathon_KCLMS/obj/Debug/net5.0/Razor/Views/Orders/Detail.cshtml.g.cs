#pragma checksum "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58baa508ac2cd54aa2ca8e0c0eafa0a70829702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Detail), @"mvc.1.0.view", @"/Views/Orders/Detail.cshtml")]
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
#line 1 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\_ViewImports.cshtml"
using Hackathon_KCLMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\_ViewImports.cshtml"
using Hackathon_KCLMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58baa508ac2cd54aa2ca8e0c0eafa0a70829702", @"/Views/Orders/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed60ab2033fed9214aa349dafee006275b51b388", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hackathon_KCLMS.ViewModels.Orders.DetailVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
  
    ViewData["Title"] = $"Order {Model.OrderHeader.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mb-3\">");
#nullable restore
#line 7 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h5>Order no. ");
#nullable restore
#line 9 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
         Write(Model.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Store: ");
#nullable restore
#line 10 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
      Write(Model.OrderHeader.Store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Date: ");
#nullable restore
#line 11 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
     Write(Model.OrderHeader.DateOfPurchase.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5 class=\"mb-5\">Time: ");
#nullable restore
#line 12 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
                  Write(Model.OrderHeader.DateOfPurchase.ToString("HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>

<div class=""d-flex"">
    <div class=""col-3 fw-bold"">
        <h6>Product name</h6>
    </div>
    <div class=""col-3 fw-bold"">
        <h6>Unit price</h6>
    </div>
    <div class=""col-3 fw-bold"">
        <h6>Quantity</h6>
    </div>
    <div class=""col-3 fw-bold"">
        <h6>Price</h6>
    </div>
</div>
<hr />

");
#nullable restore
#line 30 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
 foreach (OrderProduct orderProduct in Model.OrderProducts)
{
    //<div class="d-flex justify-content-between align-items-center mt-1 mb-2">

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex\">\r\n        <div class=\"col-3\">\r\n            <p>");
#nullable restore
#line 35 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
          Write(orderProduct.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <p>£");
#nullable restore
#line 38 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
           Write(orderProduct.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <p>");
#nullable restore
#line 41 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
          Write(orderProduct.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <p>£");
#nullable restore
#line 44 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
           Write(String.Format("{0:0.00}",orderProduct.Quantity * orderProduct.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 48 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex\">\r\n    <div class=\"col-6\">\r\n\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <p>Subtotal</p>\r\n        <p class=\"text-danger\">Amendments</p>\r\n        <h6 class=\"fw-bold\">Grand total</h6>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <p>£");
#nullable restore
#line 59 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
       Write(String.Format("{0:0.00}",Model.OrderProducts.Sum(p => p.UnitPrice * p.Quantity)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-danger\">£");
#nullable restore
#line 60 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
                           Write(String.Format("{0:0.00}", Model.OrderHeader.TotalAmount - Model.OrderProducts.Sum(p => p.UnitPrice * p.Quantity)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h6 class=\"fw-bold\">£");
#nullable restore
#line 61 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Orders\Detail.cshtml"
                        Write(String.Format("{0:0.00}",Model.OrderHeader.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hackathon_KCLMS.ViewModels.Orders.DetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
