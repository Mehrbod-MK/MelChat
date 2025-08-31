using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Client
{
    public class MelChatClientSession(string username, string passwordHash, string melChatServerAddress)
    {
        public string Username { get; private set; } = username;
        private string PasswordHash { get; set; } = passwordHash;
        public string MelChatServerAddress { get; private set; } = melChatServerAddress;

        private TcpClient? tcpClient = null;

        public async Task ConnectToServer(CancellationToken cancellationToken = default)
        {
            
        }
    }
}
