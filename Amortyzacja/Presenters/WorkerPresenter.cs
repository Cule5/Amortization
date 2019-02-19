using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    public class WorkerPresenter
    {
        private IWorkerView _workerView;
        public WorkerPresenter(IWorkerView workerView)
        {
            _workerView = workerView;
        }

        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_workerView, new LoginForm());
        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_workerView, new RegisterAssetsForm(Enums.EAssets.Hardware));
        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_workerView, new RegisterAssetsForm(Enums.EAssets.Software));
        }

    }
}
