
namespace PortalProject
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayTImeT = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Retrieve Daily TimeTable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the day to retrieve timetable for:";
            // 
            // daytxt
            // 
            this.daytxt.Location = new System.Drawing.Point(53, 146);
            this.daytxt.Name = "daytxt";
            this.daytxt.Size = new System.Drawing.Size(206, 20);
            this.daytxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // DayTImeT
            // 
            this.DayTImeT.FormattingEnabled = true;
            this.DayTImeT.Location = new System.Drawing.Point(492, 115);
            this.DayTImeT.Name = "DayTImeT";
            this.DayTImeT.Size = new System.Drawing.Size(224, 160);
            this.DayTImeT.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(53, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(219, 201);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(119, 45);
            this.clrbtn.TabIndex = 17;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(56, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(50, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "*If there\'s any complaint about the timetable, fill out the form in the complaint" +
    " section.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DayTImeT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox daytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DayTImeT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}