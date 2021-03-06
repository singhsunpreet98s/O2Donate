#pragma checksum "C:\Users\Sunpreet\source\repos\GETO@\GETO@\Views\Home\GetO2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3085e9a667a6d964a4e1b630e63eac882b3928f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetO2), @"mvc.1.0.view", @"/Views/Home/GetO2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3085e9a667a6d964a4e1b630e63eac882b3928f", @"/Views/Home/GetO2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04ad74d61bcaddde3f2f221a5488b06499b635", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetO2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""col-12 text-center"" ><h3 id=""state"" class=""text-center""></h3></div>
    <table id=""table1"" class=""table"">
        <thead>
            <tr>
                <th>Full Name</th>
                <th>Phone</th>
                <th>Mail</th>
                <th>City</th>
                <th>State</th>
                <th>Capacity</th>
                <th>Verifed</th>
            </tr>
        </thead>
        <tbody>
            <tr></tr>
        </tbody>
    </table>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    var state = document.getElementById(""state"");
    $(document).ready(function () {
        getLocation();
        
    })
    function getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        } else {
            window.alert(""Geolocation not supported !"");
        }
    }

    function showPosition(position) {
        var lat = position.coords.latitude;
        var lng = position.coords.longitude;
        
        $.get(`https://api.weatherapi.com/v1/current.json?q=${lat},${lng}&key=478b720c08964a649b272557212207`,
            function (sdata, edata) {
                getData(sdata.location.region)
            }
        )
        console.log(lat, lng)
    }
    function getData(State) {
        var Url = `/Home/GetO2?State=${State}`;
        state.innerHTML = `Your Current State is ${State}`;
        $.post(Url, function (sdata, edata) {
            console.log(sdata)
            for (let i = ");
                WriteLiteral(@"0; i < sdata.length; i++) {
                if (sdata[i].isVerified) {
                    $('#table1 tr:last').after(`<tr><td>${sdata[i].fullName}</td><td>${sdata[i].phone}</td><td>${sdata[i].mail}</td><td>${sdata[i].city}</td><td>${sdata[i].state}</td><td>${sdata[i].capacity}</td><td><a href=""#"" class=""badge badge-success""><span class=""material-icons"">check_circle</span></a></td></tr>`);
                }
                else {
                    $('#table1 tr:last').after(`<tr><td>${sdata[i].fullName}</td><td>${sdata[i].phone}</td><td>${sdata[i].mail}</td><td>${sdata[i].city}</td><td>${sdata[i].state}</td><td>${sdata[i].capacity}</td><td><a href=""#"" class=""badge badge-danger""><span class=""material-icons"">cancel</span></a></td></tr>`);
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
