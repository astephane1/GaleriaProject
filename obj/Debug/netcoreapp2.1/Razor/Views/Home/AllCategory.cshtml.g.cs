#pragma checksum "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d152fd5c62c6bf5eb853137e3ae79a891c37ad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCategory), @"mvc.1.0.view", @"/Views/Home/AllCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllCategory.cshtml", typeof(AspNetCore.Views_Home_AllCategory))]
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
#line 1 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\_ViewImports.cshtml"
using GaleriaProject;

#line default
#line hidden
#line 2 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\_ViewImports.cshtml"
using GaleriaProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d152fd5c62c6bf5eb853137e3ae79a891c37ad7", @"/Views/Home/AllCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8208ac7bc11a9c9ef15a8e376eee61f5c92e9606", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GaleriaProject.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 512, true);
            WriteLiteral(@"
<br />
<h2 style=""text-align:center; font-family:'Leelawadee UI'"">Catégories</h2>
<br />
<p style=""text-align:center"">
    Découvrez nos collections qui regroupent des catégories diverses telles que le dessin,
    la photographie ou encore les portraits. Que vous soyez fan de street art ou alors passionné de peinture.
    De la sculpture à la photographie en passant par des tableaux, il y en a pour tous les goûts.
    En vous souhaitant d'agréables découvertes !</p>
<br />
    <div class=""row"">
");
            EndContext();
#line 19 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml"
         foreach (Category item in Model)
        {

#line default
#line hidden
            BeginContext(743, 57, true);
            WriteLiteral("        <div class=\"col-md-3 textgood\">\r\n            <h2>");
            EndContext();
            BeginContext(801, 18, false);
#line 22 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml"
           Write(item.Name_Category);

#line default
#line hidden
            EndContext();
            BeginContext(819, 63, true);
            WriteLiteral("</h2>\r\n            <div class=\"anim-image\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 882, "\"", 925, 2);
            WriteAttributeValue("", 889, "/Home/OnlyCategory/", 889, 19, true);
#line 24 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml"
WriteAttributeValue("", 908, item.Id_Category, 908, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(926, 81, true);
            WriteLiteral(" alt=\"/\">\r\n                        <img class=\"right\" style=\"border-color: black\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1007, "\"", 1035, 2);
            WriteAttributeValue("", 1013, "/images/", 1013, 8, true);
#line 25 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml"
WriteAttributeValue("", 1021, item.ImageUrl, 1021, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1036, 100, true);
            WriteLiteral(" alt=\"Dog GIF\" width=\"300\" height=\"200\">\r\n                </a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Users\azo'o stephane\Desktop\Travaux_C#\Training_c#\GaleriaProject\Views\Home\AllCategory.cshtml"

        }

#line default
#line hidden
            BeginContext(1149, 11, true);
            WriteLiteral("    </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GaleriaProject.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591