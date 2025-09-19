using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MelChatAPI.Client
{
    public class MelChatClientSession(string username, string passwordHash, string melChatServerAddress, int serverPort)
    {
        private const int NUM_BYTES_PACKET_READ = 1024;

        public string Username { get; private set; } = username;
        private string PasswordHash { get; set; } = passwordHash;
        public string MelChatServerAddress { get; private set; } = melChatServerAddress;
        public int ServerPort { get; private set; } = serverPort;

        private TcpClient? tcpClient = null;

        private NetworkStream? networkStream = null;

        private CancellationToken sslReadCancellationToken = default;

        private static async Task<IPAddress[]> ResolveInternetAddress(string ipOrDomainName, CancellationToken cancellationToken)
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
                    if (cancellationToken.IsCancellationRequested)
                        return ApiResults.TaskCanceledByUser;
                    try
                    {
                        await tcpClient!.ConnectAsync(serverIP, ServerPort, cancellationToken);
                    }
                    catch(Exception)
                    {
                        continue;
                    }
                    if (tcpClient?.Connected == true)
                    {
                        await InitiateSimpleTcpConnection(cancellationToken);
                        return ApiResults.OK;
                    }
                }
                return ApiResults.ConnectionToServerFailed;
            }
            catch(Exception)
            {
                return ApiResults.NoSuchHostOrIPIsKnown;
            }
        }

        private async Task InitiateSimpleTcpConnection(CancellationToken cancellationToken)
        {
            networkStream = tcpClient!.GetStream();
            _ = Task.Run(() => PollIncomingData(sslReadCancellationToken), sslReadCancellationToken);
        }

        private async Task PollIncomingData(CancellationToken cancellationToken)
        {
            // Read buffer header size only at first.
            byte[] messageLengthBuffer = new byte[8];
            await networkStream!.ReadExactlyAsync(messageLengthBuffer, 0, 8, cancellationToken);
            long packetLength = BitConverter.ToInt64(messageLengthBuffer, 0);

            byte[] messageBuffer = new byte[packetLength];
            await networkStream!.ReadExactlyAsync(messageBuffer, cancellationToken);
            string messageJsonBase64 = Encoding.UTF8.GetString(messageBuffer);
            string messageJson = Encoding.UTF8.GetString(Convert.FromBase64String(messageJsonBase64));
        }
    }
}
