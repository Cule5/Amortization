using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class DeleteAssetsModel
    {
        private DatabaseEntities db=null;

        public DeleteAssetsModel()
        {
            db=new DatabaseEntities();
        }

        public bool DeleteSoftware(string serialNumber,string pesel)
        {
            Software software = db.Softwares.FirstOrDefault(s => s.SerialNumber == serialNumber);
            if (software == null)
                return false;
            Worker worker = software.Worker;
            if (worker == null)
                return false;

            software.Worker = null;
            db.SaveChanges();
            bool result = true;
            return result;
        }

        public bool DeleteHardware(string serialNumber,string pesel)
        {
            Hardware hardware = db.Hardwares.FirstOrDefault(h => h.SerialNumber == serialNumber);
            if (hardware == null)
                return false;
            Worker worker = hardware.Worker;
            if (worker == null)
                return false;

            hardware.Worker = null;
            db.SaveChanges();
            bool result = true;
            return result;
        }
    }
}
