﻿using Investing.BasicControls.BasicComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing.BasicControls
{
    public class BasicLabel : Label
    {
        public BasicLabel() : base()
        {
            Text = "Custom Label";
            Font = Fonts.NewTimesRoman;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(130, 30);
            ForeColor = Colors.Clouds;
            BackColor = Colors.MidnightBlue;
            Margin = new Padding(10);
        }
    }
}
