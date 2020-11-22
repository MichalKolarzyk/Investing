using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miscellaneous
{
    public static class ExceptionMessageHandler
    {
        public static string GetMessage(Exception exception)
        {
            string message = string.Empty;
            Exception innerException = exception;
            while (innerException != null)
            {
                if(innerException.GetType() != typeof(AggregateException))
                {
                    message += innerException.Message;
                    message += "\n";
                }
                innerException = innerException.InnerException;
            }
            return message;
        }

        public static void ShowError(Exception exception)
        {
            MessageBox.Show(GetMessage(exception), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
