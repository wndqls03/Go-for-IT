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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_Btn
            // 
            this.emp_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(152)))));
            this.emp_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.emp_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_Btn.Location = new System.Drawing.Point(209, 338);
            this.emp_Btn.Name = "emp_Btn";
            this.emp_Btn.Size = new System.Drawing.Size(128, 49);
            this.emp_Btn.TabIndex = 0;
            this.emp_Btn.Text = "Employee";
            this.emp_Btn.UseVisualStyleBackColor = false;
            this.emp_Btn.Click += new System.EventHandler(this.emp_Btn_Click);
            // 
            // admin_Btn
            // 
            this.admin_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(152)))));
            this.admin_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.admin_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_Btn.Location = new System.Drawing.Point(431, 338);
            this.admin_Btn.Name = "admin_Btn";
            this.admin_Btn.Size = new System.Drawing.Size(128, 49);
            this.admin_Btn.TabIndex = 1;
            this.admin_Btn.Text = "Administrator";
            this.admin_Btn.UseVisualStyleBackColor = false;
            this.admin_Btn.Click += new System.EventHandler(this.admin_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 139);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(285, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to RECA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(303, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login Option";
            // 
            // Start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_Btn);
            this.Controls.Add(this.emp_Btn);
            this.Name = "Start_page";
            this.Text = "Start_page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emp_Btn;
        private System.Windows.Forms.Button admin_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}