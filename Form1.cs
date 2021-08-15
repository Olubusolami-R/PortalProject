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
    public partial class Form1 : Form
    {
        public static string name = "";
        public static string level = "";
        public static string program = "";
        public static string matricNo = "";
        public static string con_string = "datasource=127.0.0.1;port=3306;username=root;password='';database=studentportal";
        public static double cgp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = unametxt.Text;
            string password = pwordtxt.Text;

            string query1 = "SELECT COUNT(*) AS COUNTER FROM LOGINDATA WHERE USERNAME='"+username+"' AND PASSWORD='"+password+"'";
            MySqlConnection con = new MySqlConnection(con_string);
            MySqlCommand checkUser = new MySqlCommand(query1, con);
            
            con.Open();
            try
            {
                if (checkUser.ExecuteScalar().ToString() == "1")
                {
                    MessageBox.Show("Success! Welcome user!");

                    //second query
                    string query2 = "SELECT * FROM STUDENTDETAILS WHERE REGNUMBER='" + username + "'";
                    MySqlCommand getdata = new MySqlCommand(query2, con);
                    MySqlDataReader reader = getdata.ExecuteReader();

                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        matricNo = reader.GetString(1);
                        level = reader.GetString(3);
                        program = reader.GetString(4);
                        Form3.total = reader.GetInt32(5);
                        Form3.paid = reader.GetInt32(6);
                        cgp = reader.GetDouble(7);
                    }


                    Form2 newform = new Form2();
                    this.Hide();
                    newform.ShowDialog();
                    unametxt.Clear();
                    pwordtxt.Clear();
                    this.Show();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login details");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void pwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void unametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
