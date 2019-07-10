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
    public partial class frm_config : Form
    {
        BL.Login log_in = new BL.Login();
        public frm_config()
        {

            InitializeComponent();
            txt_server_name.Text = Properties.Settings.Default.Server;
            txt_db.Text = Properties.Settings.Default.DataBase;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_uer_name.ReadOnly = false;
            txt_password.ReadOnly = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_uer_name.ReadOnly = true;
            txt_password.ReadOnly = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_server_name.Text;
            Properties.Settings.Default.DataBase = txt_db.Text;
            Properties.Settings.Default.User_Name = txt_uer_name.Text;
            Properties.Settings.Default.Password = txt_password.Text;
            Properties.Settings.Default.Mode = rb_sql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.Save();

            dataGridView1.DataSource = log_in.check_con();
            if (Convert.ToInt32 (dataGridView1.Rows.Count-1) == 0)
            {
                MessageBox.Show("Connection Failed","Error",MessageBoxButtons.OK);
            }

            else
                MessageBox.Show("Connection Done", "Correct", MessageBoxButtons.OK);
            this.Close();
          
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_config_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
