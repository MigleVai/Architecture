#pragma checksum "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85653b8122f5f8dbddd9add4b70b33958268044d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_Index), @"mvc.1.0.view", @"/Views/Sale/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sale/Index.cshtml", typeof(AspNetCore.Views_Sale_Index))]
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
#line 1 "C:\Users\migle\source\repos\Architecture\Architecture\Views\_ViewImports.cshtml"
using Architecture;

#line default
#line hidden
#line 2 "C:\Users\migle\source\repos\Architecture\Architecture\Views\_ViewImports.cshtml"
using Architecture.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85653b8122f5f8dbddd9add4b70b33958268044d", @"/Views/Sale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115efec30e3677d0c5dc8b28f057a19d54ee87e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Sale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Architecture.Models.SaleModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(93, 28, true);
            WriteLiteral("\r\n<h2>View</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8eb5650aeb7240a9bc69d27b5c4950b6", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(158, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 45, false);
#line 16 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(352, 45, false);
#line 19 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartSale));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 43, false);
#line 22 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndSale));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 50, false);
#line 25 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PublisherEmail));

#line default
#line hidden
            EndContext();
            BeginContext(602, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(720, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(769, 44, false);
#line 34 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(813, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(869, 44, false);
#line 37 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartSale));

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 42, false);
#line 40 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndSale));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1067, 49, false);
#line 43 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublisherEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1172, 51, false);
#line 46 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1244, 55, false);
#line 47 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\migle\source\repos\Architecture\Architecture\Views\Sale\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1338, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Architecture.Models.SaleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
