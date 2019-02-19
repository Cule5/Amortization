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
    class FreeSoftwarePresenter
    {
        private IFreeSoftwareView _freeSoftwareView = null;
        private FreeSoftwareModel _freeSoftwareModel = null;
        public FreeSoftwarePresenter(IFreeSoftwareView freeSoftwareView)
        {
            _freeSoftwareView = freeSoftwareView;
            _freeSoftwareModel=new FreeSoftwareModel();
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void FreeSoftware()
        {
            _freeSoftwareModel.FreeSoftware(_freeSoftwareView.Assets);

        }
    }
}
