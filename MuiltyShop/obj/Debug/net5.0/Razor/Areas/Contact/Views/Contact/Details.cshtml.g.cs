#pragma checksum "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cc15b11606c2bbfb5bed63bdf75e5025bdb4021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Contact_Views_Contact_Details), @"mvc.1.0.view", @"/Areas/Contact/Views/Contact/Details.cshtml")]
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
#line 1 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\_ViewImports.cshtml"
using MuiltyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\_ViewImports.cshtml"
using MuiltyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
using MuiltyShop.Services.Menu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc15b11606c2bbfb5bed63bdf75e5025bdb4021", @"/Areas/Contact/Views/Contact/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23fbefa54f0d8d14b6990cfa59901cda6be938d", @"/Areas/Contact/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Contact_Views_Contact_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MuiltyShop.Models.Contact.ContactModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
  
    ViewData["Title"] = "Thông tin liên hệ";
    Layout = "/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateSent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateSent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cc15b11606c2bbfb5bed63bdf75e5025bdb40217609", async() => {
                WriteLiteral("Danh sách liên hệ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 49 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
  
    _AdminSidebarService.SetActive("Contact", "Detail", "Contact");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 55 "D:\wordspace\languages\sharp\project\MuiltyShop\MuiltyShop\Areas\Contact\Views\Contact\Details.cshtml"
Write(Html.Raw(_AdminSidebarService.renderHtml()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AdminSidebarService _AdminSidebarService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MuiltyShop.Models.Contact.ContactModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591