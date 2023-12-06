namespace SWD606
{
    partial class Employee_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.yearlyholidaylist_btn = new System.Windows.Forms.Button();
            this.resigning_btn = new System.Windows.Forms.Button();
            this.grievances_btn = new System.Windows.Forms.Button();
            this.mydetails_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(19, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Employee Management";
            // 
            // yearlyholidaylist_btn
            // 
            this.yearlyholidaylist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.yearlyholidaylist_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.yearlyholidaylist_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearlyholidaylist_btn.Location = new System.Drawing.Point(458, 122);
            this.yearlyholidaylist_btn.Name = "yearlyholidaylist_btn";
            this.yearlyholidaylist_btn.Size = new System.Drawing.Size(184, 96);
            this.yearlyholidaylist_btn.TabIndex = 37;
            this.yearlyholidaylist_btn.Text = "Yearly Holiday List";
            this.yearlyholidaylist_btn.UseVisualStyleBackColor = false;
            // 
            // resigning_btn
            // 
            this.resigning_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.resigning_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.resigning_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resigning_btn.Location = new System.Drawing.Point(458, 255);
            this.resigning_btn.Name = "resigning_btn";
            this.resigning_btn.Size = new System.Drawing.Size(184, 96);
            this.resigning_btn.TabIndex = 38;
            this.resigning_btn.Text = "Resigning";
            this.resigning_btn.UseVisualStyleBackColor = false;
            // 
            // grievances_btn
            // 
            this.grievances_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.grievances_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.grievances_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grievances_btn.Location = new System.Drawing.Point(166, 255);
            this.grievances_btn.Name = "grievances_btn";
            this.grievances_btn.Size = new System.Drawing.Size(184, 96);
            this.grievances_btn.TabIndex = 39;
            this.grievances_btn.Text = "Grievances";
            this.grievances_btn.UseVisualStyleBackColor = false;
            // 
            // mydetails_btn
            // 
            this.mydetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.mydetails_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.mydetails_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mydetails_btn.Location = new System.Drawing.Point(166, 122);
            this.mydetails_btn.Name = "mydetails_btn";
            this.mydetails_btn.Size = new System.Drawing.Size(184, 96);
            this.mydetails_btn.TabIndex = 40;
            this.mydetails_btn.Text = "My Details";
            this.mydetails_btn.UseVisualStyleBackColor = false;
            this.mydetails_btn.Click += new System.EventHandler(this.mydetails_btn_Click);
            // 
            // Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mydetails_btn);
            this.Controls.Add(this.grievances_btn);
            this.Controls.Add(this.resigning_btn);
            this.Controls.Add(this.yearlyholidaylist_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Dashboard";
            this.Text = "Employee_Dashboard";
            this.Load += new System.EventHandler(this.Employee_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button yearlyholidaylist_btn;
        private System.Windows.Forms.Button resigning_btn;
        private System.Windows.Forms.Button grievances_btn;
        private System.Windows.Forms.Button mydetails_btn;
    }
}