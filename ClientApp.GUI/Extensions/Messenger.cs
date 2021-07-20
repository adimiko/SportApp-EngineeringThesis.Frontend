using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Extensions
{
    public interface IMessenger
    {
        void Show(string message);
        void Show(string message, string title);
    }
    public class Messenger : IMessenger
    {
        public void Show(string message)
            => MessageBox.Show(message);

        public void Show(string message, string title)
            => MessageBox.Show(message, title);
    }
}
