#pragma checksum "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Bmr\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8be2d386bbb81c646b1341da42f01c66589a08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bmr_Index), @"mvc.1.0.view", @"/Views/Bmr/Index.cshtml")]
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
#line 1 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\_ViewImports.cshtml"
using WebCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\_ViewImports.cshtml"
using WebCalc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8be2d386bbb81c646b1341da42f01c66589a08", @"/Views/Bmr/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7fc690451ec865d56c5212b56f7edf63d53bbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Bmr_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<div class=\"container body2\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">\r\n            ");
#nullable restore
#line 14 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Bmr\Index.cshtml"
       Write(Html.Label("Your BMR:"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Bmr\Index.cshtml"
                                Write(ViewBag.BMR);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
