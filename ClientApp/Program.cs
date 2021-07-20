using ClientApp.GUI.Forms;
using ClientApp.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(SimpleInjectorContainer.GetContainer().GetInstance<LoginForm>());
        }
    }
}
