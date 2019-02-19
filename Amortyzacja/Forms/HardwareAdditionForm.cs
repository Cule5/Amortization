using Amortyzacja.Presenters;
using Amortyzacja.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Forms
{
    public partial class HardwareAdditionForm : Form, IHardwareAdditionView
    {
        HardwareAdditionPresenter _presenter;

        public HardwareAdditionForm()
        {
            InitializeComponent();
        }

        public string SerialNumber
        {
            get
            {
                return txtSerialNumber.Text;
            }
        }

        public string HardwareType
        {
            get
            {
                return txtHardwareType.Text;
            }
        }

        public DateTime PurchaseDate
        {
            get
            {
                return datPurchaseDate.Value;
            }
        }

        public double Price
        {
            get
            {
                return Convert.ToDouble(txtPrice.Text);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Presenter.AddHardware())
            {
                MessageBox.Show("Dodano sprzęt");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd przy dodawaniu sprzętu");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Presenter.PreviousForm();
        }

        HardwareAdditionPresenter Presenter
        {
            get
            {
                if (_presenter == null)
                {
                    _presenter = new HardwareAdditionPresenter(this);
                }
                return _presenter;
            }
        }
    }
}
