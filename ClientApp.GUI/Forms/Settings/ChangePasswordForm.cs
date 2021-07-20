using ClientApp.GUI.Extensions;
using ClientApp.RestApiClient.Endpoints.V1.Accounts;
using ClientApp.RestApiClient.Models.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.Settings
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IAccountsRestClient _accountsRestClient;
        private readonly IMessenger _messenger;

        public ChangePasswordForm(IAccountsRestClient accountsRestClient, IMessenger messenger)
        {
            _accountsRestClient = accountsRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                var changePassword = new ChangePassword();
                changePassword.OldPassword = OldPasswordTextBox.Text;
                changePassword.NewPassword = NewPasswordTextBox.Text;
                changePassword.ConfirmNewPassword = ConfirmNewPasswordTextBox.Text;

                await _accountsRestClient.ChangePassword(changePassword);
                this.Close();
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
            }

        }
    }
}
