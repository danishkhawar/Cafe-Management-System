using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using Microsoft.Data.ConnectionUI;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace FL_DL
{

    public class SQLHelper
    {

        //public static String CONNECTION_STRING = "Data Source=.;Database=CafeManagement;Trusted_Connection=True";
        public static String CONNECTION_STRING = Con_String_txt();

               

        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try { connection.Open(); return true; }
                catch (SqlException) { return false; }
            }
        }
       
       
        
        

        public static string Con_String_txt()
        {
            var text = File.ReadAllText(Application.StartupPath + "\\DBInfo.txt");
            return text.ToString();

        }
        

        public static Int32 ExecuteNonQuery(CommandType cmdType, String cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                Int32 val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        public static void CreateView(string SQLCmd)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            string strSQLCommand = SQLCmd;
            SqlCommand command = new SqlCommand(strSQLCommand, conn);
            string returnvalue = (string)command.ExecuteScalar();
            conn.Close();
        }
        public static DataSet ExecuteQueryReturnDS(CommandType cmdType, String cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cmd.Parameters.Clear();
                return ds;
            }
        }
        public static SqlDataReader ExecuteReader(CommandType cmdType, String cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            conn.Open();
            PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return rdr;

        }
        public static Object ExecuteScalar(CommandType cmdType, String cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                var val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                conn.Close();
                return val;
            }
        }
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, String cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
        public static DataTable GetDataTable(string SQLQuery)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = new SqlConnection(CONNECTION_STRING);
                cmd.CommandText = SQLQuery;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                da.Fill(ds);
                //return ds.Tables[0];
            }
            catch (Exception ex)
            {

            }
            return ds.Tables[0];
        }
        public static DataSet GetDataSet(string SQLQuery)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(CONNECTION_STRING);
            cmd.CommandText = SQLQuery;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataTable GetDBViews()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(CONNECTION_STRING);
            cmd.Connection.Open();
            DataTable dtschema = cmd.Connection.GetSchema("Views");

            return dtschema;
        }

    }
}