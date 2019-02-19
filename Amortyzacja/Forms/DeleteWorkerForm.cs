using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class DeleteWorkerForm : Form,IDeleteWorkerView
    {
        private DeleteWorkerPresenter _presenter = null;
        
        public DeleteWorkerForm()
        {
            InitializeComponent();
        }

        private DeleteWorkerPresenter Presenter
        {
            get
            {
                if(_presenter==null)
                    _presenter=new DeleteWorkerPresenter(this);
                return _presenter;
            }
        }

        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            Presenter.LoadFile();
        }
    }
}
