using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace client.BL
{
    class Client_Managment
    {
        public DataTable check_con()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("check_con", null);
            dal.close();
            return dt;
        }
        
    }
}
