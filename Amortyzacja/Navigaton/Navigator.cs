using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Navigaton
{
    class Navigator
    {
        private Form _lastForm = null;
        private Form _currentForm = null;
        private static Navigator _navigator = null;

        protected Navigator()
        {

        }

        public static Navigator GetInstance()
        {
            if(_navigator==null)
                _navigator=new Navigator();
            return _navigator;
        }

        public void Navigate(Form currentForm,Form nextForm)
        {
            _lastForm = currentForm;
            _currentForm = nextForm;
            _currentForm.Show();
            _lastForm.Hide();
        }

        public void NavigateBack()
        {
            Form tmpForm = _lastForm;
            _lastForm = _currentForm;
            _currentForm = tmpForm;
            _currentForm.Show();
            _lastForm.Hide();
        }
    }
}
