#pragma checksum "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c72db0932ccc5b729ee93b83efc4d317efdfb0bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Work_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Work/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72db0932ccc5b729ee93b83efc4d317efdfb0bc", @"/Areas/Admin/Views/Work/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3ca17911d6cbbafc701d8a3edeb28ee85bb50e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Work_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project2.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
 if (ViewBag.Admin.Contains("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Delete</h1>\r\n");
            WriteLiteral("    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>Employee</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 17 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 20 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 23 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 26 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 29 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 32 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 35 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 38 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 41 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 44 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 47 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 50 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 53 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 56 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 59 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 62 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 65 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 68 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 71 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 74 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 77 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 80 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 83 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 86 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 89 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 92 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 95 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 98 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 101 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 104 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 107 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 110 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 113 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 116 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 119 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 122 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 125 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 128 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 131 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 134 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 137 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 140 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 143 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 146 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 149 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 152 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 155 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 158 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 161 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 164 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 167 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 170 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 173 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 176 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 179 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 182 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 185 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 188 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 191 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 194 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 197 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 200 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 203 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 206 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 209 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 212 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 215 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 218 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
           Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c72db0932ccc5b729ee93b83efc4d317efdfb0bc28467", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c72db0932ccc5b729ee93b83efc4d317efdfb0bc28738", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 223 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c72db0932ccc5b729ee93b83efc4d317efdfb0bc30547", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 228 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You dont have premission</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c72db0932ccc5b729ee93b83efc4d317efdfb0bc33219", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n");
#nullable restore
#line 233 "D:\backup\Backup\MVC TEST\Project2\Project2\Areas\Admin\Views\Work\Delete.cshtml"
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