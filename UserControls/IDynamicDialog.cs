using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    interface IDynamicDialog<T>
    {
        void Show();
        void Hide();
        T GetObject();
    }
}
