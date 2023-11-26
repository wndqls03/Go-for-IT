namespace SWD606
{
    partial class Admin_Dashboard
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
            this.emp_Btn = new System.Windows.Forms.Button();
            this.sal_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 37);
            this.panel1.TabIndex = 0;
            // 
            // emp_Btn
            // 
            this.emp_Btn.Location = new System.Drawing.Point(198, 333);
            this.emp_Btn.Name = "emp_Btn";
            this.emp_Btn.Size = new System.Drawing.Size(116, 55);
            this.emp_Btn.TabIndex = 3;
            this.emp_Btn.Text = "Employee Management";
            this.emp_Btn.UseVisualStyleBackColor = true;
            // 
            // sal_Btn
            // 
            this.sal_Btn.Location = new System.Drawing.Point(673, 333);
            this.sal_Btn.Name = "sal_Btn";
            this.sal_Btn.Size = new System.Drawing.Size(116, 55);
            this.sal_Btn.TabIndex = 4;
            this.sal_Btn.Text = "Salary Management";
            this.sal_Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Leave Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Management System";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sal_Btn);
            this.Controls.Add(this.emp_Btn);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emp_Btn;
        private System.Windows.Forms.Button sal_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}