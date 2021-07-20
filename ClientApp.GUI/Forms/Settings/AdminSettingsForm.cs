using ClientApp.RestApiClient.Endpoints.V1.Accounts;
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
    public partial class AdminSettingsForm : Form
    {
        private readonly SimpleInjector.Container _container;
        private readonly IAccountsRestClient _accountsRestClient;
        public AdminSettingsForm(SimpleInjector.Container container, IAccountsRestClient accountsRestClient)
        {
            _container = container;
            _accountsRestClient = accountsRestClient;
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
            => _container.GetInstance<ChangePasswordForm>().ShowDialog();

        private async void AdminSettingsForm_Load(object sender, EventArgs e)
        {
            var account = await _accountsRestClient.GetAsync();
            EmailLabel.Text = $"Email: {account.Email}";
            NameLabel.Text = $"Name: {account.Name}";
            RoleLabel.Text = $"Role: {account.Role}";
        }
    }
}
