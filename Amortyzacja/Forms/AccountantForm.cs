using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenter;
using Amortyzacja.View;

namespace Amortyzacja
{
    public partial class AccountantForm : Form,IAccountantView
    {
        AccountantPresenter presenter;

        public AccountantForm()
        {
            InitializeComponent();
        }

        private AccountantPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new AccountantPresenter(this);
                }
                return presenter;
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Presenter.Logout();
        }


        private void addWorker_Click(object sender, EventArgs e)
        {
            Presenter.AddWorker();
        }

        private void deleteWorker_Click(object sender, EventArgs e)
        {
            Presenter.DeleteWorker();
        }

        private void amortization_Click(object sender, EventArgs e)
        {
            Presenter.Amortization();
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            Presenter.RegisterHardware();
        }

        private void registerSoftware_Click(object sender, EventArgs e)
        {
            Presenter.RegisterSoftware();
        }
    }
}
