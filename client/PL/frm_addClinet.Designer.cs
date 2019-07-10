namespace client.PL
{
    partial class frm_addClinet
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
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.client_salary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.client_age = new System.Windows.Forms.Label();
            this.client_name = new System.Windows.Forms.Label();
            this.client_dep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_gender = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(29, 424);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(239, 29);
            this.txt_salary.TabIndex = 3;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(29, 358);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(239, 29);
            this.txt_phone.TabIndex = 5;
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(29, 292);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(239, 29);
            this.txt_department.TabIndex = 6;
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adress.Location = new System.Drawing.Point(29, 224);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(239, 29);
            this.txt_adress.TabIndex = 7;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(20, 98);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(248, 29);
            this.txt_age.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(29, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(239, 29);
            this.txt_name.TabIndex = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(681, 532);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(170, 89);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(921, 532);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 89);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // client_salary
            // 
            this.client_salary.AutoSize = true;
            this.client_salary.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_salary.Location = new System.Drawing.Point(290, 422);
            this.client_salary.Name = "client_salary";
            this.client_salary.Size = new System.Drawing.Size(174, 25);
            this.client_salary.TabIndex = 13;
            this.client_salary.Text = "الراتب الاساسي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "رقم التليفون";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "العنوان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "النوع";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // client_age
            // 
            this.client_age.AutoSize = true;
            this.client_age.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_age.Location = new System.Drawing.Point(402, 96);
            this.client_age.Name = "client_age";
            this.client_age.Size = new System.Drawing.Size(62, 25);
            this.client_age.TabIndex = 17;
            this.client_age.Text = "العمر";
            // 
            // client_name
            // 
            this.client_name.AutoSize = true;
            this.client_name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name.Location = new System.Drawing.Point(393, 28);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(71, 25);
            this.client_name.TabIndex = 24;
            this.client_name.Text = "الاسم";
            // 
            // client_dep
            // 
            this.client_dep.AutoSize = true;
            this.client_dep.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_dep.Location = new System.Drawing.Point(387, 280);
            this.client_dep.Name = "client_dep";
            this.client_dep.Size = new System.Drawing.Size(77, 25);
            this.client_dep.TabIndex = 28;
            this.client_dep.Text = "القسم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comb_gender);
            this.groupBox1.Controls.Add(this.client_dep);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Controls.Add(this.client_name);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_department);
            this.groupBox1.Controls.Add(this.txt_adress);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.client_age);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.client_salary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(120, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(551, 514);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // comb_gender
            // 
            this.comb_gender.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_gender.FormattingEnabled = true;
            this.comb_gender.Items.AddRange(new object[] {
            "ذكر",
            "أنثي"});
            this.comb_gender.Location = new System.Drawing.Point(29, 168);
            this.comb_gender.Name = "comb_gender";
            this.comb_gender.Size = new System.Drawing.Size(239, 31);
            this.comb_gender.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(493, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 89);
            this.button3.TabIndex = 30;
            this.button3.Text = "تفريغ البيانات";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_addClinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 627);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Name = "frm_addClinet";
            this.Text = "frm_addClinet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label client_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label client_age;
        private System.Windows.Forms.Label client_name;
        private System.Windows.Forms.Label client_dep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_gender;
        private System.Windows.Forms.Button button3;
    }
}