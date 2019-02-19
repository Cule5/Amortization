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
    public partial class OccupiedHardwareForm : Form,IOccupiedHardwareView
    {
        private OccupiedHardwarePresenter _occupiedHardwarePresenter = null;
        public OccupiedHardwareForm()
        {
            InitializeComponent();
            Assets = occupiedHardware;
            Presenter.OccupiedHardware();
        }

        private OccupiedHardwarePresenter Presenter
        {
            get
            {
                if(_occupiedHardwarePresenter==null)
                    _occupiedHardwarePresenter=new OccupiedHardwarePresenter(this);
                return _occupiedHardwarePresenter;
            }
        }
        private void lastForm_Click(object sender, EventArgs e)
        {
            Presenter.LastForm();
        }

        public ListView Assets { get; private set; }
    }
}
