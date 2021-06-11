#pragma checksum "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\StaffType\_GridPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4477998e92f037fffeac64856a9a9b405b64778a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Structure_Views_StaffType__GridPartial), @"mvc.1.0.view", @"/Areas/Structure/Views/StaffType/_GridPartial.cshtml")]
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
#line 1 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using HRProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using HRProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using HRProject.Areas.Structure.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using HRProject.Areas.Structure.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using HRProject.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\StaffType\_GridPartial.cshtml"
using HRProject.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\StaffType\_GridPartial.cshtml"
using HRProject.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4477998e92f037fffeac64856a9a9b405b64778a", @"/Areas/Structure/Views/StaffType/_GridPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f83e79b4bad3d0c6212624c123f7a61b22d3f249", @"/Areas/Structure/Views/_ViewImports.cshtml")]
    public class Areas_Structure_Views_StaffType__GridPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\COVID1904\HRMProject\HRProject\Areas\Structure\Views\StaffType\_GridPartial.cshtml"
Write(Html.DevExtreme().DataGrid<StaffTypeDTO>()
    .ID("dt-grid")
    .DataSource(d => d.Mvc().Area("Structure").Controller(StaffTypeController.Name).LoadAction(nameof(StaffTypeController.GetAll)))
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
