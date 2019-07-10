namespace client.PL
{
    partial class frm_Client_Managment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(756, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الموظفين";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.age,
            this.gender,
            this.adress,
            this.phonenumber,
            this.salary,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 336);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "بحث عن ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 30);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(797, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(215, 591);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(36, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "تحديث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "إضافة موظف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "حذف الموظف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(36, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(862, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ادارة شؤون الموظفين";
            // 
            // ID
            // 
            this.ID.FillWeight = 80.43655F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.FillWeight = 91.0805F;
            this.Name.HeaderText = "الاسم";
            this.Name.Name = "Name";
            // 
            // age
            // 
            this.age.FillWeight = 91.0805F;
            this.age.HeaderText = "العمر ";
            this.age.Name = "age";
            // 
            // gender
            // 
            this.gender.FillWeight = 91.0805F;
            this.gender.HeaderText = "النوع";
            this.gender.Name = "gender";
            // 
            // adress
            // 
            this.adress.FillWeight = 91.0805F;
            this.adress.HeaderText = "العنوان";
            this.adress.Name = "adress";
            // 
            // phonenumber
            // 
            this.phonenumber.FillWeight = 91.0805F;
            this.phonenumber.HeaderText = "رقم الهاتف";
            this.phonenumber.Name = "phonenumber";
            // 
            // salary
            // 
            this.salary.FillWeight = 91.0805F;
            this.salary.HeaderText = "الراتب الاساسى";
            this.salary.Name = "salary";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 91.0805F;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // frm_Client_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Client_Managment";
            this.Text = "Client_Managment";
            this.Load += new System.EventHandler(this.Client_Managment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}