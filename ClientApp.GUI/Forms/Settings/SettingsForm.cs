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
    public partial class SettingsForm : Form
    {
        private readonly SimpleInjector.Container _container;
        private readonly IAccountsRestClient _accountsRestClient;
        public SettingsForm(SimpleInjector.Container container, IAccountsRestClient accountsRestClient)
        {
            _container = container;
            _accountsRestClient = accountsRestClient;
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
            => _container.GetInstance<ChangePasswordForm>().ShowDialog();

        private async void SettingsForm_Load(object sender, EventArgs e)
        {
            var account = await _accountsRestClient.GetAsync();
            EmailLabel.Text = $"Email: {account.Email}";
            NameLabel.Text = $"Name: {account.Name}";
            RoleLabel.Text = $"Role: {account.Role}";
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the account?", "Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _accountsRestClient.DeleteAsync();
                Application.Exit();
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
