#pragma checksum "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359a41bd398c1b6c82795e8be46fa570ab78ed27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LeftMenuPartial), @"mvc.1.0.view", @"/Views/Shared/_LeftMenuPartial.cshtml")]
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
#line 1 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using HRProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Areas.Settings.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\COVID1904\HRMProject\HRProject\Views\_ViewImports.cshtml"
using HRProject.Areas.Structure.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359a41bd398c1b6c82795e8be46fa570ab78ed27", @"/Views/Shared/_LeftMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b31a58f36eab45dcb8608c4c20401c1b082bc70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LeftMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("            <!-- begin::navigation menu -->\r\n<div class=\"navigation-menu-body\">\r\n\r\n    <!-- begin::navigation-logo -->\r\n    <div>\r\n        <div id=\"navigation-logo\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 181, "\"", 216, 1);
#nullable restore
#line 7 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 188, Url.Action("Index", "Home"), 188, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h3 id=\"menuParagraph\">Pragmatech</h3>\r\n                <span id=\"spanParagraph\">");
#nullable restore
#line 9 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                    Write(stringLocalizer["HRM"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </a>
        </div>
    </div>
    <!-- end::navigation-logo -->

    <div class=""navigation-menu-group"">

        <div class=""open"" id=""dashboards"">
            <ul>
                <li class=""navigation-divider dividerCustom"">");
#nullable restore
#line 19 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                        Write(stringLocalizer["HRM"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n");
            WriteLiteral("                </li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <span>");
#nullable restore
#line 52 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                         Write(stringLocalizer["Structures"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span>\r\n                    </a>\r\n                    <ul id=\"structureId\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2702, "\"", 2802, 1);
#nullable restore
#line 56 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 2709, Url.Action(nameof(BranchController.Index), BranchController.Name, new { Area = "Structure"}), 2709, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                               Write(stringLocalizer["Branch"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2927, "\"", 3041, 1);
#nullable restore
#line 59 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 2934, Url.Action(nameof(StructureTypeController.Index), StructureTypeController.Name, new { Area = "Structure"}), 2934, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                             Write(stringLocalizer["StructureType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3173, "\"", 3279, 1);
#nullable restore
#line 62 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 3180, Url.Action(nameof(StructureController.Index), StructureController.Name, new { Area = "Structure"}), 3180, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                     Write(stringLocalizer["Structure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3407, "\"", 3537, 1);
#nullable restore
#line 65 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 3414, Url.Action(nameof(OrganizationStructureController.Index), OrganizationStructureController.Name, new { Area = "Structure"}), 3414, 123, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                             Write(stringLocalizer["OrganizationStructure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3677, "\"", 3783, 1);
#nullable restore
#line 68 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 3684, Url.Action(nameof(StaffTypeController.Index), StaffTypeController.Name, new { Area = "Structure"}), 3684, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                     Write(stringLocalizer["StaffType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <span>");
#nullable restore
#line 77 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                         Write(stringLocalizer["Settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                    <ul id=\"settingsId\">\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 4412, "\"", 4513, 1);
#nullable restore
#line 81 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 4419, Url.Action(nameof(CompanyController.Index), CompanyController.Name, new { Area = "Settings"}), 4419, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                      Write(stringLocalizer["Company"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 4661, "\"", 4770, 1);
#nullable restore
#line 84 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 4668, Url.Action(nameof(ContactTypeController.Index), ContactTypeController.Name, new { Area = "Settings"}), 4668, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                              Write(stringLocalizer["ContactType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 4922, "\"", 5023, 1);
#nullable restore
#line 87 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 4929, Url.Action(nameof(CountryController.Index), CountryController.Name, new { Area = "Settings"}), 4929, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                      Write(stringLocalizer["Country"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 5171, "\"", 5282, 1);
#nullable restore
#line 90 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 5178, Url.Action(nameof(DocumentTypeController.Index), DocumentTypeController.Name, new { Area = "Settings"}), 5178, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                Write(stringLocalizer["DocumentType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 5435, "\"", 5558, 1);
#nullable restore
#line 93 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 5442, Url.Action(nameof(EducationInstituteController.Index), EducationInstituteController.Name, new { Area = "Settings"}), 5442, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                            Write(stringLocalizer["EducationInstitute"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 5717, "\"", 5832, 1);
#nullable restore
#line 96 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 5724, Url.Action(nameof(EducationLevelController.Index), EducationLevelController.Name, new { Area = "Settings"}), 5724, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 96 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                    Write(stringLocalizer["EducationLevel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 5989, "\"", 6112, 1);
#nullable restore
#line 100 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 5996, Url.Action(nameof(IssuedOrganizationController.Index), IssuedOrganizationController.Name, new { Area = "Settings"}), 5996, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                            Write(stringLocalizer["IssuedOrganization"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 6271, "\"", 6386, 1);
#nullable restore
#line 103 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 6278, Url.Action(nameof(KnowledgeLevelController.Index), KnowledgeLevelController.Name, new { Area = "Settings"}), 6278, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                    Write(stringLocalizer["KnowledgeLevel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 6541, "\"", 6644, 1);
#nullable restore
#line 106 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 6548, Url.Action(nameof(LanguageController.Index), LanguageController.Name, new { Area = "Settings"}), 6548, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 106 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                        Write(stringLocalizer["Language"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 6793, "\"", 6900, 1);
#nullable restore
#line 109 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 6800, Url.Action(nameof(LocalitiesController.Index), LocalitiesController.Name, new { Area = "Settings"}), 6800, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 109 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                            Write(stringLocalizer["Localities"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 7051, "\"", 7164, 1);
#nullable restore
#line 112 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 7058, Url.Action(nameof(MartialStatusController.Index), MartialStatusController.Name, new { Area = "Settings"}), 7058, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                  Write(stringLocalizer["MartialStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 7318, "\"", 7421, 1);
#nullable restore
#line 115 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 7325, Url.Action(nameof(PositionController.Index), PositionController.Name, new { Area = "Settings"}), 7325, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                        Write(stringLocalizer["Position"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 7570, "\"", 7675, 1);
#nullable restore
#line 118 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 7577, Url.Action(nameof(PrivilegeController.Index), PrivilegeController.Name, new { Area = "Settings"}), 7577, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                          Write(stringLocalizer["Privilege"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 7825, "\"", 7944, 1);
#nullable restore
#line 121 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 7832, Url.Action(nameof(RelationshipTypeController.Index), RelationshipTypeController.Name, new { Area = "Settings"}), 7832, 112, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 121 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                        Write(stringLocalizer["RelationshipType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8101, "\"", 8198, 1);
#nullable restore
#line 124 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 8108, Url.Action(nameof(SkillController.Index), SkillController.Name, new { Area = "Settings"}), 8108, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 124 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                  Write(stringLocalizer["Skill"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8344, "\"", 8453, 1);
#nullable restore
#line 127 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 8351, Url.Action(nameof(SpecialitieController.Index), SpecialitieController.Name, new { Area = "Settings"}), 8351, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 127 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                              Write(stringLocalizer["Specialitie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8605, "\"", 8708, 1);
#nullable restore
#line 130 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 8612, Url.Action(nameof(WorkTypeController.Index), WorkTypeController.Name, new { Area = "Settings"}), 8612, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 130 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                        Write(stringLocalizer["WorkType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 8857, "\"", 8966, 1);
#nullable restore
#line 133 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 8864, Url.Action(nameof(ExcludedDayController.Index), ExcludedDayController.Name, new { Area = "Settings"}), 8864, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 133 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                              Write(stringLocalizer["ExcludedDay"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 9118, "\"", 9231, 1);
#nullable restore
#line 136 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 9125, Url.Action(nameof(DismissalTypeController.Index), DismissalTypeController.Name, new { Area = "Settings"}), 9125, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 136 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                                  Write(stringLocalizer["DismissalType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 9385, "\"", 9490, 1);
#nullable restore
#line 139 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
WriteAttributeValue("", 9392, Url.Action(nameof(TransportController.Index), TransportController.Name, new { Area = "Settings"}), 9392, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                                                                                                                          Write(stringLocalizer["Transport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <span>");
#nullable restore
#line 145 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                         Write(stringLocalizer["Reports"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                    <ul id=\"reportId\">\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li class=\"navigation-divider dividerCustom\">");
#nullable restore
#line 192 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                                                        Write(stringLocalizer["Salary"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <span>");
#nullable restore
#line 195 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                         Write(stringLocalizer["SalaryDocuments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                    <ul id=\"salaryDocumentsId\">\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                        <li>\r\n");
            WriteLiteral("                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <span>");
#nullable restore
#line 211 "D:\COVID1904\HRMProject\HRProject\Views\Shared\_LeftMenuPartial.cshtml"
                         Write(stringLocalizer["SalaryCalculation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                    <ul id=\"salaryCalcId\">\r\n                        <li>\r\n");
            WriteLiteral(@"                        </li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</div>
<!-- end::navigation menu -->

<script>
    var setDefaultActiveToStructure = function () {
        var path = window.location.pathname;
        var element = $(""ul li a[href='"" + path + ""']"");
        element.addClass(""active"");
        if (element.closest(""li"").parent(""#structureId"").length) {
            $(""#structureId"").css({ ""display"": ""block"" });
        }
    }
    var setDefaultActiveToSettings = function () {
        var path = window.location.pathname;
        var element = $(""ul li a[href='"" + path + ""']"");
        element.addClass(""active"");
        if (element.closest(""li"").parent(""#settingsId"").length) {
            $(""#settingsId"").css({ ""display"": ""block"" });
        }
    }
    var setDefaultActiveToReports = function () {
        var path = window.location.pathname;
        var element = $(""ul li a[href='"" + path + ""']"");
        eleme");
            WriteLiteral(@"nt.addClass(""active"");
        if (element.closest(""li"").parent(""#reportId"").length) {
            $(""#reportId"").css({ ""display"": ""block"" });
        }
    }
    var setDefaultActiveToSalaryDocuments = function () {
        var path = window.location.pathname;
        var element = $(""ul li a[href='"" + path + ""']"");
        element.addClass(""active"");
        if (element.closest(""li"").parent(""#salaryDocumentsId"").length) {
            $(""#salaryDocumentsId"").css({ ""display"": ""block"" });
        }
    }
    var setDefaultActiveToSalaryCalculation = function () {
        var path = window.location.pathname;
        var element = $(""ul li a[href='"" + path + ""']"");
        element.addClass(""active"");
        if (element.closest(""li"").parent(""#salaryCalcId"").length) {
            $(""#salaryCalcId"").css({ ""display"": ""block"" });
        }
    }
    setDefaultActiveToStructure();
    setDefaultActiveToSettings();
    setDefaultActiveToReports();
    setDefaultActiveToSalaryDocuments();
    s");
            WriteLiteral("etDefaultActiveToSalaryCalculation();\r\n</script>\r\n");
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
