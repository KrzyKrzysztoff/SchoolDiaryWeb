#pragma checksum "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1aaa445a354b26405fa0eac732ad9e083a2b611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetNote), @"mvc.1.0.view", @"/Views/Admin/GetNote.cshtml")]
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
#line 1 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\_ViewImports.cshtml"
using SchoolDiaryMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\_ViewImports.cshtml"
using SchoolDiaryMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\_ViewImports.cshtml"
using SchoolDiaryMVC.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1aaa445a354b26405fa0eac732ad9e083a2b611", @"/Views/Admin/GetNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518e9a40a4f3eff77afad807161a23cc020a9e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentGradeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/grade-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteNote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1aaa445a354b26405fa0eac732ad9e083a2b6117040", async() => {
                WriteLiteral("\r\n    <title>Lista uwag</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1aaa445a354b26405fa0eac732ad9e083a2b6117335", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1aaa445a354b26405fa0eac732ad9e083a2b6119217", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
     if (ViewData["Success"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3 class=\"alert alert-primary\">");
#nullable restore
#line 10 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(ViewData["Success"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
     if (ViewData["Error"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3 class=\"alert alert-danger\">");
#nullable restore
#line 14 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                  Write(ViewData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table class=""table centre"">
        <thead>
            <tr>

                <th scope=""col"">Imi??</th>
                <th scope=""col"">Naziwsko</th>
                <th scope=""col"">Pesel</th>
                <th scope=""col"">Index</th>
                <th scope=""col"">Typ u??ytkownika</th>
                <th scope=""col"">Kurs</th>
                <th scope=""col"">Uwaga</th>
                <th scope=""col"">Opis</th>
                <th scope=""col"">Data</th>
                <th scope=""col"">Lekcja</th>
                <th scope=""col"">Akcje</th>

            </tr>
        </thead>
        <tbody>
            <tr>
                <td class=""text-center"">");
#nullable restore
#line 36 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 37 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 38 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(Model.Pesel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 39 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(Model.Index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 40 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                   Write(Model.UserType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n");
#nullable restore
#line 42 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                     switch (Model.Course)
                    {
                        case CourseEnum.None:

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>Brak</p>\r\n");
#nullable restore
#line 46 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                            break;
                        case CourseEnum.Business:

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>Biznes</p>\r\n");
#nullable restore
#line 49 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                            break;
                        case CourseEnum.Finance:

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>Finanse</p>\r\n");
#nullable restore
#line 52 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                            break;
                        case CourseEnum.ComputerScience:

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>Inforamtyka</p>\r\n");
#nullable restore
#line 55 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                            break;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                 foreach (var item in Model.Notes)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                     if (item.IsPositive == true)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td class=\"text-center\">\r\n                            <p>Uwaga pozytywna</p>\r\n                        </td>\r\n");
#nullable restore
#line 68 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td class=\"text-center\">\r\n                            <p>Uwaga negatywna</p>\r\n                        </td>\r\n");
#nullable restore
#line 74 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td class=\"text-center\">\r\n                        <p>");
#nullable restore
#line 76 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                      Write(item.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n\r\n                        <p>");
#nullable restore
#line 80 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                      Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <p>");
#nullable restore
#line 83 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                      Write(item.LessonName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </td>\r\n");
#nullable restore
#line 85 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1aaa445a354b26405fa0eac732ad9e083a2b61118232", async() => {
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1aaa445a354b26405fa0eac732ad9e083a2b61118523", async() => {
                        WriteLiteral("Usu?? uwage");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetNote.cshtml"
                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentGradeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
