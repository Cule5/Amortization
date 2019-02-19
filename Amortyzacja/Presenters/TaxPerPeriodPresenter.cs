using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class TaxPerPeriodPresenter
    {
        private ITaxPerPeriodView _taxPerPeriodView = null;
        private AdminModel _adminModel = null;
        public TaxPerPeriodPresenter(ITaxPerPeriodView taxPerPeriodView)
        {
            _taxPerPeriodView = taxPerPeriodView;
            _adminModel=new AdminModel();
        }

        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void Pass()
        {
            DateTime date=new DateTime(Convert.ToInt32(_taxPerPeriodView.Year), 1, 1);
            MessageBox.Show("PODATEK ZA OKRES " + _taxPerPeriodView.Year + " WYNOSI: " + _adminModel.TaxPerPeriod(date));
        }
    }
}
