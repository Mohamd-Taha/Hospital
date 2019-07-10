using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace client.BL
{
    class Login
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

        public DataTable log_in(String User_Name, String User_Password)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@User_Name", SqlDbType.VarChar,50);
            param[0].Value = User_Name;


            param[1] = new SqlParameter("@User_Password", SqlDbType.VarChar,50);
            param[1].Value = User_Password;
               

            DataTable dt = new DataTable();
            dt = dal.selectData("log_in",param);
            dal.close();
            return dt;



        }









    }
}
