using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Client
{
    public class MelChatClientSession(string username, string passwordHash, string melChatServerAddress, int serverPort)
    {
        public string Username { get; private set; } = username;
        private string PasswordHash { get; set; } = passwordHash;
        public string MelChatServerAddress { get; private set; } = melChatServerAddress;
        public int ServerPort { get; private set; } = serverPort;

        private TcpClient? tcpClient = null;

        private async Task<IPAddress[]> ResolveInternetAddress(string ipOrDomainName, CancellationToken cancellationToken)
        {
            // Check if it is an IP address.
            if(IPAddress.TryParse(ipOrDomainName, out IPAddress? ipAddress))
            {
                return [ipAddress];
            }
            // Otherwise, resolve domain name using DNS.
            else
            {
                return await Dns.GetHostAddressesAsync(ipOrDomainName, cancellationToken);
            }
        }

        public async Task<ApiResults> ConnectToServer(CancellationToken cancellationToken)
        {
            try
            {
                var serverAddresses = await ResolveInternetAddress(MelChatServerAddress, cancellationToken);
                tcpClient = new TcpClient();
                foreach (var serverIP in serverAddresses)
                {
                    try
                    {
                        await tcpClient!.ConnectAsync(serverIP, ServerPort, cancellationToken);
                    }
                    catch(Exception)
                    {
                        continue;
                    }
                    if (tcpClient?.Connected == true)
                        return ApiResults.OK;
                }
                return ApiResults.ConnectionToServerFailed;
            }
            catch(Exception)
            {
                return ApiResults.NoSuchHostOrIPIsKnown;
            }
        }
    }
}
