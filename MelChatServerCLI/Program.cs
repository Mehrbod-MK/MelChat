using MelChatAPI.Logging;
using MelChatServerCLI.Models;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;

namespace MelChatServerCLI
{
    public class Program
    {
        private static ServerConfigurations serverConfigurations = new ServerConfigurations();

        private static CancellationToken cancellationToken;

        static async Task Main(string[] args)
        {
            await Logger.Log("In the name of God.");
            await Logger.Log($"MelChat™ Server CLI, version {FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}\n");

            ServerConfigurations.LoadServerConfigurations(serverConfigurations);
            _ = Task.Run(() => PollIncomingConnections(cancellationToken));

            while(!cancellationToken.IsCancellationRequested)
            {

            }
        }

        static async Task PollIncomingConnections(CancellationToken cancellationToken = default)
        {
            TcpListener tcpListener = new TcpListener(System.Net.IPAddress.Any, serverConfigurations.ServerPort);
            tcpListener.Start();
            await Logger.Log($"Server is listening to port {serverConfigurations.ServerPort} for incoming client connections...");
            while (!cancellationToken.IsCancellationRequested)
            {
                var newClient = await tcpListener.AcceptTcpClientAsync(cancellationToken);
                
            }
        }
    }
}
