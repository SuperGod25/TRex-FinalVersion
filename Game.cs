using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRexGame
{
    public partial class Game : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int bestScore = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();
        int position;
        bool isGameOver = false;
        string input;
        
        
        

        public Game()
        {
            
            InitializeComponent();
            input = Microsoft.VisualBasic.Interaction.InputBox("Username", "Choose an username", " ", 800, 192);
            if (input != "")
            {
                usernameLbl.Text =input;
                GameReset();
            }
            else if(input=="")
            {
                usernameLbl.Text = "unknown";
                GameReset();
            }
            else
            {
                usernameLbl.Text = "unknown";
                GameReset();
            }
            


        }

        private void MainGameTimer(object sender, EventArgs e)
        {

            score++;
            
            if (score >= bestScore)
            {
                bestScore = score;
            }
            TRex.Top += jumpSpeed;

            txtScore.Text = score.ToString();
            txtBestScore.Text = bestScore.ToString();

            if(jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -14;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score+=2;
                    }

                    if (TRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        TRex.Image = Properties.Resources.dead;
                        DialogResult dg = MessageBox.Show("Do you want to restart the game?","Restart" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            GameReset();
                        }
                        else if (dg == DialogResult.No)
                        {
                           
                            Menu menuScreen = new Menu();
                            this.Hide();
                            menuScreen.Closed += (s, args) => this.Close();
                            menuScreen.Show();
                            SaveData();
                        }
                        else
                        {
                            Menu menuScreen = new Menu();
                            this.Hide();
                            menuScreen.Closed += (s, args) => this.Close();
                            menuScreen.Show();
                            SaveData();
                        }
                    }
                }
            }

            if(TRex.Top>=400 && !jumping)
            {
                force = 10;
                TRex.Top = floor.Top - TRex.Height;
                jumpSpeed = 0;
            }

            if (score >= 10)
            {
                obstacleSpeed = 15;
            }
            

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Space && !jumping) || (e.KeyCode==Keys.Up && !jumping))
            {
                jumping = true;
            }
        }

        

        private void GameReset() 
        {

            
            if (score >= bestScore)
            {
                bestScore = score;
            }
            force = 10;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            TRex.Image = Properties.Resources.running;
            isGameOver = false;
            TRex.Top = 400;

            foreach(Control x in this.Controls)
            {
                
                if(x is PictureBox && (string)x.Tag=="obstacle")
                {
                    position = this.ClientSize.Width+rnd.Next(500,800)+(x.Width*10);

                    x.Left = position;
                }


            }
            gameTimer.Start();
        }


        void SaveData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Statia73\Documents\BestScoreUsers.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BestScoreUser (Username, BestScore) VALUES (@Username,@BestScore)", conn);
            cmd.Parameters.AddWithValue("@Username", usernameLbl.Text);
            cmd.Parameters.AddWithValue("@BestScore", txtBestScore.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void txtBestScore_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gameTimer.Stop();
            DialogResult dg = MessageBox.Show("Do you want to exit this game?", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                SaveData();
                Menu menuScreen = new Menu();
                this.Hide();
                menuScreen.Closed += (s, args) => this.Close();
                menuScreen.Show();
            }
            else if (dg == DialogResult.No)
            {
                gameTimer.Start();
            }
        }
    }
}
