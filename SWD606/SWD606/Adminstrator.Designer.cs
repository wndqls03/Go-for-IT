namespace SWD606
{
    partial class Administrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminid_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminpass_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.access_Btn = new System.Windows.Forms.Button();
            this.showPass_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Login";
            // 
            // adminid_Text
            // 
            this.adminid_Text.Location = new System.Drawing.Point(447, 142);
            this.adminid_Text.Multiline = true;
            this.adminid_Text.Name = "adminid_Text";
            this.adminid_Text.Size = new System.Drawing.Size(239, 26);
            this.adminid_Text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // adminpass_Text
            // 
            this.adminpass_Text.Location = new System.Drawing.Point(447, 250);
            this.adminpass_Text.Multiline = true;
            this.adminpass_Text.Name = "adminpass_Text";
            this.adminpass_Text.Size = new System.Drawing.Size(239, 26);
            this.adminpass_Text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin ID";
            // 
            // access_Btn
            // 
            this.access_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.access_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.access_Btn.Location = new System.Drawing.Point(447, 349);
            this.access_Btn.Name = "access_Btn";
            this.access_Btn.Size = new System.Drawing.Size(99, 33);
            this.access_Btn.TabIndex = 5;
            this.access_Btn.Text = "Access";
            this.access_Btn.UseVisualStyleBackColor = false;
            this.access_Btn.Click += new System.EventHandler(this.access_Btn_Click);
            // 
            // showPass_Check
            // 
            this.showPass_Check.AutoSize = true;
            this.showPass_Check.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass_Check.Location = new System.Drawing.Point(570, 305);
            this.showPass_Check.Name = "showPass_Check";
            this.showPass_Check.Size = new System.Drawing.Size(117, 20);
            this.showPass_Check.TabIndex = 6;
            this.showPass_Check.Text = "Show password";
            this.showPass_Check.UseVisualStyleBackColor = true;
            this.showPass_Check.CheckedChanged += new System.EventHandler(this.showPass_Check_CheckedChanged);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPass_Check);
            this.Controls.Add(this.access_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminpass_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminid_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminid_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminpass_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button access_Btn;
        private System.Windows.Forms.CheckBox showPass_Check;
    }
}