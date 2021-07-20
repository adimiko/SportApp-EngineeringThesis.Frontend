using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.UserControls
{
    public partial class CustomTextBox : UserControl
    {
        public override string Text { get { return textBox.Text; } set { textBox.Text = value; } }
        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void CustomTextBox_BackColorChanged(object sender, EventArgs e)
        {
            textBox.BackColor = BackColor;
        }

        private void CustomTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
