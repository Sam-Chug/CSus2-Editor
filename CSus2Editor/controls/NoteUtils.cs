using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Check validity of loaded sequence
        public static bool loadValidity(string seq) {

            string[] noteFSO = { "I", "C", "D", "E", "F", "G", "A", "B", "H" };

            bool error = false;
            bool numCheck = false;
            bool letterCheck = false;

            for (int i = 0; i < seq.Length; i++) {
                //Lower case check
                if (char.IsLetter(seq[i]) && char.IsLower(seq[i])) {
                    error = true;
                }

                //Check if there are numbers
                if (char.IsNumber(seq[i])) {
                    numCheck = true;
                }

                //Check if each note follows FreeSO's notation
                if (char.IsLetter(seq[i])) {
                    bool notationCheck = false;

                    for (int j = 0; j < noteFSO.Length; j++) {
                        if (Convert.ToString(seq[i]) == noteFSO[j]) {
                            notationCheck = true;
                            letterCheck = true;
                        }
                    }
                    if (!notationCheck) {
                        error = true;
                    }
                }

                //Make sure letter always follows number
                if (i > 0) {
                    if (char.IsLetter(seq[i]) && !char.IsNumber(seq[i - 1])) {
                        error = true;
                    }
                }

                //Check if letters follow another
                if (seq.Length < (i + 1)) {
                    if (char.IsLetter(seq[i]) && char.IsLetter(seq[i + 1])) {
                        error = true;
                    }
                }

                //Make sure last character is a number
                if (!char.IsDigit(seq[seq.Length - 1])) {
                    error = true;
                }
            }

            //Check for numbers and valid letters
            if (!numCheck || !letterCheck) {
                error = true;
            }

            //If error found, show warning and do not pass to loading
            if (error) {
                MessageBox.Show("This sequence does not follow the input format!", "Warning!");
            }

            //Return error found
            return error;

        }//End loadValidity

    }
}
