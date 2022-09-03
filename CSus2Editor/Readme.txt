CSus2 Music Box Editor
Created By: Reaganomics Lamborghini (FreeSO)

CSus2 Music Box Editor is a Windows Forms application programmed in C#. This program makes it easy to write songs that can be output in the correct format as to be read by the Csus2 Music Box in FreeSO.

==Creating New Sequence==
To generate a new empty sequence, click "New Sequence" under the "File" menu button. It will generate one measure's worth of empty columns.


==Edit Columns==
To add columns, set the desired amount of additional columns in the "Add or Remove Columns" box. Set the location of where you'd like to insert these new columns in the "Edit After Column:" box. Click the "Edit Columns" button to add the new columns.

To remove columns, set a negative number under the "Add or Remove Columns" box. It will remove columns following the location set in the "Edit After Column:" box.

Columns that are added or removed will be done so AFTER the indicated column in the "Edit After Column:" box. 
For instance: Adding three columns after the 8th column will add 3 new columns following the 8th column. Removing 3 columns after the 8th column will get rid of the columns in the 9th, 10th, and 11th position.


==Note Intervals==
Set time interval between each note by changing the value in the Interval box. One time interval represents one game tick, of which there are 30 per second. For the best results in game, I suggest an interval value of 5 or higher.


==Play Song==
This will play back the sequence of notes you have entered, and match how it will sound in game.

Clicking the "Loop" check box will loop your sequence until you hit the "Stop Song" button.


==Note Sequencer==
Each column represents each note the music box can play. The note displayed on each button is different from FreeSO, because FreeSO's notes do not match up with the real-life notation. However, the program will still output FreeSO's notation. This is only so that it's easier to transcript notes based on real life material.


==Copy Note Sequence==
At the bottom of the window, you will see an empty text box. To fill the textbox, click on "Update". This translates the note sequence into the format that the Csus2 Music Box uses in FreeSO. Clicking on the textbox will copy the text to your clipboard. From there, you can copy it into your music box in game.


==Loading Note Sequence==
Clicking "Load Sequence" under the "File" menu button will open a prompt asking for a sequence. Paste your note sequence in the text box and press the enter key, and your song will be loaded into the editor. Beware, only sequences that follow this program's output format will work!


==Options==
There are a few settings under the "Options" menu button that will effect the visuals.

"Show Measure Lines" will enable or disable the measure and beat colors from drawing, and all of the note columns will be white.

"Play at Fist Note" will decide wether or not the song plays from the beginning of the sequence, or at the first placed note on the sequence.

"Show Crewmate" will draw a crewmate following the notes you place, and "Draw Empty Notes" will draw the crewmate on empty notes, either at the previous or next note's height, depending on the location of the play bar.


==Tips==
FreeSO has a hard time playing repeating notes for some reason, so try to avoid having the same note twice in a row in your sequence. Intervals of at least 4 to 5 are also recommended, FreeSO also has an issue skipping notes if the interval is too short. This may be due to lag or desynchronization, but I have no idea.

Building a song out of smaller chunks can be an easier process, and allow you to have different interval settings for different sections of the song.

Copy your note sequences to a text file if you want to save them. Note sequences made in this program can be loaded again if you want to edit them later!

Clicking "Time Signature" under the "Options" menu button will open up a window that allows you to change the time signature of the note sequence. This really only changes which column's colors are changed to either blue or red, and will not be saved with your sequence if you intend to load it later. It should help a lot in placing your notes though.
