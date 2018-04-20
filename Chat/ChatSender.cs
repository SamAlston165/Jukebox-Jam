using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatSender : IChatSender
    {
        private IUser user;

        public ChatSender(IUser user)
        {
            this.user = user;
        }

        public void ReceiveMessage()
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message)
        {
            string fullMessage = user.Username + ": " + message;
        }
    }
}
