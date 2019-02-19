using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class AdminModel
    {
        DatabaseEntities db=new DatabaseEntities();
        public IQueryable<Software> FreeSoftware()
        {
            return db.Softwares.Where(software => software.Workers_IdWorker == null);
        }

        public IQueryable<Software> OccupiedSoftware()
        {
            return db.Softwares.Where(software => software.Workers_IdWorker != null);
        }

        public IQueryable<Hardware> FreeHardware()
        {
            return db.Hardwares.Where(hardware=>hardware.Workers_IdWorker==null);
        }

        public IQueryable<Hardware> OccupiedHardware()
        {
            return db.Hardwares.Where(hardware => hardware.Workers_IdWorker != null);
        }

        public double AssetsCost()
        {
            double result=0;
            foreach (Hardware hardware in db.Hardwares)
            {
                Purchase purchase = hardware.Purchase;
                result += purchase.Price;
            }

            foreach (Software software in db.Softwares)
            {
                if (software.Subscription != null)
                {
                    Subscription subscription = software.Subscription;
                    result += subscription.Price;
                }
                else
                {
                    License license = software.License;
                    result += license.Price;
                }
            }

            return result;

        }

        public double TaxPerPeriod(DateTime date)
        {
            double result = 0;

            foreach (Hardware hardware in db.Hardwares)
            {
                Amortization amortization = hardware.Amortization;
                if (amortization != null)
                {
                    double amortizationValue = amortization.AmortizationAmount;
                    Purchase purchase = hardware.Purchase;
                    if ((amortization.StartDate.Year<=date.Year)&&(amortization.EndDate.Year>=date.Year))
                    {
                        double price = purchase.Price;
                        double realPrice = price - amortizationValue;
                        result += realPrice;
                    }
                    
                }
                else
                {
                    Purchase purchase = hardware.Purchase;
                    if (purchase.PurchaseDate.Year <= date.Year)
                    {
                        double price = purchase.Price;
                        result += price;
                    }
                    
                }
                
            }

            foreach (Software software in db.Softwares)
            {
                if (software.Subscription != null)
                {
                    Subscription subscription = software.Subscription;
                    if((subscription.StartDate.Year<=date.Year)&&(subscription.EndDate.Year>=date.Year))
                        result += subscription.Price;
                }
                else
                {
                    

                    License license = software.License;
                    if(license.PurchaseDate.Year<=date.Year)
                        result += license.Price;
                }
            }
            return result*0.2;
        }
    }
}
