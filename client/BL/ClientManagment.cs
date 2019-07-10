using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace client.BL
{
    class ClientManagment
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
      /*  public DataTable view_clinets()
        {
            DAL.DAL dal = new DAL.DAL();
          conr da;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("viewCleints");
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dal.close();
            return dt;
        }

        */

        public DataTable getCleints()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[0];
            DataTable dt = new DataTable();
            dt = dal.selectData("getCleints", null);
            dal.close();
            return dt;



        }


        public void addClient(string name, int Age, string Gander, string ClientAddress, string Department,
            string PhoneNumber, double Salary
            )
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@Name", SqlDbType.VarChar,50);
            param[0].Value = name;

            param[1] = new SqlParameter("@Age", SqlDbType.TinyInt );
            param[1].Value = Age;

            param[2] = new SqlParameter("@Gander", SqlDbType.VarChar,50);
            param[2].Value = Gander;

            param[3] = new SqlParameter("@ClientAddress", SqlDbType.VarChar,50);
            param[3].Value = ClientAddress;

            param[4] = new SqlParameter("@Department", SqlDbType.VarChar,50);
            param[4].Value = Department;

            param[5] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar,50);
            param[5].Value = PhoneNumber;

            param[6] = new SqlParameter("@Salary", SqlDbType.Float);
            param[6].Value = Salary;

            dal.ExecuteComand("addClient", param);
            dal.close();
        
        
        
        
        
        
        }




    }
}
