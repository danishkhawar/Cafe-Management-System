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
    public partial class frmItemCategory : Form
    {
        public frmItemCategory()
        {
            InitializeComponent();
            string[] spParams = new string[0];

            int[] ColSize = new int[] { 70, 250, 70 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "ItemCategory";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_ItemCategory";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;

            CustomFormProperties.FindButtonSearchIndex = 1;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties(); 



        private void frmItemCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomFormProperties.SaveState = false;

            if (txtCatgName.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Category name must not be empty");
                return;
            }
            CustomFormProperties.SaveButtonProcedureName = "spSaveItemCategory";
            string[] sAdditionalSaveParam = new string[0];
            //sAdditionalSaveParam[0] = "@User=" + GlobalVariables.sUserID;

            CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;

        }
    }
}
