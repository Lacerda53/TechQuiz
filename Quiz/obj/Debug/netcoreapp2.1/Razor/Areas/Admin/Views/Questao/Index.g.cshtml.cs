#pragma checksum "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9a51b5d4771fc510312de4b75bca57ce3f1287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Questao_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Questao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Questao/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Questao_Index))]
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
#line 1 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\_ViewImports.cshtml"
using Quiz;

#line default
#line hidden
#line 2 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\_ViewImports.cshtml"
using Quiz.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9a51b5d4771fc510312de4b75bca57ce3f1287", @"/Areas/Admin/Views/Questao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f52ae242e5147d661119ba78bd93d4ad46b6e37", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Questao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Quiz.Areas.Admin.Models.Questao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 515, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        List of Questions
        <small>List of all registred questions.</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-file-text-o""></i> Questions</a></li>
        <li><a href=""#"">List</a></li>

    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <!-- Default box -->
    <div class=""box"">

        <div class=""box-body"">
            <p>
                ");
            EndContext();
            BeginContext(611, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ad8cc916504abf96931a6ed7213976", async() => {
                BeginContext(714, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 164, true);
            WriteLiteral("\r\n            </p>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(893, 45, false);
#line 31 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Enunciado));

#line default
#line hidden
            EndContext();
            BeginContext(938, 146, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 37 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1157, 58, true);
            WriteLiteral("                        <tr>\r\n                            ");
            EndContext();
            BeginContext(1216, 43, false);
#line 40 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                       Write(Html.HiddenFor(modelItem => item.IDQuestao));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 68, true);
            WriteLiteral("\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1328, 44, false);
#line 42 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Enunciado));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 166, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <span class=\"pull-right\">\r\n                                    ");
            EndContext();
            BeginContext(1539, 132, false);
#line 46 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                               Write(Html.ActionLink(" ", "Edit", new { IDQuestao = item.IDQuestao }, new { @class = "btn btn-warning fa fa-pencil", @title = "Editar" }));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(1712, 135, false);
#line 47 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                               Write(Html.ActionLink(" ", "Details", new { IDQuestao = item.IDQuestao }, new { @class = "btn btn-primary fa fa-file", @title = "Detalhes" }));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(1888, 133, false);
#line 48 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                               Write(Html.ActionLink(" ", "Delete", new { IDQuestao = item.IDQuestao }, new { @class = "btn btn-danger fa fa-trash", @title = "Deletar" }));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 109, true);
            WriteLiteral("\r\n                                </span>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 52 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Questao\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2153, 158, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.box-footer-->\r\n    </div>\r\n    <!-- /.box -->\r\n</section>\r\n<!-- /.content -->\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Quiz.Areas.Admin.Models.Questao>> Html { get; private set; }
    }
}
#pragma warning restore 1591