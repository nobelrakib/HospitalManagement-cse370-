#pragma checksum "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e8abcc8e0520236ac1e28d6b4ed638ae091a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Doctor_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Doctor/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e8abcc8e0520236ac1e28d6b4ed638ae091a7c", @"/Areas/Admin/Views/Doctor/Add.cshtml")]
    public class Areas_Admin_Views_Doctor_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySqlProject.Areas.Admin.Models.DoctorUpdateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Doctor/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("notification", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
Write(await Html.PartialAsync("_Notification", Model.Notification));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    \r\n");
            }
            );
            WriteLiteral(@"


<div class=""container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-6"">
            <!-- general form elements -->
            <div class=""card card-info"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Add Doctor</h3>
                </div>
                <!-- /.card-header -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e8abcc8e0520236ac1e28d6b4ed638ae091a7c5635", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    <div class=""card-body"">

                        <div class=""form-group"">
                            <label asp-for=""Name"" class=""control-label"">Name </label>
                            <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Enter Doctor Name....."">
                        </div>

                        <div class=""form-group"">
                            <label for=""Description"">Description </label>
                            <textarea class=""form-control"" rows=""5"" cols=""33"" name=""Description"" placeholder=""Enter Description .....""></textarea>
                        </div>
                        <div class=""form-group"">
                            <select class=""form-control"" name=""DepartmentId"">
                                <option");
                BeginWriteAttribute("value", " value=\"", 1583, "\"", 1591, 0);
                EndWriteAttribute();
                WriteLiteral(">Please Select Department</option>\r\n");
#nullable restore
#line 46 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
                                 foreach (var department in Model.Departments)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <option");
                BeginWriteAttribute("value", " value=\"", 1786, "\"", 1808, 1);
#nullable restore
#line 48 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
WriteAttributeValue("", 1794, department.Id, 1794, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
                                                              Write(department.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 49 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Doctor\Add.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""file"">Choose A file </label>
                            <input type=""file"" class=""form-control"" name=""file"" />
                        </div>

                        <div class=""card-footer"">
                            <button type=""submit"" class=""btn btn-primary"">Submit</button>
                        </div>

                        </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySqlProject.Areas.Admin.Models.DoctorUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
