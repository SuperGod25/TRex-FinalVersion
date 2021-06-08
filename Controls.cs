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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game gameScreen = new Game();
            this.Hide();
            gameScreen.Closed += (s, args) => this.Close();
            gameScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menuScreen = new Menu();
            this.Hide();
            menuScreen.Closed += (s, args) => this.Close();
            menuScreen.Show();
        }
    }
}
