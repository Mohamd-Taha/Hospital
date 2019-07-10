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
    public partial class TEST_ONLY : Form
    {
        public TEST_ONLY()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 9; x++)
            {
                object[] filldata = {x,"Month"+x , "salary"+x , "attend days"+x , "absence days "+x };
                dataGridView1.Rows.Add (filldata );
            
        }
    }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                MessageBox.Show("Connection Failed",MessageBoxButtons.OK);
        
        }
