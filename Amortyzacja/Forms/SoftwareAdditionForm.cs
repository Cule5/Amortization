using Amortyzacja.Enums;
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
    public partial class SoftwareAdditionForm : Form, ISoftwareAdditionView
    {
        SoftwareAdditionPresenter _presenter;
        public SoftwareAdditionForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (intSoftwarePaymentType.SelectedIndex == (int)ESoftwarePaymentType.License)
            {
                Presenter.AddSoftwareWithLicense();
            }
            if (intSoftwarePaymentType.SelectedIndex == (int)ESoftwarePaymentType.Subscription)
            {
                Presenter.AddSoftwareWithSubscription();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Presenter.PreviousForm();
        }

        SoftwareAdditionPresenter Presenter
        {
            get
            {
                if (_presenter == null)
                {
                    _presenter = new SoftwareAdditionPresenter(this);
                }
                return _presenter;
            }
        }

        public string SoftwareType
        {
            get
            {
                return txtSoftwareType.Text;
            }
        }

        public string SerialNumber
        {
            get
            {
                return txtSerialNumber.Text;
            }
        }

        public DateTime PurchaseDate
        {
            get
            {
                return datPurchaseDate.Value;
            }
        }

        public DateTime SubscriptionBeginning
        {
            get
            {
                return datSubscriptionBeggining.Value;
            }
        }

        public DateTime SubscriptionEnd
        {
            get
            {
                return datSubscriptionEnd.Value;
            }
        }

        public double Price
        {
            get
            {
                return Convert.ToDouble(txtPrice.Text);
            }
        }

        private void intSoftwarePaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (intSoftwarePaymentType.SelectedIndex == (int)ESoftwarePaymentType.License)
            {
                datPurchaseDate.Enabled = true;
                datSubscriptionBeggining.Enabled = false;
                datSubscriptionEnd.Enabled = false;
            }
            if (intSoftwarePaymentType.SelectedIndex == (int)ESoftwarePaymentType.Subscription)
            {
                datPurchaseDate.Enabled = false;
                datSubscriptionBeggining.Enabled = true;
                datSubscriptionEnd.Enabled = true;
            }
        }
    }
}
