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
    public partial class OccupiedSoftwareForm : Form,IOccupiedSoftwareView
    {
        private OccupiedSoftwarePresenter _occupiedSoftwarePresenter = null;
        public OccupiedSoftwareForm()
        {
            InitializeComponent();
            Assets = occupiedSoftware;
            Presenter.OccupiedSoftware();
        }

        private OccupiedSoftwarePresenter Presenter
        {
            get
            {
                if(_occupiedSoftwarePresenter==null)
                    _occupiedSoftwarePresenter=new OccupiedSoftwarePresenter(this);
                return _occupiedSoftwarePresenter;
            }
        }


        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public ListView Assets { get; private set; }
    }
}
