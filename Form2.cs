using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PortalProject
{
    public partial class Form2 : Form
    {
        
       

        public Form2()
        {
            InitializeComponent();
            namelbl.Text = Form1.name;
            levlbl.Text = Form1.level;
            matlbl.Text = Form1.matricNo;
            proglbl.Text = Form1.program;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void matlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 new3 = new Form3();
            string query22 = "SELECT * FROM STUDENTDETAILS WHERE MATRICNUMBER='" + Form1.matricNo + "'";
            MySqlConnection con22 = new MySqlConnection(Form1.con_string);
            con22.Open();
            MySqlCommand getUpdatedPay = new MySqlCommand(query22, con22);

            MySqlDataReader reader = getUpdatedPay.ExecuteReader();
            
            reader.Read();
            Form3.paid = reader.GetInt32(6);
            reader.Close();
            con22.Close();

            new3.ShowDialog();
            this.Show();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 new4 = new Form4();
            new4.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 new6 = new Form6();
            this.Hide();
            new6.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 new7 = new Form7();
            this.Hide();
            new7.ShowDialog();
            this.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 new6 = new Form6();
            this.Hide();
            new6.ShowDialog();
            this.Show();

        }
    }
}
