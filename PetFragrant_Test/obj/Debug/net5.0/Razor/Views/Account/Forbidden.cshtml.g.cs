#pragma checksum "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Account\Forbidden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8193e6e3c11c3edaa26e47dc631a59776be8dd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Forbidden), @"mvc.1.0.view", @"/Views/Account/Forbidden.cshtml")]
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
#line 1 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\_ViewImports.cshtml"
using PetFragrant_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\_ViewImports.cshtml"
using PetFragrant_Test.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\_ViewImports.cshtml"
using PetFragrant_Test.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\_ViewImports.cshtml"
using PetFragrant_Test.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Account\Forbidden.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8193e6e3c11c3edaa26e47dc631a59776be8dd60", @"/Views/Account/Forbidden.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275e3dd2a393428434a3584939a310d5234a899d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Forbidden : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Account\Forbidden.cshtml"
  
    ViewData["Title"] = "Forbidden";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>很抱歉，您無權限進入此頁面</h1>\r\n\r\n<h2>");
#nullable restore
#line 9 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Account\Forbidden.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("雖通過帳密驗證，無權限進入此頁面</h2>\r\nf");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591