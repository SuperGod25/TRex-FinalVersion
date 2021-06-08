using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRexGame
{
    public partial class Menu : Form
    {

        public string userName;
        public Menu()
        {
            InitializeComponent();
        }

        private void playLbl_MouseEnter(object sender, EventArgs e)
        {
            playLbl.Font = new Font("Consolas", 42);
        }

        private void playLbl_MouseLeave(object sender, EventArgs e)
        {
            playLbl.Font = new Font("Consolas", 36);
        }

        private void bestScoreLbl_MouseEnter(object sender, EventArgs e)
        {
            bestScoreLbl.Font = new Font("Consolas", 42);
        }

        private void bestScoreLbl_MouseLeave(object sender, EventArgs e)
        {
            bestScoreLbl.Font = new Font("Consolas", 36);
        }

        private void controlsLbl_MouseEnter(object sender, EventArgs e)
        {
            controlsLbl.Font = new Font("Consolas", 42);
        }

        private void controlsLbl_MouseLeave(object sender, EventArgs e)
        {
            controlsLbl.Font = new Font("Consolas", 36);
        }

        private void exitLbl_MouseEnter(object sender, EventArgs e)
        {
            exitLbl.Font = new Font("Consolas",42);
        }

        private void exitLbl_MouseLeave(object sender, EventArgs e)
        {
            exitLbl.Font = new Font("Consolas", 36);
        }

        private void playLbl_MouseClick(object sender, MouseEventArgs e)
        {
          
                Game gameScreen = new Game();
               
                this.Hide();
                gameScreen.Closed += (s, args) => this.Close();
                gameScreen.Show();
           
        }

        private void bestScoreLbl_MouseClick(object sender, MouseEventArgs e)
        {
            TopScore bestScoreScreen = new TopScore();
            this.Hide();
            bestScoreScreen.Closed += (s, args) => this.Close();
            bestScoreScreen.Show();
        }

        private void controlsLbl_MouseClick(object sender, MouseEventArgs e)
        {
            Controls controlsScreen = new Controls();
            this.Hide();
            controlsScreen.Closed += (s, args) => this.Close();
            controlsScreen.Show();
        }

        private void exitLbl_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to exit this game?", "Exit" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
