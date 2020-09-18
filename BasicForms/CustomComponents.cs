using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BasicForms
{
    public static class CustomComponents
    {
        public static Font GetRegularFont()
        {
            string familyName = "Times New Roman";
            int size = 12;
            FontStyle fontStyle = FontStyle.Regular;
            GraphicsUnit graphicsUnit = GraphicsUnit.Point;
            return new Font(familyName, size, fontStyle, graphicsUnit);
        }

    }
}
