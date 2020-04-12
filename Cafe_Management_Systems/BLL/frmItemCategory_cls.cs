using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FL_DL;

namespace Cafe_Management_Systems
{
    public class frmItemCategory_cls
    {

        public void FillItemCategory(ComboBox cmb)
        {
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "CatgName";
            cmb.DataSource = GetAll_ItemCategory().Tables[0];
            cmb.SelectedIndex = -1;
            
        }

        public DataSet GetAll_ItemCategory()
        {
            DataSet ds = new DataSet();
            string SQLCmd = "spGetAll_ItemCategory";

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
