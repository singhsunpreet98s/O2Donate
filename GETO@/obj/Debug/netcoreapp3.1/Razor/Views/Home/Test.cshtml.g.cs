#pragma checksum "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c6af6738b19a4a9575c11c652b7a10e08269e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
#line 1 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\_ViewImports.cshtml"
using GETO_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\_ViewImports.cshtml"
using GETO_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c6af6738b19a4a9575c11c652b7a10e08269e0", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04ad74d61bcaddde3f2f221a5488b06499b635", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Home\Test.cshtml"
   
    var a = Model;
    var b = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <ul id=""myUL"">
        <li>
            <span class=""caret"">Beverages</span>
            <ul class=""nested"">
                <li>Water</li>
                <li>Coffee</li>
                <li>
                    <span class=""caret"">Tea</span>
                    <ul class=""nested"">
                        <li>Black Tea</li>
                        <li>White Tea</li>
                        <li>
                            <span class=""caret"">Green Tea</span>
                            <ul class=""nested"">
                                <li>Sencha</li>
                                <li>Gyokuro</li>
                                <li>Matcha</li>
                                <li>Pi Lo Chun</li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                <script>
                    var toggler = document.getElementsByClassName(""caret"");
                    var i;

                    for (i = 0; i < toggler.length; i++) {
                      toggler[i].addEventListener(""click"", function() {
                        this.parentElement.querySelector("".nested"").classList.toggle(""active"");
                        this.classList.toggle(""caret-down"");
  });
}
                </script>
            ");
            }
            );
            WriteLiteral(" ");
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
