using MelChatClientUI.Helpers;

namespace MelChatClientUI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            labelAbout.Text = $"Developed by: Mehrbod Molla Kazemi\nApp Version: {CommonHelpers.GetVersionString()}";
        }
    }
}
