using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Models
{
    class OccupiedHardwareModel
    {
        private DatabaseEntities db=null;

        public OccupiedHardwareModel()
        {
            db=new DatabaseEntities();
        }
        public void OccupiedHardware(ListView occupiedHardware)
        {
            string[] elemTab = new string[3];

            IQueryable<Hardware> collection = db.Hardwares.Where(hardware => hardware.Worker != null);
            foreach (Hardware hardware in collection)
            {
                string typ = hardware.Type;
                string serialNumber = hardware.SerialNumber;
                Purchase purchase = hardware.Purchase;
                double price = purchase.Price;
                elemTab[0] = typ;
                elemTab[1] = serialNumber;
                elemTab[2] = price.ToString();
                ListViewItem item = new ListViewItem(elemTab);
                occupiedHardware.Items.Add(item);
            }

            
        }
    }
}
