using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class DeleteWorkerPresenter
    {
        private IDeleteWorkerView _deleteWorkerView = null;
        private DeleteWorkerModel _deleteWorkerModel = null;
        public DeleteWorkerPresenter(IDeleteWorkerView deleteWorkerView)
        {
            _deleteWorkerView = deleteWorkerView;
            _deleteWorkerModel=new DeleteWorkerModel();
        }

        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }

        public void LoadFile()
        {
            
            Stream stream = null;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.InitialDirectory = @"C:\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                stream=fileDialog.OpenFile();
                if (stream != null)
                {
                    string line = null;
                    StreamReader streamReader=new StreamReader(stream);
                    while ((line=streamReader.ReadLine())!=null)
                    {
                        string pesel = line;
                        if (!_deleteWorkerModel.DeleteWorker(pesel))
                            MessageBox.Show("PESEL NIE ZNAJDUJE SIĘ W BAZIE");
                    }
                }
            }
        }
    }
}
