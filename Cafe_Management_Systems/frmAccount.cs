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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            string[] spParams = new string[0];

            int[] ColSize = new int[] { 70, 250, 100, 80, 80, 80, 80 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "AccountMaster";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_AccountMaster";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;

            CustomFormProperties.FindButtonSearchIndex = 1;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties();

        private void FillAccountType()
        {
            DataTable dtAcctType = new DataTable();
            dtAcctType.Columns.Add("ID");
            dtAcctType.Columns.Add("Type");


            dtAcctType.Rows.Add("Regular", "Regular");
            dtAcctType.Rows.Add("Delivery", "Delivery");
            cmbAcctType.DataSource = dtAcctType;
            cmbAcctType.ValueMember = "ID";
            cmbAcctType.DisplayMember = "Type";

        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            FillAccountType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomFormProperties.SaveState = false;

            if (txtAcctName.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Account Name must not be empty");
                return;
            }
            CustomFormProperties.SaveButtonProcedureName = "spSaveAccountMaster";
            string[] sAdditionalSaveParam = new string[0];
            //sAdditionalSaveParam[0] = "@User=" + GlobalVariables.sUserID;

            CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;

        }

    }
}
