#pragma checksum "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ad7bac58e5488de105dbedc94dff7f8b0c677c"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoListSoliman.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using System.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using System.Web.UI.WebControls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using ToDoListSoliman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\_Imports.razor"
using ToDoListSoliman.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddMarkupContent(2, @"<nav class=""main-header navbar navbar-expand navbar-white navbar-light""><ul class=""navbar-nav""><li class=""nav-item""><a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a></li>
            <li class=""nav-item""><a href class=""nav-link"">Home</a></li></ul></nav>
    ");
            __builder.OpenElement(3, "aside");
            __builder.AddAttribute(4, "class", "main-sidebar sidebar-dark-primary elevation-4");
            __builder.AddMarkupContent(5, "<a href class=\"brand-link\"><img src=\"img/logo.png\" alt=\"Blazor.WebForm Logo\" class=\"brand-image\">\r\n            <span class=\"brand-text font-weight-light\">Blazor.WebForm</span></a>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar");
            __builder.OpenElement(8, "nav");
            __builder.AddAttribute(9, "class", "mt-2");
            __builder.OpenComponent<ToDoListSoliman.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content-wrapper");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "container-fluid");
            __builder.AddContent(18, 
#nullable restore
#line 27 "F:\ProgrammingProjects\WeighMore\Code\ToDoListSoliman\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    <footer class=\"main-footer\"></footer>\r\n    <aside class=\"control-sidebar control-sidebar-dark\"></aside>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenComponent<ToDoListSoliman.Shared.MainScript>(21);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
