#pragma checksum "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6bd65867cec70fd750661e6cbdcfbb80311c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CalculateHouseInfomation), @"mvc.1.0.view", @"/Views/Home/CalculateHouseInfomation.cshtml")]
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
#line 1 "/Users/jginvincible/git/Investments/Investments/Views/_ViewImports.cshtml"
using Investments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jginvincible/git/Investments/Investments/Views/_ViewImports.cshtml"
using Investments.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6bd65867cec70fd750661e6cbdcfbb80311c11", @"/Views/Home/CalculateHouseInfomation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ca9448d6883e8a3434209f72ed91cf675b5f47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CalculateHouseInfomation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Investments.Models.ListOfHouse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
  
    ViewData["Title"] = "House Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--\n    create loop to view mortage payment at\n    different intrest rates\n-->\n\n");
#nullable restore
#line 11 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
 foreach (HouseInvestment house in Model.LOH)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card text-center\">\n        <div class=\"card-header\">\n            <code>\n                Fixed Intrest Rate: ");
#nullable restore
#line 16 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
                               Write(house.FixedIntrestRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%\n            </code>\n        </div>\n        <div class=\"card-body\">\n            <h4 class=\"card-title display-4\">\n                Mortgage Payment: <code>\n                    $");
#nullable restore
#line 22 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
                Write(String.Format("{0:0,0.##}", house.MortgageMonthlyPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </code>\n            </h4>\n            <p class=\"card-text\">\n                The total money paid for this house was <code>$");
#nullable restore
#line 26 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
                                                          Write(String.Format("{0:0,0.##}", house.TotalCostPayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</code> and\n                the you paid <code>$");
#nullable restore
#line 27 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
                               Write(String.Format("{0:0,0.##}", house.PayedIntrest));

#line default
#line hidden
#nullable disable
            WriteLiteral("</code> in intrest.\n            </p>\n        </div>\n    </div>\n    <br />\n");
#nullable restore
#line 32 "/Users/jginvincible/git/Investments/Investments/Views/Home/CalculateHouseInfomation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Investments.Models.ListOfHouse> Html { get; private set; }
    }
}
#pragma warning restore 1591
