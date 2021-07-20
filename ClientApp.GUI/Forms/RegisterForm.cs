using ClientApp.GUI.Extensions;
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
    public partial class RegisterForm : Form
    {
        private readonly IIdentityRestClient _identityRestClient;
        private readonly Register register = new Register();
        private readonly IMessenger _messenger;

        public RegisterForm(IMessenger messenger, IIdentityRestClient identityRestClient)
        {
            _messenger = messenger;
            _identityRestClient = identityRestClient;
            InitializeComponent();
        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                register.Email = textBoxEmail.Text;
                register.Name = textBoxName.Text;
                register.Password = textBoxPassword.Text;
                register.ConfirmPassword = textBoxReEnterPassword.Text;
                await _identityRestClient.RegisterAsync(register);
                this.Close();
            }
            catch(Exception ex)
            {
                _messenger.Show(ex.Message);
            }
        }
    }
}