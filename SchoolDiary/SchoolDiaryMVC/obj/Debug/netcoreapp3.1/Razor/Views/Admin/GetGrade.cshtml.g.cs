#pragma checksum "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977068453a6cb9468b9ec183b23f31f42f1529ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetGrade), @"mvc.1.0.view", @"/Views/Admin/GetGrade.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977068453a6cb9468b9ec183b23f31f42f1529ad", @"/Views/Admin/GetGrade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518e9a40a4f3eff77afad807161a23cc020a9e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetGrade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GradeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteGrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977068453a6cb9468b9ec183b23f31f42f1529ad5880", async() => {
                WriteLiteral("\r\n        <title>Wyswietl oceny</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977068453a6cb9468b9ec183b23f31f42f1529ad6895", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977068453a6cb9468b9ec183b23f31f42f1529ad7439", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
             if (item.IsFinalGrade == true)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <h3 class=\"text-danger\">Ocena Końcowa</h3>");
#nullable restore
#line 12 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                                                 Write(item.Rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <h3>Email studenta</h3>");
#nullable restore
#line 13 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                              Write(item.StudentEmail);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Adres Email Nauczyciela: </h3> ");
#nullable restore
#line 14 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                                          Write(item.TeacherEmail);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Typ lekcji: </h3> ");
#nullable restore
#line 15 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                             Write(item.LessonType);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Data: </h3>");
#nullable restore
#line 16 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                      Write(item.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            }\r\n            <h3>Ocena</h3>");
#nullable restore
#line 18 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                     Write(item.Rating);

#line default
#line hidden
#nullable disable
                    WriteLiteral("}\r\n            <h3>Email studenta</h3>");
#nullable restore
#line 19 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                              Write(item.StudentEmail);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Adres Email Nauczyciela: </h3> ");
#nullable restore
#line 20 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                                          Write(item.TeacherEmail);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Typ lekcji: </h3> ");
#nullable restore
#line 21 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                             Write(item.LessonType);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            <h3>Data: </h3>");
#nullable restore
#line 22 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                      Write(item.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977068453a6cb9468b9ec183b23f31f42f1529ad11595", async() => {
                        WriteLiteral("Usuń");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\krzys\Desktop\Seminarium dyplomowe\SchoolDiaryWeb\SchoolDiary\SchoolDiaryMVC\Views\Admin\GetGrade.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GradeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
