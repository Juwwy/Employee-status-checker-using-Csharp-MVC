#pragma checksum "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fda6637f3c4c631eb695f3151d8ec2ba68de2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee), @"mvc.1.0.view", @"/Views/Home/Employee.cshtml")]
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
#line 1 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\_ViewImports.cshtml"
using session3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\_ViewImports.cshtml"
using session3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fda6637f3c4c631eb695f3151d8ec2ba68de2f", @"/Views/Home/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130341ba5909ed11bfe978e4d61f2a4c19a5169f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Check", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Confirm Status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
  
    ViewData["Title"] = "Employee Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"container\">\r\n    <div class=\"row text-center p-3\">\r\n        <div class=\"col-md-8\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92fda6637f3c4c631eb695f3151d8ec2ba68de2f5734", async() => {
                WriteLiteral(@"
                <table class=""table table-responsive table-striped"">
                    <tr>
                        <th colspan=""2""><h4>Employee Information</h4></th>

                    </tr>
                    <tr>
                        <td><b>First Name</b></td>
                        <td><input type=""text"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 550, "\"", 574, 1);
#nullable restore
#line 17 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 558, Model.FirstName, 558, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Last Name</b></td>\r\n                        <td><input type=\"text\" class=\"form-control\" readonly");
                BeginWriteAttribute("value", " value=\"", 765, "\"", 788, 1);
#nullable restore
#line 21 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 773, Model.LastName, 773, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>Department</b></td>\r\n                        <td><input type=\"text\" class=\"form-control\" readonly");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 1005, 1);
#nullable restore
#line 25 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 988, Model.Department, 988, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /></td>
                    </tr>
                    <tr>
                        <td><b>Salary</b></td>
                        <td>
                            <div class=""input-group mb-2"">
                                <input type=""text"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 1287, "\"", 1308, 1);
#nullable restore
#line 31 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 1295, Model.Salary, 1295, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text"">$</div>
                                </div>
                            </div>
                        </td>

                    </tr>
                    <tr>
");
#nullable restore
#line 40 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
                         switch (@Model.Confirmed)
                        {
                            case false:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td colspan=\"2\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92fda6637f3c4c631eb695f3151d8ec2ba68de2f9262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
                                break;

                            case true:

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <td colspan=""2"">
                                    <div class=""card"">
                                        <div class=""card-body"">
                                            <h5 class=""text-success"">Employee status has been Confirmed!</h5>
                                        </div>
                                    </div>
                                </td>
");
#nullable restore
#line 54 "C:\CodebitsAcademy\ClassSession\ASP.NET\session3\session3\Views\Home\Employee.cshtml"
                                break;

                            default:

                                break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n\r\n                </table>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
