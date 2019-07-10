using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace client.PL
{
    public partial class frm_Client_Managment : Form
    {

        BL.ClientManagment client_managment = new BL.ClientManagment();
        
        

        
        public frm_Client_Managment()
        {
            InitializeComponent();
            dataGridView1.Refresh();
         //   this.dataGridView1.DataSource = client_managment.view_clinets();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.frm_addClinet frm = new frm_addClinet();
            frm.ShowDialog();
        }

        private void Client_Managment_Load(object sender, EventArgs e)
        {
   

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client_managment.getCleints();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
