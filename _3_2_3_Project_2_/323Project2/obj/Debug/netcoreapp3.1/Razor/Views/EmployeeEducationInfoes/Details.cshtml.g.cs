#pragma checksum "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a435f7f9f44999c5fd317332049ce38046395f93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeEducationInfoes_Details), @"mvc.1.0.view", @"/Views/EmployeeEducationInfoes/Details.cshtml")]
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
#line 1 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\_ViewImports.cshtml"
using _323Project2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\_ViewImports.cshtml"
using _323Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a435f7f9f44999c5fd317332049ce38046395f93", @"/Views/EmployeeEducationInfoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158b7d09ffbb18ff10b32b8006e7f65bd39003f4", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeEducationInfoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_323Project2.Models.EmployeeEducationInfo>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>EmployeeEducationInfo</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationCodeNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationCodeNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeNumberNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeNumberNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 34 "C:\Users\kelendria leoker\Desktop\_323_Project_2_\323Project2\Views\EmployeeEducationInfoes\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a435f7f9f44999c5fd317332049ce38046395f936347", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_323Project2.Models.EmployeeEducationInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
