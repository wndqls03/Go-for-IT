namespace SWD606
{
    partial class Login
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
            this.ID_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Btn = new System.Windows.Forms.Button();
            this.signup_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(329, 117);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(100, 21);
            this.ID_text.TabIndex = 0;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(329, 157);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 21);
            this.password_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_Btn
            // 
            this.login_Btn.Location = new System.Drawing.Point(338, 206);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(75, 23);
            this.login_Btn.TabIndex = 4;
            this.login_Btn.Text = "Login";
            this.login_Btn.UseVisualStyleBackColor = true;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // signup_Btn
            // 
            this.signup_Btn.Location = new System.Drawing.Point(338, 245);
            this.signup_Btn.Name = "signup_Btn";
            this.signup_Btn.Size = new System.Drawing.Size(75, 23);
            this.signup_Btn.TabIndex = 5;
            this.signup_Btn.Text = "Sign up";
            this.signup_Btn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.signup_Btn);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.ID_text);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Button signup_Btn;
    }
}

