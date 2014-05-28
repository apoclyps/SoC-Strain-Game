/**
 * STRAIN - Gameboard form
 * The gameboard consists of a game grid and buttons to initilise the game, restart it and exit it
 * The logic of the game is handled by seperate methods in this form that are called when specific
 * requirements have been met in the user interface and by pressing the mutate button.
 * On screen messages and message box's are displayed to keep the user information of vital information
 * The game can be played as many times as the user wishes and can be restarted at any point during a game 
 * or after a game has finished. 
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
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace STRAIN
{
 

    public partial class frmGameboard : Form
    {
        // New instance of timer class
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        // New instance of random
        Random random = new Random();
        // New instance of button array uninitialised
        Button[,] btnArray;
        // integer arrays for holding the starting game state and the ending game state
        int[,] btnParentMutation; 
        int[,] btnChildMutation;

        // Integer variables for calculating cords,measuring time, and scores
        int arraySize, randomx, randomy;
        int mutationGenerations = 0, virusCells = 0;
        int highScore = 0;
        int minuteStopper = 1, timeTickerSeconds = 0, timeTickerMinutes = 0;
        // Boolean set to false until the game is started
        bool cellMutation = false;

       /**
        * frmGameboard
        * Uses default initialiseComponent method
        * @param  none
        * @return none
        */
        public frmGameboard()
        {
            InitializeComponent();
        }

        /**
        * frmGameboard_Load
        * Initilises array size and arrays
        * Creates a button with properties for entire array
        * Adds event handler to buttons
        * Starts timer tick every 1 second
        * @param  object sender, EventArgs e
        * @return none
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            // Initilises array size, and initilises arrays
            arraySize = 10;
            btnArray = new Button[arraySize, arraySize];
            btnParentMutation = new int[arraySize+2, arraySize+2];
            btnChildMutation = new int[arraySize+2, arraySize+2];
      
            // Creates a grid of buttons and sets properties for each- 10*10 grid
            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    // Initilising individual button and setting properties
                    btnArray[x, y] = new Button();
                    btnArray[x, y].SetBounds(x * 40, y * 40, 40, 40);
                    btnArray[x, y].Location = new Point((x+2) * 40, (y+2) * 40);
                    btnArray[x, y].BackColor = Color.DodgerBlue;
                    btnArray[x, y].Anchor = AnchorStyles.Bottom;

                    // Adding event handler to button
                    btnArray[x, y].Click += new EventHandler(this.btnArrayEvent_Click);
                    Controls.Add(btnArray[x, y]);
                }
            }

            // Add event handler to timer and call every second
            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick every second
        }


        /**
        * btnArrayEvent_Click
        * Added to every button
        * Checks to see if game is enabled and if so allows cells to be selected and modified
        * During game red cells that are clicked will generate a score 
        * when all virus cells are killed a message is displayed to mutate now
        * @param  object sender, EventArgs e
        * @return none
        */
        void btnArrayEvent_Click(object sender, EventArgs e)
        {
            // Print to console when button is pressed
            Console.WriteLine(" Cell array button pressed");

            // When game has not been started and selects are to be selected from the grid
            if (cellMutation == false)
            {
                // If a user wants to select a cell - change colour
                if (((Button)sender).BackColor == Color.DodgerBlue)
                {
                    ((Button)sender).BackColor = Color.White;
                }
                // If a user decides to unselect a cell they selected - change back
                else if (((Button)sender).BackColor == Color.White)
                {
                    ((Button)sender).BackColor = Color.DodgerBlue;
                } 
            }

            // If virus cells have been generated and the game hasnt ended
            if (((Button)sender).BackColor == Color.Red && lblGameStatus.Text != "Game over")
            {
                // Allow user to select cell to return it to blue and generate score
                ((Button)sender).BackColor = Color.DodgerBlue;
                highScore = highScore + 10;
                txtHighScore.Text = "" + highScore;
                virusCells = virusCells - 1;

                // Update onscreen message and print to console
                lblGameStatus.Text = "Bacteria : " + virusCells;
                Console.WriteLine("Virus cells = " + virusCells);
            }

            // If all virus cells have been killed then update on screen message
            if (virusCells == 0)
            {
                lblGameStatus.Text = "Mutate Now";
            }
        }


        /**
        * btnMutate
        * Checks to see if the user has selected cells on the grid
        * If cells selected then calls mutateGrid method
        * if cells have been selected and all died, then game ends 
        * if cells have not been selected the user is prompted to do so
        * @param  object sender, EventArgs e
        * @return none
        */
        private void button2_Click(object sender, EventArgs e)
        {
            // White cells is reset to zero to recount each time button is pressed
            int whiteCells = 0;

            // Plays a sound when clicked
            System.Media.SystemSounds.Asterisk.Play();

            // Checks if any buttons are white and if so, increments by 1
            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    if (btnArray[x, y].BackColor == Color.White)
                    {
                        whiteCells = whiteCells + 1;
                    }
                }
            }

            // If whitecells are greater than zero then mutateGrid can be called
            if (whiteCells > 0)
            {
                mutateGrid();
            }
            // If the game has started but all cells die, then game ends
            else if ( (cellMutation == true) && (whiteCells == 0) )
            {
                // Stops timer, and displays on screen text / messagebox
                timer.Stop();
                lblGameStatus.Text = "Game over";
                btnMutate.Visible = false;
                MessageBox.Show("The DNA sequence has died prematurely. \r\n\r\nPlease select restart and generate a new DNA sequence on the grid.", "STRAIN : New DNA Sequence Needed", MessageBoxButtons.OK);
            }
            // Messagebox is shown if user has not started the game by selecting cells
            else
            {
                MessageBox.Show("A DNA sequence is needed. \r\n\r\nPlease select cells on the grid to create a DNA sequence.", "STRAIN : DNA Sequence Needed", MessageBoxButtons.OK);
            }

        }

        /**
        * mutateGrid
        * Changes on screen messages, high scores, timer and generations when pressed
        * Randomly introduces virus cells to the game that the user must kill
        * Calls a method to update the parent generation back to previous child generation
        * Updates the display with the updated parent generation of the grid. 
        * @param  object sender, EventArgs e
        * @return none
        */
        private void mutateGrid()
        {
            // Changes on screen text and prints to console
            Console.WriteLine(" Mutate button pressed ");
            lblGameStatus.Text = " Mutating";

            // Enables the timer, starts the game and starts the timer
            timer.Enabled = true;                      
            cellMutation = true;
            timer.Start();

            // If the current grid has virus cells then these produce a negative score
            if (virusCells > 0)
            {
                // For each virus cell 20 points is deducted
                highScore = highScore - (virusCells * 20);
                txtHighScore.Text = "" + highScore;
            }
            // If the current grid has been cleared of virus cells then a bonus if given
            else
            {
                // If all virus cells are killed then a bonus if given of the next generation / highscore
                highScore = highScore + (highScore / (mutationGenerations+1));
                txtHighScore.Text = "" + highScore;
            }
            // Virus cells are reset to zero for next iteration
            virusCells = 0;

            // Updating the parent generation of the grid with changes
            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    if (btnArray[x, y].BackColor == Color.DodgerBlue)
                    {
                        btnParentMutation[x, y] = 0;
                    }
                    else if (btnArray[x, y].BackColor == Color.White)
                    {
                        btnParentMutation[x, y] = 1;

                        highScore = highScore + (btnParentMutation[x,y] * 5);
                        txtHighScore.Text = "" + highScore;
                    }
                }
            }

            // Increment the generations by 1 and update text
            mutationGenerations += 1;
            txtMutations.Text = "" + mutationGenerations;

            // call the update Parent mutation method to mutate all cells on the grid
            Console.WriteLine(" update mutations ");
            updatebtnParentMutation();

            // Display the mutation on the grid
            Console.WriteLine(" update display ");
            updateDisplay();

            // Randomly introduce virus cells to the grid and display
            for (int x = 0; x < (arraySize / 2); x++)
            {
                // Generation random cordinates
                randomx = random.Next(arraySize);
                randomy = random.Next(arraySize);

                // Checking to see if cordinates are available
                if (btnArray[randomx, randomy].BackColor == Color.DodgerBlue)
                {
                    // Cordinates available - virus placed
                    btnArray[randomx, randomy].BackColor = Color.Red;
                    virusCells = virusCells + 1;
                    Console.WriteLine("Virus cells = " + virusCells);
                }
                else
                {
                    // cordinates unavailable - try again with new cords
                    x = x - 1;
                }
            }
        }

        /**
        * updateDisplay
        * Updates the previous display with the current display a
        * @param  none
        * @return none
        */
        private void updateDisplay()
        {
            // makes parent mutation grid = to child mutation grid
            for (int x = 0; x < arraySize + 2; x++)
            {
                for (int y =0; y < arraySize + 2; y++)
                {
                    btnParentMutation[x, y] = btnChildMutation[x, y];
                }
            }

            // Checks parent mutation grid to update display grid accordingly
            for (int x = 0; x < arraySize + 0; x++)
            {
                for (int y = 0; y < arraySize + 0; y++)
                {
                    // Cell does not contain anything
                    if (btnParentMutation[x, y] == 0)
                    {
                        btnArray[x, y].BackColor = Color.DodgerBlue;
                    }
                    // Cell contains a living cell
                    else if (btnParentMutation[x, y] == 1)
                    {
                        btnArray[x, y].BackColor = Color.White;
                    }
                }
            }
        }


        /**
        * timer_Tick
        * Increments the clock by 1 second , each second it is called
        * Outputs the time to the screen in seconds and minutes.
        * Stops when the time reaches 1 minute and declares game over
        * @param  object sender, EventArgs e
        * @return none
        */
        private void timer_Tick(object sender, EventArgs e)
        {
            // Increment by 1 to represent 1 second
            timeTickerSeconds += 1;

            // Every 60 seconds reset seconds to zero and increment minutes by 1
            if (timeTickerSeconds >= 60)
            {
                timeTickerSeconds = 0;
                timeTickerMinutes += 1;
            }

            // If seconds are less than 10 use :0 formatting
            if (timeTickerSeconds < 10)
            {
                txtTime.Text = timeTickerMinutes + ":0" + timeTickerSeconds;
            }
            // If seconds are greater than 10 use : formatting
            else
            {
                txtTime.Text = timeTickerMinutes + ":" + timeTickerSeconds;
            }

            // When the time is equal to the stop clock then end game
            if (timeTickerMinutes == minuteStopper)
            {
                timer.Stop();
                lblGameStatus.Text = "Game over";
                btnMutate.Visible = false;
            }
        }

        /**
      * button3_Click
      * Confirms if the user wants to exit the system
      * @param  object sender, EventArgs e
      * @return none
      */
        private void button3_Click(object sender, EventArgs e)
        {
            // Plays a sound when clicked
            System.Media.SystemSounds.Asterisk.Play();

            // Messagebox to confirm the user wants to exit
            if (MessageBox.Show("Confirmation of mission abort required : \r\n\r\nAre you sure you want to abort the mission ? ", "STRAIN : Mission Abort", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        /**
        * updatebtnParentMutation
        * Updates the parent grid by cycling through all x and y cordinates
        * Maps border cordinates to additional cells used around grid to link all sides to each other to createa a torus.
        * @param  none
        * @return none
        */
        void updatebtnParentMutation()
        {
            Console.WriteLine("update Parent Mutation");
            for (int x = 0; x < (arraySize + 2); x++)
            {
                for (int y = 0; y < (arraySize + 2); y++)
                {
                    // Determines the type of cells used
                    if ((x == 0 && y == 0) || (x == 0 && y == (arraySize + 1)) || (x == (arraySize + 1) && y == 0) || (x == (arraySize + 1) && y == (arraySize + 1)))
                    {
                        Console.WriteLine("Non used cells");
                    }
                    // if the cordinates are in range
                    else if (((x > 0) || (x < arraySize)) && ((y > 0) || (y < arraySize)))
                    {
                        // Searching the Y cordinate boundries
                      if (x > 0 && ((y == 0) || (y == arraySize + 1)))
                        {
                            if ((x == (arraySize + 1)) || (y == (arraySize + 1)))
                            {
                                if (x == (arraySize + 1))
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x-arraySize, y];
                                }
                                else if (y == (arraySize + 1))
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x, y - arraySize];
                                }
                            }
                            else if ((x == 0) || (y == 0))
                            {
                                if (x == 0)
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x+1, y];
                                }
                                else if (y == 0)
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x, y+1];
                                }
                            }
                        }
                      // Searching the x cordinate boundries
                        else if (y > 0 && ((x == 0) || (x == arraySize + 1)))
                        {
                            if ((x == (arraySize + 1)) || (y == (arraySize + 1)))
                            {
                                if (x == (arraySize + 1))
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x - arraySize, y];
                                }
                                else if (y == (arraySize + 1))
                                {
                                    btnParentMutation[x,y] = btnParentMutation[x,y-arraySize];
                                }
                            }
                            else if ((x == 0) || (y == 0))
                            {
                                if (x == 0)
                                {
                                    btnParentMutation[x, y] = btnParentMutation[x + 1, y];
                                }
                                else if (y == 0)
                                {
                                    btnParentMutation[x,y] = btnParentMutation[x,y+1];
                                }
                            }
                        }
                    }
                }
            }
 
            // Cycles through all cells in the array
            for (int x = 0; x < (arraySize); x++)
            {
                for (int y = 0; y < (arraySize); y++)
                {
                    if (((x > 0) && (x < (arraySize + 1))) && ((y > 0) && (y < (arraySize + 1))))
                    {
                        // Calls method to find the next state of the current cell and saves it in the child grid
                        findNextCellState(x, y);
                    }
                }
            }
        }

        /**
        * findNextCellState
        * Finds the number of living neighbours and then applys the rule set to check if the cell lives or dies during the next generation
        * @param  (int x, int y)
        * @return none
        */
        private void findNextCellState(int x, int y)
        {
            // Resets the counter to zero
            int alive_count = 0;

            //This code counts how many neighbours are alive
            alive_count += btnParentMutation[x - 1, y - 1];
            alive_count += btnParentMutation[x - 1, y];
            alive_count += btnParentMutation[x - 1, y + 1];
            alive_count += btnParentMutation[x, y - 1];
            alive_count += btnParentMutation[x, y + 1];
            alive_count += btnParentMutation[x + 1, y - 1];
            alive_count += btnParentMutation[x + 1, y];
            alive_count += btnParentMutation[x + 1, y + 1];

            // Applys the rule set to determine if it lives or dies
            if ((alive_count == 2 && btnParentMutation[x, y] == 1) || (alive_count == 3))
            {
                // Sets cell to live
                btnChildMutation[x, y] = 1;
            }
            else
            {
                // Sets cell to die
                btnChildMutation[x, y] = 0;
            }
        }

        /**
        * btnRestart_Click
        * Resets all properties to default settings used when game has not been started
        * Asks the user to confirm they want to restart the game
        * @param  (int x, int y)
        * @return none
        */
        private void btnRestart_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();

            if (MessageBox.Show("Confirmation of virus strain experiement restart required : \r\n\r\nAre you sure you want to restart the virus strain experiment ? ", "STRAIN : Virus Strain Creation Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Reset text on form
                txtTime.Text = "0:00";
                txtHighScore.Text = "0";
                txtMutations.Text = "0";
                lblGameStatus.Text = "Create DNA";

                // Set boolean properties
                btnMutate.Visible = true;
                cellMutation = false;

                // Resert variables to zero
                highScore = 0;
                mutationGenerations = 0;
                timeTickerSeconds = 0;
                timeTickerMinutes = 0;
                virusCells = 0;
                highScore = 0;

                // Stop the timer
                timer.Stop();

                // Reset all grids to default
                for (int x = 0; x < arraySize; x++)
                {
                    for (int y = 0; y < arraySize; y++)
                    {
                        btnArray[x, y].BackColor = Color.DodgerBlue;
                        btnParentMutation[x, y] = 0;
                        btnChildMutation[x,y] = 0;                                
                    }
                }
            }
        }

        /**
          * frmGameboard_FormClosing
          * When the user closes it will kill the application
          * @param  Object sender, FormClosingEventArgs e
          * @return none
          */
        private void frmGameboard_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       
    }
}