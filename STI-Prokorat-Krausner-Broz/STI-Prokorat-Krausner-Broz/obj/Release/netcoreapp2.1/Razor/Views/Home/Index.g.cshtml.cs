#pragma checksum "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8782700ae8859c660643025ae8a74e50059c2c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8782700ae8859c660643025ae8a74e50059c2c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080e8c16754dd410d86b0910d4a98d6a0ab200ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<STIProkoratKrausnerBroz.Models.ToolsClass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Kraušner, Prokorát, Brož";

#line default
#line hidden
            BeginContext(177, 4383, true);
            WriteLiteral(@"<div class=""currencyContainer"" id=""audDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""aud-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""aud-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""dkkDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""dkk-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""dkk-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""eurDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""eur-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""eur-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""hrkDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""hrk-purchase-canvas""></canvas>
    </div>
    <d");
            WriteLiteral(@"iv class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""hrk-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""cadDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""cad-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""cad-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""hufDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""huf-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""huf-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""nokDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""nok-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""nok-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""plnDiv"">
    <div");
            WriteLiteral(@" class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""pln-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""pln-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""ronDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""ron-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""ron-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""rubDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""rub-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""rub-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""sekDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""sek-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""gr");
            WriteLiteral(@"aphCanvas"" id=""sek-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""chfDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""chf-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""chf-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""jpyDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""jpy-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""jpy-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""usdDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""usd-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""usd-sale-canvas""></canvas>
    </div>
</div>
<div class=""currencyContainer"" id=""gbpDiv"">
    <div class=""graphCanvasDiv"">
        <canvas class=""grap");
            WriteLiteral(@"hCanvas"" id=""gbp-purchase-canvas""></canvas>
    </div>
    <div class=""graphCanvasDiv"">
        <canvas class=""graphCanvas"" id=""gbp-sale-canvas""></canvas>
    </div>
</div>
<script type=""text/javascript"">
    let bankNames = [];
    let dates = [];
    let currencyNames = [];
");
            EndContext();
#line 131 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
      

        foreach (var d in Model.Currencies[0].Dates)
        {

#line default
#line hidden
            BeginContext(4635, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(4649, 12, true);
            WriteLiteral("dates.push(\"");
            EndContext();
            BeginContext(4662, 17, false);
#line 135 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                     Write(d.date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4679, 5, true);
            WriteLiteral("\");\r\n");
            EndContext();
#line 136 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
        }
        foreach(var curr in Model.Currencies){

#line default
#line hidden
            BeginContext(4743, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(4757, 39, true);
            WriteLiteral("var currenciesSales = [];\r\n            ");
            EndContext();
            BeginContext(4798, 43, true);
            WriteLiteral("var currenciesPurchases = [];\r\n            ");
            EndContext();
            BeginContext(4843, 44, true);
            WriteLiteral("var indexes = [0, 0, 0, 0, 0];\r\n            ");
            EndContext();
            BeginContext(4889, 45, true);
            WriteLiteral("for(var i = 0; i < 5; i++){\r\n                ");
            EndContext();
            BeginContext(4936, 43, true);
            WriteLiteral("currenciesSales.push([]);\r\n                ");
            EndContext();
            BeginContext(4981, 43, true);
            WriteLiteral("currenciesPurchases.push([]);\r\n            ");
            EndContext();
            BeginContext(5026, 3, true);
            WriteLiteral("}\r\n");
            EndContext();
#line 145 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
            foreach(var date in curr.Dates){
                foreach(var bank in date.Banks){

#line default
#line hidden
            BeginContext(5125, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(5147, 51, true);
            WriteLiteral("if(bankNames.length < 5){\r\n                        ");
            EndContext();
            BeginContext(5200, 16, true);
            WriteLiteral("bankNames.push(\"");
            EndContext();
            BeginContext(5217, 9, false);
#line 148 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                     Write(bank.name);

#line default
#line hidden
            EndContext();
            BeginContext(5226, 25, true);
            WriteLiteral("\");\r\n                    ");
            EndContext();
            BeginContext(5253, 3, true);
            WriteLiteral("}\r\n");
            EndContext();
#line 150 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    if(bank.name == "kb"){

#line default
#line hidden
            BeginContext(5300, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5326, 34, true);
            WriteLiteral("currenciesSales[0][indexes[0]] = \"");
            EndContext();
            BeginContext(5361, 41, false);
#line 151 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                       Write(bank.saleVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(5402, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(5432, 38, true);
            WriteLiteral("currenciesPurchases[0][indexes[0]] = \"");
            EndContext();
            BeginContext(5471, 45, false);
#line 152 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                           Write(bank.purchaseVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(5516, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(5546, 15, true);
            WriteLiteral("indexes[0]++;\r\n");
            EndContext();
#line 154 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    }
                    if(bank.name == "rb"){

#line default
#line hidden
            BeginContext(5628, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5654, 34, true);
            WriteLiteral("currenciesSales[1][indexes[1]] = \"");
            EndContext();
            BeginContext(5689, 41, false);
#line 156 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                       Write(bank.saleVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(5730, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(5760, 38, true);
            WriteLiteral("currenciesPurchases[1][indexes[1]] = \"");
            EndContext();
            BeginContext(5799, 45, false);
#line 157 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                           Write(bank.purchaseVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(5844, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(5874, 15, true);
            WriteLiteral("indexes[1]++;\r\n");
            EndContext();
#line 159 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    }
                    if(bank.name == "cs"){

#line default
#line hidden
            BeginContext(5956, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5982, 34, true);
            WriteLiteral("currenciesSales[2][indexes[2]] = \"");
            EndContext();
            BeginContext(6017, 41, false);
#line 161 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                       Write(bank.saleVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6058, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6088, 38, true);
            WriteLiteral("currenciesPurchases[2][indexes[2]] = \"");
            EndContext();
            BeginContext(6127, 45, false);
#line 162 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                           Write(bank.purchaseVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6172, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6202, 15, true);
            WriteLiteral("indexes[2]++;\r\n");
            EndContext();
#line 164 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    }
                    if(bank.name == "cnb"){

#line default
#line hidden
            BeginContext(6285, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(6311, 34, true);
            WriteLiteral("currenciesSales[3][indexes[3]] = \"");
            EndContext();
            BeginContext(6346, 41, false);
#line 166 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                       Write(bank.saleVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6387, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6417, 38, true);
            WriteLiteral("currenciesPurchases[3][indexes[3]] = \"");
            EndContext();
            BeginContext(6456, 45, false);
#line 167 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                           Write(bank.purchaseVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6501, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6531, 15, true);
            WriteLiteral("indexes[3]++;\r\n");
            EndContext();
#line 169 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    }
                    if(bank.name == "csob"){

#line default
#line hidden
            BeginContext(6615, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(6641, 34, true);
            WriteLiteral("currenciesSales[4][indexes[4]] = \"");
            EndContext();
            BeginContext(6676, 41, false);
#line 171 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                       Write(bank.saleVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6717, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6747, 38, true);
            WriteLiteral("currenciesPurchases[4][indexes[4]] = \"");
            EndContext();
            BeginContext(6786, 45, false);
#line 172 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                           Write(bank.purchaseVal.ToString().Replace(",", "."));

#line default
#line hidden
            EndContext();
            BeginContext(6831, 28, true);
            WriteLiteral("\";\r\n                        ");
            EndContext();
            BeginContext(6861, 15, true);
            WriteLiteral("indexes[4]++;\r\n");
            EndContext();
#line 174 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                    }

                }

            }

#line default
#line hidden
            BeginContext(6937, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(6951, 25, true);
            WriteLiteral("createCurrencySaleGraph(\"");
            EndContext();
            BeginContext(6977, 19, false);
#line 179 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                  Write(curr.name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(6996, 19, true);
            WriteLiteral("\"+\"-sale-canvas\", \"");
            EndContext();
            BeginContext(7016, 9, false);
#line 179 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                                         Write(curr.name);

#line default
#line hidden
            EndContext();
            BeginContext(7025, 52, true);
            WriteLiteral("\", bankNames, dates, currenciesSales);\r\n            ");
            EndContext();
            BeginContext(7079, 29, true);
            WriteLiteral("createCurrencyPurchaseGraph(\"");
            EndContext();
            BeginContext(7109, 19, false);
#line 180 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                      Write(curr.name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(7128, 23, true);
            WriteLiteral("\"+\"-purchase-canvas\", \"");
            EndContext();
            BeginContext(7152, 9, false);
#line 180 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
                                                                                 Write(curr.name);

#line default
#line hidden
            EndContext();
            BeginContext(7161, 44, true);
            WriteLiteral("\", bankNames, dates, currenciesPurchases);\r\n");
            EndContext();
#line 181 "C:\Users\proko\Documents\Gitlab tul\STI-SledovaniKurzu\STI-Prokorat-Krausner-Broz\STI-Prokorat-Krausner-Broz\Views\Home\Index.cshtml"
        }
     

#line default
#line hidden
            BeginContext(7224, 17, true);
            WriteLiteral("</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<STIProkoratKrausnerBroz.Models.ToolsClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
