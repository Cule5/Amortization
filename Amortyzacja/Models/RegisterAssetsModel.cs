using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Models
{
    class RegisterAssetsModel
    {
        private DatabaseEntities db = null;

        public RegisterAssetsModel()
        {
            db=new DatabaseEntities();
        }
        public void RegisterSoftware(string serialNumber)
        {
            Software tmpSoftware = db.Softwares.FirstOrDefault(software => software.SerialNumber == serialNumber);
            if (tmpSoftware != null)
            {
                if (tmpSoftware.Worker == null)
                {
                    int id = AppSession.GetInstance().CurrentWorker.IdWorker;
                    Worker tmpWorker = db.Workers.FirstOrDefault(worker => worker.IdWorker == id);
                    tmpSoftware.Worker = tmpWorker;
                    MessageBox.Show("POMYŚLNA REJESTRACJA");
                    db.SaveChanges();
                }
                else
                    MessageBox.Show("OPROGRAMOWANIE JUŻ JEST ZAREJESTROWANE");
            }

            else
                MessageBox.Show("BŁĘDNY NUMER SERYJNY");


        }

        public void RegisterHardware(string serialNumber)
        {
            Hardware tmpHardware = db.Hardwares.FirstOrDefault(hardware => hardware.SerialNumber == serialNumber);
            if (tmpHardware != null)
            {
                if (tmpHardware.Worker == null)
                {
                    int id=AppSession.GetInstance().CurrentWorker.IdWorker;
                    Worker tmpWorker = db.Workers.FirstOrDefault(worker=>worker.IdWorker==id);
                    tmpHardware.Worker = tmpWorker;
                    MessageBox.Show("POMYŚLNA REJESTRACJA");
                    db.SaveChanges();
                }
                else
                    MessageBox.Show("SPRZĘT JUŻ JEST ZAREJESTROWANY");
            }
                
            else
                MessageBox.Show("BŁĘDNY NUMER SERYJNY");
        }
    }
}
