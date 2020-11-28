using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls.BasicComponents;

namespace UserControls.BasicControls.BasicComponents
{
    class BasicTextBox : TextBox
    {
        public BasicTextBox() : base()
        {
            Font = Fonts.NewTimesRoman;
            Margin = new Padding(10);
            CharacterCasing = CharacterCasing.Upper;
        }
    }
}
