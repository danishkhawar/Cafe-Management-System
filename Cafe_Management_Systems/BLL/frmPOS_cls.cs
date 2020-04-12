using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cafe_Management_Systems
{
    public class frmPOS_cls
    {
        public DataSet GetAll_Sale(string _ID)
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_Sale";

            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@ID", _ID);

            try
            {
                ds = FL_DL.SQLHelper.ExecuteQueryReturnDS(System.Data.CommandType.StoredProcedure, SQLCmd, p);

            }
            catch (Exception ex)
            {

            }
            return ds;

        }
    }
}
