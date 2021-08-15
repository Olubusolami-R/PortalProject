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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DayTImeT.Items.Clear();
            string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday" };
            string day = daytxt.Text.ToLower();
            int check = 0;
            for(int i = 0; i < days.Length; i++)
            {
                if (day == days[i])

                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {

                string query4 = "select * from "+day+" where program='"+Form1.program.ToLower()+"'";

                MySqlConnection con = new MySqlConnection(Form1.con_string);
                con.Open();
                MySqlCommand getdays = new MySqlCommand(query4, con);
                MySqlDataReader reader = getdays.ExecuteReader();

                reader.Read();
                DayTImeT.Items.Add("8 am to 10 am");
                DayTImeT.Items.Add(reader.GetString(1));
                DayTImeT.Items.Add("10 am to 12 pm");
                DayTImeT.Items.Add(reader.GetString(2));
                DayTImeT.Items.Add("12 pm to 2 pm");
                DayTImeT.Items.Add(reader.GetString(3));
                DayTImeT.Items.Add("3 pm to 5 pm");
                DayTImeT.Items.Add(reader.GetString(4));
                reader.Close();

                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid day entered. Enter a day between Monday and Friday");
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            daytxt.Clear();
            DayTImeT.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
