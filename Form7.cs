using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalProject
{
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
            cgpa.Text = Convert.ToString(Form1.cgp);
            if (Convert.ToDouble(cgpa.Text) >= 4.50)
            {
                label3.Text = "First Class";
            }
            else if(Convert.ToDouble(cgpa.Text) >= 3.50)
            {
                label3.Text = "Second Class Upper";
            }
            else if (Convert.ToDouble(cgpa.Text) >= 2.40)
            {
                label3.Text = "Second Class Lower";
            }
            else if (Convert.ToDouble(cgpa.Text) >= 1.50)
            {
                label3.Text = "Third Class";
            }
            else
            {
                label3.Text = "Pass";
            }
        }

        private void cgpa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bkbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
