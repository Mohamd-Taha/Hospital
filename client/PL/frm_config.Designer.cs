namespace client.PL
{
    partial class frm_config
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_server_name = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_uer_name = new System.Windows.Forms.TextBox();
            this.rb_sql = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(152, 300);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 46);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(35, 300);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 46);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server Name";
            // 
            // txt_server_name
            // 
            this.txt_server_name.Location = new System.Drawing.Point(107, 15);
            this.txt_server_name.Name = "txt_server_name";
            this.txt_server_name.Size = new System.Drawing.Size(157, 20);
            this.txt_server_name.TabIndex = 7;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(107, 51);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(157, 20);
            this.txt_db.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(99, 78);
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = true;
            this.txt_password.Size = new System.Drawing.Size(157, 20);
            this.txt_password.TabIndex = 9;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_uer_name
            // 
            this.txt_uer_name.Location = new System.Drawing.Point(99, 18);
            this.txt_uer_name.Name = "txt_uer_name";
            this.txt_uer_name.ReadOnly = true;
            this.txt_uer_name.Size = new System.Drawing.Size(157, 20);
            this.txt_uer_name.TabIndex = 10;
            // 
            // rb_sql
            // 
            this.rb_sql.AutoSize = true;
            this.rb_sql.Location = new System.Drawing.Point(12, 105);
            this.rb_sql.Name = "rb_sql";
            this.rb_sql.Size = new System.Drawing.Size(117, 17);
            this.rb_sql.TabIndex = 11;
            this.rb_sql.TabStop = true;
            this.rb_sql.Text = "SQL Authentication";
            this.rb_sql.UseVisualStyleBackColor = true;
            this.rb_sql.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows Authentication";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_uer_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 127);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(35, 14);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb_sql);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_server_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Name = "frm_config";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_server_name;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_uer_name;
        private System.Windows.Forms.RadioButton rb_sql;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}