using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320;
        const int DISPLAY_HEIGHT = 460;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>

        private void drawBallsButton_Click(object sender, EventArgs e)
        {
            //Draw graphics
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.Blue);
            //x position of the current ball
            int x = DISPLAY_LEFT;
            //y position of the current ball
            int y = DISPLAY_TOP;
            //get the number of balls to draw
            int ballAmount = int.Parse(ballAmountTextBox.Text);
            //set row length
            int rowLength = (BALL_SIZE + GAP_SIZE) * ballAmount;
            //calculate column height
            int numRows = DISPLAY_HEIGHT / (BALL_SIZE + GAP_SIZE);
            //Declare variable to generate random colors
            int ballColor;
            Random rand = new Random();
            //Set try to catch errors
            try
            {
                if (rowLength < DISPLAY_WIDTH)
                {
                    //define amount of rows that can fit inside screen height
                    for (int row = 1; row <= numRows; row++)
                    {
                        //define amount of columns that can fit in screen width
                        for (int col = 1; col <= ballAmount; col++)
                        {
                            //get random colors for ellipses based on the random values assigned to each color
                            for (int c = 1; c <= 10; c++)
                            {
                                ballColor = rand.Next(1, 41);
                                Console.WriteLine(ballColor);
                                if (ballColor > 1 && ballColor <= 9)
                                {
                                    br.Color = Color.Blue;
                                }
                                else if (ballColor > 9 && ballColor <= 19)
                                {
                                    br.Color = Color.Red;
                                }
                                else if (ballColor > 19 && ballColor <= 29)
                                {
                                    br.Color = Color.Orange;
                                }
                                else if (ballColor > 29 && ballColor <= 39)
                                {
                                    br.Color = Color.Green;
                                }
                                else if (ballColor == 40)
                                {
                                    br.Color = Color.Purple;
                                }
                            }
                            //define start location for ellipses
                            paper.FillEllipse(br, x, y, BALL_SIZE, BALL_SIZE);
                            //move ellipses to right by ball and gap size
                            x += BALL_SIZE + GAP_SIZE;
                        }
                        //mover ellipses down by ball and gap size
                        y += BALL_SIZE + GAP_SIZE;
                        //start x back at starting point
                        x = DISPLAY_LEFT;
                    }
                }
                //display error if ballamount is greater then screen width and height
                if (ballAmount >= 7)
                {
                    MessageBox.Show("Oh Snap! The amount you have entered exceeds the limit. Please enter an amount between 1 and 6");
                    pictureBoxDisplay.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// Draws an image of a phone in the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = Properties.Resources.iPhone;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
    }
}
