#pragma checksum "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3c99ef8102c0e71460dcedaa1998ccb2bdd9026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 5 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
using Hackathon_KCLMS.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3c99ef8102c0e71460dcedaa1998ccb2bdd9026", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed60ab2033fed9214aa349dafee006275b51b388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageCards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
 if (User.IsInRole(Hackathon_KCLMS.Helpers.Constants.UserRoles.Customer))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container px-4 py-5\" id=\"custom-cards\">\r\n        <h2 class=\"pb-2 border-bottom\">");
#nullable restore
#line 16 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
                                  Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Dashboard</h2>\r\n\r\n        <div class=\"row row-cols-1 row-cols-lg-3 align-items-stretch g-4 py-5\">\r\n\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3c99ef8102c0e71460dcedaa1998ccb2bdd90268120", async() => {
                WriteLiteral(@"
                    <div class=""card card-cover h-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg"" style=""background-image: url('https://i.imgur.com/VbLCs9z.png');"">
                        <div class=""d-flex flex-column h-100 p-5 pb-3 text-white text-shadow-1"">
                            <h2 class=""pt-5 mt-5 mb-4 display-6 lh-1 fw-bold"">Cards</h2>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3c99ef8102c0e71460dcedaa1998ccb2bdd902610371", async() => {
                WriteLiteral(@"
                    <div class=""card card-cover h-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg"" style=""background-image: url('https://i.imgur.com/tXEwBhP.jpg');"">
                        <div class=""d-flex flex-column h-100 p-5 pb-3 text-white text-shadow-1"">
                            <h2 class=""pt-5 mt-5 mb-4 display-6 lh-1 fw-bold"">Receipts</h2>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3c99ef8102c0e71460dcedaa1998ccb2bdd902612626", async() => {
                WriteLiteral(@"
                    <div class=""card card-cover h-100 w-100 overflow-hidden text-white bg-dark rounded-5 shadow-lg"" style=""background-image: url('https://i.imgur.com/rpvEy41.png');"">
                        <div class=""d-flex flex-column h-100 p-5 pb-3 text-shadow-1"">
                            <h2 class=""pt-5 mt-5 mb-4 display-6 lh-1 fw-bold"">Sign Out</h2>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
                                                                                                               WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj\" crossorigin=\"anonymous\"></script>\r\n");
#nullable restore
#line 53 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""bg-dark text-secondary py-5 text-center"">
        <img src=""https://i.imgur.com/BBhFn5b.png"" height=""100"" width=""100"" style=""border-radius:12px;""><br>
        <h1 class=""display-5 fw-bold text-white mt-3"">Welcome to U-Receipts</h1>
        <div class=""col-lg-6 mx-auto"">
            <p class=""fs-5 mb-4"">The clean alternative to paper receipts
        </div>
    </div>
    <div class=""container py-5"">
        <div class=""row p-4 pb-0 pe-lg-0 pt-lg-5 align-items-center rounded-3 border shadow-lg"">
            <div class=""col-lg-7 p-3 p-lg-5 pt-lg-3"">
                <h1 class=""display-4 fw-bold lh-1"">Register Now</h1>
                <p class=""lead"">The clean solution to paper receipts. Helping to offset 700 million kilograms of non-recyclable waste, save companies 32 million pounds  and save 3 million trees annually in the UK.</p>
                <div class=""d-grid gap-2 d-md-flex justify-content-md-start mb-4 mb-lg-3"">
                    <a type=""button"" class=""btn theme-clr btn-l");
            WriteLiteral(@"g px-4 me-md-2 fw-bold"" id=""register"" href=""/Identity/Account/Register"">Register</a>
                </div>
                <a id=""login"" href=""/Identity/Account/Login"">Already have an account?</a>

            </div>
            <div class=""col-lg-4 offset-lg-1 p-0 position-relative overflow-hidden shadow-lg"">
                <div class=""position-lg-absolute top-0 left-0 overflow-hidden"">
                    <img class=""mg-fluid border rounded-3 shadow-lg mb-4 img-100"" src=""https://www.rotary.org/sites/default/files/styles/w_600/public/Area_of_focus_Environment_Hero_SHU1317118457.jpg?itok=ZmMjhjF2""");
            BeginWriteAttribute("alt", " alt=\"", 4384, "\"", 4390, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""720"">
                </div>
            </div>
        </div>
    </div>
    <div class=""container py-5"">
        <a id=""reasons""><h2 class=""pb-2 border-bottom"">U-Receipts: How It Will Help Combat Climate Change</h2></a>
    </div>
    <div class=""container marketing"">

        <link href=""carousel.css"" rel=""stylesheet"">


        <div class=""row featurette"">
            <div class=""col-md-7"">
                <h2 class=""featurette-heading"">Trees</h2>
                <p class=""lead"">
                    Every year in the UK 11 billion till receipts are printed, cutting down trees that would absorb over 60 million kilograms of carbon dioxide,
                    meaning 0.01% of the UKs carbon footprint comes from these receipts.
                </p>
            </div>
            <div class=""col-md-5"">
                <img src=""https://www.plt.org/wp-content/uploads/2017/03/facts-trees-world-500x500.png"">

            </div>
        </div>

        <hr class=""featurette-divi");
            WriteLiteral(@"der"">

        <div class=""row featurette"">
            <div class=""col-md-7 order-md-2"">
                <h2 class=""featurette-heading"">Toxicity</h2>
                <p class=""lead"">
                    Till receipts are made using thermal paper, which are coated in a substance called bisphenol A and S (BPA and BPS).
                    These substances are banned from plastic ass they are extremely toxic when ingested and hence also cant be recycled and must be thrown away in landfills,
                    this means that companies are wasting money and resources without reason when our application can help solve this issue.
                </p>
            </div>
            <div class=""col-md-5 order-md-1"">
                <img src=""https://thumbor.granitemedia.com/img/DwRNY8xVmpuB52tLecXApZf-zjY=/500x500/filters:format(webp):quality(80)/granite-web-prod/1b/d1/1bd1048c41624d9fbf54fb4d3a0b2b8c.jpeg"">

            </div>
        </div>

        <hr class=""featurette-divider"">
        <div ");
            WriteLiteral(@"class=""container py-5"">
            <div class=""row featurette"">
                <div class=""col-md-7"">
                    <h2 class=""featurette-heading"">Untapped Market</h2>
                    <p class=""lead"">
                        Some banks, such as Monzo, Barclays and HSBC  have already started to utilise something similar to U-Receipts, however these only show the price,
                        store and time for  purchases made using your phone and must be purchases under £30. We hope to make a universal platform to be used by all stores and aim for a paperless retail community.
                    </p>
                </div>
                <div class=""col-md-5"">
                    <img src=""https://www.strath.ac.uk/media/1newwebsite/departmentsubject/huntercentreforentrepreneurship/engagement.jpg"">

                </div>
            </div>
        </div>
    </div>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-U1D");
            WriteLiteral("AWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj\" crossorigin=\"anonymous\"></script>\r\n");
#nullable restore
#line 140 "C:\Users\najme\Documents\Nush thing\Hackathon\Hackathon_KCLMS\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
