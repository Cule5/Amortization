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
    class OccupiedSoftwarePresenter
    {
        private IOccupiedSoftwareView _occupiedSoftwareView = null;
        private OccupiedSoftwareModel _occupiedSoftwareModel = null;
        public OccupiedSoftwarePresenter(IOccupiedSoftwareView occupiedSoftwareView)
        {
            _occupiedSoftwareView = occupiedSoftwareView;
            _occupiedSoftwareModel=new OccupiedSoftwareModel();
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void OccupiedSoftware()
        {
            _occupiedSoftwareModel.OccupiedSoftware(_occupiedSoftwareView.Assets);
        }
    }
}
