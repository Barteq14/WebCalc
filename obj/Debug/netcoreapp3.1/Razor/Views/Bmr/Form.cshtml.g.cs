#pragma checksum "C:\Users\barteq\Desktop\magisterka\inne zadania\Wieksze Projekty\Aplikacja_Kalkulator\WebCalc\Views\Bmr\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00f533dff662dd735c95343a202d9b0d7439b65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bmr_Form), @"mvc.1.0.view", @"/Views/Bmr/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00f533dff662dd735c95343a202d9b0d7439b65", @"/Views/Bmr/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7fc690451ec865d56c5212b56f7edf63d53bbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Bmr_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bmr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />



<div class=""row"">
    <div class=""tab"" style=""opacity:0.9"">
        <font style=""color:white;font-family:Arial"">
            <div class=""text-center"">
                <h1> BMR Form </h1>
            </div>
            <div class=""col-md-3"" style=""width:50%;float:left"">


                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a00f533dff662dd735c95343a202d9b0d7439b654539", async() => {
                WriteLiteral(@"

                    <!--<input type=""hidden"" asp-for=""ID"" />-->
                    <div class=""form-group"">
                        Male <input type=""radio"" id=""M"" name=""sex"" value=""Male"" checked /><br />
                        Female <input type=""radio"" id=""F"" name=""sex"" value=""Female"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">WEIGHT</label>
                        <input name=""weight"" class=""form-control"" />
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-group"">
                        <label name=""height"" class=""control-label"">HEIGHT</label>
                        <input name=""height"" class=""form-control"" />
                        <span class=""text-danger""></span>
                    </div>

                    <div class=""form-group"">
                        <label name=""age"" class=""control-label"">AGE</label>
          ");
                WriteLiteral(@"              <input name=""age"" type=""number"" class=""form-control"" />
                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""info"">
                Kalkulator BMR (Basal Metabolic Rate) jest specjalnym wskaźnikiem wykorzystywanym przy obliczeniu minimalnego dziennego zapotrzebowania kalorycznego.
                Do obliczeń wykorzystywane są indywidualne dane, w tym waga, wzrost, wiek oraz płeć. <br /><br />
                Aby wstępnie oszacować zapotrzebowanie kaloryczne dorosłego człowieka, wystarczy pomnożyć masę ciała przez 24 (wartość odnosząca się do doby).
                Przykładowo, osoba ważąca 60 kg potrzebuje około 1440 kcal dziennie. Niestety już na pierwszy rzut oka widać,
                że wynik jest mało dokładny – wszak dwie osoby, ważące tyle samo, mogą mieć odmienne zapotrzebowanie na kalorie.
                Licząc wskaźnik BMR, należy uwzględnić indywidualne predyspozycje osobnicze, m.in. wzrost, wiek i płeć. Uzyskanie precyzyjnych wartości wymaga
                zastosowania wzoru Mifflina-St Jeora. <br /><br />
                Zapotrzebowanie kaloryczne ");
            WriteLiteral(@"- wzór dla kobiet:<br />

                BMR = (9,99 x waga) + (6,25 x wzrost) – (4,92 x wiek) – 161<br /><br />

                Zapotrzebowanie kaloryczne wzór dla mężczyzn:<br />

                BMR = (9,99 x waga) + (6,25 x wzrost) – (4,92 x wiek) + 5<br /><br />

                Wzrost – [cm]<br />

                Waga – [kg] <br />
                
                Więcej informacji znajdziesz pod tym linkiem:
                <a style=""color:yellow"" href=""https://www.medonet.pl/zdrowie,kalkulator-bmr---czym-jest-zapotrzebowanie-kaloryczne--co-moze-miec-wplyw-na-wynik-,artykul,1724924.html"">medonet.pl</a> 

            </div>
        </font>
    </div>
    
</div>");
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
