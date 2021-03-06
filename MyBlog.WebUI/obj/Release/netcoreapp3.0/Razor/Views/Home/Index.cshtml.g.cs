#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceddc279ee774cefba363a4e523f5638f8ad1715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceddc279ee774cefba363a4e523f5638f8ad1715", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ömer ARIYÜREK - .NET Developer";

#line default
#line hidden
#nullable disable
            DefineSection("metaTags", async() => {
                WriteLiteral(@"
    <meta name=""description"" content=""Ömer Arıyürek .NET Developer,C#,ASP.NET Core MVC,.NET Core,.NET,ASP.NET MVC,Entity Framework,Design Patterns,ASP.NET Core Web Api,Object Oriented Programming hakkında yazılar"" />
    <meta name=""keywords"" content=""Ömer Arıyürek,C#,ASP.NET CORE,.NET Core,.NET,Entity Framework,Ömer Arıyürek,C#,ASP.NET CORE MVC,.NET Core,.NET,Entity Framework,Design Patterns,ASP.NET MVC,ASP.NET Core Web Api"" />
    <meta property=""og:image""");
                BeginWriteAttribute("content", " content=\"", 610, "\"", 675, 1);
#nullable restore
#line 9 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 620, Url.Content("~/Content/images/omer-ariyurek-logo.png"), 620, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:title\"");
                BeginWriteAttribute("content", " content=\"", 710, "\"", 738, 1);
#nullable restore
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 720, ViewData["Title"], 720, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
    <meta property=""og:url"" content=""https://www.omerariyurek.com"">
    <meta property=""og:description"" content=""Ömer Arıyürek .NET Developer,C#,ASP.NET Core MVC,.NET Core,.NET,ASP.NET MVC,Entity Framework,Design Patterns,ASP.NET Core Web Api,Object Oriented Programming hakkında yazılar"" />
");
            }
            );
            WriteLiteral(@"<section class=""homepage-content"">
    <div class=""homepage-content__about-me"">
        <img class=""homepage-content__my-photo"">
        <div class=""homepage-content__about-txt"">
            <span class=""homepage-content__about-txt--hello"">Merhaba! Ben</span>
            <span class=""homepage-content__about-txt--name"">Ömer Arıyürek</span>
            <p class=""homepage-content__about-txt--about-content"">
                Yazılım ile lise yıllarımda bilişim teknolojileri bölümünde okurken tanıştım. Daha sonrasında üniversitede ise bilgisayar programcılığı bölümünü bitirdim. Yaklaşık 5 senedir kod yazmakla birlikte bilgilerime yenilerini eklemekteyim. Ağırlıklı olarak Microsoft teknolojilerini kullanmaktayım. Blogumda elimden geldiğince bildiklerim ve öğrendiğim teknolojiler hakkında yazılar yazmaya çalışacağım...
            </p>
        </div>
        <div class=""homepage-content__about-me--background-image""></div>
    </div>
    <div class=""homepage-content__recents-articles"">
        <h3 class=""");
            WriteLiteral("homepage-content__recents-articles--recents-title\">Son Yazılar</h3>\r\n        <ul class=\"homepage-content__articles-list\">\r\n");
#nullable restore
#line 29 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
             foreach (var post in Model.Posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"homepage-content__articles-list--item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2339, "\"", 2396, 1);
#nullable restore
#line 32 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2346, Url.Action("Get","Post",new{@seoUrl=post.SeoUrl}), 2346, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2397, "\"", 2416, 1);
#nullable restore
#line 32 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2405, post.Title, 2405, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2448, "\"", 2470, 1);
#nullable restore
#line 33 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2454, post.CoverImage, 2454, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2471, "\"", 2488, 1);
#nullable restore
#line 33 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2477, post.Title, 2477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2489, "\"", 2508, 1);
#nullable restore
#line 33 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2497, post.Title, 2497, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h5 class=\"homepage-content__articles-list--content-title\">");
#nullable restore
#line 34 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
                                                                              Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </a>\r\n                    <span class=\"homepage-content__articles-list--content-date\">");
#nullable restore
#line 36 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
                                                                           Write(post.CreatedDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 38 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <div class=\"homepage-content__recents-articles--more-btn\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2903, "\"", 2937, 1);
#nullable restore
#line 41 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2910, Url.Action("Index","Post"), 2910, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">TÜM YAZILAR</a>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
