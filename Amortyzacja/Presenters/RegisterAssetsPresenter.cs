using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class RegisterAssetsPresenter
    {
        private IRegisterAssetsView _registerAssetsView = null;
        private RegisterAssetsModel _registerAssetsModel = null;
        public RegisterAssetsPresenter(IRegisterAssetsView registerAssetsView)
        {
            _registerAssetsView = registerAssetsView;
            _registerAssetsModel=new RegisterAssetsModel();
        }

        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void Pass()
        {
            string serialNumber = _registerAssetsView.SerialNumber;
            if (_registerAssetsView.AssetsType == EAssets.Hardware)
            {
                _registerAssetsModel.RegisterHardware(serialNumber);

            }
            else if (_registerAssetsView.AssetsType == EAssets.Software)
            {
                _registerAssetsModel.RegisterSoftware(serialNumber);
            }
        }
    }
}
