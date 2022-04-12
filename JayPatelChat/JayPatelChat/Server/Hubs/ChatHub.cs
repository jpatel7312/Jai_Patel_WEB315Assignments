using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace JayPatelChat.Server.Hubs
{
    public class ChatHub : Hub
    {

        public async Task SendWhoIsTyping(string user)
        {
            await Clients.All.SendAsync("RecieveWhoIsTyping", user);
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
