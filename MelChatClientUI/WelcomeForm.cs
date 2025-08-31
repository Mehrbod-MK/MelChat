using MelChatClientUI.Forms;
using MelChatClientUI.Helpers;

namespace MelChatClientUI
{
    /// <summary>
    /// Initial welcome form.
    /// </summary>
    public partial class WelcomeForm : Form
    {
        /// <summary>
        /// Welcome form default .ctor
        /// </summary>
        public WelcomeForm()
        {
            InitializeComponent();

            labelAbout.Text = $"Developed by: Mehrbod Molla Kazemi\nApp Version: {CommonHelpers.GetVersionString()}";
        }

        private void buttonStartChatting_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
