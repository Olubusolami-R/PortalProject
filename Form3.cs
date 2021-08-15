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
    public partial class Form3 : Form
    {
        
        public static double total,paid;
        public  double outstanding = total - paid;
        public Form3()
        {
            InitializeComponent();
            totaltxt.Text = Convert.ToString(total);
            paidtxt.Text = Convert.ToString(paid);
            outtxt.Text = Convert.ToString(outstanding);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            double newPaid,paid_local;
            string recptID = rectxt.Text;
            int amountToPay = Convert.ToInt32(payamttxt.Text);

            MySqlConnection con2 = new MySqlConnection(Form1.con_string);
            con2.Open();

            string query3 = "SELECT * FROM STUDENTDETAILS WHERE MATRICNUMBER='" + Form1.matricNo + "'";
            MySqlCommand getUpdatedPay = new MySqlCommand(query3, con2);
            MySqlDataReader reader = getUpdatedPay.ExecuteReader();
            reader.Read();
            paid_local = reader.GetInt32(6);
            reader.Close();


            if (recptID.Length == 5)
            {
                if ((recptID[3] == 'D') && (recptID[4] == 'E'))
                {
                    newPaid = paid_local + amountToPay;
                    paidtxt.Text = Convert.ToString(newPaid);
                    outtxt.Text = Convert.ToString(total - (newPaid));

                    string query4 = "UPDATE STUDENTDETAILS SET PAID='" + newPaid + "' WHERE MATRICNUMBER='" + Form1.matricNo + "'";
                    MySqlCommand putdata = new MySqlCommand(query4, con2);
                    //not updating or reading from DB
                    if (putdata.ExecuteNonQuery().ToString() == "1")
                    {
                        MessageBox.Show("You have successfully paid!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccesful");
                    }



                    con2.Close();
                }
                else
                {
                    MessageBox.Show("Invalid receipt ID");
                }
            }
            else
            {
                MessageBox.Show("Invalid receipt ID");
            }
               
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
