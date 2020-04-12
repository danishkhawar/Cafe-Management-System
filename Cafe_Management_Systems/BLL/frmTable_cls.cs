using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Management_Systems
{
    public class frmTable_cls
    {
        public void FillTableSetup(ComboBox cmb)
        {
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "TableDesc";
            cmb.DataSource = GetAll_TableSetup().Tables[0];

            cmb.SelectedIndex = -1;

        }
        public DataSet GetAll_TableSetup()
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_TableSetup";

            SqlParameter[] p = new SqlParameter[0];

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
