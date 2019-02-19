using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenter;

namespace Amortyzacja
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm=new LoginForm();
            var presenter = new LoginPresenter(loginForm);
            Application.Run(loginForm);
        }
    }
}
