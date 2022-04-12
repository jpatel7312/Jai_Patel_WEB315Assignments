using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayPatelChat.Shared
{
    public class UserMessage
    {
        public string Username { get; set; }
        public string Message { get; set; }
        public bool isCurrentUser { get; set; }
        public DateTime timeSent { get; set; }
    }
}
