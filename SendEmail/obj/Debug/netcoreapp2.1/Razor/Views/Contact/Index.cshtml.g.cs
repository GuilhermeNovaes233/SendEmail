#pragma checksum "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3fb4e6b6d8ae02eebf978ac93164392b18c6f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\_ViewImports.cshtml"
using SendEmail;

#line default
#line hidden
#line 2 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\_ViewImports.cshtml"
using SendEmail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3fb4e6b6d8ae02eebf978ac93164392b18c6f4", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8bccef37b9b1cdf820a33c1e3db1f2443ead2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SendEmail.Site.Web.Models.EmailSettings>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(93, 30, true);
            WriteLiteral("\r\n    <h2>Enviar e-mail</h2>\r\n");
            EndContext();
#line 8 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
 using (Html.BeginForm("sendmail", "contact", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(196, 28, false);
#line 10 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(230, 49, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(280, 64, false);
#line 16 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(344, 105, true);
            WriteLiteral("\r\n\r\n    <label>Email:</label>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(450, 96, false);
#line 21 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
       Write(Html.EditorFor(model => model.ToEmail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(546, 135, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <label>Assunto:</label>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(682, 96, false);
#line 28 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
       Write(Html.EditorFor(model => model.Subject, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(778, 136, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <label>Mensagem:</label>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(915, 96, false);
#line 35 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
       Write(Html.EditorFor(model => model.Message, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 107, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</div>\r\n");
            EndContext();
#line 41 "C:\Users\GuilhermeSilva\Desktop\Cursos\APIs com Asp .Net Core e EF Core\SendEmail\SendEmail\Views\Contact\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1121, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SendEmail.Site.Web.Models.EmailSettings> Html { get; private set; }
    }
}
#pragma warning restore 1591
