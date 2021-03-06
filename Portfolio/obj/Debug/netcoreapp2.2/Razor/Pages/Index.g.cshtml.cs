#pragma checksum "/Users/rlussier/www/RS/Portfolio/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5d3035e50051157329c24345adf5a1aa93a027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Portfolio.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Portfolio.Pages.Pages_Index), null)]
namespace Portfolio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/rlussier/www/RS/Portfolio/Pages/_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5d3035e50051157329c24345adf5a1aa93a027", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0b91d38f740f858130f6573772cab915b9c278", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/rlussier/www/RS/Portfolio/Pages/Index.cshtml"
  
    ViewData["Title"] = "Ray Stratos";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(268, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(303, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5d3035e50051157329c24345adf5a1aa93a0273337", async() => {
                BeginContext(309, 104, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(563, 4614, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5d3035e50051157329c24345adf5a1aa93a0274613", async() => {
                BeginContext(569, 368, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""wrapper"">
            <div class=""header_container"">
                <div class=""logo"">
                    <a class=""navbar-brand"" href=""#home"">
                        <img src=""img/RayStratos.png"">
                    </a>
                    <!-- <img src=""img/RayStratos.png""> -->
                </div>
");
                EndContext();
                BeginContext(1586, 3584, true);
                WriteLiteral(@"            </div>

            <div id=""home"" class=""main_container"">
                <!-- <h1>Reggie Lussier</h1> -->
                <img src=""img/RayStratos.png"">
                <p class=""lead"">Web Developer &#x25C8; Designer &#x25C8; Adventurer</p>
            </div>
            <div id=""about"" class=""about_container"">
                <h2>About Me</h2>
                <div class=""about_section"">
                    <img src=""img/animeme.png"">
                    <div class=""about_paragraph"">
                        <h3>
                            “An idea that is developed and put into action
                            is more important than an idea that exists
                            only as an idea.” ~Buddha.
                        </h3>
                        <p>
                            Hi, my name is Regan Lussier. I am a front
                            end developer based in Dallas, TX, with over
                            years of experience in both front end and");
                WriteLiteral(@" back
                            end development.  On my spare time, I enjoy
                            playing the guitar, being in nature, and hanging
                            out with my feathery companion Xena.
                        </p>
                    </div>
                </div>
            </div>
            <div id=""work"" class=""work_container"">
                <h2>My Work</h2>

                <div class=""slick_container"">
                    <div class=""slick responsive active"" data-slick='{""slidesToShow"": 3, ""slidesToScroll"": 3}'>
                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_img.jpg""></a>
                        </div>
                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_img.jpg""></a>
                        </div>
                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_im");
                WriteLiteral(@"g.jpg""></a>
                        </div>

                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_img.jpg""></a>
                        </div>
                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_img.jpg""></a>
                        </div>
                        <div class=""slick__card-body"">
                            <a href=""#""><img src=""img/DoUHave_img.jpg""></a>
                        </div>
                    </div>
                </div>

            </div>


        </div>
        <div id=""contact"" class=""contact_container"">
            <h2>Let's Connect</h2>
            <div class=""contact_info"">
                <span>Phone Number: <a href=""tel:+12693706368"">269-370-6368</a></span>
                <span>Email: <a href=""mailto:reganlussier@gmail.com"">reganlussier@gmail.com</a></span>
            </div>
        </div>
        <div class=""footer_con");
                WriteLiteral(@"tainer"">
            <p>Copyright 2018</p>
        </div>

    </div>
    <script src=""http://code.jquery.com/jquery-1.11.0.min.js""></script>
    <script src=""http://code.jquery.com/jquery-migrate-1.2.1.min.js""></script>
    <script src=""Gruntfile.js""></script>
    <script src=""js/index.js""></script>
    <scripts src=""js/slick/slick.min.js""></scripts>
    <!-- <script src=""//cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.min.js""></script> -->
    <script src=""js/slick/slick.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5177, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
