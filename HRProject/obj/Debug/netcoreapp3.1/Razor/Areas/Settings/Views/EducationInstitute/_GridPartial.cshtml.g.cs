#pragma checksum "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\EducationInstitute\_GridPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49340ccdfa4c6b41fcf7540d8fb72d4d5a64439c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Settings_Views_EducationInstitute__GridPartial), @"mvc.1.0.view", @"/Areas/Settings/Views/EducationInstitute/_GridPartial.cshtml")]
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
#line 1 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Areas.Settings.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Areas.Settings.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\EducationInstitute\_GridPartial.cshtml"
using HRProject.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\EducationInstitute\_GridPartial.cshtml"
using HRProject.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49340ccdfa4c6b41fcf7540d8fb72d4d5a64439c", @"/Areas/Settings/Views/EducationInstitute/_GridPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0724e909257dad6eb623473b212ee5d11a1de564", @"/Areas/Settings/Views/_ViewImports.cshtml")]
    public class Areas_Settings_Views_EducationInstitute__GridPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\EducationInstitute\_GridPartial.cshtml"
Write(Html.DevExtreme().DataGrid<EducationInstituteDTO>()
    .ID("dt-grid")
    .DataSource(d => d.Mvc().Area("Settings").Controller(EducationInstituteController.Name).LoadAction(nameof(EducationInstituteController.GetAll)))
    .RemoteOperations(true)
    .ShowBorders(true)
    .ShowRowLines(true)
    .AllowColumnResizing(true)
    .HRMGrid()
    .Columns(c =>
    {
        c.AddFor(x => x.Name).Caption(stringLocalizer["Name"]);
        c.AddFor(x => x.Description).Caption(stringLocalizer["Description"]);
    })
    .Pager(p => p.AllowedPageSizes(new int[] { 5, 20, 50 }))
    .Paging(paging => paging.PageSize(10))
.Selection(s => s.Mode(SelectionMode.Single)).OnSelectionChanged("dtGrid.selectionChanged")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool?> Html { get; private set; }
    }
}
#pragma warning restore 1591
