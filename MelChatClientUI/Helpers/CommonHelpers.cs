using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MelChatClientUI.Helpers
{
    /// <summary>
    /// Class containing common functions.
    /// </summary>
    public static class CommonHelpers
    {
        /// <summary>
        /// Get current Application Version string.
        /// </summary>
        /// <returns>Product version string, or N/A if not applicable.</returns>
        public static string GetVersionString()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion ?? "N/A";
        }
    }
}
