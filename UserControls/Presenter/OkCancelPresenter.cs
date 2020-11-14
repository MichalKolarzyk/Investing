using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.View;

namespace UserControls.Presenter
{
    class OkCancelPresenter
    {
        IOkCancelView View;
        public OkCancelPresenter(IOkCancelView view)
        {
            View = view;
        }
        public void Ok_Click()
        {
            UserControl view = (UserControl)View;
            Form form = (Form)view.Parent;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        public void Cancel_Click()
        {
            UserControl view = (UserControl)View;
            Form form = (Form)view.Parent;
            form.DialogResult = DialogResult.Cancel;
            form.Close();
        }
    }
}
