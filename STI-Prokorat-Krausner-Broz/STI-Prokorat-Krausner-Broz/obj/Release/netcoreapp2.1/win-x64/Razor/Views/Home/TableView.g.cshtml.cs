#pragma checksum "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37b46d0fb525732d9e3304155065c67b46a28e3"
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
#line 1 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz;

#line default
#line hidden
#line 2 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz.Models;

#line default
#line hidden
#line 2 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a37b46d0fb525732d9e3304155065c67b46a28e3", @"/Views/Home/TableView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080e8c16754dd410d86b0910d4a98d6a0ab200ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TableView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<STIProkoratKrausnerBroz.Models.TableData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Kraušner, Prokorát, Brož";

#line default
#line hidden
            BeginContext(176, 1253, true);
            WriteLiteral(@"
<div class=""checkBoxDiv"">
        <label class=""container"">
            RB
            <input type=""radio"" name=""radio"" id=""cnbRadio"" onclick=""showTable('rbTableDiv')"">
            <span class=""checkmark""></span>
        </label>
        <label class=""container"">
            ČS
            <input type=""radio"" name=""radio"" id=""csobRadio"" onclick=""showTable('csTableDiv')"">
            <span class=""checkmark""></span>
        </label>
        <label class=""container"">
            ČSOB
            <input type=""radio"" name=""radio"" id=""csRadio"" onclick=""showTable('csobTableDiv')"">
            <span class=""checkmark""></span>
        </label>
        <label class=""container"">
            KB
            <input type=""radio"" name=""radio"" id=""kbRadio"" onclick=""showTable('kbTableDiv')"">
            <span class=""checkmark""></span>
        </label>
        <label class=""container"">
            ČNB
            <input type=""radio"" checked=""checked"" name=""radio"" id=""rbRadio"" onclick=""showTable('cnbTable");
            WriteLiteral("Div\')\">\r\n            <span class=\"checkmark\"></span>\r\n        </label>\r\n</div>\r\n<button class=\"button\" type=\"button\" onclick=\"exportTable()\">Exportovat tabulku</button>\r\n\r\n<div class=\"tableDiv\" id=\"kbTableDiv\">\r\n\r\n    <h2>Banka: ");
            EndContext();
            BeginContext(1430, 34, false);
#line 39 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[0].bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1464, 22, true);
            WriteLiteral("</h2>\r\n    <h2>Datum: ");
            EndContext();
            BeginContext(1487, 43, false);
#line 40 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[0].date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 55, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 44 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[0].table.Columns)
                {

#line default
#line hidden
            BeginContext(1680, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(1706, 14, false);
#line 46 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 47 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(1747, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
             foreach (DataRow row in Model.Tables[0].table.Rows)
            {

#line default
#line hidden
            BeginContext(1882, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 54 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                     foreach (DataColumn col in Model.Tables[0].table.Columns)
                    {

#line default
#line hidden
            BeginContext(2007, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(2037, 19, false);
#line 56 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(2056, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 57 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(2087, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 59 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(2125, 99, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"tableDiv\" id=\"csobTableDiv\">\r\n    <h2>Banka: ");
            EndContext();
            BeginContext(2225, 34, false);
#line 65 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[1].bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2259, 22, true);
            WriteLiteral("</h2>\r\n    <h2>Datum: ");
            EndContext();
            BeginContext(2282, 43, false);
#line 66 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[1].date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 55, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 70 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[1].table.Columns)
                {

#line default
#line hidden
            BeginContext(2475, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(2501, 14, false);
#line 72 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(2515, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 73 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(2542, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 77 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
             foreach (DataRow row in Model.Tables[1].table.Rows)
            {

#line default
#line hidden
            BeginContext(2677, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 80 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                     foreach (DataColumn col in Model.Tables[1].table.Columns)
                    {

#line default
#line hidden
            BeginContext(2802, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(2832, 19, false);
#line 82 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(2851, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 83 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(2882, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 85 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(2920, 98, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"tableDiv\" id=\"cnbTableDiv\">\r\n    <h2>Banka: ");
            EndContext();
            BeginContext(3019, 34, false);
#line 91 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[2].bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3053, 22, true);
            WriteLiteral("</h2>\r\n    <h2>Datum: ");
            EndContext();
            BeginContext(3076, 43, false);
#line 92 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[2].date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3119, 55, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 96 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[2].table.Columns)
                {

#line default
#line hidden
            BeginContext(3269, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(3295, 14, false);
#line 98 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(3309, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 99 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(3336, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 103 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
             foreach (DataRow row in Model.Tables[2].table.Rows)
            {

#line default
#line hidden
            BeginContext(3471, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 106 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                     foreach (DataColumn col in Model.Tables[2].table.Columns)
                    {

#line default
#line hidden
            BeginContext(3596, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(3626, 19, false);
#line 108 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(3645, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 109 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(3676, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 111 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(3714, 97, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"tableDiv\" id=\"rbTableDiv\">\r\n    <h2>Banka: ");
            EndContext();
            BeginContext(3812, 34, false);
#line 117 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[3].bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3846, 22, true);
            WriteLiteral("</h2>\r\n    <h2>Datum: ");
            EndContext();
            BeginContext(3869, 43, false);
#line 118 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[3].date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3912, 55, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 122 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[3].table.Columns)
                {

#line default
#line hidden
            BeginContext(4062, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(4088, 14, false);
#line 124 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(4102, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 125 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(4129, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 129 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
             foreach (DataRow row in Model.Tables[3].table.Rows)
            {

#line default
#line hidden
            BeginContext(4264, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 132 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                     foreach (DataColumn col in Model.Tables[3].table.Columns)
                    {

#line default
#line hidden
            BeginContext(4389, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(4419, 19, false);
#line 134 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(4438, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 135 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(4469, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 137 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(4507, 97, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"tableDiv\" id=\"csTableDiv\">\r\n    <h2>Banka: ");
            EndContext();
            BeginContext(4605, 34, false);
#line 143 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[4].bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(4639, 22, true);
            WriteLiteral("</h2>\r\n    <h2>Datum: ");
            EndContext();
            BeginContext(4662, 43, false);
#line 144 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
          Write(Model.Tables[4].date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4705, 55, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 148 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                 foreach (DataColumn col in Model.Tables[4].table.Columns)
                {

#line default
#line hidden
            BeginContext(4855, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(4881, 14, false);
#line 150 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(4895, 8, true);
            WriteLiteral(" </th>\r\n");
            EndContext();
#line 151 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(4922, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 155 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
             foreach (DataRow row in Model.Tables[4].table.Rows)
            {

#line default
#line hidden
            BeginContext(5057, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 158 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                     foreach (DataColumn col in Model.Tables[4].table.Columns)
                    {

#line default
#line hidden
            BeginContext(5182, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(5212, 19, false);
#line 160 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(5231, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 161 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(5262, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 163 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(5300, 92, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<script>\r\n    showTable(\'cnbTableDiv\');\r\n</script>");
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
