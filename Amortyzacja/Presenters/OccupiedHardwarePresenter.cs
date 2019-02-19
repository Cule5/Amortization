using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class OccupiedHardwarePresenter
    {
        private IOccupiedHardwareView _occupiedHardwareView = null;
        private OccupiedHardwareModel _occupiedHardwareModel = null;
        public OccupiedHardwarePresenter(IOccupiedHardwareView occupiedHardwareView)
        {
            _occupiedHardwareView = occupiedHardwareView;
            _occupiedHardwareModel=new OccupiedHardwareModel();
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void OccupiedHardware()
        {
            _occupiedHardwareModel.OccupiedHardware(_occupiedHardwareView.Assets);
        }
    }
}
