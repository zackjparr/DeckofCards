#pragma checksum "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25eaa1f9be8aca6e7a83372f670f8fb5fbbd4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Draw), @"mvc.1.0.view", @"/Views/Home/Draw.cshtml")]
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
#line 1 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\_ViewImports.cshtml"
using DeckofCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\_ViewImports.cshtml"
using DeckofCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25eaa1f9be8aca6e7a83372f670f8fb5fbbd4d2", @"/Views/Home/Draw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353dd6e4ec2e87cf32533d5d992c51df210bf175", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Draw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Draw>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Cards</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml"
 foreach(Card c in Model.cards)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 101, "\"", 115, 1);
#nullable restore
#line 7 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml"
WriteAttributeValue("", 107, c.image, 107, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                <p>Value: ");
#nullable restore
#line 8 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml"
                     Write(c.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Suit: ");
#nullable restore
#line 9 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml"
                    Write(c.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\ZParr\source\repos\DeckofCards\DeckofCards\Views\Home\Draw.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Draw> Html { get; private set; }
    }
}
#pragma warning restore 1591