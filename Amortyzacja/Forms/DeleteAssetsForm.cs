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
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class DeleteAssetsForm : Form,IDeleteAssetsView
    {
        private DeleteAssetsPresenter _presenter=null;
        public DeleteAssetsForm(EAssets assets)
        {
            InitializeComponent();
            
            Assets = assets;
        }

        private DeleteAssetsPresenter Presenter
        {
            get
            {
                if (_presenter == null)
                    _presenter=new DeleteAssetsPresenter(this);
                return _presenter;
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            SerialNumber = serialNumber.Text;
            Pesel = pesel.Text;
            Presenter.Pass();
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public string SerialNumber { get; private set; }
        public string Pesel { get; private set; }
        public EAssets Assets { get; private set; }
    }
}
