using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class DeleteWorkerModel
    {
        private DatabaseEntities db;
        public DeleteWorkerModel()
        {
            db=new DatabaseEntities();
        }
        public bool DeleteWorker(string pesel)
        {
            Worker worker = db.Workers.FirstOrDefault(w => w.Pesel == pesel);
            if (worker == null)
                return false;
            int id= worker.IdWorker;

            IQueryable<Software>softwares =db.Softwares.Where(s=>s.Workers_IdWorker==id);
            IQueryable<Hardware> hardwares = db.Hardwares.Where(h => h.Workers_IdWorker == id);

            foreach (Software software in softwares)
            {
                software.Worker = null;
            }

            foreach (Hardware hardware in hardwares)
            {
                hardware.Worker = null;
            }

            Employment employment=db.Employments.FirstOrDefault(e=>e.Workers_IdWorker==id);
            Account account = db.Accounts.FirstOrDefault(a=>a.Workers_IdWorker==id);
            db.Employments.Remove(employment);
            db.Accounts.Remove(account);
            db.Workers.Remove(worker);
            db.SaveChanges();
            return true;
        }
    }
}
