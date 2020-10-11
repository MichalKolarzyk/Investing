using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.BasicControls.BasicComponents
{
    public static class Fonts
    {
        public static Font NewTimesRoman {
            get
            {
                string familyName = "Times New Roman";
                int size = 12;
                FontStyle fontStyle = FontStyle.Regular;
                GraphicsUnit graphicsUnit = GraphicsUnit.Point;
                return new Font(familyName, size, fontStyle, graphicsUnit);
            }
        }
    }
}
