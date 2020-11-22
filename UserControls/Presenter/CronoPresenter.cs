using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Model;
using UserControls.View;

namespace UserControls.Presenter
{
    public class CronoPresenter
    {
        private readonly ICronoExpressionView View;
        private CronoExpression Model;

        public CronoPresenter(ICronoExpressionView view)
        {
            View = view;
            Model = new CronoExpression();
        }

        public string GetCronoExpression()
        {
            Model.Seconds = View.Seconds;
            Model.Minutes = View.Minutes;
            Model.Hours = View.StartHour;
            Model.Days = View.Days;
            Model.Months = View.Months;
            return Model.ToString();
        }
        
    }
}
