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
    public partial class ListUserControl<T> : UserControl where T: UserControl
    {
        List<T> List = new List<T>();
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        public ListUserControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            flowLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanel);
        }

        public void Add(T item)
        {
            item.Dock = DockStyle.Top;
            List.Add(item);
            this.Height += item.Height;
            flowLayoutPanel.Controls.Add(item);
        }

        public void Clear()
        {
            List.Clear();
            Controls.Clear();
            this.Refresh();
        }

        public void SetList(List<T> items)
        {
            Controls.Clear();

            foreach (var item in items)
            {
                item.Dock = DockStyle.Top;
                this.Controls.Add(item);
            }
        }
    }
}
