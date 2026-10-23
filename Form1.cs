using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rock_paper_scissors_game.Properties;

namespace Rock_paper_scissors_game
{
    

    public partial class Form1 : Form
    {
        private enum EnRbsChoice { paper, rock, scissor }
        private enum EnWinner { player ,Computer,Draw,InProgress}
        private class clsGameStatues
        {
            public EnRbsChoice? Player;
            public EnRbsChoice? Computer;
            public EnWinner? WhoWinner;
            public int CounterWinner;

            public clsGameStatues() {

                Player = null;
                  Computer = null;
                WhoWinner = EnWinner.InProgress;
                CounterWinner = 0;
            }
        }
        private EnRbsChoice GetRandomChoice()
        {

            Array Values = Enum.GetValues(typeof( EnRbsChoice));

            Random rnd = new Random();
            return (EnRbsChoice)Values.GetValue(rnd.Next(Values.Length));

        }
        
        private void EndGame()
        {

            if (GameStaues.WhoWinner == EnWinner.player)
            {
               
                lblChoiceWiner.Text = "the " + GameStaues.Player.ToString() + " is Winner";
                GameStaues.CounterWinner++;
                lblScore.Text = GameStaues.CounterWinner.ToString();
                MessageBox.Show("Player is Winner");
            }
            else if (GameStaues.WhoWinner == EnWinner.Computer)
            {
                
                lblChoiceWiner.Text = "the " + GameStaues.Computer.ToString() + " is Winner";
                MessageBox.Show("Computer is Winner");
            }

            else
            {
                
                lblChoiceWiner.Text = "Draw";
                MessageBox.Show("Draw");
            }

           

            // Disable Btn Choices

            btnPaper.Enabled = false;
            btnRock.Enabled = false;
            btnScissors.Enabled = false;

            // show Btn Reset
            btnReset.Visible = true;
        }
        void CheckWinner()
        {

            // Draw
            if (GameStaues.Player == GameStaues.Computer)
            {
                GameStaues.WhoWinner = EnWinner.Draw;

            }

            // winner Player 
            else if (GameStaues.Player == EnRbsChoice.rock && GameStaues.Computer
                 == EnRbsChoice.scissor)
            {
                GameStaues.WhoWinner = EnWinner.player;
            }

            else if (GameStaues.Player == EnRbsChoice.paper
                && GameStaues.Computer == EnRbsChoice.rock)
            {
                GameStaues.WhoWinner = EnWinner.player;
            }

            else if (GameStaues.Player == EnRbsChoice.scissor
                && GameStaues.Computer == EnRbsChoice.paper)
            {
                GameStaues.WhoWinner = EnWinner.player;
            }

            else
            {
                GameStaues.WhoWinner = EnWinner.Computer;
            }

            EndGame();  

        }
        private EnRbsChoice ChangeImage(EnRbsChoice ?Choice,PictureBox pb)
        {

            if (Choice == EnRbsChoice.paper)
            {
                pb.Image = imgLIconsPlay.Images[0];
                return EnRbsChoice.paper;
                
            }

            if(Choice == EnRbsChoice.scissor)
            {
                pb.Image = imgLIconsPlay.Images[1];
                return EnRbsChoice.scissor;

            }

            pb.Image = imgLIconsPlay.Images[2];
            return EnRbsChoice.rock;


        }

        public Form1()
        {
            InitializeComponent();
            
        }
        clsGameStatues GameStaues = new clsGameStatues();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            
            GameStaues.Player = (EnRbsChoice) Enum.Parse(typeof(EnRbsChoice), btn.Tag.ToString());

            ChangeImage(GameStaues.Player, pbPlayer);

             GameStaues.Computer = GetRandomChoice();

            ChangeImage(GameStaues.Computer, pbComputer);

            pbComputer.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            CheckWinner();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset Images
            pbComputer.Image = Resources.question_mark;
            pbPlayer.Image = Resources.question_mark;

            // Reset Choices to Null

            GameStaues.Player = null;
            GameStaues.Computer = null;
            GameStaues.WhoWinner = null;

            // Enabled btn Choices
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            btnRock.Enabled = true;

            //rest lblWhoWinner
            lblChoiceWiner.Text = String.Empty;

            // hide btn Reset
            btnReset.Visible = false;

        }
    }
}
