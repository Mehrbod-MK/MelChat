using MelChatAPI.Client;
using MelChatClientUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelChatClientUI.Forms
{
    public partial class LoginForm : Form
    {
        public MelChatClientSession? clientSession = null;

        private Bitmap errorBitmap = Properties.Resources.error;
        private Bitmap infoBitmap = Properties.Resources.information;

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool UsernameInputValidation()
        {
            bool result = true;
            pictureBoxInfoUsername.Visible = labelInfoUsername.Visible = true;
            if (textBoxUsername.Text.Length < 8 || textBoxUsername.Text.Length > 32)
            {
                CommonHelpers.IndicateFieldMessage(errorBitmap, "At least 8 characters, up to 32.", NotifyIndicatorTypes.Error, pictureBoxInfoUsername, labelInfoUsername);
                result = false;
            }
            else
            {
                pictureBoxInfoUsername.Visible = labelInfoUsername.Visible = false;
            }
            return result;
        }

        private bool PasswordInputValidation()
        {
            bool result = true;
            pictureBoxInfoPassword.Visible = labelInfoPassword.Visible = true;
            if (textBoxPassword.Text.Length < 8 || textBoxPassword.Text.Length > 100)
            {
                CommonHelpers.IndicateFieldMessage(errorBitmap, "At least 8 characters, up to 100.", NotifyIndicatorTypes.Error, pictureBoxInfoPassword, labelInfoPassword);
                result = false;
            }
            else
            {
                pictureBoxInfoPassword.Visible = labelInfoPassword.Visible = false;
            }
            return result;
        }

        private bool ServerIPDomainInputValidation()
        {
            bool result = true;
            pictureBoxInfoServerIPDomain.Visible = labelInfoServerIPDomain.Visible = true;
            if (string.IsNullOrEmpty(textBoxServerIP.Text.Trim()) || string.IsNullOrWhiteSpace(textBoxServerIP.Text.Trim()))
            {
                CommonHelpers.IndicateFieldMessage(errorBitmap, "IP/Domain cannot be empty.", NotifyIndicatorTypes.Error, pictureBoxInfoServerIPDomain, labelInfoServerIPDomain);
                result = false;
            }
            else
            {
                pictureBoxInfoServerIPDomain.Visible = labelInfoServerIPDomain.Visible = false;
            }
            return result;
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            UsernameInputValidation();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            PasswordInputValidation();
        }

        private void textBoxServerIP_Leave(object sender, EventArgs e)
        {
            ServerIPDomainInputValidation();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            UsernameInputValidation();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordInputValidation();
        }

        private void textBoxServerIP_TextChanged(object sender, EventArgs e)
        {
            ServerIPDomainInputValidation();
        }

        private bool ValidateAllFields()
        {
            bool result = true;
            result &= UsernameInputValidation();
            result &= PasswordInputValidation();
            result &= ServerIPDomainInputValidation();
            return result;
        }

        private void buttonStartChatting_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
                return;

            EnableUI(false);
        }

        private void EnableUI(bool enable)
        {
            textBoxUsername.Enabled = textBoxPassword.Enabled = textBoxServerIP.Enabled
                = linkLabelSignUp.Enabled = linkLabelAccountRecovery.Enabled
                = buttonLogin.Enabled
                = enable;
        }
    }
}
