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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opinion = opiniontxt.Text;
            MySqlConnection con = new MySqlConnection(Form1.con_string);
            string query6 = "INSERT INTO COMPLAINTS VALUES('" + Form1.matricNo+ "', '" + Form1.name + "', '"+txt_opinionclass.Text+"', '"+opiniontxt.Text+"')";
            con.Open();
            MySqlCommand insertData = new MySqlCommand(query6, con);
            if (insertData.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Your input is highly appreciated. An email will be sent to you shortly in response.");
            }
            else
            {
                MessageBox.Show("Unsuccesful. Try again.");
            }
            con.Close();
            txt_opinionclass.Clear();
            opiniontxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
