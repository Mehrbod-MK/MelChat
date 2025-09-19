using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Logging
{
    public static class Logger
    {
        public enum LogLevels
        {
            Info,
            Warning,
            Error,
        }

        public static async Task Log(string message)
        {
            await Log(LogLevels.Info, message);
        }

        public static async Task Log(LogLevels logLevel, string message)
        {
            string logText = $"[{DateTime.Now}]\t[{logLevel.ToString().ToUpper()}]:\t{message}";
            if (logLevel != LogLevels.Error)
                await Console.Out.WriteLineAsync(logText);
            else
                await Console.Error.WriteLineAsync(logText);
        }
    }
}
