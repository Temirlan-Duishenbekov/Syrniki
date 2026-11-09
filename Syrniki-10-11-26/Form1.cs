using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Syrniki_10_11_26
{
    public partial class Form1 : Form
    {
        // Game variables
        private Random random = new Random();

        private int totalRounds = 0;
        private int currentRound = 1;

        private int firstDice = 0;
        private int secondDice = 0;

        private int firstScore = 0;
        private int secondScore = 0;

        private int currentPlayer = 1;

        private bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();

            button8.Enabled = false;

            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
        }

        // START GAME
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                label9.Text = "Please enter how many rounds you want to play.";
                return;
            }

            if (string.IsNullOrWhiteSpace(Firstplayer1.Text) ||
                string.IsNullOrWhiteSpace(SecondPlayer.Text))
            {
                label9.Text = "Please set up both players first.";
                return;
            }

            if (pictureBox5.Image == null || pictureBox6.Image == null)
            {
                label9.Text = "Please select characters for both players.";
                return;
            }

            totalRounds = (int)numericUpDown1.Value;

            currentRound = 1;
            firstDice = 0;
            secondDice = 0;

            firstScore = 0;
            secondScore = 0;

            currentPlayer = 1;

            gameStarted = true;

            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "1";

            label1.Text = Firstplayer1.Text;

            label9.Text = "Game started!\n";

            button1.Enabled = false;
            button8.Enabled = true;
        }

        // ROLL DICE
        private void button8_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
                return;

            int dice = random.Next(1, 7);

            ShowDice(dice);

            if (currentPlayer == 1)
            {
                firstDice = dice;

                label1.Text = SecondPlayer.Text;

                label9.Text +=
                    Firstplayer1.Text + " rolled: " +
                    firstDice + Environment.NewLine;

                currentPlayer = 2;
            }
            else
            {
                secondDice = dice;

                label9.Text +=
                    SecondPlayer.Text + " rolled: " +
                    secondDice + Environment.NewLine;

                // Compare dice results
                if (firstDice > secondDice)
                {
                    firstScore++;

                    label9.Text +=
                        Firstplayer1.Text + " wins Round " +
                        currentRound + Environment.NewLine;
                }
                else if (secondDice > firstDice)
                {
                    secondScore++;

                    label9.Text +=
                        SecondPlayer.Text + " wins Round " +
                        currentRound + Environment.NewLine;
                }
                else
                {
                    label9.Text +=
                        "Round " + currentRound +
                        " is a draw!" + Environment.NewLine;
                }

                // Update scores
                label7.Text = firstScore.ToString();
                label8.Text = secondScore.ToString();

                label9.Text += "--------------------" +
                    Environment.NewLine;

                // Check remaining rounds
                if (currentRound >= totalRounds)
                {
                    gameStarted = false;

                    button8.Enabled = false;

                    label1.Text = "Game Finished!";

                    label9.Text += "Game completed!" +
                        Environment.NewLine;

                    return;
                }

                // Next round
                currentRound++;

                label10.Text = currentRound.ToString();

                currentPlayer = 1;

                label1.Text = Firstplayer1.Text;
            }
        }

        // SHOW DICE IMAGE
        private void ShowDice(int dice)
        {
            switch (dice)
            {
                case 1:
                    pictureBox7.Image = Properties.Resources.Dice1;
                    break;

                case 2:
                    pictureBox7.Image = Properties.Resources.Dice2;
                    break;

                case 3:
                    pictureBox7.Image = Properties.Resources.Dice3;
                    break;

                case 4:
                    pictureBox7.Image = Properties.Resources.Dice4;
                    break;

                case 5:
                    pictureBox7.Image = Properties.Resources.Dice5;
                    break;

                case 6:
                    pictureBox7.Image = Properties.Resources.Dice6;
                    break;
            }
        }

        // SHOW RESULT
        private void button3_Click(object sender, EventArgs e)
        {
            string result;

            if (firstScore > secondScore)
            {
                result = Firstplayer1.Text + " is the WINNER!";
            }
            else if (secondScore > firstScore)
            {
                result = SecondPlayer.Text + " is the WINNER!";
            }
            else
            {
                result = "It's a DRAW!";
            }

            string details =
                "GAME RESULT\n\n" +
                Firstplayer1.Text + ": " + firstScore + " points\n" +
                SecondPlayer.Text + ": " + secondScore + " points\n\n" +
                result;

            MessageBox.Show(
                details,
                "Dice Game Results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // RESET ALL
        public void button4_Click(object sender, EventArgs e)
        {
            gameStarted = false;

            totalRounds = 0;
            currentRound = 1;

            firstDice = 0;
            secondDice = 0;

            firstScore = 0;
            secondScore = 0;

            currentPlayer = 1;

            numericUpDown1.Value = 0;

            label1.Text = "";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "";
            label10.Text = "0";

            pictureBox7.Image = null;

            button1.Enabled = true;
            button8.Enabled = false;
        }

        // FIRST PLAYER SETUP - YOUR ORIGINAL CODE
        public void button6_Click(object sender, EventArgs e)
        {
            string firstplayer = Firstplayer1.Text;

            if (pictureBox6.Image == pictureBox5.Image)
            {
                label9.Text = "Image cant be same";
                return;
            }

            if (string.IsNullOrEmpty(firstplayer))
            {
                label9.Text = "Please enter the first player's name.";
                return;
            }

            if (radioButton1.Checked == true &&
                pictureBox6.Image != pictureBox1.Image)
            {
                pictureBox5.Image = pictureBox1.Image;
            }

            if (radioButton2.Checked == true &&
                pictureBox6.Image != pictureBox2.Image)
            {
                pictureBox5.Image = pictureBox2.Image;
            }

            if (radioButton3.Checked == true &&
                pictureBox6.Image != pictureBox3.Image)
            {
                pictureBox5.Image = pictureBox3.Image;
            }

            if (radioButton4.Checked == true &&
                pictureBox6.Image != pictureBox4.Image)
            {
                pictureBox5.Image = pictureBox4.Image;
            }

            groupBox5.Text = firstplayer;
        }

        // SECOND PLAYER SETUP - YOUR ORIGINAL CODE
        public void button5_Click_1(object sender, EventArgs e)
        {
            string firstplayer = Firstplayer1.Text;

            if (pictureBox6.Image == pictureBox5.Image)
            {
                label9.Text = "Image cant be same";
                return;
            }

            if (string.IsNullOrEmpty(firstplayer))
            {
                label9.Text = "Please enter the first player's name.";
                return;
            }
            else
                if (radioButton1.Checked == true &&
                    pictureBox5.Image != pictureBox1.Image)
                {
                    pictureBox6.Image = pictureBox1.Image;
                }

            if (radioButton2.Checked == true &&
                pictureBox5.Image != pictureBox2.Image)
            {
                pictureBox6.Image = pictureBox2.Image;
            }

            if (radioButton3.Checked == true &&
                pictureBox5.Image != pictureBox3.Image)
            {
                pictureBox6.Image = pictureBox3.Image;
            }

            if (radioButton4.Checked == true &&
                pictureBox5.Image != pictureBox4.Image)
            {
                pictureBox6.Image = pictureBox4.Image;
            }

            groupBox6.Text = firstplayer;
        }

        // OTHER DESIGNER EVENTS
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        public void Firstplayer1_TextChanged(object sender, EventArgs e) { }
        public void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void SecondPlayer_TextChanged(object sender, EventArgs e) { }
    }
}
