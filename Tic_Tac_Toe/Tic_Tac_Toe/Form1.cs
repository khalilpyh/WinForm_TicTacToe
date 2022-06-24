/*
 * Name: Yuhao Peng
 * Date: 2022-06-24
 * Title: Tic Tac Toe Game Practice
 * */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool checker;
        int counter;

        void EnableFalse()
        {
            //disable all field buttons
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }

        void EnableTrue()
        {
            //enable all field buttons
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
        }

        void ResetFieldButton()
        {
            //reset button content
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";
            //reset button background color
            btnTic1.BackColor = Color.WhiteSmoke;
            btnTic2.BackColor = Color.WhiteSmoke;
            btnTic3.BackColor = Color.WhiteSmoke;
            btnTic4.BackColor = Color.WhiteSmoke;
            btnTic5.BackColor = Color.WhiteSmoke;
            btnTic6.BackColor = Color.WhiteSmoke;
            btnTic7.BackColor = Color.WhiteSmoke;
            btnTic8.BackColor = Color.WhiteSmoke;
            btnTic9.BackColor = Color.WhiteSmoke;
        }

        void WinCount(string player)
        {
            if(player == "X")
            {
                counter = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = (counter+1).ToString();
            }
            else
            {
                counter = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = (counter+1).ToString();
            }
        }

        void Score()
        {
            //first row all X
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //first column all X
            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.Pink;
                btnTic4.BackColor = Color.Pink;
                btnTic7.BackColor = Color.Pink;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //right angle all X
            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic9.BackColor = Color.Crimson;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //left angle all X
            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.CadetBlue;
                btnTic5.BackColor = Color.CadetBlue;
                btnTic7.BackColor = Color.CadetBlue;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //second column all X
            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.SlateBlue;
                btnTic5.BackColor = Color.SlateBlue;
                btnTic8.BackColor = Color.SlateBlue;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //third column all X
            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.Violet;
                btnTic6.BackColor = Color.Violet;
                btnTic9.BackColor = Color.Violet;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //second row all X
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.DarkSlateBlue;
                btnTic5.BackColor = Color.DarkSlateBlue;
                btnTic6.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }
            //third row all X
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.Azure;
                btnTic8.BackColor = Color.Azure;
                btnTic9.BackColor = Color.Azure;
                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("X");
                EnableFalse();
            }

            //===========================================================================================================

            //first row all O
            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.AliceBlue;
                btnTic2.BackColor = Color.AliceBlue;
                btnTic3.BackColor = Color.AliceBlue;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //first column all O
            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.LemonChiffon;
                btnTic4.BackColor = Color.LemonChiffon;
                btnTic7.BackColor = Color.LemonChiffon;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //right angle all O
            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.BlueViolet;
                btnTic5.BackColor = Color.BlueViolet;
                btnTic9.BackColor = Color.BlueViolet;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //left angle all O
            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.NavajoWhite;
                btnTic5.BackColor = Color.NavajoWhite;
                btnTic7.BackColor = Color.NavajoWhite;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //second column all O
            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.SandyBrown;
                btnTic5.BackColor = Color.SandyBrown;
                btnTic8.BackColor = Color.SandyBrown;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //third column all O
            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.SeaGreen;
                btnTic6.BackColor = Color.SeaGreen;
                btnTic9.BackColor = Color.SeaGreen;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //second row all O
            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.Azure;
                btnTic5.BackColor = Color.Azure;
                btnTic6.BackColor = Color.Azure;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
            //third row all O
            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.DarkBlue;
                btnTic8.BackColor = Color.DarkBlue;
                btnTic9.BackColor = Color.DarkBlue;
                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WinCount("O");
                EnableFalse();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            //check and switch player
            if(checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            //check winner
            Score();
            //disable button to prevent duplicate selection
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            Score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            Score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            Score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            Score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            Score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            Score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            Score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            Score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                EnableTrue();
                ResetFieldButton();
                lblPlayerO.Text = "0";
                lblPlayerX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                EnableTrue();
                ResetFieldButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
