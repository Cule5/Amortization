using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class WorkerForm : Form,IWorkerView
    {
        WorkerPresenter presenter;

        public WorkerForm()
        {
            InitializeComponent();
        }

        private WorkerPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new WorkerPresenter(this);
                }
                return presenter;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Presenter.Logout();
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
