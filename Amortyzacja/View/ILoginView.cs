using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Presenter;

namespace Amortyzacja.View
{
    public interface ILoginView
    {
        string Login { set; get; }
        string Password { set; get; }
    }
}
