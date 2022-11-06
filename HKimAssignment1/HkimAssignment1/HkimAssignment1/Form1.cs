using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HkimAssignment1
{
    public partial class Form1 : Form
    {

        bool turn = true; // true = X, false = O
        int count = 0; // counts turns

        public Form1()
        {
            InitializeComponent();

            // Send clicked button to ClickedButton method
            button1.Click += new System.EventHandler(ClickedButton);
            button2.Click += new System.EventHandler(ClickedButton);
            button3.Click += new System.EventHandler(ClickedButton);
            button4.Click += new System.EventHandler(ClickedButton);
            button5.Click += new System.EventHandler(ClickedButton);
            button6.Click += new System.EventHandler(ClickedButton);
            button7.Click += new System.EventHandler(ClickedButton);
            button8.Click += new System.EventHandler(ClickedButton);
            button9.Click += new System.EventHandler(ClickedButton);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialized the form when it is loaded
            Restart();
        }

        /// <summary>
        /// When the user clicked one of the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickedButton(object sender, EventArgs e)
        {

            // Get the clicked button
            Button clickedBtn = (Button)sender;


            // When it is X's turn
            if (turn == true)
            {
                clickedBtn.BackgroundImage = Properties.Resources.x; // Show X
                clickedBtn.Tag = "x"; // Give the button tag x
                clickedBtn.Enabled = false; // Prevent from clicking the same button again
                turn = false; // Change turn to O
                count++; // Count turn
                Winner(); // Check if there is a winner
            }

            // When it is O'x turn
            else
            {
                clickedBtn.BackgroundImage = Properties.Resources.o; // Show O
                clickedBtn.Tag = "o"; // Give the button tag o
                clickedBtn.Enabled = false; // Prevent from clicking the same button again
                turn = true; // Change turn to X
                count++; // Count turn
                Winner(); // Check if there is a winner
            }
        }


        /// <summary>
        /// A method that lets the users know who won
        /// </summary>
        public void Winner()
        {
            bool winner = false; // Becomes true when someone won

            // Horizontal column 1
            if ((button1.Tag == button2.Tag) && (button2.Tag == button3.Tag) && (button1.Tag != null))
            {
                winner = true;
            }

            // Horizontal column 2
            else if ((button4.Tag == button5.Tag) && (button5.Tag == button6.Tag) && (button4.Tag != null))
            {
                winner = true;
            }
            // Horizontal column 3
            else if ((button7.Tag == button8.Tag) && (button8.Tag == button9.Tag) && (button7.Tag != null))
            {
                winner = true;
            }

            // Vertical column 1
            else if ((button1.Tag == button4.Tag) && (button4.Tag == button7.Tag) && (button1.Tag != null))
            {
                winner = true;
            }

            // Vertical column 2
            else if ((button2.Tag == button5.Tag) && (button5.Tag == button8.Tag) && (button2.Tag != null))
            {
                winner = true;
            }

            // Vertical column 3
            else if ((button3.Tag == button6.Tag) && (button6.Tag == button9.Tag) && (button3.Tag != null))
            {
                winner = true;
            }

            // Diagonal column 1
            else if ((button1.Tag == button5.Tag) && (button5.Tag == button9.Tag) && (button1.Tag != null))
            {
                winner = true;
            }

            // Diagonal column 2
            else if ((button3.Tag == button5.Tag) && (button5.Tag == button7.Tag) && (button3.Tag != null))
            {
                winner = true;
            }


            if (winner)
            {
                string win = "";

                if (turn)
                {
                    // Send text O to show that O won
                    win = "O";
                }
                else
                {
                    // Send text X to show that X won
                    win = "X";
                }

                MessageBox.Show(win + " won"); // Show the message that X won 
                Restart(); // Restart the game
            }

            else if (count == 9) // When user clicked all the buttons
            {
                MessageBox.Show("Tie"); // Show the message that it was draw
                Restart(); // Restart the game
            }

        }

        /// <summary>
        /// A method that restarts the game
        /// </summary>
        public void Restart()
        {
            // Reset turn count
            count = 0;
            // Give X the first turn
            turn = true;

            // Reset background image, tag and enable all buttons
            button1.BackgroundImage = null;
            button1.Enabled = true;
            button1.Tag = null;

            button2.BackgroundImage = null;
            button2.Enabled = true;
            button2.Tag = null;

            button3.BackgroundImage = null;
            button3.Enabled = true;
            button3.Tag = null;

            button4.BackgroundImage = null;
            button4.Enabled = true;
            button4.Tag = null;

            button5.BackgroundImage = null;
            button5.Enabled = true;
            button5.Tag = null;

            button6.BackgroundImage = null;
            button6.Enabled = true;
            button6.Tag = null;

            button7.BackgroundImage = null;
            button7.Enabled = true;
            button7.Tag = null;

            button8.BackgroundImage = null;
            button8.Enabled = true;
            button8.Tag = null;

            button9.BackgroundImage = null;
            button9.Enabled = true;
            button9.Tag = null;

        }

    }
}

