#pragma checksum "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15e9b298717024c0a96c19994cfc64f36667f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductDetail), @"mvc.1.0.view", @"/Views/Products/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15e9b298717024c0a96c19994cfc64f36667f11", @"/Views/Products/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275e3dd2a393428434a3584939a310d5234a899d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<petsFragrant.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product_page.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
  
    ViewData["Title"] = Model.ProductName;

#line default
#line hidden
#nullable disable
            DefineSection("topJS", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topCSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a15e9b298717024c0a96c19994cfc64f36667f116362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/swiper@9/swiper-bundle.min.css\" />\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<!-- 麵包屑 -->\r\n<nav style=\"--bs-breadcrumb-divider: \'>\';\" aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a15e9b298717024c0a96c19994cfc64f36667f117870", async() => {
                WriteLiteral("首頁");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item\" aria-current=\"page\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a15e9b298717024c0a96c19994cfc64f36667f119292", async() => {
                WriteLiteral("飼料");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
    </ol>
</nav>
<!-- 購買page -->
<div class=""row d-flex justify-content-evenly p-4 shadow-sm"" style=""background-color: #ffffff;"">
    <div class=""col-md-12 col-lg-4"">
        <div style=""--swiper-navigation-color: #fff; --swiper-pagination-color: #fff"" class=""swiper mySwiper2"">
            <div class=""swiper-wrapper"">
");
#nullable restore
#line 29 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                 for (var i = 1; i <= 1; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide\"");
            BeginWriteAttribute("style", " style=\"", 1136, "\"", 1144, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#");
#nullable restore
#line 32 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("-model\">\r\n                            <div class=\"img-wrap\"><img src=\"https://picsum.photos/300/300?random=1\" class=\"img-thumbnail\"></div>\r\n");
            WriteLiteral("                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"swiper-button-next\"></div>\r\n            <div class=\"swiper-button-prev\"></div>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("thumbsSlider", " thumbsSlider=\"", 1739, "\"", 1754, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"swiper mySwiper\">\r\n            <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 47 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                 for (var i = 1; i <= 1; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide\">\r\n                        <img src=\"https://picsum.photos/300/300?random=1\">\r\n");
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
         for (var i = 1; i <= 1; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2270, "\"", 2285, 2);
#nullable restore
#line 61 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 2275, i, 2275, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2279, "-model", 2279, 6, true);
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">\r\n                <div class=\"modal-dialog modal-lg\">\r\n                    <div>\r\n                        <div class=\"modal-body\">\r\n                            <img src=\"https://picsum.photos/300/300?random=1\" class=\"img-fluid\">\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"col-md-12 col-lg-7 \">\r\n");
#nullable restore
#line 78 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
         using (Html.BeginForm("Carts", "ShopingCarts", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 style=\"font-family: Arial, Helvetica, sans-serif;font-weight: bold;\">");
#nullable restore
#line 83 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                                                                Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"price\">\r\n                <h2 style=\"color: rgb(194, 22, 22);\">NT ");
#nullable restore
#line 85 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                                   Write(Math.Round(Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h6 class=\"text-black-50\"><del>NT ");
#nullable restore
#line 86 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                             Write(Math.Round(Model.Price*(decimal)0.9));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h6>\r\n                <p class=\"text-black-50\">庫存: ");
#nullable restore
#line 87 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                        Write(Model.Inventory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""row"">
                    <div class=""amount col-5 d-flex flex-column justify-content-between"">
                        <p style=""color: #6f5f5f;"">數量:</p>
                        <div class=""d-flex mb-2"">
                            <span><input type=""button"" class=""sub"" value=""-"" /></span>
                            <input type=""text"" value=""1"" style=""width: 40px;"" id=""quantity"" name=""quantity""");
            BeginWriteAttribute("class", " class=\"", 3767, "\"", 3775, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span><input type=""button"" class=""add"" value=""+"" /></span>
                        </div>

                    </div>
                    <div class=""col-5 d-flex flex-column justify-content-between "">
                        <input type=""hidden"" name=""productId""");
            BeginWriteAttribute("value", " value=\"", 4075, "\"", 4099, 1);
#nullable restore
#line 99 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 4083, Model.ProdcutId, 4083, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <p style=\"color: #6f5f5f;\">規格:</p>\r\n                        <div>\r\n                            \r\n");
#nullable restore
#line 103 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                             foreach(var sp in Model.ProductSpecs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>\r\n                                    <input type=\"radio\" name=\"spec\"");
            BeginWriteAttribute("value", " value=\"", 4433, "\"", 4456, 1);
#nullable restore
#line 106 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 4441, sp.Spec.SpecID, 4441, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    \r\n                                    <span class=\"button \">\r\n                                        ");
#nullable restore
#line 109 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                                   Write(sp.Spec.SpecName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </label>\r\n");
#nullable restore
#line 112 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <hr>
                <div class=""describe mt-2 p-3"" style=""background-color: #f6f6f6;"">
                    <p><b>付款方式 </b>雞腿、飼料、罐罐，與其他多種方式</p>
                    <p><b>運費 </b>$87</p>
                    <p><b>配送方式 </b>狗狗會送來你家</p>
                </div>
                <div class=""buy d-flex justify-content-end align-items-center"">
");
            WriteLiteral(@"
                    <input type=""button"" class=""btn btn-danger"" id=""cart"" value=""追蹤"">
                    <input type=""button"" class=""m-2 btn btn-danger"" id=""shopcart"" value=""加入購物車"" />
                    <button type=""submit"" class=""m-2 btn btn-danger"">直接購買</button>

                </div>
            </div>
");
#nullable restore
#line 133 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"row shadow-sm bg-white mt-4 p-4\">\r\n    <h4 class=\"d-flex justify-content-center w-100\"><b>商品詳情</b></h4>\r\n \r\n        <h5 class=\"fw-bold\">商品規格</h5>\r\n");
#nullable restore
#line 143 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
         foreach (var item in Model.ProductSpecs)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 146 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
          Write(item.Spec.SpecName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 147 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr>\r\n\r\n    <h5 class=\"fw-bold\">商品描述</h5>\r\n        <p>");
#nullable restore
#line 151 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
      Write(Model.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>


        <hr>
    <h5 class=""fw-bold"">商品評價</h5>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Voluptate rerum quidem provident, ratione at laborum! Unde, amet debitis assumenda cum magnam similique. Magnam quae provident eos, quaerat perferendis alias earum.</p>

 
</div>

<div class=""row shadow-sm bg-white  p-4"">
    <h4><b>推薦</b></h4>
    <div class=""col-12"">
    </div>
</div>

<a");
            BeginWriteAttribute("href", " href=\"", 6525, "\"", 6594, 1);
#nullable restore
#line 167 "C:\Users\gfri5\Desktop\大學\Hack\MVC_Practice\PetFragrant_Test\PetFragrant_Test\Views\Products\ProductDetail.cshtml"
WriteAttributeValue("", 6532, ViewContext.HttpContext.Request.Headers["Referer"].ToString(), 6532, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n   class=\"btn btn-primary mt-4\">Back返回上一頁</a>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("endJS", async() => {
                WriteLiteral(@"

    <script src=""https://cdn.jsdelivr.net/npm/swiper@9/swiper-bundle.min.js""></script>


    <script>
        let add = document.querySelector("".add"");
        let sub = document.querySelector("".sub"");
        let quantity = document.getElementById(""quantity"");
        let shopcart = document.getElementById(""shopcart"");

        // 增減按鈕
        add.addEventListener(""click"", function () {
            let v = parseInt(quantity.value) + 1;
            quantity.value = v;
            console.log(quantity.innerText);
        });

        sub.addEventListener(""click"", function () {
            let v = parseInt(quantity.value) - 1;
            if (v < 0) quantity.value = 0;
            else quantity.value = v;

            console.log(quantity.innerText);
        });

        //加入購物車
        shopcart.addEventListener(""click"", function () {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: '成功加入購物車!',
                s");
                WriteLiteral(@"howConfirmButton: false,
                timer: 1500
            })
        });
        var swiper = new Swiper("".mySwiper"", {
            loop: true,
            spaceBetween: 10,
            slidesPerView: 4,
            freeMode: true,
            watchSlidesProgress: true,
        });
        var swiper2 = new Swiper("".mySwiper2"", {
            loop: true,
            spaceBetween: 10,
            navigation: {
                nextEl: "".swiper-button-next"",
                prevEl: "".swiper-button-prev"",
            },
            thumbs: {
                swiper: swiper,
            },
        });

        let cart = document.getElementById(""cart"");
        let carticon = document.querySelector("".carticon"");

        // 追蹤按鈕
        cart.addEventListener(""click"", function () {
            if (cart.value == ""追蹤"") {
                //console.log(carticon.value);
                cart.insertAdjacentHTML = ('beforeend', '<i class=""material-icons"">grade</i>已追蹤');
                c");
                WriteLiteral("art.value = \"已追蹤\";\r\n            }\r\n            else {\r\n                cart.insertAdjacentHTML = (\'beforeend\', \'<i class=\"material-icons\">grade</i>已追蹤\');\r\n                cart.value = \"追蹤\";\r\n            }\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<petsFragrant.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591