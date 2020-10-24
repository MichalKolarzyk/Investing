using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using UserControls.BasicControls.BasicComponents;

namespace UserControls.BasicControls
{
    class BasicChart : Chart
    {
        public BasicChart(): base()
        {
            BackColor = Color.Transparent;
        }
    }
}
