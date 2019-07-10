using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.PL
{
    public partial class frm_login : Form
    {
        BL.Login log_in = new BL.Login();
        PL.Getting_Start get_start = new Getting_Start();
        public frm_login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = log_in.log_in(txt_user_name.Text, txt_password.Text);

            if (Convert.ToInt32(dataGridView1.Rows.Count - 1) != 0)
            {
                
                MessageBox.Show("تم تسجيل الدخول بنجاح", "مرحبا", MessageBoxButtons.OK);
                this.Hide();
                Getting_Start obj = new Getting_Start();
            //    obj.الموظفينToolStripMenuItem.Enabled = true;
            //    obj.المستخدمينToolStripMenuItem.Enabled = true;


            }

            else
            {
                if (txt_user_name.Text.Trim().Equals(""))
                {
                    MessageBox.Show("قم بإدخال اسم المستخدم", "حقل اسم المستخدم فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (txt_password.Text.Trim().Equals(""))
                {
                    MessageBox.Show("قم بإدخال كلمة السر", "حقل كلمة السر فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {

                    MessageBox.Show("اسم المستخدم او كلمة السر خطأ", "حاول مرة اخري", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
               
    

            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
