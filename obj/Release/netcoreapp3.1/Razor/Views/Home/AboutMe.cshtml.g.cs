#pragma checksum "D:\C Shapr\Projects\ASP Projects\Resume\Resume\Views\Home\AboutMe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355b50c89b15c6ab47891158cecc13bce1c8c402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutMe), @"mvc.1.0.view", @"/Views/Home/AboutMe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355b50c89b15c6ab47891158cecc13bce1c8c402", @"/Views/Home/AboutMe.cshtml")]
    public class Views_Home_AboutMe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355b50c89b15c6ab47891158cecc13bce1c8c4022720", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>My awesome Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT""
          crossorigin=""anonymous"" />
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3""
            crossorigin=""anonymous""></script>
    <style>
        .left-card {
            width: 18rem;
            text-align: left;
        }

        .right-card {
            width: 18rem;
            text-align: right;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355b50c89b15c6ab47891158cecc13bce1c8c4024553", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""/""></a>
            <button class=""navbar-toggler""
                    type=""button""
                    data-bs-toggle=""collapse""
                    data-bs-target=""#navbarNav""
                    aria-controls=""navbarNav""
                    aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" aria-current=""page"" href=""Index"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#"">About me</a>
                    </li>
                </ul>
            </div>
   ");
                WriteLiteral(@"     </div>
    </nav>
    <div class=""container my-3"">
        <div class=""row"">
            <div class=""col-12"">
                <h1>О себе</h1>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <p>
                    Меня зовут Эпштейн Анна Александровна. Я родилась 10 ноября 2001
                    года в городе Бобруйске. В 6 лет я пошла в 16 школу. Позже в 5
                    классе перевелась в 31 школу. Закончила в 2019 году 31 школу и в
                    этом же году поступила в Беларуский Государственный Университет
                    (далее -БГУ). В 2023 году получила диплом о высшем юридическом
                    образовании категории бакалавр. В данный момент я работаю в
                    прокуратуре фрунзенского района ""ПФР"".
                </p>
                <p>
                    Университет закончила с оценками не ниже 7. Опыт работы в
                    прок");
                WriteLiteral(@"уратуре: 1 год. Знания английского: Уровень Б2.
                <p>
                    <a href=""https://31bobr.schools.by/""
                       class=""btn btn-primary""
                       target=""_blank"">Моя школа</a>
                    <a href=""https://bsu.by/"" class=""btn btn-primary"" target=""_blank"">Мой университет</a>
                </p>
                </p>
            </div>
        </div>
    </div>
    <div class=""container my-5"">
        <div class=""row"">
            <h2>
                Мои работы:
            </h2>
            <p class=""my-2"">
                <a");
                BeginWriteAttribute("href", " href=\"", 3558, "\"", 3565, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">Мой дипломный проект</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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