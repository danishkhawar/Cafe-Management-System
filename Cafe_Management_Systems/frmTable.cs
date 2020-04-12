using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FL_DL;

namespace Cafe_Management_Systems
{
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
            string[] spParams = new string[0];

            int[] ColSize = new int[] { 70, 250, 100, 70 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "TableSetup";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_TableSetup";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;
            
            CustomFormProperties.FindButtonSearchIndex = 1;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties(); 


        private void frmTable_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomFormProperties.SaveState = false;

            if (txtTableDesc.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Description must not be empty");
                return;
            }
            CustomFormProperties.SaveButtonProcedureName = "spSaveTableSetup";
            string[] sAdditionalSaveParam = new string[0];
            //sAdditionalSaveParam[0] = "@User=" + GlobalVariables.sUserID;

            CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;

        }
    }
}
