namespace SWD606
{
    partial class Admim_Emp_Management
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.add_Btn = new System.Windows.Forms.Button();
            this.del_Btn = new System.Windows.Forms.Button();
            this.up_Btn = new System.Windows.Forms.Button();
            this.empID_Text = new System.Windows.Forms.TextBox();
            this.empName_Text = new System.Windows.Forms.TextBox();
            this.age_Text = new System.Windows.Forms.TextBox();
            this.userNa_Text = new System.Windows.Forms.TextBox();
            this.pass_Text = new System.Windows.Forms.TextBox();
            this.address_Text = new System.Windows.Forms.TextBox();
            this.num_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sal_Text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Sra = new System.Windows.Forms.Label();
            this.gen_Combo = new System.Windows.Forms.ComboBox();
            this.posi_Combo = new System.Windows.Forms.ComboBox();
            this.status_Combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(20, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(20, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(20, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(20, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(20, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(352, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(352, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(352, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Number";
            // 
            // add_Btn
            // 
            this.add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.add_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_Btn.Location = new System.Drawing.Point(723, 430);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(99, 33);
            this.add_Btn.TabIndex = 10;
            this.add_Btn.Text = "Add";
            this.add_Btn.UseVisualStyleBackColor = false;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // del_Btn
            // 
            this.del_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.del_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.del_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.del_Btn.Location = new System.Drawing.Point(842, 430);
            this.del_Btn.Name = "del_Btn";
            this.del_Btn.Size = new System.Drawing.Size(99, 33);
            this.del_Btn.TabIndex = 11;
            this.del_Btn.Text = "Delete";
            this.del_Btn.UseVisualStyleBackColor = false;
            this.del_Btn.Click += new System.EventHandler(this.del_Btn_Click);
            // 
            // up_Btn
            // 
            this.up_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.up_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.up_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.up_Btn.Location = new System.Drawing.Point(955, 430);
            this.up_Btn.Name = "up_Btn";
            this.up_Btn.Size = new System.Drawing.Size(99, 33);
            this.up_Btn.TabIndex = 12;
            this.up_Btn.Text = "Update";
            this.up_Btn.UseVisualStyleBackColor = false;
            this.up_Btn.Click += new System.EventHandler(this.up_Btn_Click);
            // 
            // empID_Text
            // 
            this.empID_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empID_Text.Location = new System.Drawing.Point(126, 333);
            this.empID_Text.Name = "empID_Text";
            this.empID_Text.Size = new System.Drawing.Size(100, 21);
            this.empID_Text.TabIndex = 15;
            // 
            // empName_Text
            // 
            this.empName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empName_Text.Location = new System.Drawing.Point(126, 368);
            this.empName_Text.Name = "empName_Text";
            this.empName_Text.Size = new System.Drawing.Size(100, 21);
            this.empName_Text.TabIndex = 16;
            // 
            // age_Text
            // 
            this.age_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age_Text.Location = new System.Drawing.Point(126, 403);
            this.age_Text.Name = "age_Text";
            this.age_Text.Size = new System.Drawing.Size(100, 21);
            this.age_Text.TabIndex = 17;
            // 
            // userNa_Text
            // 
            this.userNa_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNa_Text.Location = new System.Drawing.Point(126, 438);
            this.userNa_Text.Name = "userNa_Text";
            this.userNa_Text.Size = new System.Drawing.Size(100, 21);
            this.userNa_Text.TabIndex = 18;
            // 
            // pass_Text
            // 
            this.pass_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_Text.Location = new System.Drawing.Point(126, 473);
            this.pass_Text.Name = "pass_Text";
            this.pass_Text.Size = new System.Drawing.Size(100, 21);
            this.pass_Text.TabIndex = 19;
            // 
            // address_Text
            // 
            this.address_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_Text.Location = new System.Drawing.Point(420, 333);
            this.address_Text.Name = "address_Text";
            this.address_Text.Size = new System.Drawing.Size(100, 21);
            this.address_Text.TabIndex = 21;
            // 
            // num_Text
            // 
            this.num_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Text.Location = new System.Drawing.Point(420, 399);
            this.num_Text.Name = "num_Text";
            this.num_Text.Size = new System.Drawing.Size(100, 21);
            this.num_Text.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(352, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(354, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Position";
            // 
            // sal_Text
            // 
            this.sal_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sal_Text.Location = new System.Drawing.Point(420, 439);
            this.sal_Text.Name = "sal_Text";
            this.sal_Text.Size = new System.Drawing.Size(100, 21);
            this.sal_Text.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 41);
            this.panel1.TabIndex = 28;
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
            // Sra
            // 
            this.Sra.AutoSize = true;
            this.Sra.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Sra.Location = new System.Drawing.Point(354, 508);
            this.Sra.Name = "Sra";
            this.Sra.Size = new System.Drawing.Size(47, 17);
            this.Sra.TabIndex = 29;
            this.Sra.Text = "Status";
            // 
            // gen_Combo
            // 
            this.gen_Combo.FormattingEnabled = true;
            this.gen_Combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gen_Combo.Location = new System.Drawing.Point(420, 368);
            this.gen_Combo.Name = "gen_Combo";
            this.gen_Combo.Size = new System.Drawing.Size(100, 20);
            this.gen_Combo.TabIndex = 32;
            // 
            // posi_Combo
            // 
            this.posi_Combo.FormattingEnabled = true;
            this.posi_Combo.Items.AddRange(new object[] {
            "Front End",
            "Project Manager",
            "Data Analysist",
            "Back End"});
            this.posi_Combo.Location = new System.Drawing.Point(420, 473);
            this.posi_Combo.Name = "posi_Combo";
            this.posi_Combo.Size = new System.Drawing.Size(100, 20);
            this.posi_Combo.TabIndex = 33;
            // 
            // status_Combo
            // 
            this.status_Combo.FormattingEnabled = true;
            this.status_Combo.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_Combo.Location = new System.Drawing.Point(420, 508);
            this.status_Combo.Name = "status_Combo";
            this.status_Combo.Size = new System.Drawing.Size(100, 20);
            this.status_Combo.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SWD606.Properties.Resources.power_off_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1004, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Admim_Emp_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_Combo);
            this.Controls.Add(this.posi_Combo);
            this.Controls.Add(this.gen_Combo);
            this.Controls.Add(this.Sra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sal_Text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_Text);
            this.Controls.Add(this.address_Text);
            this.Controls.Add(this.pass_Text);
            this.Controls.Add(this.userNa_Text);
            this.Controls.Add(this.age_Text);
            this.Controls.Add(this.empName_Text);
            this.Controls.Add(this.empID_Text);
            this.Controls.Add(this.up_Btn);
            this.Controls.Add(this.del_Btn);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admim_Emp_Management";
            this.Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.Button del_Btn;
        private System.Windows.Forms.Button up_Btn;
        private System.Windows.Forms.TextBox empID_Text;
        private System.Windows.Forms.TextBox empName_Text;
        private System.Windows.Forms.TextBox age_Text;
        private System.Windows.Forms.TextBox userNa_Text;
        private System.Windows.Forms.TextBox pass_Text;
        private System.Windows.Forms.TextBox address_Text;
        private System.Windows.Forms.TextBox num_Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sal_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Sra;
        private System.Windows.Forms.ComboBox gen_Combo;
        private System.Windows.Forms.ComboBox posi_Combo;
        private System.Windows.Forms.ComboBox status_Combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
    }
}