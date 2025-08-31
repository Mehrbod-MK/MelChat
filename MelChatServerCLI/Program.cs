using MelChatServerCLI.Models;
using System.Net.Sockets;

namespace MelChatServerCLI
{
    public class Program
    {
        private static ServerConfigurations serverConfigurations = new ServerConfigurations();

        static void Main(string[] args)
        {
            ServerConfigurations.LoadServerConfigurations(serverConfigurations);
        }
    }
}
