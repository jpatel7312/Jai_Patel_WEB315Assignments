#pragma checksum "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2279bb4b0cf194e72ee18d5fa03f2c1426f7ec"
// <auto-generated/>
#pragma warning disable 1591
namespace JayPatelChat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using JayPatelChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\_Imports.razor"
using JayPatelChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
using JayPatelChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatapp")]
    public partial class ChatAppComponent : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label for=\"username\">Name:</label>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "id", "username");
            __builder.AddAttribute(7, "placeholder", "Enter Name");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                                                          userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "messaging");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mesgs");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "msg_history");
#nullable restore
#line 18 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
           foreach (var message in messages){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "margin-bottom-15" + " " + (
#nullable restore
#line 19 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                             message.isCurrentUser?"outgoing_msg":"incoming_msg"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "div");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", 
#nullable restore
#line 21 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                  message.isCurrentUser?"sent_msg":"received_withd_msg"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(22, "strong");
            __builder.AddAttribute(23, "class", "messageInfo username");
#nullable restore
#line 22 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
__builder.AddContent(24, message.isCurrentUser?"You":@message.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t          ");
            __builder.OpenElement(26, "p");
#nullable restore
#line 23 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
__builder.AddContent(27, message.Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                      ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "messageInfo");
#nullable restore
#line 24 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
__builder.AddContent(31, message.timeSent.ToString("MMM dd | hh:mm tt"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t  ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "type_msg");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "messageInfo");
            __builder.AddAttribute(37, "hidden", (
#nullable restore
#line 31 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                           whoIsTyping

#line default
#line hidden
#nullable disable
            ) + " ==" + " " + (
#nullable restore
#line 31 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                           userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "User is tupsodifj");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group mb-3");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "id", "usermessage");
            __builder.AddAttribute(46, "placeholder", "Type Message....");
            __builder.AddAttribute(47, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                                                                                                   SendWhoIsTyping

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                                                                                                                             RemoveWhoIsTyping

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                                                                           messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n             ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "input-group-append");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                        Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "disabled", 
#nullable restore
#line 34 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
                                                                          !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-success");
            __builder.AddContent(58, "Send ");
#nullable restore
#line 35 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
__builder.AddContent(59, whoIsTyping);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\axrpt\Documents\Jai_Patel_WEB315Assignments\JayPatelChat\JayPatelChat\Client\Pages\ChatAppComponent.razor"
       
    private HubConnection hubConnection;
    private List<UserMessage> messages = new();
    private string userInput;
    private string messageInput;
    private string whoIsTyping = "";

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder() 
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            whoIsTyping = user;
            messages.Add(new UserMessage{Username = user,Message = message, isCurrentUser= user==userInput,timeSent = DateTime.Now});
            StateHasChanged();
        });

        hubConnection.On<string>("RecieveWhoIsTyping", (user) =>
        {
            whoIsTyping = user;
            StateHasChanged();
        });


        await hubConnection.StartAsync();
    }

    async Task Send(){
        if(!String.IsNullOrEmpty(userInput) && !String.IsNullOrEmpty(messageInput)){
            await hubConnection.SendAsync("SendMessage", userInput, messageInput);
            messageInput = "";
            RemoveWhoIsTyping();
        }
    }

    async Task SendWhoIsTyping(){
        await hubConnection.SendAsync("SendWhoIsTyping",userInput);
    }
    
    async Task RemoveWhoIsTyping(){
        await hubConnection.SendAsync("SendWhoIsTyping","");
    }
        
    

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
