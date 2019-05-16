#pragma checksum "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a1f15331600776d5bf8ac4e638bebbc15eb3de"
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
#line 1 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz;

#line default
#line hidden
#line 2 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/_ViewImports.cshtml"
using STI_Prokorat_Krausner_Broz.Models;

#line default
#line hidden
#line 2 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
using STIProkoratKrausnerBroz.Models;

#line default
#line hidden
#line 3 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a1f15331600776d5bf8ac4e638bebbc15eb3de", @"/Views/Home/TableView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e6b529a7d93b3cba08e4ac68d320e2c92f45dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TableView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<STIProkoratKrausnerBroz.Models.TableData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Kraušner, Prokorát, Brož";

#line default
#line hidden
            BeginContext(208, 1165, true);
            WriteLiteral(@"
<div class=""checkBoxDiv"" id=""tablePickDiv"">
    <label class=""container"" id=""rbLabel"">
        RB
        <input type=""radio"" name=""radio"" id=""rb"" onclick=""showTable('rbTableDiv')"">
        <span class=""checkmark""></span>
    </label>
    <label class=""container"" id=""csLabel"">
        ČS
        <input type=""radio"" name=""radio"" id=""cs"" onclick=""showTable('csTableDiv')"">
        <span class=""checkmark""></span>
    </label>
    <label class=""container"" id=""csobLabel"">
        ČSOB
        <input type=""radio"" name=""radio"" id=""csob"" onclick=""showTable('csobTableDiv')"">
        <span class=""checkmark""></span>
    </label>
    <label class=""container"" id=""kbLabel"">
        KB
        <input type=""radio"" name=""radio"" id=""kb"" onclick=""showTable('kbTableDiv')"">
        <span class=""checkmark""></span>
    </label>
    <label class=""container"" id=""cnbLabel"">
        ČNB
        <input type=""radio"" name=""radio"" checked=""checked"" id=""cnb"" onclick=""showTable('cnbTableDiv')"">
        <span class=""checkmark""></span>
    </l");
            WriteLiteral("abel>\n</div>\n<button class=\"button\" type=\"button\" onclick=\"exportTable()\">Exportovat tabulku</button>\n<div class=\"tableDiv\" id=\"rbTableDiv\">\n");
            EndContext();
#line 38 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      
        TableObject bank = Model.Tables.Find(TableObject => TableObject.bankName.ToUpper() == "RB" &&
        TableObject.date == Model.Tables.Max(t => t.date));
    

#line default
#line hidden
            BeginContext(1548, 15, true);
            WriteLiteral("    <h2>Banka: ");
            EndContext();
            BeginContext(1564, 23, false);
#line 42 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank.bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1587, 21, true);
            WriteLiteral("</h2>\n    <h2>Datum: ");
            EndContext();
            BeginContext(1609, 32, false);
#line 43 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank.date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 51, true);
            WriteLiteral("</h2>\n    <table>\n        <thead>\n            <tr>\n");
            EndContext();
#line 47 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in bank.table.Columns)
                {

#line default
#line hidden
            BeginContext(1774, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(1800, 14, false);
#line 49 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 7, true);
            WriteLiteral(" </th>\n");
            EndContext();
#line 50 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(1839, 51, true);
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 54 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in bank.table.Rows)
            {

#line default
#line hidden
            BeginContext(1958, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 57 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                     foreach (DataColumn col in bank.table.Columns)
                    {

#line default
#line hidden
            BeginContext(2069, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(2099, 19, false);
#line 59 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(2118, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 60 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(2147, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 62 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(2183, 77, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n<div class=\"tableDiv\" id=\"kbTableDiv\">\n");
            EndContext();
#line 68 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      
        TableObject bank2 = Model.Tables.Find(TableObject => TableObject.bankName.ToUpper() == "KB" &&
        TableObject.date == Model.Tables.Max(t => t.date));
    

#line default
#line hidden
            BeginContext(2436, 15, true);
            WriteLiteral("    <h2>Banka: ");
            EndContext();
            BeginContext(2452, 24, false);
#line 72 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank2.bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2476, 21, true);
            WriteLiteral("</h2>\n    <h2>Datum: ");
            EndContext();
            BeginContext(2498, 33, false);
#line 73 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank2.date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 51, true);
            WriteLiteral("</h2>\n    <table>\n        <thead>\n            <tr>\n");
            EndContext();
#line 77 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in bank2.table.Columns)
                {

#line default
#line hidden
            BeginContext(2665, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(2691, 14, false);
#line 79 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(2705, 7, true);
            WriteLiteral(" </th>\n");
            EndContext();
#line 80 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(2730, 51, true);
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 84 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in bank2.table.Rows)
            {

#line default
#line hidden
            BeginContext(2850, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 87 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                     foreach (DataColumn col in bank2.table.Columns)
                    {

#line default
#line hidden
            BeginContext(2962, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(2992, 19, false);
#line 89 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(3011, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 90 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(3040, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 92 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(3076, 79, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n<div class=\"tableDiv\" id=\"csobTableDiv\">\n");
            EndContext();
#line 98 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      
        TableObject bank3 = Model.Tables.Find(TableObject => TableObject.bankName.ToUpper() == "CSOB" &&
        TableObject.date == Model.Tables.Max(t => t.date));
    

#line default
#line hidden
            BeginContext(3333, 15, true);
            WriteLiteral("    <h2>Banka: ");
            EndContext();
            BeginContext(3349, 24, false);
#line 102 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank3.bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3373, 21, true);
            WriteLiteral("</h2>\n    <h2>Datum: ");
            EndContext();
            BeginContext(3395, 33, false);
#line 103 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank3.date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3428, 51, true);
            WriteLiteral("</h2>\n    <table>\n        <thead>\n            <tr>\n");
            EndContext();
#line 107 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in bank3.table.Columns)
                {

#line default
#line hidden
            BeginContext(3562, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(3588, 14, false);
#line 109 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(3602, 7, true);
            WriteLiteral(" </th>\n");
            EndContext();
#line 110 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(3627, 51, true);
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 114 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in bank3.table.Rows)
            {

#line default
#line hidden
            BeginContext(3747, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 117 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                     foreach (DataColumn col in bank3.table.Columns)
                    {

#line default
#line hidden
            BeginContext(3859, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(3889, 19, false);
#line 119 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(3908, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 120 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(3937, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 122 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(3973, 77, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n<div class=\"tableDiv\" id=\"csTableDiv\">\n");
            EndContext();
#line 128 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      
        TableObject bank4 = Model.Tables.Find(TableObject => TableObject.bankName.ToUpper() == "CS" &&
        TableObject.date == Model.Tables.Max(t => t.date));
    

#line default
#line hidden
            BeginContext(4226, 15, true);
            WriteLiteral("    <h2>Banka: ");
            EndContext();
            BeginContext(4242, 24, false);
#line 132 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank4.bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(4266, 21, true);
            WriteLiteral("</h2>\n    <h2>Datum: ");
            EndContext();
            BeginContext(4288, 33, false);
#line 133 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank4.date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4321, 51, true);
            WriteLiteral("</h2>\n    <table>\n        <thead>\n            <tr>\n");
            EndContext();
#line 137 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in bank4.table.Columns)
                {

#line default
#line hidden
            BeginContext(4455, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(4481, 14, false);
#line 139 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(4495, 7, true);
            WriteLiteral(" </th>\n");
            EndContext();
#line 140 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(4520, 51, true);
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 144 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in bank4.table.Rows)
            {

#line default
#line hidden
            BeginContext(4640, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 147 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                     foreach (DataColumn col in bank4.table.Columns)
                    {

#line default
#line hidden
            BeginContext(4752, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(4782, 19, false);
#line 149 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(4801, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 150 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(4830, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 152 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(4866, 78, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n<div class=\"tableDiv\" id=\"cnbTableDiv\">\n");
            EndContext();
#line 158 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
      
        TableObject bank5 = Model.Tables.Find(TableObject => TableObject.bankName.ToUpper() == "CNB" &&
        TableObject.date == Model.Tables.Max(t => t.date));
    

#line default
#line hidden
            BeginContext(5121, 15, true);
            WriteLiteral("    <h2>Banka: ");
            EndContext();
            BeginContext(5137, 24, false);
#line 162 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank5.bankName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(5161, 21, true);
            WriteLiteral("</h2>\n    <h2>Datum: ");
            EndContext();
            BeginContext(5183, 33, false);
#line 163 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
          Write(bank5.date.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5216, 51, true);
            WriteLiteral("</h2>\n    <table>\n        <thead>\n            <tr>\n");
            EndContext();
#line 167 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                 foreach (DataColumn col in bank5.table.Columns)
                {

#line default
#line hidden
            BeginContext(5350, 25, true);
            WriteLiteral("                    <th> ");
            EndContext();
            BeginContext(5376, 14, false);
#line 169 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    Write(col.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(5390, 7, true);
            WriteLiteral(" </th>\n");
            EndContext();
#line 170 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                }

#line default
#line hidden
            BeginContext(5415, 51, true);
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 174 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
             foreach (DataRow row in bank5.table.Rows)
            {

#line default
#line hidden
            BeginContext(5535, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 177 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                     foreach (DataColumn col in bank5.table.Columns)
                    {

#line default
#line hidden
            BeginContext(5647, 29, true);
            WriteLiteral("                        <td> ");
            EndContext();
            BeginContext(5677, 19, false);
#line 179 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                        Write(row[col.ColumnName]);

#line default
#line hidden
            EndContext();
            BeginContext(5696, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 180 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
                    }

#line default
#line hidden
            BeginContext(5725, 22, true);
            WriteLiteral("                </tr>\n");
            EndContext();
#line 182 "/Users/jan/Git/STI-SledovaniKurzu/STI-Prokorat-Krausner-Broz/Views/Home/TableView.cshtml"
            }

#line default
#line hidden
            BeginContext(5761, 814, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script type=""text/javascript"">

    var timeCheckboxValues = JSON.parse(localStorage.getItem('timeCheckboxValues')) || {};
    var $timecheckboxes = $(""#tablePickDiv :radio"");
    $timecheckboxes.on(""change"", function () {
        $timecheckboxes.each(function () {
            timeCheckboxValues[this.id] = this.checked;
        });
        localStorage.setItem(""timeCheckboxValues"", JSON.stringify(timeCheckboxValues));
    });

    $.each(timeCheckboxValues, function (key, value) {
        $(""#"" + key).prop('checked', value);
    });

    var timeBoxes = $(""#tablePickDiv :radio"");
    for (var i = 0; i < timeBoxes.length; i++) {
        if (timeBoxes[i].checked == true) {
            showTable(timeBoxes[i].id + 'TableDiv');
        }
    }
</script>");
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
