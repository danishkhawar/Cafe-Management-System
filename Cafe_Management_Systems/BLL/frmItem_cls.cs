using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cafe_Management_Systems
{
    public class frmItem_cls
    {
        public DataSet GetAll_ItemMaster()
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_ItemMaster";

            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@InActive", "0");

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
