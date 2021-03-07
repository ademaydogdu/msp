using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Tool
{
    class ChanceTextColor
    {
        public static void ChangeColor(TextEdit rtx, int Start, byte Lenght = 1)
        {
            //rtx.SelectionAlignment = HorizontalAlignment.Left;           
            rtx.SelectionStart = Start;
            rtx.SelectionLength = Lenght;
            rtx.ForeColor = Color.Crimson;
        }
    }
}
