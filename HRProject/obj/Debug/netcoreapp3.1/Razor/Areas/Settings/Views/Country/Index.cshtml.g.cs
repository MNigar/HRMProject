#pragma checksum "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f47098b13fac0fbc953a1bc79d10bb4f66c6071b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Settings_Views_Country_Index), @"mvc.1.0.view", @"/Areas/Settings/Views/Country/Index.cshtml")]
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
#line 8 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\_ViewImports.cshtml"
using HRProject.Models.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml"
using HRProject.Areas.Settings.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f47098b13fac0fbc953a1bc79d10bb4f66c6071b", @"/Areas/Settings/Views/Country/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0724e909257dad6eb623473b212ee5d11a1de564", @"/Areas/Settings/Views/_ViewImports.cshtml")]
    public class Areas_Settings_Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml"
  
    ViewData["Title"] = "Country";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page-header\">\r\n    <div class=\"container-fluid d-sm-flex justify-content-between\">\r\n        <h4>");
#nullable restore
#line 7 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n<div id=\"content-wrapper\" class=\"d-flex flex-column\">\r\n    <div id=\"content\">\r\n        <div id=\"mainDiv\" class=\"container-fluid\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 15 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml"
               Write(await Html.PartialAsync("_GridButtonPartial", new Tuple<String,String>(
                                                          @Url.Action(nameof(CountryController.Remove), CountryController.Name),
                                                          @Url.Action(nameof(CountryController.Form), CountryController.Name))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"devDiv\">\r\n                        ");
#nullable restore
#line 19 "D:\C#course\HRMProject\HRProject\Areas\Settings\Views\Country\Index.cshtml"
                   Write(await Html.PartialAsync("_GridPartial", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
