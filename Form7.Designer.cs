
namespace PortalProject
{
    partial class Form7
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
            this.Bkbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cgpa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bkbtn
            // 
            this.Bkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bkbtn.Location = new System.Drawing.Point(46, 24);
            this.Bkbtn.Name = "Bkbtn";
            this.Bkbtn.Size = new System.Drawing.Size(53, 23);
            this.Bkbtn.TabIndex = 21;
            this.Bkbtn.Text = "back";
            this.Bkbtn.UseVisualStyleBackColor = true;
            this.Bkbtn.Click += new System.EventHandler(this.Bkbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "CGPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Your current CGPA is ";
            // 
            // cgpa
            // 
            this.cgpa.Location = new System.Drawing.Point(49, 181);
            this.cgpa.Name = "cgpa";
            this.cgpa.ReadOnly = true;
            this.cgpa.Size = new System.Drawing.Size(100, 20);
            this.cgpa.TabIndex = 23;
            this.cgpa.TextChanged += new System.EventHandler(this.cgpa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bkbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "CGPA";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bkbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cgpa;
        private System.Windows.Forms.Label label3;
    }
}