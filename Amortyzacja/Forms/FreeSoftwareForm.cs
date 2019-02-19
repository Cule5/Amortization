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
    public partial class FreeSoftwareForm : Form,IFreeSoftwareView
    {
        private FreeSoftwarePresenter _freeSoftwarePresenter = null;
        public FreeSoftwareForm()
        {
            InitializeComponent();
            Assets = freeSoftware;
            Presenter.FreeSoftware();

        }

        private FreeSoftwarePresenter Presenter
        {
            get
            {
                if(_freeSoftwarePresenter==null)
                    _freeSoftwarePresenter=new FreeSoftwarePresenter(this);
                return _freeSoftwarePresenter;
            }
        }
        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public ListView Assets { get; private set; }
    }
}
