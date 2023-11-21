namespace SWD606
{
    partial class Start_page
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
            this.emp_Btn = new System.Windows.Forms.Button();
            this.admin_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emp_Btn
            // 
            this.emp_Btn.Location = new System.Drawing.Point(212, 188);
            this.emp_Btn.Name = "emp_Btn";
            this.emp_Btn.Size = new System.Drawing.Size(128, 49);
            this.emp_Btn.TabIndex = 0;
            this.emp_Btn.Text = "Employee";
            this.emp_Btn.UseVisualStyleBackColor = true;
            this.emp_Btn.Click += new System.EventHandler(this.emp_Btn_Click);
            // 
            // admin_Btn
            // 
            this.admin_Btn.Location = new System.Drawing.Point(434, 188);
            this.admin_Btn.Name = "admin_Btn";
            this.admin_Btn.Size = new System.Drawing.Size(128, 49);
            this.admin_Btn.TabIndex = 1;
            this.admin_Btn.Text = "Administrator";
            this.admin_Btn.UseVisualStyleBackColor = true;
            this.admin_Btn.Click += new System.EventHandler(this.admin_Btn_Click);
            // 
            // Start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_Btn);
            this.Controls.Add(this.emp_Btn);
            this.Name = "Start_page";
            this.Text = "Start_page";
            this.Load += new System.EventHandler(this.Start_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emp_Btn;
        private System.Windows.Forms.Button admin_Btn;
    }
}