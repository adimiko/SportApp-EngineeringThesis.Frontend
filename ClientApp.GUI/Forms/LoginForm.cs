using ClientApp.GUI.Extensions;
using ClientApp.RestApiClient.Endpoints.V1.Accounts;
using ClientApp.RestApiClient.Endpoints.V1.Identity;
using ClientApp.RestApiClient.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IIdentityRestClient _identityRestClient;
        private readonly IAccountsRestClient _accountsRestClient;
        private readonly Login login = new Login();
        private readonly IMessenger _messenger;
        private readonly SimpleInjector.Container _container;

        public LoginForm(SimpleInjector.Container container, IMessenger messenger, IIdentityRestClient identityRestClient, IAccountsRestClient accountsRestClient)
        {
            _messenger = messenger;
            _identityRestClient = identityRestClient;
            _accountsRestClient = accountsRestClient;
            _container = container;
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                login.Email = EmailTextBox.Text;
                login.Password = PasswordTextBox.Text;

                await _identityRestClient.Login(login);
                var account = await _accountsRestClient.GetAsync();
                if (account.Role == "admin")
                {
                    this.Hide();
                    _container.GetInstance<AdminMainMenuForm>().ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    _container.GetInstance<MainMenuForm>().ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
            => _container.GetInstance<RegisterForm>().ShowDialog();

    }
}
