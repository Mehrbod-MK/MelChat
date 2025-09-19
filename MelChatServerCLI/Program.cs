using MelChatAPI.Logging;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using MelChatAPI.Server;
using System.Runtime.CompilerServices;

namespace MelChatServerCLI
{
    public class Program
    {
        public static ServerConfigurations serverConfigurations = new ServerConfigurations();

        private static CancellationToken cancellationToken;

        private static readonly List<MelChatClientConnection> clientConnections = new List<MelChatClientConnection>();

        static async Task Main(string[] args)
        {
            await Logger.Log("In the name of God.");
            await Logger.Log($"MelChat™ Server CLI, version {FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}\n");

            ServerConfigurations.LoadServerConfigurations(serverConfigurations);
            _ = Task.Run(() => PollIncomingConnections(cancellationToken));

            while (!cancellationToken.IsCancellationRequested)
            {

            }
        }

        static async Task PollIncomingConnections(CancellationToken cancellationToken)
        {
            TcpListener tcpListener = new TcpListener(System.Net.IPAddress.Any, serverConfigurations.ServerPort);
            tcpListener.Start();
            await Logger.Log($"Server is listening on port {serverConfigurations.ServerPort} for incoming client connections...");
            while (!cancellationToken.IsCancellationRequested)
            {
                var newTcpClient = await tcpListener.AcceptTcpClientAsync(cancellationToken);
                await Logger.Log($"NEW CLIENT CONNECTED:  {newTcpClient.Client.RemoteEndPoint?.ToString()}");
                clientConnections.Add(new MelChatClientConnection(newTcpClient));
            }
        }
    }
}
