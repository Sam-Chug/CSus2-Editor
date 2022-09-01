using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSus2Editor
{
    internal class ControlExtensions
    {

        public static void DisableRTB(Control rtb, Control focusTarget)
        {

            rtb.TabStop = false;
            rtb.Cursor = Cursors.Arrow;
            rtb.Enter += delegate { focusTarget.Focus(); };

        }//End Disable
    }
}
