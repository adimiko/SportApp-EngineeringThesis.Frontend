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
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }
        protected ErrorForm(string message, string title)
        {
            InitializeComponent();
            this.ErrorMessageRichTextBox.Text = message;
            this.Text = title;
        }

        protected ErrorForm(string message)
        {
            InitializeComponent();
            this.ErrorMessageRichTextBox.Text = message;
        }

        public static DialogResult Show(string message, string title)
            => new ErrorForm(message, title).ShowDialog();

        public static DialogResult Show(string message)
    => new ErrorForm(message).ShowDialog();

        private void ClipboardButton_Click(object sender, EventArgs e)
            => Clipboard.SetText(ErrorMessageRichTextBox.Text);

    }
}
