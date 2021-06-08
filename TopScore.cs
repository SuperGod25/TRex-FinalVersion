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
    public partial class TopScore : Form
    {
        public TopScore()
        {
            InitializeComponent();
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menuScreen = new Menu();
            this.Hide();
            menuScreen.Closed += (s, args) => this.Close();
            menuScreen.Show();
        }

        void ShowData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Statia73\Documents\BestScoreUsers.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BestScoreUser", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        void SearchData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Statia73\Documents\BestScoreUsers.mdf;Integrated Security=True;Connect Timeout=30");
            string sqlquery="SELECT * FROM BestScoreUser WHERE Username like '"+textBox1.Text+"%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
