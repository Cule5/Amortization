using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Forms;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class AccountantPresenter
    {
        private IAccountantView _accountantView = null;
        public AccountantPresenter(IAccountantView accountantView)
        {
            _accountantView = accountantView;
        }

        public void AddWorker()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new AddWorkerForm());

        }

        public void DeleteWorker()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new DeleteWorkerForm());
        }
        
        public void Amortization()
        {
            
            Navigator.GetInstance().Navigate((Form)_accountantView,new AmortizationForm());
        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView,new RegisterAssetsForm(EAssets.Software));

        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new RegisterAssetsForm(EAssets.Hardware));
        }
        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new LoginForm());
        }
    }
}
