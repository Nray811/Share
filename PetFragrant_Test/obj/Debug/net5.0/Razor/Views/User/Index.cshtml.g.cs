#pragma checksum "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4512b1a7bb80ced7bc61a114a4ea9d425a3d3af"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4512b1a7bb80ced7bc61a114a4ea9d425a3d3af", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275e3dd2a393428434a3584939a310d5234a899d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
  
    ViewData["Title"] = "使用者資訊";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1><center>使用者資訊</center></h1>

    <div class=""row bg-white h-50 p-4 rounded-2 shadow-sm   "">
        <div class=""col-12 col-md-4 d-flex flex-column align-items-center"">
            <img src=""https://picsum.photos/200/200/?random=10"" class=""rounded-circle"">
        <h4>");
#nullable restore
#line 11 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <a href=\"#\">編輯</a>\r\n        </div>\r\n        <div class=\"col-12 col-md-6\">\r\n            <table class=\"table table-hover table-borderless\">\r\n                <tbody");
            BeginWriteAttribute("class", " class=\"", 521, "\"", 529, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <tr>\r\n                        <td><h5>姓名</h5></td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
                   Write(ViewBag.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a href=\"#\">編輯</a></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><h5>E-mail</h5></td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
                   Write(ViewBag.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a href=\"#\">編輯</a></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><h5>手機號碼</h5></td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
                       Write(ViewBag.User.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a href=\"#\">編輯</a></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><h5>地址</h5></td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\User\Index.cshtml"
                       Write(ViewBag.User.IsAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td><a href=""#"">編輯</a></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <div class=""row bg-white h-100 mt-4 p-2 shadow-sm rounded-2"">
        <div class=""grid-container "">
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6");
            WriteLiteral(@" text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
       ");
            WriteLiteral(@"     </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle r");
            WriteLiteral(@"ounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>
            <a href=""#"" class=""grid-item"">
                <div class=""img"">
                    <div class=""circle rounded-circle  d-flex justify-content-center align-items-center"" style=""background-color:#E0B547;width: 100px; height: 100px;"">
                        <i class=""icon ion-heart display-6 text-white ""></i>
                    </div>
                    <h5 class=""fw-bold"">按讚好物</h5>
                </div>
            </a>


        </div>
    </div>


");
            DefineSection("topCSS", async() => {
                WriteLiteral("\r\n    <style>\r\n        .grid-container {\r\n            display: grid;\r\n            grid-template-columns: repeat(2, 1fr);\r\n            gap: 1px;\r\n            height:100%;\r\n        }\r\n\r\n        ");
                WriteLiteral(@"@media screen and (min-width : 1024px ) {
            .grid-container {
                display: grid;
                grid-template-columns: repeat(4, 1fr);
                gap: 1px;
            }
        }


        .grid-item {
            /*background-color: rgb(255, 255, 255);*/
            height: 150px;
            border: none;
            display: flex;
            text-align: center;
            align-items: center;
            justify-content: center;
            text-decoration: none;
            color: #3a3946;
        }

            .grid-item:hover {
                color: #dd8a24;
            }
    </style>
");
            }
            );
            WriteLiteral("    ");
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