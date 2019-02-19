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
    public partial class AmortizationForm : Form,IAmortizationView
    {
        private AmortizationPresenter _amortizationPresenter = null;
        public AmortizationForm()
        {
            InitializeComponent();
            YearTextBox = year;
            SerialNumberTextBox = serialNumber;
            HardwareListView = hardwareListView;
            Presenter.FindHardware();
        }



        private AmortizationPresenter Presenter
        {
            get
            {
                if(_amortizationPresenter==null)
                    _amortizationPresenter=new AmortizationPresenter(this);
                return _amortizationPresenter;

            }
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        private void pass_Click(object sender, EventArgs e)
        {
            Presenter.Pass();
            Presenter.FindHardware();
        }


        public TextBox YearTextBox { get; private set; }
        public TextBox SerialNumberTextBox { get; private set; }
        public ListView HardwareListView { get; private set; }
    }
}
