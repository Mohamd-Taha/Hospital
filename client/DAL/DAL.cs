using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace client.DAL
{
    class DAL
    {
        
  SqlConnection sqlconnection;

        //انشاء الاتصال مابين قاعده البيانات
        public DAL()
        {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "sql")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = false; User ID=" + Properties.Settings.Default.User_Name + ";password=" + Properties.Settings.Default.Password + "");

            }
            else
            {

                sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; DataBase=" + Properties.Settings.Default.DataBase + ";Integrated security = true ");
            }
        }
        //فتح الاتصال
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
            //غلق الاتصال
            public void close ()
            { if (sqlconnection.State== ConnectionState.Open)
            {
            sqlconnection.Close();

           }
            }

        //قراءة البيانات
            public DataTable selectData(string stored_procedure, SqlParameter[] param)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;
                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
             da.Fill(dt);
                return dt;
            }
        //طريقة الاضافة والحذف والتعديل في البيانات
            public void ExecuteComand(string stored_procedure, SqlParameter[] param)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;
                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }
                 sqlcmd.ExecuteNonQuery();
            }
        }







}

