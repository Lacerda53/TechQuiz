#pragma checksum "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c503f70ddc04ad302d74ee08310b14da55bb2a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Alternativa_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Alternativa/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Alternativa/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Alternativa_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c503f70ddc04ad302d74ee08310b14da55bb2a9", @"/Areas/Admin/Views/Alternativa/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f52ae242e5147d661119ba78bd93d4ad46b6e37", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Alternativa_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quiz.Areas.Admin.Models.Alternativa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 569, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Details of alternative
        <small>Details of alternative.</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-check-square-o""></i> Alterneatives</a></li>
        <li><a href=""#"">Edit</a></li>

    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <!-- Default box -->
    <div class=""box"">

        <div class=""box-body"">
            <dl class=""dl-horizontal"">
                <dd>
                    ");
            EndContext();
            BeginContext(659, 44, false);
#line 27 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.HiddenFor(model => model.IDAlternativa));

#line default
#line hidden
            EndContext();
            BeginContext(703, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(771, 44, false);
#line 30 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Resposta));

#line default
#line hidden
            EndContext();
            BeginContext(815, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(883, 40, false);
#line 33 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayFor(model => model.Resposta));

#line default
#line hidden
            EndContext();
            BeginContext(923, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(991, 43, false);
#line 36 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Correta));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1102, 39, false);
#line 39 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayFor(model => model.Correta));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1209, 45, false);
#line 42 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IDQuestao));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1322, 41, false);
#line 45 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
               Write(Html.DisplayFor(model => model.IDQuestao));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 71, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1435, 76, false);
#line 49 "C:\Dev\Quiz\Quiz\Areas\Admin\Views\Alternativa\Details.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { IDAlternativa = Model.IDAlternativa }));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(1527, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d12fe59927b4f6086e246c72f31208f", async() => {
                BeginContext(1573, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1581, 120, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!-- /.box-footer-->\r\n    </div>\r\n    <!-- /.box -->\r\n</section>\r\n<!-- /.content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quiz.Areas.Admin.Models.Alternativa> Html { get; private set; }
    }
}
#pragma warning restore 1591
