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
    public partial class frmDeals : Form
    {
        public frmDeals()
        {
            InitializeComponent();

            string[] spParams = new string[0];
            int[] ColSize = new int[] { 70, 80, 100, 70, 150, 50, 200, 80, 80, 80, 120, 80, 80, 60 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "DealMaster";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_Deal";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;
            //CustomFormProperties.AfterFind = "AfterFind";
            CustomFormProperties.SaveGridView1 = dgvDealDetail;
            
            CustomFormProperties.FindButtonSearchIndex = 0;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties();

        private void frmDeals_Load(object sender, EventArgs e)
        {
            DataGridSettings();
            CreateItemButtons();
        
        }
        private void DataGridSettings()
        {
            dgvDealDetail.DataSource = null;
            dgvDealDetail.Columns.Clear();
            dgvDealDetail.RowsDefaultCellStyle.BackColor = Color.Cornsilk;
            dgvDealDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;

            int colIndex = 0;

            dgvDealDetail.Columns.Add("ID", "ID");
            dgvDealDetail.Columns[colIndex].Tag = "ID";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].Width = 100;
            dgvDealDetail.Columns[colIndex].Visible = false;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "ID";
            colIndex++;

            dgvDealDetail.Columns.Add("ItemID", "ItemID");
            dgvDealDetail.Columns[colIndex].Tag = "ItemID";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].Width = 100;
            dgvDealDetail.Columns[colIndex].Visible = false;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "ItemID";
            colIndex++;

            dgvDealDetail.Columns.Add("ItemName", "Item");
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].ReadOnly = true;
            dgvDealDetail.Columns[colIndex].Width = 170;
            dgvDealDetail.Columns[colIndex].ReadOnly = true; 
            dgvDealDetail.Columns[colIndex].DataPropertyName = "ItemName";
            colIndex++;

            dgvDealDetail.Columns.Add("DealQnty", "Qnty");
            dgvDealDetail.Columns[colIndex].Tag = "DealQnty";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 50;
            dgvDealDetail.Columns[colIndex].ReadOnly = true; 
            dgvDealDetail.Columns[colIndex].DataPropertyName = "DealQnty";
            colIndex++;

            dgvDealDetail.Columns.Add("SalePrice", "Price");
            dgvDealDetail.Columns[colIndex].Tag = "SalePrice";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 50;
            dgvDealDetail.Columns[colIndex].ReadOnly = true;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "SalePrice";
            colIndex++;

            dgvDealDetail.Columns.Add("DealPrice", "Deal Price");
            dgvDealDetail.Columns[colIndex].Tag = "DealPrice";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 50;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "DealPrice";
            colIndex++;

            dgvDealDetail.Columns.Add("Tax_Perc", "Tax %");
            dgvDealDetail.Columns[colIndex].Tag = "Tax_Perc";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 70;
            dgvDealDetail.Columns[colIndex].ReadOnly = true; 
            dgvDealDetail.Columns[colIndex].DataPropertyName = "Tax_Perc";
            colIndex++;

            dgvDealDetail.Columns.Add("Tax_Amnt", "Tax Amnt.");
            dgvDealDetail.Columns[colIndex].Tag = "Tax_Amnt";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 90;
            dgvDealDetail.Columns[colIndex].ReadOnly = true;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "Tax_Amnt";
            colIndex++;


            dgvDealDetail.Columns.Add("DealAmnt", "Amount");
            dgvDealDetail.Columns[colIndex].Tag = "DealAmnt";
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvDealDetail.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDealDetail.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvDealDetail.Columns[colIndex].Width = 80;
            dgvDealDetail.Columns[colIndex].ReadOnly = true;
            dgvDealDetail.Columns[colIndex].DataPropertyName = "DealAmnt";
            colIndex++;


            //dgvDealDetail.ReadOnly = true;
            dgvDealDetail.AllowUserToOrderColumns = false;
            dgvDealDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDealDetail.AllowUserToAddRows = false;
            dgvDealDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDealDetail.ColumnHeadersHeight = 50;
            dgvDealDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvDealDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDealDetail.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvDealDetail.ColumnHeadersDefaultCellStyle.Font.FontFamily, 15, FontStyle.Bold, GraphicsUnit.Pixel);
            dgvDealDetail.EnableHeadersVisualStyles = false;
            dgvDealDetail.Font = new System.Drawing.Font(dgvDealDetail.ColumnHeadersDefaultCellStyle.Font.FontFamily, 15, FontStyle.Bold, GraphicsUnit.Pixel);

            dgvDealDetail.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvDealDetail.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDealDetail.RowHeadersWidth = 50;


        }
        
        int btnWidth = 92, btnHeight = 50;
        private void CreateItemButtons()
        {
            DataTable dtItemCategory = (new frmItem_cls()).GetAll_ItemMaster().Tables[0];
            DataView dv = dtItemCategory.DefaultView;
            dv.Sort = "CatgName";
            DataTable dt = dv.ToTable();


            Button dynamicbutton = new Button();
            string CatgName = "";

            int LineNo = 0, rindex = 0;

            foreach (DataRow dRow in dt.Rows)
            {

                if (CatgName != dRow["CatgName"].ToString())
                {
                    if (LineNo != 0)
                        LineNo++;

                    CatgName = dRow["CatgName"].ToString();
                    Label lblCatgName = new Label();
                    lblCatgName.Text = dRow["CatgName"].ToString();
                    lblCatgName.Name = "Catg" + dRow["ID"].ToString();
                    lblCatgName.ForeColor = Color.White;
                    lblCatgName.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                    lblCatgName.Location = new Point(10, (LineNo * btnHeight) + 30);
                    lblCatgName.AutoSize = true;

                    pnlItems.Controls.Add(lblCatgName);
                    rindex = 0;
                    LineNo++;
                }

                dynamicbutton = new Button();
                dynamicbutton.Click += new EventHandler(ItemButton_Click);
                //dynamicbutton.Click += new CommandEventHandler(dynamicbutton_Click);
                dynamicbutton.Name = "btn_" + rindex.ToString() + dRow["ShortName"].ToString();
                dynamicbutton.Text = dRow["ShortName"].ToString();

                dynamicbutton.Tag = dRow["ID"].ToString() + "Tax_Perc" + (dRow["Tax_Perc"].ToString() == "" ? "0" : dRow["Tax_Perc"].ToString()) + "rate" + dRow["SalePrice"].ToString() + "name" + dRow["ItemName"].ToString();
                dynamicbutton.Width = btnWidth;
                dynamicbutton.Height = btnHeight;
                dynamicbutton.ForeColor = Color.White;
                dynamicbutton.FlatAppearance.BorderColor = Color.DarkGray;
                dynamicbutton.Location = new Point((rindex * btnWidth) + 10, (LineNo * btnHeight) + 15);

                dynamicbutton.FlatStyle = FlatStyle.Flat;
                dynamicbutton.FlatAppearance.MouseOverBackColor = Color.DarkGray;


                //dynamicbutton.Mouseh += new EventHandler(ItemButton_MouseHover);
                //dynamicbutton.MouseLeave += new EventHandler(ItemButton_MouseLeave);

                ToolTip tlpBtn = new ToolTip();
                tlpBtn.SetToolTip(dynamicbutton, dRow["ItemName"].ToString());

                pnlItems.Controls.Add(dynamicbutton);
                rindex++;
                if (rindex % 5 == 0)
                {
                    LineNo++;
                    rindex = 0;
                }
            }
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            //dynamicbutton.Tag = dRow["ID"].ToString() + "rate" + dRow["SalePrice"].ToString() + "name" + dRow["ItemName"].ToString();

            string ButtonTag = ((Button)sender).Tag.ToString();
            string _ItemShortName = ((Button)sender).Text;
            string _ItemID = ButtonTag.Substring(0, ButtonTag.IndexOf("Tax_Perc"));
            string _SalePrice = ButtonTag.Substring(ButtonTag.IndexOf("rate") + 4, ButtonTag.IndexOf("name") - (ButtonTag.IndexOf("rate") + 4)).ToString();
            string _Tax_Perc = ButtonTag.Substring(ButtonTag.IndexOf("Tax_Perc") + 8, ButtonTag.IndexOf("rate") - (ButtonTag.IndexOf("Tax_Perc") + 8)).ToString();
            string _ItemName = ButtonTag.Substring(ButtonTag.IndexOf("name") + 4);

            float _Tax_Amnt = _Tax_Perc == string.Empty ? 0 : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100);
            float _Net_Price = _Tax_Amnt == 0 ? float.Parse(_SalePrice) : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100) + float.Parse(_SalePrice);

            bool isPresent = false;
            
            foreach (DataGridViewRow dgvRow in dgvDealDetail.Rows)
            {

                if (dgvRow.Cells["ItemID"].Value != null)
                {
                    if (dgvRow.Cells["ItemID"].Value.ToString() == _ItemID)
                    {
                        isPresent = true;
                        dgvRow.Cells["DealQnty"].Value = (int.Parse(dgvRow.Cells["DealQnty"].Value.ToString()) + 1).ToString();
                        dgvRow.Cells["Tax_Perc"].Value = _Tax_Perc;
                        dgvRow.Cells["Tax_Amnt"].Value = _Tax_Amnt * float.Parse(dgvRow.Cells["DealQnty"].Value.ToString());

                        dgvRow.Cells["DealAmnt"].Value = (_Net_Price * float.Parse(dgvRow.Cells["DealQnty"].Value.ToString())).ToString();
                        //   float.Parse(dgvRow.Cells["OrderAmount"].Value.ToString()) +
                        //float.Parse(ButtonTag.Substring(ButtonTag.IndexOf("**") + 2))).ToString();
                    }
                }
            }
            if (!isPresent)
            {

                object[] cellValues = new object[9];
                cellValues[0] = "0";
                cellValues[1] = _ItemID;
                cellValues[2] = _ItemName;
                cellValues[3] = 1; //qnty
                cellValues[4] = _SalePrice; //Sale price
                cellValues[5] = _SalePrice; //Deal price
                cellValues[6] = _Tax_Perc; //Tax Perc
                cellValues[7] = _Tax_Amnt; //tax Amount
                cellValues[8] = _Net_Price * 1; //Amount

                dgvDealDetail.Rows.Add(cellValues);

            }
            
            CalculateTotal();

        }
        private void CalculateTotal()
        {
       
            float Amnt = 0, Tax_Amnt = 0;
            for (int i = 0; i < dgvDealDetail.Rows.Count; i++)
            {
                dgvDealDetail.Rows[i].Cells["DealAmnt"].Value = (float.Parse(dgvDealDetail.Rows[i].Cells["DealQnty"].Value.ToString()) * float.Parse(dgvDealDetail.Rows[i].Cells["DealPrice"].Value.ToString())); 
                dgvDealDetail.Rows[i].HeaderCell.Value = (i + 1).ToString();
                Amnt = Amnt + (float.Parse(dgvDealDetail.Rows[i].Cells["DealQnty"].Value.ToString()) * float.Parse(dgvDealDetail.Rows[i].Cells["DealPrice"].Value.ToString()));
                Tax_Amnt = Tax_Amnt + float.Parse(dgvDealDetail.Rows[i].Cells["Tax_Amnt"].Value.ToString());

            }
            lblAmnt.Text = Amnt.ToString();
            lblTaxAmnt.Text = Tax_Amnt.ToString();
            txtDiscAmnt.Text = txtDiscAmnt.Text == string.Empty ? "0" : txtDiscAmnt.Text;

            lblNet_Amnt.Text = ((Amnt + Tax_Amnt) - float.Parse(txtDiscAmnt.Text)).ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomFormProperties.SaveState = false;

            if (lblNet_Amnt.Text == "" || lblNet_Amnt.Text == "0")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Add quantity to save");
                return;
            }
            else if (txtDealName.Text == "")
            {
                CustomFormProperties.SaveState = true;
                MessageBox.Show("Short name must not be empty");
                return;
            }

            if (!CustomFormProperties.SaveState)
            {

                string[] sAdditionalSaveParam = new string[1];
                sAdditionalSaveParam[0] = "@typeDealDetail=Table1";

                CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;
                CustomFormProperties.SaveButtonProcedureName = "spSaveDeal";


                CustomFormProperties.SaveGridView1 = dgvDealDetail;

              }

        }

        private void txtDiscAmnt_Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void dgvDealDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotal();
        }
       


    }
}
