using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSus2Editor
{
    public class NoteUtils
    {

        //Use beat and quarters to color columns based on time signature
        public static Color beatColor(int i) {
            //Default color
            Color c = Color.White;

            int quarters = mainWindow.quarters;
            int beats = mainWindow.beats;

            //Check if measure lines are enabled
            if (!mainWindow.measureLines) return c;

            //Quarters
            if ((i + 1) % quarters == 1) {
                c = Color.LightBlue;
            }
            //Beats
            if ((i + 1) % (beats * quarters) == 1) {
                c = Color.LightCoral;
            }
            //Measures
            if ((i + 1) % (beats * beats * quarters) == 1) {
                c = Color.Plum;
            }

            //Return color
            return c;

        }//End beatColor


    }
}
