#pragma checksum "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8270a44cc5f4d3b5720b16bb4376459199f7c2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Oxyzen), @"mvc.1.0.view", @"/Views/Admin/Oxyzen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8270a44cc5f4d3b5720b16bb4376459199f7c2c", @"/Views/Admin/Oxyzen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04ad74d61bcaddde3f2f221a5488b06499b635", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Oxyzen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Mail</th>
                <th>Phone</th>
                <th>Capacity</th>
                <th>State</th>
                <th>City</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
                 if (item.IsVerified)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><div class=\"btn btn-success disabled\">Verifed</div></td>\r\n");
#nullable restore
#line 29 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 946, "\"", 975, 3);
            WriteAttributeValue("", 956, "verifyFun(", 956, 10, true);
#nullable restore
#line 32 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
WriteAttributeValue("", 966, item.Id, 966, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 974, ")", 974, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 976, "\"", 989, 1);
#nullable restore
#line 32 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
WriteAttributeValue("", 981, item.Id, 981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Verify</button></td>\r\n");
#nullable restore
#line 33 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\Oxyzen.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    function verifyFun(a) {
        var btn = document.getElementById(`${a}`);
        const url = `/Admin/VerifyOxy?Id=${a}`;
        $.get(url, function (sdata,edata) {
            if (sdata) {
                console.log(sdata)
                if (sdata == ""success"") {
                    btn.innerHTML = ""Verified""
                    $(`#${a}`).removeClass(""btn-warning"").addClass(""btn-success"").addClass(""disabled"");
                }
                
            }
           
        })
    }
</script>
");
            }
            );
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
