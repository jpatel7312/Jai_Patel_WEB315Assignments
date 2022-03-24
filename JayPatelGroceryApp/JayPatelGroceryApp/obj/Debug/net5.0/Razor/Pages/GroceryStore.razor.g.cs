#pragma checksum "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22024cd729f1061c98abb43f96277fe55aef98ca"
// <auto-generated/>
#pragma warning disable 1591
namespace JayPatelGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using JayPatelGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\_Imports.razor"
using JayPatelGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddContent(1, "Welcome to JP\'s Grocery Store");
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddMarkupContent(3, "<h3>Add/Remove Food Item to an isle</h3>\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "hidden", 
#nullable restore
#line 5 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
              hideOnPage

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(6, "ul");
#nullable restore
#line 7 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
        foreach (var isle in groceryIsles)
       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
#nullable restore
#line 9 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
__builder.AddContent(8, isle.isleName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
       }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "placeholder", "Add Grocery Isle");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
                                                                                          newIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newIsle = __value, newIsle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-success");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
                                                      AddIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Add Isle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelGroceryApp\JayPatelGroceryApp\Pages\GroceryStore.razor"
       

    [Parameter]
    public string hideOnPage { get; set; }

    private List<GroceryIsle> groceryIsles = new();
    private string? newIsle;

   
    private void AddIsle()
    {
        if (!string.IsNullOrWhiteSpace(newIsle))
        {
            groceryIsles.Add(new GroceryIsle { isleName = newIsle });
            newIsle = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
