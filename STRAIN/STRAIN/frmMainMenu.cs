/**
 * STRAIN - Main Menu form
 * STRAIN is a grid based game based on a modified version of the game of life.
 * The game has two interfaces. The first interface is the main menu which allows the
 * user to read the rules of the game alongside additional relevant material relating to the game.
 * the second screen is the gameboard which consists of the grid, buttons, and textboxes which update
 * during game play with scores, times, and other stats.
 * @ "Kyle Harrison"
 * @ (07/01/2011)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace STRAIN
{
    public partial class frmMainMenu : Form
    {

        // Creates a new instance of the gameboard form and Sound Player
        frmGameboard frmBoard = new frmGameboard();
        static System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();
        
        // Access to text file to gain location of *.wav file
        private const string FILE_NAME = "C:/Users/Kyle/Documents/Visual Studio 2010/Projects/STRAIN/STRAIN/bin/Debug/soundFile.txt";

        /**
         * frmMainMenu
         * Uses default initialiseComponent method
         * Add's a .wav file to a string sound path and is then used to set an instance of soundplayer
         * The audio file is played and set to play looping.
         * @param  none
         * @return none
         */
        public frmMainMenu()
        {
            InitializeComponent();

            /* NO LONGER NEEDED 
            // Location of audio file
            string soundPath ="";

            // Checks if file exists for the soundfile and if it does then reads from it to access file name
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist.", FILE_NAME);
                return;
            }
            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                String input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                    soundPath = input;
                }
                Console.WriteLine("The end of the stream has been reached.");
            } 
             */

            // Setting the sound player to access the audio file and play
           // mediaSoundPlayer.SoundLocation = soundPath;
            mediaSoundPlayer.SoundLocation = "Gene.wav";
            mediaSoundPlayer.PlayLooping();
        }

        /**
          * DNA structures button
          * Play a sound when clicked
          * Calls hideText method to hide all labels that are not part of txtSelectedText
          * Set's the correct labels to be visible
          * Updates lblSelectedTitle
          * Updates the text of txtSelectedText
          * @param  object sender, EventArgs e
          * @return none
          */
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            if (!(String.IsNullOrEmpty(txtPlayerName.Text)))
            {
                this.Visible = false;
                frmBoard.Visible = true;
            }
            else
            {
                MessageBox.Show("A Scientist is needed to create a new strain of virus. \r\n\r\nPlease enter a Scientist Name.", "STRAIN : Scientist Needed", MessageBoxButtons.OK);
            }

        }

        /**
          * DNA structures button
          * Play a sound when clicked
          * Calls hideText method to hide all labels that are not part of txtSelectedText
          * Set's the correct labels to be visible
          * Updates lblSelectedTitle
          * Updates the text of txtSelectedText
          * @param  object sender, EventArgs e
          * @return none
          */
        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play(); 
            
            if (MessageBox.Show("Confirmation of mission abort required : \r\n\r\nAre you sure you want to abort the mission ? ", "STRAIN : Mission Abort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mediaSoundPlayer.Stop();
                this.Close();
            }

        }

        /**
         * frmMainMenu_FormClosing
         * When the user closes it will kill the application
         * @param  Object sender, FormClosingEventArgs e
         * @return none
         */
        private void frmMainMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /**
         * frmMainMenu_Load
         * No code but needed to run
         * @param  object sender, EventArgs e
         * @return none
         */
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        /**
          * Mute button
          * Play a sound when clicked
          * stop audio file playing
          * @param  object sender, EventArgs e
          * @return none
          */
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play(); 
            mediaSoundPlayer.Stop();
        }


        /**
          * DNA structures button
          * Play a sound when clicked
          * Calls hideText method to hide all labels that are not part of txtSelectedText
          * Set's the correct labels to be visible
          * Updates lblSelectedTitle
          * Updates the text of txtSelectedText
          * @param  object sender, EventArgs e
          * @return none
          */
        private void button2_Click(object sender, EventArgs e)
        {
            // Play sound
            System.Media.SystemSounds.Asterisk.Play();

            // Hide all 
            hideText();

            // Update label title
            lblSelectedTitle.Text = "DNA structures";

            // Set requied picture boxs and labels to visible
            pbBlock.Visible = true;
            pbBlinker.Visible = true;
            PbScatter.Visible = true;
            lblBlinker.Visible = true;
            lblBlock.Visible = true;
            lblScatter.Visible = true;
            lblBlinkerDes.Visible = true;
            lblBlockDes.Visible = true;
            lblScatterDes.Visible = true;
        }

        /**
          * hideText
          * Hides all labels, picture boxes, and sets text to null. 
          * @param  none
          * @return none
          */
        private void hideText()
        {
            lblRules1.Visible = false;
            lblRules2.Visible = false;
            lblRules3.Visible = false;
            lblMission.Visible = false;
            lblObjective.Visible = false;
            pbBlock.Visible = false;
            pbBlock.Visible = false;
            pbBlinker.Visible = false;
            PbScatter.Visible = false;
            lblBlinker.Visible = false;
            lblBlock.Visible = false;
            lblScatter.Visible = false;
            lblBlinkerDes.Visible = false;
            lblBlockDes.Visible = false;
            lblScatterDes.Visible = false;
            txtSelectedText.Text = "";
        }

        /**
          * btnRules_Click
          * Play a sound when clicked
          * Calls hideText method to hide all labels that are not part of txtSelectedText
          * Set's the correct labels to be visible
          * Updates lblSelectedTitle
          * Updates the text of txtSelectedText
          * @param  object sender, EventArgs e
          * @return none
          */
        private void btnRules_Click(object sender, EventArgs e)
        {
            // Play sound when clicked
            System.Media.SystemSounds.Asterisk.Play();

            // Hide all labels, set needed labels to true, and update text       
            hideText();
            lblSelectedTitle.Text = "DNA Mutation Laws";
            lblRules1.Visible = true;
            lblRules2.Visible = true;
            lblRules3.Visible = true;
            txtSelectedText.Text = //"Living Cell's ( White ) \r\n" +
                                    "\r\n" +
                                    "  - 2 or 3 neighbours is a stable mutation \r\n    and survives. \r\n" +
                                    "  - 2 or 3 neighbours is a unstable \r\n    mutation and dies. \r\n\r\n" +
                                   // "Neutral Cells ( Blue ) \r\n" +
                                    "\r\n" +
                                     "  - Unpopulated cells with 3 neighbours \r\n    mutate through proximity . \r\n\r\n" +
                                   // "Bacteria Cells ( Red) \r\n" +
                                    "\r\n" +
                                     "  - Bacteria is randomly occurs after a \r\n    genetic mutation. \r\n  - It must be killed before mutating again. \r\n";      
        }


        /**
          * btnMission_Click
          * Play a sound when clicked
          * Calls another method to hide all labels that are not part of txtSelectedText
          * Set's the correct labels to be visible
          * Updates lblSelectedTitle
          * Updates the text of txtSelectedText
          * @param  object sender, EventArgs e
          * @return none
          */
        private void btnMission_Click(object sender, EventArgs e)
        {
            // Play sound when clicked
            System.Media.SystemSounds.Asterisk.Play(); 
            
            // Hide all labels, set needed labels to true, and update text
            hideText();
            lblMission.Visible = true;
            lblObjective.Visible = true;
            lblSelectedTitle.Text = "Mission Protocols";
            txtSelectedText.Text =  // "Mission : \r\n\r\n" + 
                                    "\r\n\r\n"+ "  Engineer a new strain of virus by placing\r\n  gene identifiers on the grid in any \r\n  formation to create your DNA structure. \r\n  The virus must survive mutation for 1 \r\n  minute to be a viable candidate.\r\n\r\n" +
                                    "\r\n\r\n" + "  Create a stable DNA structure for your \r\n  virus, mutate it through various \r\n  generations, and kill all bacteria. ";     
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBlockDes_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
