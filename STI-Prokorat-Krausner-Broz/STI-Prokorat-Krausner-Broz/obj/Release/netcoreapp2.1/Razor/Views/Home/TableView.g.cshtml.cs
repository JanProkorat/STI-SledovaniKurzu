#pragma checksum "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef13c87401323ece24f9f54a622e173fd751fb04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TableView), @"mvc.1.0.view", @"/Views/Home/TableView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TableView.cshtml", typeof(AspNetCore.Views_Home_TableView))]
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
#line 1 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz;

#line default
#line hidden
#line 2 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz.Models;

#line default
#line hidden
#line 2 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef13c87401323ece24f9f54a622e173fd751fb04", @"/Views/Home/TableView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080e8c16754dd410d86b0910d4a98d6a0ab200ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TableView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<STIProkoratKrausnerBroz.Models.TableData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Tabulky";

#line default
#line hidden
            BeginContext(159, 973, true);
            WriteLiteral(@"
<div class=""checkBoxDiv"">
    <div class=""labelText"">ČNB&nbsp;&nbsp;</div>
    <label class=""switch"" id=""cnbChecker"">
        <input type=""checkbox"">
        <span class=""slider round""></span>
    </label>
    <div class=""labelText"">ČSOB&nbsp;&nbsp;</div>
    <label class=""switch"" id=""csobChecker"">
        <input type=""checkbox"">
        <span class=""slider round""></span>
    </label>
    <div class=""labelText"">ČS&nbsp;&nbsp;</div>
    <label class=""switch"" id=""csChecker"">
        <input type=""checkbox"">
        <span class=""slider round""></span>
    </label>
    <div class=""labelText"">KB&nbsp;&nbsp;</div>
    <label class=""switch"" id=""kbChecker"">
        <input type=""checkbox"">
        <span class=""slider round""></span>
    </label>
    <div class=""labelText"">RB&nbsp;&nbsp;</div>
    <label class=""switch"">
        <input type=""checkbox"" id=""rbChecker"">
        <span class=""slider round""></span>
    </label>
</div>


<h2>Banka: ");
            EndContext();
            BeginContext(1133, 28, false);
#line 37 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      Write(Model.bankNames[0].ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1161, 18, true);
            WriteLiteral("</h2>\r\n<h2>Datum: ");
            EndContext();
            BeginContext(1180, 14, false);
#line 38 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      Write(Model.dates[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 76, true);
            WriteLiteral("</h2>\r\n<div id=\"tablediv\">\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 43 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[0].Columns)
            {

#line default
#line hidden
            BeginContext(1355, 21, true);
            WriteLiteral("                <th> ");
            EndContext();
            BeginContext(1377, 14, false);
#line 45 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 46 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
        }

#line default
#line hidden
            BeginContext(1410, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 50 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in Model.Tables[0].Rows)
            {

#line default
#line hidden
            BeginContext(1539, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 53 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[0].Columns)
                {

#line default
#line hidden
            BeginContext(1650, 25, true);
            WriteLiteral("                    <td> ");
            EndContext();
            BeginContext(1676, 19, false);
#line 55 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 56 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(1722, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 58 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(1760, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<STIProkoratKrausnerBroz.Models.TableData> Html { get; private set; }
    }
}
#pragma warning restore 1591