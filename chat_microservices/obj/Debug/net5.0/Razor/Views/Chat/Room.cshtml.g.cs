#pragma checksum "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\Chat\Room.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9ccc7704d00b4a823644b14312405ad5804599e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Room), @"mvc.1.0.view", @"/Views/Chat/Room.cshtml")]
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
#line 1 "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\_ViewImports.cshtml"
using chat_microservices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\_ViewImports.cshtml"
using chat_microservices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ccc7704d00b4a823644b14312405ad5804599e", @"/Views/Chat/Room.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e61364d0dbe1e449034b730e2bcf4a26859f58", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chat_Room : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\Chat\Room.cshtml"
Write(chat_microservices.Controllers.ChatController.Rooms.GetValueOrDefault(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""row""> 
    <div class=""col-12"">
        <input type=""text"" placeholder=""usuario"" id=""user"" />
        <input type=""text"" placeholder=""mensaje"" id=""message"" />
        <button id=""btnSend"">Send</button>
    </div>
</div>

<div class=""row"">
    <div class=""col-6"">
        <div id=""messages""></div>
    </div>
    <div class=""col-6"">
        <div id=""notifications""></div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ccc7704d00b4a823644b14312405ad5804599e4316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    var connection = new signalR.HubConnectionBuilder().withUrl(\"/chat\").build();\r\n    connection.start().then(() => {\r\n        connection.invoke(\"AddToGroup\", \"");
#nullable restore
#line 27 "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\Chat\Room.cshtml"
                                    Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n    }).catch((e) => console.error(e));\r\n\r\n    document.getElementById(\"btnSend\").addEventListener(\"click\", (event) => {\r\n\r\n        let room = \"");
#nullable restore
#line 32 "C:\Users\sebastian\Documents\chat_microservices\chat_microservices\Views\Chat\Room.cshtml"
               Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        let user = document.getElementById(""user"").value;
        let message = document.getElementById(""message"").value;

        connection.invoke(""SendMessage"", room, user, message)
            .catch((e) =>  console.log(e.toString()))

        document.getElementById(""message"").value = """";
        document.getElementById(""message"").focus();

        event.preventDefault();
    })
    
    connection.on(""ReceiveMessage"", (user , message) => {
        var message = ""<div><b>"" + user + ""</b>"" + message + ""</div>"";
        document.getElementById(""messages"").innerHTML =
            message + document.getElementById(""messages"").innerHTML;
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
