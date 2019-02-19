using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Navigaton;
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class RegisterAssetsForm : Form,IRegisterAssetsView
    {
        private RegisterAssetsPresenter _registerAssetsPresenter = null;
        
        public RegisterAssetsForm(EAssets assets)
        {
            InitializeComponent();
            AssetsType = assets;
        }

        private RegisterAssetsPresenter Presenter
        {
            get
            {
                if(_registerAssetsPresenter==null)
                    _registerAssetsPresenter=new RegisterAssetsPresenter(this);
                return _registerAssetsPresenter;
            }
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        private void pass_Click(object sender, EventArgs e)
        {
            Presenter.Pass();
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber.Text;
            }
            private set
            {
                serialNumber.Text = value;
            }
        }
        public EAssets AssetsType { get; private set; }
    }
}
