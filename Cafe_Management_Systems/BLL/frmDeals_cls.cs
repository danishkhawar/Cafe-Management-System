using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FL_DL;

namespace Cafe_Management_Systems
{
    public class frmDeals_cls
    {
        public DataSet GetAll_Deals(string _DealID = "%")
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_Deal";

            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@InActive", "0");
            p[1] = new SqlParameter("@Id", _DealID);

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
