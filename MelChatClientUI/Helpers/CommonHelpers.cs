using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MelChatClientUI.Helpers
{
    public static class CommonHelpers
    {
        public static string GetVersionString()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion ?? "N/A";
        }
    }
}
