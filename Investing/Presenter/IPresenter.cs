using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investing.Presenter
{
    public interface IPresenter<T>
    {
        T View { get; set; }
    }
}
