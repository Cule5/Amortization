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
    public class DeleteAssetsPresenter
    {
        private IDeleteAssetsView _deleteAssetsView = null;
        private DeleteAssetsModel _deleteAssetsModel = null;
        public DeleteAssetsPresenter(IDeleteAssetsView deleteAssetsView)
        {
            _deleteAssetsView = deleteAssetsView;
            _deleteAssetsModel=new DeleteAssetsModel();
        }


        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void Pass()
        {
            string serialNumber = _deleteAssetsView.SerialNumber;
            string pesel = _deleteAssetsView.Pesel;
            if (_deleteAssetsView.Assets == EAssets.Hardware)
            {
                if (!_deleteAssetsModel.DeleteHardware(serialNumber,pesel))
                {
                    MessageBox.Show("NIE UDAŁO SIĘ USUNĄĆ SPRZĘTU");
                }
            }
            else if (_deleteAssetsView.Assets == EAssets.Software)
            {
                if (!_deleteAssetsModel.DeleteSoftware(serialNumber,pesel))
                {
                    MessageBox.Show("NIE UDAŁO SIĘ USUNĄĆ OPROGRAMOWANIA");
                }
            }
        }

    }
}
