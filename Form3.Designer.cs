
namespace PortalProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rectxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paidtxt = new System.Windows.Forms.TextBox();
            this.outtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paybtn = new System.Windows.Forms.Button();
            this.payamttxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(99, 267);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(96, 40);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back to Home";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter receipt ID";
            // 
            // rectxt
            // 
            this.rectxt.Location = new System.Drawing.Point(151, 83);
            this.rectxt.Multiline = true;
            this.rectxt.Name = "rectxt";
            this.rectxt.Size = new System.Drawing.Size(162, 20);
            this.rectxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fees Paid";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // paidtxt
            // 
            this.paidtxt.Location = new System.Drawing.Point(215, 143);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.ReadOnly = true;
            this.paidtxt.Size = new System.Drawing.Size(162, 20);
            this.paidtxt.TabIndex = 5;
            // 
            // outtxt
            // 
            this.outtxt.Location = new System.Drawing.Point(215, 187);
            this.outtxt.Name = "outtxt";
            this.outtxt.ReadOnly = true;
            this.outtxt.Size = new System.Drawing.Size(162, 20);
            this.outtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Outstanding";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.paybtn);
            this.panel1.Controls.Add(this.payamttxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rectxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(458, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 233);
            this.panel1.TabIndex = 8;
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.Color.Navy;
            this.paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paybtn.Location = new System.Drawing.Point(105, 184);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(75, 23);
            this.paybtn.TabIndex = 13;
            this.paybtn.Text = "Pay";
            this.paybtn.UseVisualStyleBackColor = false;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // payamttxt
            // 
            this.payamttxt.Location = new System.Drawing.Point(151, 129);
            this.payamttxt.Name = "payamttxt";
            this.payamttxt.Size = new System.Drawing.Size(162, 20);
            this.payamttxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Make Payment";
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(215, 97);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(162, 20);
            this.totaltxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Fees";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paidtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rectxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paidtxt;
        private System.Windows.Forms.TextBox outtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.TextBox payamttxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label6;
    }
}