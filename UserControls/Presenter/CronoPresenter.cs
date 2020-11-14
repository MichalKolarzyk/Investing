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

        public CronoExpression GetCronoExpression()
        {
            Model.Seconds = View.Seconds;
            Model.Minutes = View.Minutes;
            Model.Hours = View.Hours;
            Model.Days = View.Days;
            Model.Months = View.Months;
            Model.WeekDays = View.WeekDays;
            return Model;
        }

    }
}
