#pragma checksum "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1503c53e6f2b65aa0144720751973c1c04263d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1503c53e6f2b65aa0144720751973c1c04263d", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04ad74d61bcaddde3f2f221a5488b06499b635", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\User\Index.cshtml"
     if (Model == null && ViewBag.Error !=true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 text-center mt-5\">\r\n            <a class=\"btn btn-primary\" href=\"/User/GetApiKey\">Get Api Key</a>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\User\Index.cshtml"
    }
    else if (Model!=null && ViewBag.Error!= true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-1\"></div>\r\n            <div class=\"col-3\"><strong>Your Api Key</strong></div>\r\n            <div class=\"col-1\">-</div>\r\n            <div class=\"col-6\"><input type=\"text\" class=\"btn-block text-center\"");
            BeginWriteAttribute("value", " value=\"", 545, "\"", 563, 1);
#nullable restore
#line 16 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\User\Index.cshtml"
WriteAttributeValue("", 553, Model.Key, 553, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled /></div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""row mt-4"">
        <div class=""col-12"">
            <h3 class=""text-center"">Api Documentation</h3>
        </div>
        <div class=""col-12"">
            <h4 class=""text-center"">Base Address : <small>https://localhost:44341/User</small> </h4>
        </div>
    </div>
    <div class=""col-12 mt-3"">
        <div class=""row p-4"">
            <div class=""col-4"">
                <h3>To Get Oxyzen Data</h3>
            </div>
            <div class=""col-1""></div>
            <div class=""col-4"">
                <p>
                    <strong>Url</strong> <small class=""ml-3"">/GetO2Data</small>
                </p>
                <p>
                    <strong class=""text-success"">Paramertes</strong>
                </p>
                <p><strong class=""text-danger"">To Get Full Data</strong></p>
                <p>
                    <small><strong>Query String</strong> : Key =""Your Api key""</small>
                </p>
                <p></p>
                <p><str");
            WriteLiteral(@"ong class=""text-danger"">To Get Particular State Data</strong></p>
                <p>
                    <div class=""row"">
                        <div class=""col-5""><strong>Query String</strong></div><div class=""col-6""><small> : Key =""Your Api key""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> : State =""State Name""</small></div>
                    </div>
                </p>
                <p></p>
            </div>
        </div>
    </div>
    <div class=""col-12 mt-3"">
        <div class=""row p-4"">
            <div class=""col-4"">
                <h3>To Get Plasma Data</h3>
            </div>
            <div class=""col-1""></div>
            <div class=""col-4"">
                <p>
                    <strong>Url</strong> <small class=""ml-3"">/GetPlasmaData</small>
                </p>
                <p>
                    <strong class=""text-success"">Paramertes</strong>
                </p>
                <p><strong class=""text-danger""");
            WriteLiteral(@">To Get Full Data</strong></p>
                <p>
                    <small><strong>Query String</strong> : Key =""Your Api key""</small>
                </p>
                <p></p>
                <p><strong class=""text-danger"">To Get Particular State Data</strong></p>
                <p>
                    <div class=""row"">
                        <div class=""col-5""><strong>Query String</strong></div><div class=""col-6""><small> : Key =""Your Api key""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> : State =""State Name""</small></div>
                    </div>
                </p>
                <p></p>
            </div>
        </div>
    </div>
    <div class=""col-12 mt-3"">
        <div class=""row p-4"">
            <div class=""col-4"">
                <h3>To Add O2 Donor</h3>
            </div>
            <div class=""col-1""></div>
            <div class=""col-4"">
                <p>
                    <strong>Url</strong> <small class=""ml-");
            WriteLiteral(@"3"">/AddO2Donor</small>
                </p>
                <p>
                    <strong class=""text-success"">Paramertes</strong>
                </p>
             
                
                <p>
                    <div class=""row"">
                        <div class=""col-5""><strong>Query String</strong></div><div class=""col-6""><small> : Key =""Your Api key""</small></div>

                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-5""><strong>Body</strong></div><div class=""col-7""><small> :FullName =""User Full Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :Address =""His Address""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :State =""State Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :City =""City Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :Ma");
            WriteLiteral(@"il =""EMail""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :Capacity =""oxyen in kilo""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small class=""text-warning"">Capacity must be in number</small></div>
                    </div>
                </p>
                <p></p>
            </div>
        </div>
    </div>
    <div class=""col-12 mt-3"">
        <div class=""row p-4"">
            <div class=""col-4"">
                <h3>To Add Paslma Donor</h3>
            </div>
            <div class=""col-1""></div>
            <div class=""col-4"">
                <p>
                    <strong>Url</strong> <small class=""ml-3"">/AddPlasmaDonor</small>
                </p>
                <p>
                    <strong class=""text-success"">Paramertes</strong>
                </p>
                
                
                <p>
                    <div class=""row"">
                        <div class=""col-5""><str");
            WriteLiteral(@"ong>Query String</strong></div><div class=""col-6""><small> : Key =""Your Api key""</small></div>

                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-5""><strong>Body</strong></div><div class=""col-7""><small> :FullName =""User Full Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :Address =""His Address""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :State =""State Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :City =""City Name""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :Mail =""EMail""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small> :BGroup =""Blood Group""</small></div>
                        <div class=""col-5""></div><div class=""col-6""><small class=""text-warning"">Blood group values must be if its positve then write p in end ");
            WriteLiteral("lik Bp and if -ve the write n</small></div>\r\n                    </div>\r\n                </p>\r\n                <p></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
