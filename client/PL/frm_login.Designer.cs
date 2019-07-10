namespace client.PL
{
    partial class frm_login
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(31, 163);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 39);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(124, 163);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(65, 39);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "دخول";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Location = new System.Drawing.Point(31, 61);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(174, 27);
            this.txt_user_name.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(31, 99);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(174, 27);
            this.txt_password.TabIndex = 7;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "من فضلك قم بعملية تسجيل الدخول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "كلمة السر";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "إسم المستخدم";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(226, 103);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_exit);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة تسجيل الدخول";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}