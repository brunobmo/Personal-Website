#pragma checksum "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5230d807fe1c1f9184805eadf68bc46b5d56883f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemoBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using DemoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/_Imports.razor"
using DemoBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 691 "/Users/brunooliveira/Projects/DemoBlazor/DemoBlazor/Shared/MainLayout.razor"
        
    protected override async Task OnAfterRenderAsync(bool firstRender){ 
        if (firstRender)
        { 
            await JSRuntime.InvokeVoidAsync("onLoadMain.onscroll");
            await JSRuntime.InvokeVoidAsync("onLoadMain.preloader");
            await JSRuntime.InvokeVoidAsync("onLoadMain.scrolloffset");
            await JSRuntime.InvokeVoidAsync("onLoadMain.clickonscroll");

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
