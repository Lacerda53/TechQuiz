#pragma checksum "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fded95c2dd1c4c97650e7f7e7e4b24a7808eb115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/Index.cshtml", typeof(AspNetCore.Views_Quiz_Index))]
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
#line 1 "C:\Dev\Quiz\Quiz\Views\_ViewImports.cshtml"
using Quiz;

#line default
#line hidden
#line 2 "C:\Dev\Quiz\Quiz\Views\_ViewImports.cshtml"
using Quiz.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fded95c2dd1c4c97650e7f7e7e4b24a7808eb115", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af933ed20ea9357856e76c30db85e3ad8cfd27cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quiz.Models.Test>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-xs button-default-outline button-nina"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Quiz";

#line default
#line hidden
            BeginContext(67, 269, true);
            WriteLiteral(@"<div class=""section section-variant-1 bg-white"">
    <div class=""shell shell-wide text-center"">
        <h3>Quiz</h3>
        <div class=""divider divider-default""></div>
        <div class=""row"">
            <div class=""col-md-5 col-md-offset-1"">
                ");
            EndContext();
            BeginContext(336, 2979, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c68fafa441d748b19fd22d626854183c", async() => {
                BeginContext(361, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(383, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0effffe585d542ab847f379bd9b21512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 13 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(449, 47, true);
                WriteLiteral("\r\n                    <div class=\"text-left\">\r\n");
                EndContext();
#line 15 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                          
                            int index_questao = 0;
                            int index_alternativa = 0;
                        

#line default
#line hidden
                BeginContext(659, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 19 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                         foreach (var Questao in Model.Questoes)
                        {

#line default
#line hidden
                BeginContext(752, 51, true);
                WriteLiteral("                            <h4 class=\"text-muted\">");
                EndContext();
                BeginContext(804, 17, false);
#line 21 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                              Write(Questao.Enunciado);

#line default
#line hidden
                EndContext();
                BeginContext(821, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 22 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                             if (Questao.Msg == "Right Answer")
                            {

#line default
#line hidden
                BeginContext(924, 108, true);
                WriteLiteral("                                <h4>\r\n                                    <span class=\"label label-success\">");
                EndContext();
                BeginContext(1033, 11, false);
#line 25 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                                                 Write(Questao.Msg);

#line default
#line hidden
                EndContext();
                BeginContext(1044, 48, true);
                WriteLiteral("</span>\r\n                                </h4>\r\n");
                EndContext();
#line 27 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1188, 107, true);
                WriteLiteral("                                <h4>\r\n                                    <span class=\"label label-danger\">");
                EndContext();
                BeginContext(1296, 11, false);
#line 31 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                                                Write(Questao.Msg);

#line default
#line hidden
                EndContext();
                BeginContext(1307, 48, true);
                WriteLiteral("</span>\r\n                                </h4>\r\n");
                EndContext();
#line 33 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1386, 84, true);
                WriteLiteral("                            <br />\r\n                            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1470, "\"", 1489, 1);
#line 35 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1478, Questao.ID, 1478, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1490, "\"", 1524, 3);
                WriteAttributeValue("", 1497, "Questoes[", 1497, 9, true);
#line 35 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1506, index_questao, 1506, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1520, "].ID", 1520, 4, true);
                EndWriteAttribute();
                BeginContext(1525, 53, true);
                WriteLiteral(" />\r\n                            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1578, "\"", 1604, 1);
#line 36 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1586, Questao.Enunciado, 1586, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1605, "\"", 1646, 3);
                WriteAttributeValue("", 1612, "Questoes[", 1612, 9, true);
#line 36 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1621, index_questao, 1621, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1635, "].Enunciado", 1635, 11, true);
                EndWriteAttribute();
                BeginContext(1647, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 37 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                            { index_alternativa = 0; }
                            

#line default
#line hidden
#line 38 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                             foreach (var Alternativa in Questao.Alternativas)
                            {


#line default
#line hidden
                BeginContext(1821, 120, true);
                WriteLiteral("                                <div class=\"custom-control custom-radio\">\r\n                                    <label>\r\n");
                EndContext();
#line 43 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                           ViewBag.Checked = Alternativa.Resposta == Questao.Resposta ? "checked" : string.Empty; 

#line default
#line hidden
                BeginContext(2074, 59, true);
                WriteLiteral("                                        <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2133, "\"", 2162, 1);
#line 44 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2141, Alternativa.Resposta, 2141, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2163, 29, true);
                WriteLiteral(" class=\"custom-control-input\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2192, "\"", 2232, 3);
                WriteAttributeValue("", 2199, "Questoes[", 2199, 9, true);
#line 44 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2208, index_questao, 2208, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2222, "].Resposta", 2222, 10, true);
                EndWriteAttribute();
                BeginContext(2233, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2235, 15, false);
#line 44 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                                                                                                                                           Write(ViewBag.Checked);

#line default
#line hidden
                EndContext();
                BeginContext(2250, 65, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2315, "\"", 2344, 1);
#line 45 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2323, Alternativa.Resposta, 2323, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2345, "\"", 2418, 5);
                WriteAttributeValue("", 2352, "Questoes[", 2352, 9, true);
#line 45 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2361, index_questao, 2361, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2375, "].Alternativas[", 2375, 15, true);
#line 45 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2390, index_alternativa, 2390, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 2408, "].Resposta", 2408, 10, true);
                EndWriteAttribute();
                BeginContext(2419, 65, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2484, "\"", 2507, 1);
#line 46 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2492, Alternativa.ID, 2492, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2508, "\"", 2575, 5);
                WriteAttributeValue("", 2515, "Questoes[", 2515, 9, true);
#line 46 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2524, index_questao, 2524, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2538, "].Alternativas[", 2538, 15, true);
#line 46 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2553, index_alternativa, 2553, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 2571, "].ID", 2571, 4, true);
                EndWriteAttribute();
                BeginContext(2576, 45, true);
                WriteLiteral(" />\r\n                                        ");
                EndContext();
                BeginContext(2622, 20, false);
#line 47 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                   Write(Alternativa.Resposta);

#line default
#line hidden
                EndContext();
                BeginContext(2642, 88, true);
                WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n");
                EndContext();
#line 50 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                                { index_alternativa++; }
                            }

#line default
#line hidden
                BeginContext(2819, 36, true);
                WriteLiteral("                            <br />\r\n");
                EndContext();
#line 53 "C:\Dev\Quiz\Quiz\Views\Quiz\Index.cshtml"
                            { index_questao++; }
                        }

#line default
#line hidden
                BeginContext(2932, 210, true);
                WriteLiteral("                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <input type=\"submit\" value=\"Reply\" class=\"button button-primary btn-flat button-nina\" />\r\n                        ");
                EndContext();
                BeginContext(3142, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7793b04272426287c428d14e6cb726", async() => {
                    BeginContext(3246, 12, true);
                    WriteLiteral("Back to Home");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3262, 46, true);
                WriteLiteral("\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3315, 4307, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div id=""links-fixos"">
    <!-- Botão para acionar modal -->
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#SiteModal"">
        Go to the text
    </button>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""SiteModal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""TituloModalLongoExemplo"">Read the text below:</h5>
                <div class=""divider divider-default""></div>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>x</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""text-justify recuo"">
                    We think of smartphones as something recent, up-to-date, but believe it or not, the first
                    smartphone was ac");
            WriteLiteral(@"tually invented about two decades ago, when the term ""smartphone"" did not
                    even exist. In an article in the technology section of <i>Bloomberg Businessweek</i> (June 29,2012),
                    Ira Sager states that there was a smartphone called Simon (a reference to the game ""Simon says..."")
                    which had the features of a computer, cell phone, fax machine, and pager. It was a black brick
                    weighting 18 ounces (approximately 510 grams). Sager claims Simon appeared some years before cell
                    phones where called ""smart"", anticipating the term created only in 1997, and many years before
                    iPhones, iPads, and Android-based phones appeared on the market to change the concept of cell
                    phones and their capabilities.
                </p>
                <p class=""text-justify recuo"">
                    <i>Wikipedia</i> also mentions Simon and its history. According to an entry on Smartphones,
     ");
            WriteLiteral(@"               Simon's prototype was named ""Angler"" and was presented at the COMDEX computer and technology
                    trade show in Las Vegas, on November 2, 1992. It was later re-baptized as The Simon Personal
                    Communicator at the Wireless World Conference in November 1992. This handheld cellular phone
                    and PDA was created by IBM, assembled by Mitsubish Electric Corp., and distributed by Bell South
                    in the USA between August 1994 and February 1995.
                </p>
                <p class=""text-justify recuo"">
                    Simon already had a monochromatic touch screen, which enabled the user to input information by
                    either tapping the icons or poking them with a stylus. Its innovations included features and
                    applications such as email, clock, an address book, appointment scheduler, calender, calculator,
                    world time clock, electronic note pad, handwritten annotatio");
            WriteLiteral(@"ns, standard and predictive typing
                    (with touch screen keyboards that guessed the next characters to be typed), and a basic game
                    called Scramble, which consisted of moving squares to form a picture on the screen. Simon
                    already had the equivalent of our modern apps, or what Sager calls a ""way to deliver more
                    features"" such as maps, music and a camera. All this was possible with the insertion of a
                    memory card into the phone.
                </p>
                <p class=""text-justify recuo"">
                    Sager mentions that Simon's battery lasted from 30 to 60 minutes, depending on the amount
                    of data used and the area covered. He adds that Simon can still be purchased nowadays through
                    collectors who sell them for the same price they were retailed two decades ago, when about
                    50,000 units were sold at $899 each.
                </p>
    ");
            WriteLiteral("        </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quiz.Models.Test> Html { get; private set; }
    }
}
#pragma warning restore 1591
