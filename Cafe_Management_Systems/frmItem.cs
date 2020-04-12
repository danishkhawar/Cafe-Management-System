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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
            string[] spParams = new string[0];

            int[] ColSize = new int[] { 70, 250, 100, 60, 120, 80, 80, 60, 60 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "ItemMaster";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_ItemMaster";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;
            CustomFormProperties.AfterFind = "AfterFind";

            CustomFormProperties.FindButtonSearchIndex = 1;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties(); 

        private void frmItem_Load(object sender, EventArgs e)
        {
            (new frmItemCategory_cls()).FillItemCategory(cmbCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomFormProperties.SaveState = false;

            if (txtShortName.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Short name must not be empty");
                return;
            }
            else if (txtItemName.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Item name must not be empty");
                return;
            }
            CustomFormProperties.SaveButtonProcedureName = "spSaveItemMaster";
            string[] sAdditionalSaveParam = new string[0];
            //sAdditionalSaveParam[0] = "@User=" + GlobalVariables.sUserID;

            CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;

        }

        public void AfterFind()
        {
            CalculateNetPrice();
        }
        private void txtTax_Perc_Leave(object sender, EventArgs e)
        {
            CalculateNetPrice();
        }
        private void CalculateNetPrice()
        {
            txtSalePrice.Text = txtSalePrice.Text == "" ? "0" : txtSalePrice.Text;
            txtTax_Perc.Text = txtTax_Perc.Text == "" ? "0" : txtTax_Perc.Text;

            txtNetPrice.Text = (float.Parse(txtSalePrice.Text) + (float.Parse(txtSalePrice.Text) * float.Parse(txtTax_Perc.Text) / 100)).ToString();
        }

        private void txtSalePrice_Leave(object sender, EventArgs e)
        {
            CalculateNetPrice();
        
        }
    }
}
