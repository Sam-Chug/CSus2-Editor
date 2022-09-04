using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CSus2Editor {
    //I got this whole thing from stackexchange lmao
    class PanelNoScrollOnFocus : Panel {
        public PanelNoScrollOnFocus() {
            Enter += PanelNoScrollOnFocus_Enter;
            Leave += PanelNoScrollOnFocus_Leave;
        }

        private System.Drawing.Point scrollLocation;

        void PanelNoScrollOnFocus_Enter(object sender, System.EventArgs e) {
            // Set the scroll location back when the control regains focus.
            HorizontalScroll.Value = scrollLocation.X;
            VerticalScroll.Value = scrollLocation.Y;
        }

        void PanelNoScrollOnFocus_Leave(object sender, System.EventArgs e) {
            // Remember the scroll location when the control loses focus.
            scrollLocation.X = HorizontalScroll.Value;
            scrollLocation.Y = VerticalScroll.Value;
        }

        protected override Point ScrollToControl(Control activeControl) {
            // When there's only 1 control in the panel and the user clicks
            //  on it, .NET tries to scroll to the control. This invariably
            //  forces the panel to scroll up. This little hack prevents that.
            return DisplayRectangle.Location;
        }
    }
}
