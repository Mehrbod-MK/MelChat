using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace MelChatServerCLI.Models
{
    public class ServerConfigurations
    {
        public const string SERVER_CONFIGURATION_FILE_NAME = "melchat.server.config";
        public static readonly string CurrentServerDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
        public static readonly string ServerConfigurationFilePath = Path.Combine(CurrentServerDirectory, SERVER_CONFIGURATION_FILE_NAME);

        private static readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions() { WriteIndented = true };

        public int ServerPort { get; set; } = 9090;

        public static void SaveServerConfigurations(ServerConfigurations configurationsInstance)
        {
            string configurationsJson = JsonSerializer.Serialize(configurationsInstance, serializerOptions);
            File.WriteAllText(ServerConfigurationFilePath, configurationsJson);
        }

        public static void LoadServerConfigurations(ServerConfigurations configurationsInstance)
        {
            try
            {
                string configurationsJson = File.ReadAllText(ServerConfigurationFilePath);
                configurationsInstance = JsonSerializer.Deserialize<ServerConfigurations>(configurationsJson) ?? new ServerConfigurations();
            }
            catch { /* Do nothing. */ }
            SaveServerConfigurations(configurationsInstance);
        }
    }
}
