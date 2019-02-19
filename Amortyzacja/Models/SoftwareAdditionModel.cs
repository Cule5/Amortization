using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class SoftwareAdditionModel
    {
        private DatabaseEntities db = null;

        public SoftwareAdditionModel()
        {
            db = new DatabaseEntities();
        }

        public bool AddSoftwareWithLicense(string softwareType, string serialNumber, double price, DateTime purchaseDate)
        {
            bool result;

            Software tmpSoftware = db.Softwares.FirstOrDefault(s=>s.SerialNumber==serialNumber);
            
            if (tmpSoftware != null)
                result = false;
            else
            {
                try
                {

                    License license = new License() { Price = price, PurchaseDate = purchaseDate };
                    License addedLicense = db.Licenses.Add(license);
                    Software software = new Software() { SoftwareType = softwareType, SerialNumber = serialNumber, Licenses_IdLicense = addedLicense.IdLicense };
                    db.Softwares.Add(software);
                    db.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            
            return result;
        }

        public bool AddSoftwareWithSubscription(string softwareType, string serialNumber, double price, DateTime subscriptionBeggining, DateTime subscriptionEnd)
        {
            bool result;
            Software tmpSoftware = db.Softwares.FirstOrDefault(s => s.SerialNumber == serialNumber);
            if (tmpSoftware != null)
                result = false;
            else
            {
                try
                {
                    Subscription subscription = new Subscription() { Price = price, StartDate = subscriptionBeggining, EndDate = subscriptionEnd };
                    Subscription addedSubscription = db.Subscriptions.Add(subscription);
                    Software software = new Software() { SoftwareType = softwareType, SerialNumber = serialNumber, Subscriptions_IdSubscription = addedSubscription.IdSubscription };
                    db.Softwares.Add(software);
                    db.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
