#pragma checksum "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d07a09e190f578d3965ed688584fe9b71708e4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GridButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_GridButtonPartial.cshtml")]
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
#line 1 "D:\C#course\HRProject\HRProject\Views\_ViewImports.cshtml"
using HRProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#course\HRProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#course\HRProject\HRProject\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#course\HRProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#course\HRProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Areas.Settings.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d07a09e190f578d3965ed688584fe9b71708e4d", @"/Views/Shared/_GridButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b8b630447b852e7612db819e6c78974506af16", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GridButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<String, String>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row mb-3"">
    <div class=""col"" id=""col"">
        <button type=""button"" class=""btn btn-sm btn-outline-primary"" onclick=""dtGrid.reload();""><i class=""dx-icon-refresh""></i></button>
        <button type=""button"" class=""btn  btn-sm btn-outline-primary"" onclick=""dtGrid.filter();""><i class=""fa fa-search""></i></button>
        <button id=""btnNew"" type=""button"" class=""btn btn-sm btn-primary"" onclick=""toForm(null);""><i class=""fa fa-plus""></i> ");
#nullable restore
#line 7 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
                                                                                                                       Write(stringLocalizer["AddNew"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        <button id=\"btnEdit\" type=\"button\" class=\"btn btn-sm btn-primary\" onclick=\"toForm(selectedId);\" disabled><i class=\"fa fa-edit\"></i> ");
#nullable restore
#line 8 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
                                                                                                                                       Write(stringLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        <button id=\"btnRemove\" type=\"button\" class=\"btn btn-sm btn-danger active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 779, "\"", 811, 3);
            WriteAttributeValue("", 789, "remove(\'", 789, 8, true);
#nullable restore
#line 9 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
WriteAttributeValue("", 797, Model.Item1, 797, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 809, "\')", 809, 2, true);
            EndWriteAttribute();
            WriteLiteral(" disabled><i class=\"fa fa-trash\"></i> ");
#nullable restore
#line 9 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
                                                                                                                                                   Write(stringLocalizer["Remove"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    var allData = true;\r\n\r\n    function remove(url) {\r\n\r\n        dialog.confirm(\'");
#nullable restore
#line 19 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
                   Write(stringLocalizer["AreYouSureRemoveData"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', function () {

            $.ajax(url, {
                data: { id: selectedId },
                method: ""POST"",
                success: function (response) {
                    dtGrid.reload();
                },
                error: function (error) {
                    success(error);
                }
            });
        });
    }

     function toForm(id) {
        $.get('");
#nullable restore
#line 35 "D:\C#course\HRProject\HRProject\Views\Shared\_GridButtonPartial.cshtml"
          Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', { id: id },

            function (response) {
                $(""#modalDiv"").html(response);
                $(""#formModal"").modal('show');

            }).fail(function (error) {
                swal(""Error!"", error.statusText, ""error"");
            });
    }





</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<String, String>> Html { get; private set; }
    }
}
#pragma warning restore 1591
