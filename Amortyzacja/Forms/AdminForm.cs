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

namespace Amortyzacja.Forms
{
    public partial class AdminForm : Form,IAdminView
    {
        

        public AdminForm()
        {
            InitializeComponent();
        }

        AdminPresenter presenter;
        private AdminPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new AdminPresenter(this);
                }
                return presenter;
            }
        }


        private void freeHardware_Click(object sender, EventArgs e)
        {
            Presenter.FreeHardware();
        }

        private void occupiedHardware_Click(object sender, EventArgs e)
        {
            Presenter.OccupiedHardware();
        }

        private void occupiedSoftware_Click(object sender, EventArgs e)
        {
            Presenter.OccupiedSoftware();
        }

        private void freeSoftware_Click(object sender, EventArgs e)
        {
           Presenter.FreeSoftware();
        }

        private void tax_Click(object sender, EventArgs e)
        {
            Presenter.TaxPerPeriod();
        }

        private void assetsCosts_Click(object sender, EventArgs e)
        {
            Presenter.AssetsCosts();
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            Presenter.RegisterHardware();
        }

        private void registerSoftware_Click(object sender, EventArgs e)
        {
            Presenter.RegisterSoftware();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Presenter.Logout();
        }
    }
}
