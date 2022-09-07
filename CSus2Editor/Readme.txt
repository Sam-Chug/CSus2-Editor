CSus2 Music Box Editor
Created By: Reaganomics Lamborghini (FreeSO)

CSus2 Music Box Editor is a Windows Forms application programmed in C#. This program makes it easy to write songs that can be output in the correct format as to be read by the Csus2 Music Box in FreeSO.

Placing Notes
⦁	Clicking on a note in one of the columns present in the sequencer will mark a note at that position. These notes will be played back in the program upon playing the sequence, and will be included in the sequence upon output.
⦁	You can clear a note by clicking on it again, or move the note to a different position in the same column by clicking another note in said column.
⦁	The music box can only play one note at a time, so only one note will be allowed in a column at any time.


Editing Columns
⦁	To add columns, set the desired amount of additional columns in the "Add or Remove Columns" box. Set the location of where you'd like to insert these new columns in the "Edit After Column:" box. Click the "Edit Columns" button to add the new columns.
⦁	To remove columns, set a negative number under the "Add or Remove Columns" box. It will remove columns following the location set in the "Edit After Column:" box.
⦁	Columns that are added or removed will be done so AFTER the indicated column in the "Edit After Column:" box. 
⦁	For instance: Adding three columns after the 8th column will add 3 new columns following the 8th column. Removing 3 columns after the 8th column will get rid of the columns in the 9th, 10th, and 11th position.


Note Interval
⦁	Set the time interval between each note by changing the value in the Interval box. One time interval represents one game tick, which happens 30 times per second.
⦁	Notes of the same tone will have trouble playing if placed too quickly in succession with one another. Check the "Sequence Summary" box to make sure your song will play properly in game.


Media Controls
⦁	Underneath the note sequencer, you will see three buttons with loop, play, and play-from-start symbols. These allow you to preview your sequence before exporting and importing into FreeSO's music box.
⦁	The left-most box will toggle looping during playback. If the symbol is red, your sequence will end after the last note. If it is black, that means your sequence will continue looping until you hit the stop button.
⦁	The middle button will play your sequence, starting from the very first column in the sequence.
⦁	The right-most button will play your sequence, starting from the column currently at the center of the screen. This column is highlighted yellow while the song is not playing, so you have an indication of where the song will play from.
⦁	Pressing either the play or play-from-start buttons during playback will stop playing the song.


Sequence Output
⦁	At the bottom of the window, you will see an empty text box. To fill the textbox, click on "Update". This translates the note sequence into the format that the Csus2 Music Box uses in FreeSO. Clicking on the textbox will copy the text to your clipboard. From there, you can copy it into your music box in game.
⦁	Music boxes in FreeSO have a maximum length of sequence that can be played. If your sequence is over 1,024 characters long, any notes over the maximum limit will not be played. The "Sequence Summary" box will let you know if your sequence goes over this maximum length.


Sequence Input
⦁	You can load a sequence by clicking "Load Sequence" under the "File" tab at the top of the window. Note that only sequences that follow the same output format as this program will load properly, if they load at all.


Sequence Summary
⦁	The sequence summary box will display any discrepancies your sequence has in comparison with FreeSO's music box format.
⦁	Each note has a different interval deciding whether or not two of the same note will play after one another. If one note is too close to another with the same value, it will not play properly in FreeSO. The summary box will show any errors, and if clicked, will open a window showing the columns errors were found at.
⦁	FreeSO's music box has a maximum character limit, 1,024, and will skip any note past this value. The summary box will display the current character count, and alert you if the current sequence passes this threshold.


Generating a New Sequence
⦁	You can generate a clean sequencer by clicking "New Sequence" under the "File" tab. This will generate two measures worth of empty note columns.


Options
⦁	There are several settings you can toggle to change the look and behavior of the editor. These settings are found under the "Options" tab at the top of the window.
⦁	Clicking "Time Signature" will open a window with a few settings to change how the sequencer is laid out. There are a number of beats per measure, and a number of quarters per beat. You can change these values to fit the rhythm of the song you are currently making. The "Offset" value will shift the measure backwards or forwards depending on the value, if your song requires some empty space before the first major beat.
⦁	"Show Measure Lines", if enabled, will color the column at each quarter, beat, and measure, and will account for the specified offset value.
⦁	"Follow Play Bar" will toggle whether sequencer will scroll and follow the play bar's current position.
⦁	"Show Crewmate" will toggle a crewmate graphic at each note when played.
⦁	"Draw Empty Notes", under the "Show Crewmate" setting, will draw a crewmate on every column, regardless of it having a note or not.


Tips
⦁	The editor becomes unstable when editing songs over ~500 columns, so keep that in mind when making longer songs. Make sure to save your output sequence fairly regularly, as they are lost if the program crashes.
⦁	If you intend to build a longer song, it's much easier to build it in parts, then paste the sequences together afterwards. You can also load the combined output back into the editor to make sure the sequence plays correctly.
⦁	Save your output sequences to a textfile for documentation and later usage. You may also load these sequences back into the editor at a later time, if you wish to further edit them.
⦁	Share your sequences with others! I'm sure people are sick of hearing the same old Among Us tune playing out of their music boxes, and would love to hear something new.