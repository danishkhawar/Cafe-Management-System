using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FL_DL;
using System.Windows.Forms;

namespace Cafe_Management_Systems
{
    public class frmAccount_cls
    {

        public void FillAccountMaster(ComboBox cmb)
        {
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "AcctName";
            cmb.DataSource = GetAll_AccountMaster().Tables[0];

            cmb.SelectedIndex = -1;

        }
        public DataSet GetAll_AccountMaster()
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_AccountMaster";

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
