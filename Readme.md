![image](https://i.imgur.com/2jl3TXD.png)

#CSus2 Music Box Editor

#Song Length

Selected the length of the sequence by changing the value in Song Length Box. Beware that lengths larger than ~50 may cause the program to lag upon resizing. After selecting new length, click "Generate New Sheet" to apply the length. Generating a new sheet will clear all previous notes. The sequence length is currently capped at 100 notes for instability reasons.


#Add Columns

Instead of generating a new set of columns, this will add a specified amount of columns to the end of the current sequence.


#Note Intervals

Set time interval between each note by changing the value in the Interval box. One time interval represents one game tick, of which there are 30 per second. For the best results in game, I suggest an interval value of 5 or higher.


#Play Song

This will play back the sequence of notes you have entered, and match how it will sound in game.


#Note Sequencer

Each column represents each note the music box can play. The note displayed on each button is different from FreeSO, because FreeSO's notes do not match up with the real-life notation. However, the program will still output FreeSO's notation. This is only so that it's easier to transcript notes based on real life material. If you want to clear a column, click on the "Clr." button.


#Copy Note Sequence

At the bottom of the window, you will see an empty text box. To fill the textbox, click on "Update". This translates the note sequence into the format that the Csus2 Music Box uses in FreeSO. Clicking on the textbox will copy the text to your clipboard. From there, you can copy it into your music box in game.


#Tips

FreeSO has a hard time playing repeating notes for some reason, so try to avoid having the same note twice in a row in your sequence. Intervals of at least 4 to 5 are also recommended, FreeSO also has an issue skipping notes if the interval is too short. This may be due to lag or desynchronization, but I have no idea.

Building a song out of smaller chunks can be an easier process, and allow you to have different interval settings for different sections of the song.

Saving and loading are not yet implemented (if they ever will be), so make sure to copy your songs into a text file for easy access later.
