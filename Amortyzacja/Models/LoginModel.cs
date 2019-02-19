using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class LoginModel
    {
        DatabaseEntities db;

        public LoginModel()
        {
            db = new DatabaseEntities();
        }

        public Account GetAccount(string login, string password)
        {
            return db.Accounts.FirstOrDefault(account => account.UserLogin == login && account.UserPassword == password);
        }

        public void CheckWorkers()
        {
            foreach (Worker worker in db.Workers)
            {
                Employment tmpEmployment = db.Employments.Find(worker.IdWorker);
                if (tmpEmployment.EndDate!=null)
                {
                    
                    if (tmpEmployment.EndDate < DateTime.Now.Date)
                    {
                        int id = worker.IdWorker;

                        IQueryable<Software> softwares = db.Softwares.Where(s => s.Workers_IdWorker == id);
                        IQueryable<Hardware> hardwares = db.Hardwares.Where(h => h.Workers_IdWorker == id);

                        foreach (Software software in softwares)
                        {
                            software.Worker = null;
                        }

                        foreach (Hardware hardware in hardwares)
                        {
                            hardware.Worker = null;
                        }

                        Employment employment = db.Employments.FirstOrDefault(e => e.Workers_IdWorker == id);
                        Account account = db.Accounts.FirstOrDefault(a => a.Workers_IdWorker == id);
                        db.Employments.Remove(employment);
                        db.Accounts.Remove(account);
                        db.Workers.Remove(worker);
                        
                    }


                }
            }
            db.SaveChanges();
        }

        public void CheckSoftware()
        {
            foreach (Software software in db.Softwares)
            {
                if (software.Subscription != null)
                {
                    Subscription subscription = software.Subscription;
                    if (subscription.EndDate < DateTime.Now.Date)
                    {
                        db.Softwares.Remove(software);
                        db.Subscriptions.Remove(subscription);
                    }
                }
            }

            db.SaveChanges();
        }

        public void CheckAmortization()
        {
            foreach (Amortization amortization in db.Amortizations)
            {
                if (amortization.EndDate < DateTime.Now.Date)
                {
                    Hardware hardware = db.Hardwares.FirstOrDefault((h => h.Amortizations_IdAmortization == amortization.IdAmortization));
                    hardware.Amortization = null;
                    db.Amortizations.Remove(amortization);
                }
                
            }

            db.SaveChanges();
            
        }
    }
}
