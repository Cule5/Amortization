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
    public partial class TaxPerPeriodForm : Form,ITaxPerPeriodView
    {
        private TaxPerPeriodPresenter _presenter = null;
        public TaxPerPeriodForm()
        {
            InitializeComponent();
        }

        private TaxPerPeriodPresenter Presenter
        {
            get
            {
                if(_presenter==null)
                    _presenter=new TaxPerPeriodPresenter(this);
                return _presenter;
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            Year = year.Text;
            Presenter.Pass();
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public string Year { get; private set; }
    }
}
