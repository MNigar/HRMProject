#pragma checksum "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc47f0ded63c6db7de9f67fc2a2cd96ac62a11ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Settings_Views_Transport_Form), @"mvc.1.0.view", @"/Areas/Settings/Views/Transport/Form.cshtml")]
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
#line 1 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Areas.Settings.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Models.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
using HRProject.Areas.Settings.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc47f0ded63c6db7de9f67fc2a2cd96ac62a11ce", @"/Areas/Settings/Views/Transport/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0724e909257dad6eb623473b212ee5d11a1de564", @"/Areas/Settings/Views/_ViewImports.cshtml")]
    public class Areas_Settings_Views_Transport_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRProject.Areas.Settings.Models.TransportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m-t-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Form", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""formModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalCenterTitle"" style=""color: white;"">AddNew</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i class=""ti-close""></i>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc47f0ded63c6db7de9f67fc2a2cd96ac62a11ce7380", async() => {
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 21 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    ");
#nullable restore
#line 23 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
               Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <h6 class=\"sub-title\">Name</h6>\r\n                        ");
#nullable restore
#line 27 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
                   Write(Html.DevExtreme().TextBoxFor(x => x.Name).StylingMode(EditorStylingMode.Filled));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Name, "", new { @class = "text-danger small" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <h6 class=\"sub-title\">Description</h6>\r\n                        ");
#nullable restore
#line 35 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
                   Write(Html.DevExtreme().TextAreaFor(x => x.Description).StylingMode(EditorStylingMode.Filled));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""submit"" value=""Save"" class=""btn btn-success"" />
                    <input type=""button"" value=""Cancel"" class=""btn btn-default"" data-dismiss=""modal"" />
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    function cancel() {\r\n        location.href = \'");
#nullable restore
#line 53 "D:\COVID1904\HRMProject\HRProject\Areas\Settings\Views\Transport\Form.cshtml"
                    Write(Url.Action(nameof(TransportController.Index), TransportController.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    }\r\n\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> stringLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRProject.Areas.Settings.Models.TransportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
