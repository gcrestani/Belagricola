#pragma checksum "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35486f41b06ff723faa2898ee542745202551452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Index), @"mvc.1.0.view", @"/Views/Contatos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contatos/Index.cshtml", typeof(AspNetCore.Views_Contatos_Index))]
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
#line 1 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\_ViewImports.cshtml"
using BelagricolaMVC;

#line default
#line hidden
#line 2 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\_ViewImports.cshtml"
using BelagricolaMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35486f41b06ff723faa2898ee542745202551452", @"/Views/Contatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6426c420e1aac2de9c72c2c286f1da93ac706a", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BelagricolaMVC.Models.Contato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 109, true);
            WriteLiteral("\r\n<h2>Contatos</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(204, 40, false);
#line 14 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(244, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(300, 50, false);
#line 17 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Relacionamento));

#line default
#line hidden
            EndContext();
            BeginContext(350, 117, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Cliente\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(468, 50, false);
#line 23 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ListaTelefones));

#line default
#line hidden
            EndContext();
            BeginContext(518, 91, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(641, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(690, 39, false);
#line 32 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(729, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(785, 49, false);
#line 35 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Relacionamento));

#line default
#line hidden
            EndContext();
            BeginContext(834, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(890, 47, false);
#line 38 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(937, 41, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
            EndContext();
#line 42 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
                 foreach (var tel in item.ListaTelefones)
                {
                    

#line default
#line hidden
            BeginContext(1077, 53, false);
#line 44 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
               Write(Html.Raw("<a class=\"badge\" href=\"Telefones/Edit/"));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 6, false);
#line 45 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
               Write(tel.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1182, 15, false);
#line 46 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
               Write(Html.Raw("\">"));

#line default
#line hidden
            EndContext();
#line 46 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
                                    ;
                    

#line default
#line hidden
            BeginContext(1221, 7, false);
#line 47 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
               Write(tel.Tel);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 22, false);
#line 48 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
               Write(Html.Raw("</a>&nbsp;"));

#line default
#line hidden
            EndContext();
#line 48 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
                                           
                }

#line default
#line hidden
            BeginContext(1294, 32, true);
            WriteLiteral("                <a class=\"badge\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1326, "\"", 1358, 2);
            WriteAttributeValue("", 1333, "Telefones/Create/", 1333, 17, true);
#line 50 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
WriteAttributeValue("", 1350, item.Id, 1350, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1359, 61, true);
            WriteLiteral(">+</a>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1420, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29291b4500454d18b32c6540a8658be0", async() => {
                BeginContext(1465, 13, true);
                WriteLiteral("<b>Editar</b>");
                EndContext();
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
#line 53 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1482, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1502, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dba71209f46415db6b123f8529de6e5", async() => {
                BeginContext(1549, 14, true);
                WriteLiteral("<b>Excluir</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1567, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "D:\Curso CSharp\Belagricola\BelagricolaMVC\BelagricolaMVC\BelagricolaMVC\Views\Contatos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1606, 33, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1639, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eddf8a44855547b393ce02b420c7557b", async() => {
                BeginContext(1686, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1699, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BelagricolaMVC.Models.Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
