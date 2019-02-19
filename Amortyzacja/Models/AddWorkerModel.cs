using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Enums;

namespace Amortyzacja.Models
{
    public class AddWorkerModel
    {
        private DatabaseEntities db;

        public AddWorkerModel()
        {
            db=new DatabaseEntities();
        }
        public bool AddWorker(string firstName,string lastName,string pesel,string startDate,string endDate,string permission)
        {
            Worker tmpWorker=db.Workers.FirstOrDefault(w=>w.Pesel==pesel);
            if (tmpWorker != null)
                return false;
            if (!DateTime.TryParse(startDate, out DateTime start))
                return false;
            if (!int.TryParse(permission,out int perrmissionResult))
                return false;
            else
                if (perrmissionResult == (int) EAccountPermission.Admin)
                    return false;
            
            if (!DateTime.TryParse(endDate, out DateTime end))
            {
                if (!endDate.Equals("null"))
                    return false;
                if (endDate.Equals("null"))
                {
                    Worker worker = new Worker() { FirstName = firstName, LastName = lastName, Pesel = pesel };
                    Employment employment = new Employment() { StartDate = start, EndDate = null, Worker = worker };
                    Account account = new Account() { UserLogin = pesel, UserPassword = lastName, Permission = perrmissionResult, Worker = worker };
                    db.Workers.Add(worker);
                    db.Employments.Add(employment);
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    return true;
                }
            }
            Worker worker1 = new Worker() { FirstName = firstName, LastName = lastName, Pesel = pesel };
            Employment employment1 = new Employment() { StartDate = start, EndDate = end, Worker = worker1 };
            Account account1 = new Account() { UserLogin = pesel, UserPassword = lastName, Permission = perrmissionResult, Worker = worker1 };
            db.Workers.Add(worker1);
            db.Employments.Add(employment1);
            db.Accounts.Add(account1);
            db.SaveChanges();
            return true;
        }
    }
}
