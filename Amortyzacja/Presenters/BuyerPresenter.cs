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
    public class BuyerPresenter
    {
        private IBuyerView _buyerView;

        public BuyerPresenter(IBuyerView buyerView)
        {
            _buyerView = buyerView;
        }
        public void AddSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView,new SoftwareAdditionForm());
        }

        public void AddHardware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView,new HardwareAdditionForm());
        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new RegisterAssetsForm(EAssets.Software));

        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new RegisterAssetsForm(EAssets.Hardware));
        }

        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new LoginForm());
        }

        public void FreeSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView,new FreeSoftwareForm());
        }

        public void FreeHardware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView,new FreeHardwareForm());
        }

        public void DeleteSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView,new DeleteAssetsForm(EAssets.Software));
        }

        public void DeleteHardware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new DeleteAssetsForm(EAssets.Hardware));
        }
    }
}
