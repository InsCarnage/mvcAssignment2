#pragma checksum "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19616c238c4c6e0408c68ff0f2e2849c1a06cda1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Work_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Work/Details.cshtml")]
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
#line 1 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\_ViewImports.cshtml"
using Project2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\_ViewImports.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19616c238c4c6e0408c68ff0f2e2849c1a06cda1", @"/Areas/Admin/Views/Work/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3ca17911d6cbbafc701d8a3edeb28ee85bb50e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Work_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project2.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 32 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
         if (ViewBag.Admin.Contains("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 35 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 38 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
           Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 40 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 83 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
         if (ViewBag.Admin.Contains("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 86 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 89 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
           Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 91 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 122 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
         if (ViewBag.Admin.Contains("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 125 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 136 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 138 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 141 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 144 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 147 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 150 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 153 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 156 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 159 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 162 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 165 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 168 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 171 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 174 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 177 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 180 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 183 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 186 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 189 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 192 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 195 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 198 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 201 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 204 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 207 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 210 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 213 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 216 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 219 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 222 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 225 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
#nullable restore
#line 229 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
 if (ViewBag.Admin.Contains("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19616c238c4c6e0408c68ff0f2e2849c1a06cda128152", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 232 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
                               WriteLiteral(Model.EmployeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19616c238c4c6e0408c68ff0f2e2849c1a06cda130318", async() => {
                WriteLiteral("Back List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 235 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19616c238c4c6e0408c68ff0f2e2849c1a06cda131719", async() => {
                WriteLiteral("Back List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 241 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project2.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591