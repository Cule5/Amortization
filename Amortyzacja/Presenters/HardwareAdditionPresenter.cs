using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Presenters
{
    class HardwareAdditionPresenter
    {
        IHardwareAdditionView _view;
        HardwareAdditionModel _model;

        public HardwareAdditionPresenter(IHardwareAdditionView view)
        {
            _view = view;
            _model = new HardwareAdditionModel();
        }

        public bool AddHardware()
        {
            return _model.AddHardware(_view.HardwareType, _view.SerialNumber, _view.Price, _view.PurchaseDate);
        }

        public void PreviousForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
