using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    public class AmortizationPresenter
    {
        private IAmortizationView _amortizationView = null;
        private AmortizationModel _amortizationModel = null;
        public AmortizationPresenter(IAmortizationView amortizationView)
        {
            _amortizationView = amortizationView;
            _amortizationModel=new AmortizationModel();
            
           
        }

        public void Pass()
        {
            try
            {
                if (_amortizationView.YearTextBox.Text.Equals("")|| _amortizationView.SerialNumberTextBox.Text.Equals(""))
                {
                    MessageBox.Show("POLE NIE ZOSTAŁO WYPEŁNIONE");
                    return;
                }
                
                int year = int.Parse(_amortizationView.YearTextBox.Text);
                string serialNumber = _amortizationView.SerialNumberTextBox.Text;
                if (year <= 0)
                {
                    MessageBox.Show("POLE ZOSTAŁO BŁEDNIE WYPEŁNIONE");
                    return;
                }
                _amortizationModel.Amortization(serialNumber,year);
            }
            catch (FormatException)
            {
                MessageBox.Show("ŹLE WYPEŁNIONE POLE");
            }
        }

        public void LastForm()
        {
            Navigator.GetInstance().Navigate((AmortizationForm)_amortizationView,new AccountantForm());

        }

        public void FindHardware()
        {
            ListView listView = _amortizationView.HardwareListView;
            listView.Items.Clear();
            IQueryable<Hardware> collection = _amortizationModel.FindHardware();
            foreach (Hardware hardware in collection)
            {
                Purchase purchase = hardware.Purchase;
                string[] elemTab = {hardware.SerialNumber, hardware.Type, purchase.Price.ToString()};
                ListViewItem item=new ListViewItem(elemTab);
                listView.Items.Add(item);
            }
        }
    }
}
