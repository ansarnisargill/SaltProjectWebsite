#pragma checksum "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f0405f3fb4e7d3cd73f78559cb0961f655889d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(XtendersProject.Pages.Shared.Pages_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_CookieConsentPartial.cshtml", typeof(XtendersProject.Pages.Shared.Pages_Shared__CookieConsentPartial))]
namespace XtendersProject.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\_ViewImports.cshtml"
using XtendersProject;

#line default
#line hidden
#line 1 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f0405f3fb4e7d3cd73f78559cb0961f655889d", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e97a2ad5d7bcd710cbb4e675450a99777c6931a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
            BeginContext(248, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml"
 if (showBanner)
{

#line default
#line hidden
            BeginContext(271, 189, true);
            WriteLiteral("    <article class=\"message\" id=\"consent\">\r\n        <div class=\"message-header\">\r\n            <p>Hello World</p>\r\n            <button class=\"delete\" aria-label=\"delete\" data-cookie-string=\"");
            EndContext();
            BeginContext(461, 12, false);
#line 14 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml"
                                                                      Write(cookieString);

#line default
#line hidden
            EndContext();
            BeginContext(473, 584, true);
            WriteLiteral(@"""></button>
        </div>
        <div class=""message-body"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. <strong>Pellentesque risus mi</strong>, tempus quis placerat ut, porta nec nulla. Vestibulum rhoncus ac ex sit amet fringilla. Nullam gravida purus diam, et dictum <a>felis venenatis</a> efficitur. Aenean ac <em>eleifend lacus</em>, in mollis lectus. Donec sodales, arcu et sollicitudin porttitor, tortor urna tempor ligula, id porttitor mi magna a neque. Donec dui urna, vehicula et sem eget, facilisis sodales sem.
        </div>
    </article>
");
            EndContext();
#line 20 "C:\Users\it\Desktop\SaltProjectWebsite\Pages\Shared\_CookieConsentPartial.cshtml"
}

#line default
#line hidden
            BeginContext(1060, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
