#pragma checksum "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6cbbe51dfb0aa4baa28b8c564d5d0761943eb62", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/chosen/chosen.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/dashboard/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/avatar-placeholder.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/chosen/chosen.jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MyBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb627133", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>");
#nullable restore
#line 9 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/admin/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Tempusdominus Bbootstrap 4 -->
    <link rel=""stylesheet"" href=""/admin/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
    <!-- iCheck -->
    <link rel=""stylesheet"" href=""/admin/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- JQVMap -->
    <link rel=""stylesheet"" href=""/admin/plugins/jqvmap/jqvmap.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/admin/css/adminlte.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""/admin/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesh");
                WriteLiteral(@"eet"" href=""/admin/plugins/daterangepicker/daterangepicker.css"">
    <!-- summernote -->
    <link rel=""stylesheet"" href=""/admin/plugins/summernote/summernote-bs4.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb629171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 33 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("styles", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb6211313", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb6212053", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""#"" class=""nav-link"">Contact</a>
                </li>
            </ul>

            <!-- Right navbar links -->
            <ul class=""navbar-nav ml-auto"">
                <!-- Messages Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-user""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-sm-right"">
                        <a class=""dropdown-item"">
                            <form class=""form-inline"" method=""post""");
                BeginWriteAttribute("action", " action=\"", 3064, "\"", 3105, 1);
#nullable restore
#line 62 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3073, Url.Action("Logout", "Account"), 3073, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <input type=""submit"" class=""nav-link btn btn-link text-dark"" value=""Logout"" />
                            </form>
                        </a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"">
                        <i class=""fas fa-th-large""></i>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""/"" class=""brand-link"">
                <img src=""/admin/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3""
                     style=""opacity: .8"">
                <span class=""brand-text font-weight-light""></span>
            </a>

            <!-- Sidebar -->
            <di");
                WriteLiteral("v class=\"sidebar\">\r\n                <!-- Sidebar user panel (optional) -->\r\n                <div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\r\n                    <div class=\"image\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb6215746", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 92 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"info\">\r\n                            <a href=\"#\" class=\"d-block\">");
#nullable restore
#line 95 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </div>\r\n");
#nullable restore
#line 97 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>

                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <li class=""nav-item has-treeview"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb6218339", async() => {
                    WriteLiteral(@"
                                <i class=""nav-icon fas fa-tachometer-alt""></i>
                                <p>
                                    Dashboard
                                    <i class=""right fas fa-angle-left""></i>
                                </p>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"                    </ul>
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>

        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <div class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">

                        </div><!-- /.col -->
");
                WriteLiteral(@"<!-- /.col -->
                    </div><!-- /.row -->
                </div><!-- /.container-fluid -->
            </div>
            <!-- /.content-header -->
            <!-- Main content -->
            <section class=""content"">
                ");
#nullable restore
#line 204 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderSection("notification", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 205 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <footer class=""main-footer"">
            <strong>Copyright &copy; 2020 - DevSkill.TenantPro.Web </strong>
            All rights reserved.
            <div class=""float-right d-none d-sm-inline-block"">
                <b>Version</b> 1.0
            </div>
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""/admin/plugins/jquery/jquery.min.js""></script>
    <!-- jQuery UI 1.11.4 -->
    <script src=""/admin/plugins/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>$.widget.bridge('uibutton', $.ui.button)</script>
    <!-- Bootstrap 4 -->
    <script src=""/admin/plugi");
                WriteLiteral(@"ns/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- ChartJS -->
    <script src=""/admin/plugins/chart.js/Chart.min.js""></script>
    <!-- Sparkline -->
    <script src=""/admin/plugins/sparklines/sparkline.js""></script>
    <!-- JQVMap -->
    <script src=""/admin/plugins/jqvmap/jquery.vmap.min.js""></script>
    <script src=""/admin/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""/admin/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""/admin/plugins/moment/moment.min.js""></script>
    <script src=""/admin/plugins/daterangepicker/daterangepicker.js""></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src=""/admin/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
    <!-- Summernote -->
    <script src=""/admin/plugins/summernote/summernote-bs4.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""/admin/plugins/overlayScrollbars/js/jquery.overl");
                WriteLiteral(@"ayScrollbars.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""/admin/js/adminlte.js""></script>
    <!-- AdminLTE dashboard demo (This is only for demo purposes) -->
    <script src=""/admin/js/pages/dashboard.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""/admin/js/demo.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cbbe51dfb0aa4baa28b8c564d5d0761943eb6223861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 259 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 263 "G:\HospitalManagement(Cse370)\MySqlProject\MySqlProject\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("ScriptAfterBody", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
