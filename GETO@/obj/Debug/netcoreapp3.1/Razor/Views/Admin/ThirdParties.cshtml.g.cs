#pragma checksum "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a555b93228b163ad9f0fec7b919b47f5410511a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ThirdParties), @"mvc.1.0.view", @"/Views/Admin/ThirdParties.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a555b93228b163ad9f0fec7b919b47f5410511a", @"/Views/Admin/ThirdParties.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04ad74d61bcaddde3f2f221a5488b06499b635", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ThirdParties : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 2 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
     if(ViewBag.Success ==true){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">");
#nullable restore
#line 3 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
                                    Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Api Credentials Deleted Succesfully</div>\r\n");
#nullable restore
#line 4 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
     if(ViewBag.Error == true) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\"> Some error occured</div>\r\n");
#nullable restore
#line 7 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>User</th>\r\n                <th>Edit Permissions</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
               Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 629, "\"", 665, 2);
            WriteAttributeValue("", 636, "/Admin/EditApiKey?Id=", 636, 21, true);
#nullable restore
#line 21 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
WriteAttributeValue("", 657, item.Id, 657, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 766, 2);
            WriteAttributeValue("", 735, "/Admin/DeleteApiKey?Id=", 735, 23, true);
#nullable restore
#line 22 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
WriteAttributeValue("", 758, item.Id, 758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Admin\ThirdParties.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
