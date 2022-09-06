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

        //Various functions dealing with notes and note sequences

        //Use beat and quarters to color columns based on time signature
        public static Color beatColor(int i) {
            //Default color
            Color c = Color.White;

            int quarters = mainWindow.quarters;
            int beats = mainWindow.beats;
            int offset = -mainWindow.offset;

            int index = i + 1 + offset;

            //Check if measure lines are enabled
            if (!mainWindow.measureLines) return c;

            //Quarters
            if (index % quarters == 1) {
                c = Color.LightBlue;
            }
            //Beats
            if (index % (beats * quarters) == 1) {
                c = Color.LightCoral;
            }
            //Measures
            if (index % (beats * beats * quarters) == 1) {
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

        //Generate sequence based on notes in editor
        public static string sequenceText(int masterInt) {

            //FreeSO notation
            string[] noteFSO = { "I", "C", "D", "E", "F", "G", "A", "B", "H" };

            //Sequence temp
            string sequence = "";

            //Note interval
            int noteInt = 0;

            //If searching for next real note
            bool parseNext = true;

            for (int i = 0; i < mainWindow.indexList.Length; i++) {

                //Add note at end of sequence to preserve master interval
                if (i == mainWindow.indexList.Length - 1) {
                    sequence += noteFSO[mainWindow.indexList[i]] + masterInt;
                    goto ExitFor;
                }
                //If note parse enabled, write next real note to string
                if (parseNext) {

                    //Find and write correct note, then disable parse
                    sequence += noteFSO[mainWindow.indexList[i]];
                    noteInt += masterInt;
                    parseNext = false;
                }
                //Cutoff long interval at second-to-last note, to preserve final note's master interval
                if (i == mainWindow.indexList.Length - 2) {
                    sequence += noteInt;
                    noteInt = 0;
                    goto SkipOneLoop;
                }
                //If real note at next location, write interval after present note
                if (i + 1 < mainWindow.indexList.Length) {

                    if (mainWindow.indexList[i + 1] != 0) {
                        //Write interval and reset to 0
                        sequence += noteInt;
                        noteInt = 0;
                        //Enable parse for next real note
                        parseNext = true;

                    }
                    else {
                        noteInt += masterInt;
                    }
                }
            SkipOneLoop: int skipOneLoop;
            }
        ExitFor: int exitFor;

            return sequence;

        }//End summaryText

        //Audit note sequence and check for any intervals that are too short, add to list
        public static List<int> auditSequence(int masterInt) {

            //FreeSO maximum allowed interval per note
            {
                // Real Notation - FreeSO Notation - Interval
                // E2   8        - H               - 20
                // D#   7        - B               - 15
                // C#   6        - A               - 18
                // B    5        - G               - 18
                // A    4        - F               - 17
                // G#   3        - E               - 18
                // F#   2        - D               - 18
                // E    1        - C               - 18
            }

            int[] noteSpace = { 18, 18, 18, 17, 18, 18, 15, 20 };

            bool error = false;

            List<int> errorList = new List<int>();

            //For each value of note
            for (int i = 0; i < 8; i++) {

                List<int> noteFound = new List<int>();

                //For each entry of type of note
                for (int j = 0; j < mainWindow.indexList.Length; j++) {

                    //Add location of note to list
                    if (i + 1 == mainWindow.indexList[j]) {

                        noteFound.Add(j);
                    }
                }

                //If list has 1 or less entries, skip error check
                if (noteFound.Count <= 1) goto SkipErrorCheck;

                //For each of specified note's locations
                for (int j = 0; j < noteFound.Count - 1; j++) {

                    //Find interval difference between note and next note's occurance
                    int noteInt = (noteFound[j + 1] - noteFound[j]) * masterInt;

                    //If interval is greater than the limit value
                    if (noteInt < noteSpace[i]) {

                        //Add bad note's position to error list
                        errorList.Add(noteFound[j]);
                    }

                }
            SkipErrorCheck: int skipErrorCheck;
            }

            return errorList;

        }//End auditSequence
    }
}
