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
    class FreeHardwarePresenter
    {
        private IFreeHardwareView _freeHardwareView = null;
        private FreeHardwareModel _freeHardwareModel=null;
        public FreeHardwarePresenter(IFreeHardwareView freeHardwareView)
        {
            _freeHardwareView = freeHardwareView;
            _freeHardwareModel=new FreeHardwareModel();

        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void FreeHardware()
        {
            _freeHardwareModel.FreeHardware(_freeHardwareView.Assets);
        }
    }
}
