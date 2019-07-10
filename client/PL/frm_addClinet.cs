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
    public partial class frm_addClinet : Form
    {
        BL.ClientManagment clmang = new BL.ClientManagment();
      

        public frm_addClinet()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string clientname = client_name.Name;
                string clientage = client_age.Text;
                string clientpnone = txt_phone.Text;

                {
                    clmang.addClient(txt_name.Text, Convert.ToInt32(txt_age.Text), comb_gender.Text, txt_adress.Text, txt_department.Text, txt_phone.Text, Convert.ToDouble(txt_salary.Text));


                    MessageBox.Show("تم اضافه موظف جديد بنجاح", "نم", MessageBoxButtons.OK);
                    PL.frm_Client_Managment frm = new frm_Client_Managment();

                    frm.dataGridView1.DataSource = clmang.getCleints();
                    MessageBox.Show("تم التحديث", "نم", MessageBoxButtons.OK);


                    this.Close();
                }
            }

            catch
            {

            }
        }
    }
}
