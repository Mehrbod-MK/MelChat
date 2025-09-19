using MelChatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Server
{
    public class MelChatClientConnection
    {
        private TcpClient tcpClient { get; set; }

        private NetworkStream? networkStream { get; set; } = null;

        private CancellationToken keepAliveCancellationToken = default;

        public MelChatClientConnection(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            networkStream = tcpClient.GetStream();
            _ = Task.Run(InitiateSimpleConnection);
        }

        private async Task InitiateSimpleConnection()
        {
            await IdentifyClient();
            _ = Task.Run(CheckPingLoop);
        }

        private async Task IdentifyClient()
        {
            IdentifyMelChatClientRequest identifyMelChatClientRequest = new IdentifyMelChatClientRequest("123", "123");
            await identifyMelChatClientRequest.SendRequest(networkStream!, keepAliveCancellationToken);
        }

        private async Task CheckPingLoop()
        {
            while(!keepAliveCancellationToken.IsCancellationRequested)
            {
                
            }
        }
    }
}
