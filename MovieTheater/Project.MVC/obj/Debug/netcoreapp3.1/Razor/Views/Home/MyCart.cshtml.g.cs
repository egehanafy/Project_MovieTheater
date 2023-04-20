#pragma checksum "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed812c0c3264a553dff4864f4019e421edc1528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyCart), @"mvc.1.0.view", @"/Views/Home/MyCart.cshtml")]
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
#line 1 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\_ViewImports.cshtml"
using Project.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\_ViewImports.cshtml"
using Project.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\_ViewImports.cshtml"
using Project.MVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed812c0c3264a553dff4864f4019e421edc1528", @"/Views/Home/MyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df719b8e25c6aead4649377e8f16324a31cca3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Common.Cart>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
  
    ViewData["Title"] = "MyCart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    decimal? toplamTutar = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""py-2"">
    <div class=""container px-4 mt-5"">
        <div class=""row"">
            <div class=""col-md-9"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Movie</th>
                            <th>Quantity</th>
                            <th>Price</th>
                            <th>Edit</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                         foreach (var item in Model._myCart.Values)
                        {
                            toplamTutar += @item.SubTotal;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                                <td>");
#nullable restore
#line 28 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                               Write(item.MovieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"col-sm-3\">\r\n                                        <input type=\"number\" name=\"quantity\"");
            BeginWriteAttribute("id", " id=\"", 1229, "\"", 1242, 1);
#nullable restore
#line 33 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
WriteAttributeValue("", 1234, item.Id, 1234, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1264, "\"", 1286, 1);
#nullable restore
#line 33 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
WriteAttributeValue("", 1272, item.Quantity, 1272, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                                    </div>
                                </td>
                                <td>
                                    <a class=""btn btn-danger btn-sm"">Delete</a>
                                </td>
                            </tr>
");
#nullable restore
#line 40 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col-md-3"">
                <div class=""card"">
                    <div class=""card-header"">
                        <label>Have VIP?</label>
                        <div");
            BeginWriteAttribute("class", " class=\"", 1867, "\"", 1875, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <input type=""text"" class=""form-control"" placeholder=""VIP Code""/>
                            <button class=""btn btn-primary"">Apply</button>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h5>Total Price: ");
#nullable restore
#line 56 "D:\YZL3162\Projelerim\MovieTheater\MovieTheater\Project.MVC\Views\Home\MyCart.cshtml"
                                    Write(toplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h5>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ed812c0c3264a553dff4864f4019e421edc15289008", async() => {
                WriteLiteral("Complete Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Common.Cart> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
