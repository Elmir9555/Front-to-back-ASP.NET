#pragma checksum "/Users/elmirustayev/Projects/Front.to.Back/Front.to.Back/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335a23a8ce2d9f136cc5812ae366c68439122919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335a23a8ce2d9f136cc5812ae366c68439122919", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>

    <section id=""transition"">

        <div class=""first-row"">
            <div class=""container"">
                <div class=""transition"">
                    <span class=""home"">HOME</span>
                    <span class=""icon"">
                        <i class=""fa-solid fa-greater-than""></i>
                    </span>

                    <span class=""account"">CART</span>
                </div>
            </div>
        </div>

    </section>


    <section id=""product-price-count"">
        <div class=""product-price-count"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-8"">
                        <div class=""product-names"">
                            <div class=""product"">
                                <span>Product</span>
                            </div>

                            <div class=""price-quant-subtotal"">
                                <div class=""price-quant"">
                                    <div class=""price"">
   ");
            WriteLiteral(@"                                     Price
                                    </div>
                                    <div class=""quant"">
                                        Quantity
                                    </div>
                                </div>

                                <div class=""subtotal"">
                                    Subtotal
                                </div>
                            </div>
                        </div>

                        <div class=""choosen-product"">
                            <div class=""product-img"">
                                <img src=""./assets/img/boom chicka.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 1684, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;height:100%"">
                            </div>

                            <div class=""product-nm"">
                                <p>Angie's Boomchickapop Sweet & Salty Kettle Corn</p>
                            </div>

                            <div class=""prc"">
                                <span>$3.29</span>
                            </div>

                            <div class=""count-minus"">
                                <div class=""minus"">
                                    -
                                </div>
                                <div class=""count"">
                                    1
                                </div>
                                <div class=""plus"">
                                    +
                                </div>
                            </div>

                            <div class=""total"">
                                <span>$3.29</span>
                            </div>

                            <div cl");
            WriteLiteral(@"ass=""x"">
                                x
                            </div>

                        </div>

                        <div class=""choosen-product"">
                            <div class=""product-img"">
                                <img src=""./assets/img/chao.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 2999, "\"", 3005, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;height:100%"">
                            </div>

                            <div class=""product-nm"">
                                <p>Field Roast Chao Cheese Creamy Original</p>
                            </div>

                            <div class=""prc ps-1"">
                                <span>$19.50</span>
                            </div>

                            <div class=""count-minus "">
                                <div class=""minus"">
                                    -
                                </div>
                                <div class=""count"">
                                    1
                                </div>
                                <div class=""plus"">
                                    +
                                </div>
                            </div>

                            <div class=""total"">
                                <span>$19.50</span>
                            </div>

                            <div cl");
            WriteLiteral(@"ass=""x"">
                                x
                            </div>

                        </div>

                        <div class=""inpt-part"">
                            <input type=""text"" placeholder=""Coupon code"">
                            <button id=""applycoupon"">Apply coupon</button>
                            <button id=""updatecart"">Update cart</button>
                        </div>
                    </div>
                    <div class=""col-4"">

                        <div class=""sales-schedule"">
                            <div class=""card-total"">
                                CART TOTALS
                            </div>
                            <div class=""subtotal-price"">
                                <div class=""subtotal"">
                                    Subtotal
                                </div>
                                <div class=""price"">
                                    $22.79
                                </div>
                            <");
            WriteLiteral(@"/div>

                            <div class=""shipping-schedule"">
                                <div class=""shipping"">
                                    Shipping
                                </div>
                                <div class=""radius"">
                                    <div class=""name-radius"">
                                        <div class=""select"">
                                            <span>Flat rate: <span class=""us"">$5.00</span> </span>
                                            <input type=""radio"" id=""contactChoice1"" name=""contact"" value=""email""
                                                   checked>
                                        </div>
                                        <div class=""select"">
                                            <span>Free shipping </span>
                                            <input type=""radio"" id=""contactChoice2"" name=""contact"" value=""email"">
                                        </div>
                             ");
            WriteLiteral(@"           <div class=""select"">
                                            <span>Local pickup</span>
                                            <input type=""radio"" id=""contactChoice3"" name=""contact"" value=""email"">
                                        </div>
                                        <div class=""select"">
                                            <span>Shipping to <strong>AL</strong> </span>
                                        </div>
                                        <a href=""#"">Change address</a>
                                    </div>
                                </div>
                            </div>

                            <div class=""total-section"">
                                <div class=""total"">
                                    Total
                                </div>
                                <div class=""price"">
                                    $27.79
                                </div>
                            </div>

               ");
            WriteLiteral(@"             <div class=""check"">
                                <button id=""chck"">Proceed to checkout</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>

</main>
");
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
