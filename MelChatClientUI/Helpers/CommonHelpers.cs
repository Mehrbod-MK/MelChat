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
            return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "N/A";
        }

        public static void IndicateFieldMessage(Bitmap icon, string message, NotifyIndicatorTypes indicatorType, PictureBox iconPictureBox, Label labelInfo)
        {
            iconPictureBox.Image = icon;
            labelInfo.Text = message;
            switch(indicatorType)
            {
                case NotifyIndicatorTypes.Information:
                    labelInfo.ForeColor = Color.Gray;
                    break;
                case NotifyIndicatorTypes.Warning:
                    labelInfo.ForeColor = Color.Olive;
                    break;
                case NotifyIndicatorTypes.Error:
                    labelInfo.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
