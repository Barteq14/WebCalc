#pragma checksum "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eefb97a97805b71db9f6640c54f9a3e5c7d637f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Measure_Index), @"mvc.1.0.view", @"/Views/Measure/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eefb97a97805b71db9f6640c54f9a3e5c7d637f", @"/Views/Measure/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7fc690451ec865d56c5212b56f7edf63d53bbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Measure_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br /><br />
<div class=""container body2"">
    <div class=""text-center"">
        <h1 class=""display-4"">
            <img src=""https://s2.manifo.com/usr/f/F7BAa/51/manager/normy_tkanki-tluszczowej.jpg"" />
            <hr />
            <p class=""alert-dark"">
                
                ");
#nullable restore
#line 14 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
           Write(Html.Label("Your BF:"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                   Write(ViewBag.BF);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %  <br /> +/- 3% <br />\r\n");
#nullable restore
#line 15 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                 if (ViewBag.sex == "Male")
                {
                    if (@ViewBag.BF > 0 && @ViewBag.BF < 7.5)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Niestety posiadasz zbyt mało tkanki tłuszczowej! Zalecamy stosowanie diety oraz trening siłowy ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                                        
                    if (@ViewBag.BF >= 7.5 && @ViewBag.BF < 20)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Gratulacje posiadasz prawidlową ilosc tkanki tłuszcowej! Oby tak dalej ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                
                    if (@ViewBag.BF >= 20 && @ViewBag.BF < 31)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Lekka nadwaga! Posiadasz zbyt dużo tkanki tłuszczowej! Zalecamy więcej ruchu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                   
                    if (@ViewBag.BF >= 31 && @ViewBag.BF < 50) 
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Niestety posiadasz za dużo tkanki tłuszczowej! Zalecamy diete oraz treningi cardio, Powodzenia ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                                        
                }
                else
                {
                    if (@ViewBag.BF > 0 && @ViewBag.BF < 21)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Niestety posiadasz zbyt mało tkanki tłuszczowej! Zalecamy stosowanie diety oraz trening siłowy ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                                        
                    if (@ViewBag.BF >= 21 && @ViewBag.BF < 33)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Gratulacje posiadasz prawidlową ilosc tkanki tłuszcowej! Oby tak dalej ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                
                    if (@ViewBag.BF >= 33 && @ViewBag.BF < 40)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Lekka nadwaga! Posiadasz zbyt dużo tkanki tłuszczowej! Zalecamy więcej ruchu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                   
                    if (@ViewBag.BF >= 40 && @ViewBag.BF < 50) 
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                   Write(Html.Label("Niestety posiadasz za dużo tkanki tłuszczowej! Zalecamy diete oraz treningi cardio, Powodzenia ;)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Measure\Index.cshtml"
                                                                                                                                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n        </h1>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
