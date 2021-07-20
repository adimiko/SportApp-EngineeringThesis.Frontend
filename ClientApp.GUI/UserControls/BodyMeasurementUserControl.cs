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
    public partial class BodyMeasurementUserControl : UserControl
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public BodyMeasurementUserControl()
        {
            InitializeComponent();
        }
    }
}
