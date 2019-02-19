using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Forms;
using Amortyzacja.Presenter;
using Amortyzacja.View;

namespace Amortyzacja
{
    public partial class LoginForm : Form,ILoginView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
        }

      

        public string Login
        {
            get => LoginBox.Text;
            set => LoginBox.Text = value;
        }

        public string Password
        {
            get => PasswordBox.Text;
            set => PasswordBox.Text = value;
        }

        private LoginPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new LoginPresenter(this);
                }
                return presenter;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            Presenter.LoginToApp(Login,Password);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Presenter.CheckWorkers();
            Presenter.CheckSoftware();
            Presenter.CheckAmortization();
        }
    }
}
