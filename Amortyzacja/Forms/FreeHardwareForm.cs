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
    public partial class FreeHardwareForm : Form,IFreeHardwareView
    {
        private FreeHardwarePresenter _presenter = null;
        public FreeHardwareForm()
        {
            InitializeComponent();
            Assets = freeHardware;
            Presenter.FreeHardware();
        }

        private FreeHardwarePresenter Presenter
        {
            get
            {
                if(_presenter==null)
                    _presenter=new FreeHardwarePresenter(this);
                return _presenter;
            }
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public ListView Assets { get; private set; }
    }
}
