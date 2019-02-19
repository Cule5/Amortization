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
    public partial class AddWorkerForm : Form,IAddWorkerView
    {
        AddWorkerPresenter presenter;
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private AddWorkerPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new AddWorkerPresenter(this);
                }
                return presenter;
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            Presenter.LoadFile();
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }
    }
}
