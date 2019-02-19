using Amortyzacja.Enums;
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
    class SoftwareAdditionPresenter
    {
        ISoftwareAdditionView _view;
        SoftwareAdditionModel _model;
        public SoftwareAdditionPresenter(ISoftwareAdditionView view)
        {
            _view = view;
            _model = new SoftwareAdditionModel();
        }

        public bool AddSoftwareWithLicense()
        {
            return _model.AddSoftwareWithLicense(_view.SoftwareType, _view.SerialNumber, _view.Price, _view.PurchaseDate);

        }
        public bool AddSoftwareWithSubscription()
        {
            return _model.AddSoftwareWithSubscription(_view.SoftwareType, _view.SerialNumber, _view.Price, _view.SubscriptionBeginning, _view.SubscriptionEnd);
        }

        public void PreviousForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
