using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    public class AddWorkerPresenter
    {
        private IAddWorkerView _addWorkerView = null;
        private AddWorkerModel _addWorkerModel = null;

        public AddWorkerPresenter(IAddWorkerView addWorkerView)
        {
            _addWorkerView = addWorkerView;
            _addWorkerModel=new AddWorkerModel();
        }

        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void LoadFile()
        {
            Stream stream = null;
            OpenFileDialog fileDialog = new OpenFileDialog {Filter = "TXT files|*.txt", InitialDirectory = @"C:\"};
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                stream=fileDialog.OpenFile();
                
                string line = null;
                StreamReader streamReader = new StreamReader(stream);
                List<string>paramList=new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    MatchCollection matchCollection=Regex.Matches(line, @"\b([^\s]+)\b");
                    foreach (Match match in matchCollection)
                    {
                        string matchValue = match.Value;
                        paramList.Add(matchValue);
                        if (paramList.Count == 6)
                        {
                            if (!_addWorkerModel.AddWorker(paramList[0], paramList[1], paramList[2], paramList[3], paramList[4], paramList[5]))
                                MessageBox.Show("BŁĘDNE DANE OSOBY: "+paramList[0]+ " "+paramList[1]);
                            paramList.Clear();
                        }
                    }
                }       
                
            }
        }
    }
}
