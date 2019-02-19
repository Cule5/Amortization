using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja
{
    class AppSession
    {
        private static AppSession _appSession=null;

        protected AppSession()
        {

        }
        
        public static AppSession GetInstance()
        {
            if(_appSession==null)
                _appSession=new AppSession();
            return _appSession;
        }

        private Worker _worker = null;

        public Worker CurrentWorker
        {
            get => _worker;
            set => _worker = value;
        }



    }
}
