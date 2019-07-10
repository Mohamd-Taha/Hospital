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
    public partial class Getting_Start : Form
    {
        BL.ClientManagment clmang = new BL.ClientManagment();
        public Getting_Start()
        {
            InitializeComponent();


        }

        private void اعدادتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_config frm = new frm_config();


            frm.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.frm_login frm = new frm_login();
            frm.ShowDialog();
        }

        private  void Getting_Start_Load(object sender, EventArgs e)
        {

           // الموظفينToolStripMenuItem.Enabled = false;
           // المستخدمينToolStripMenuItem.Enabled = false;
        }

        private void اضافهموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manage_clinets_Click(object sender, EventArgs e)
        {
            PL.frm_Client_Managment frm = new frm_Client_Managment();
            frm.dataGridView1.DataSource = clmang.getCleints();
            frm.ShowDialog();
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_user openform =new frm_add_user();
        openform.Show();
        
        
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
