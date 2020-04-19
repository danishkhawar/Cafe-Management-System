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
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Cafe_Management_Systems
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();


            CreateTableButtons();
        
            string[] spParams = new string[1];
            spParams[0] = "@IsBilled=" + "1";


            int[] ColSize = new int[] { 70, 80, 100, 70, 150, 50, 200, 80, 80, 80, 120, 80, 80, 60 };

            CustomFormProperties.Form = this;
            CustomFormProperties.MainTableName = "SaleMaster";
            CustomFormProperties.MainTableIDFieldName = "ID";
            CustomFormProperties.FindButtonProcedureName = "spGetAll_Sale";
            CustomFormProperties.FindButtonParameters = spParams;
            CustomFormProperties.FindButtonColSizes = ColSize;
            CustomFormProperties.AfterFind = "AfterFind";
            CustomFormProperties.AfterRefresh = "AfterRefresh";
            CustomFormProperties.SaveGridView1 = dgvOrderItems;
            CustomFormProperties.AfterTableButtonClick = "AfterTableButtonClick";

            CustomFormProperties.FindButtonSearchIndex = 0;
            (new FL_DL.FormPresentationBLL()).SetFormTitleAndAuthorities(this, CustomFormProperties);
        }
        CustomFormProperties CustomFormProperties = new CustomFormProperties();

        public void AfterRefresh()
        { gbRept.Visible=false; }

        public void AfterFind() 
        { CalculateTotal(); }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            lblAppHeader.Text = GlobalVariables.ssCompanyName;
            lblAppVer.Text = "Version :" + GlobalVariables.sAppVersion;

            gbRept.Draggable(true);
            CreateItemButtons();
            DataGridSettings();
            (new frmAccount_cls()).FillAccountMaster(cmbAcct);
            (new frmTable_cls()).FillTableSetup(cmbTableSetupID);
            CalculateTotal();
            chkDelivery.Checked = true;
            gbRept.Visible = false;
        }

        private void DataGridSettings()
        {
            dgvOrderItems.DataSource = null;
            dgvOrderItems.Columns.Clear();
            dgvOrderItems.RowsDefaultCellStyle.BackColor = Color.Cornsilk;
            dgvOrderItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;

            int colIndex = 0;

            dgvOrderItems.Columns.Add("ID", "ID");
            dgvOrderItems.Columns[colIndex].Tag = "ID";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].Width = 100;
            dgvOrderItems.Columns[colIndex].Visible = false;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "ID";
            colIndex++;

            dgvOrderItems.Columns.Add("ItemID", "ItemID");
            dgvOrderItems.Columns[colIndex].Tag = "ItemID";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font,FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].Width = 100;
            dgvOrderItems.Columns[colIndex].Visible = false;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "ItemID";
            colIndex++;

            dgvOrderItems.Columns.Add("DealID", "DealID");
            dgvOrderItems.Columns[colIndex].Tag = "DealID";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].Width = 100;
            dgvOrderItems.Columns[colIndex].Visible = false;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "DealID";
            colIndex++;

            dgvOrderItems.Columns.Add("DealName", "Deal");
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].ReadOnly = true;
            dgvOrderItems.Columns[colIndex].Width = 40;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "DealName";
            colIndex++;


            dgvOrderItems.Columns.Add("ItemName", "Item");
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].ReadOnly = true;
            dgvOrderItems.Columns[colIndex].Width = 170;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "ItemName";
            colIndex++;

            dgvOrderItems.Columns.Add("SaleQnty", "Qnty");
            dgvOrderItems.Columns[colIndex].Tag = "SaleQnty";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].Width = 40;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "SaleQnty";
            colIndex++;

            dgvOrderItems.Columns.Add("SalePrice", "Price");
            dgvOrderItems.Columns[colIndex].Tag = "SalePrice";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].Width = 50;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "SalePrice";
            colIndex++;

            dgvOrderItems.Columns.Add("Tax_Perc", "Tax %");
            dgvOrderItems.Columns[colIndex].Tag = "Tax_Perc";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].Width = 70;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "Tax_Perc";
            colIndex++;

            dgvOrderItems.Columns.Add("Tax_Amnt", "Tax Amnt");
            dgvOrderItems.Columns[colIndex].Tag = "Tax_Amnt";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].Width = 80;
            //dgvOrderItems.Columns[colIndex].Visible = false;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "Tax_Amnt";
            colIndex++;


            dgvOrderItems.Columns.Add("SaleAmnt", "Amount");
            dgvOrderItems.Columns[colIndex].Tag = "SaleAmnt";
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.Font = new Font(dgvOrderItems.DefaultCellStyle.Font, FontStyle.Bold);
            dgvOrderItems.Columns[colIndex].HeaderCell.Style.BackColor = Color.DarkGray;
            dgvOrderItems.Columns[colIndex].Width = 80;
            dgvOrderItems.Columns[colIndex].DataPropertyName = "SaleAmnt";
            colIndex++;


            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.AllowUserToOrderColumns = false;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrderItems.ColumnHeadersHeight = 50;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvOrderItems.ColumnHeadersDefaultCellStyle.Font.FontFamily, 15, FontStyle.Bold, GraphicsUnit.Pixel);
            dgvOrderItems.EnableHeadersVisualStyles = false;
            dgvOrderItems.Font = new System.Drawing.Font(dgvOrderItems.ColumnHeadersDefaultCellStyle.Font.FontFamily, 15, FontStyle.Bold, GraphicsUnit.Pixel);

            dgvOrderItems.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvOrderItems.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderItems.RowHeadersWidth = 50;


        }

        int btnWidth = 92, btnHeight = 50;
        private void CreateItemButtons()
        {
            DataTable dtItemMaster = (new frmItem_cls()).GetAll_ItemMaster().Tables[0];
            DataView dv = dtItemMaster.DefaultView;
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
            ////deal buttons
            ///////////
            /////////   

            LineNo++;

            //CatgName = "Today's Deals"; //dRow["CatgName"].ToString();
            Label lblDeals = new Label();
            lblDeals.Text = "Today's Deals";
            lblDeals.Name = "CatgDeals";
            lblDeals.ForeColor = Color.White;
            lblDeals.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            lblDeals.Location = new Point(10, (LineNo * btnHeight) + 30);
            lblDeals.AutoSize = true;

            pnlItems.Controls.Add(lblDeals);
            rindex = 0;
            LineNo++;


            DataTable dtDeals = (new frmDeals_cls()).GetAll_Deals().Tables[0];
            dv = dtDeals.DefaultView;
            dv.Sort = "DealPerson";
            DataTable dtdeal = dv.ToTable();


            dynamicbutton = new Button();


            foreach (DataRow dRowdeal in dtdeal.Rows)
            {

                dynamicbutton = new Button();
                dynamicbutton.Click += new EventHandler(ItemButton_Click);
                //dynamicbutton.Click += new CommandEventHandler(dynamicbutton_Click);
                dynamicbutton.Name = "btn_" + rindex.ToString() + dRowdeal["DealName"].ToString();
                dynamicbutton.Text = dRowdeal["DealName"].ToString();

                dynamicbutton.Tag = "Deal_" + dRowdeal["ID"].ToString();
                dynamicbutton.Width = btnWidth;
                dynamicbutton.Height = btnHeight;
                dynamicbutton.ForeColor = Color.White;
                dynamicbutton.FlatAppearance.BorderColor = Color.DarkGray;
                dynamicbutton.Location = new Point((rindex * btnWidth) + 10, (LineNo * btnHeight) + 15);

                dynamicbutton.FlatStyle = FlatStyle.Flat;
                dynamicbutton.FlatAppearance.MouseOverBackColor = Color.DarkGray;

                ToolTip tlpBtn = new ToolTip();
                tlpBtn.SetToolTip(dynamicbutton, dRowdeal["DealDescription"].ToString());

                pnlItems.Controls.Add(dynamicbutton);
                rindex++;
                if (rindex % 5 == 0)
                {
                    LineNo++;
                    rindex = 0;
                }
            }
        }
        private void CreateTableButtons()
        {
            DataTable dt = (new frmTable_cls()).GetAll_TableSetup().Tables[0];
            //RadioButton rb = new RadioButton();
            Button btn = new Button();
            int LineNo = 0;

            foreach (DataRow dRow in dt.Rows)
            {
                btn = new Button();

                btn.Text = dRow["ShortName"].ToString();
                btn.Name = "tbutton_" + dRow["ID"].ToString();
                btn.Tag = dRow["ID"].ToString();
                btn.ForeColor = Color.White;

                btn.Width = btnWidth;
                btn.Height = btnHeight;

                btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseOverBackColor = Color.DarkGray;

                btn.Location = new Point(5, LineNo * btnHeight);
                btn.Dock = DockStyle.Top;

                btn.AutoSize = true;

               
                ToolTip tlp = new ToolTip();
                tlp.SetToolTip(btn, dRow["TableDesc"].ToString());
                pnlTable.Controls.Add(btn);
                LineNo++;

            }        
        }
        private void TableButtonUnselect()
        {
            foreach (Control ctl in pnlTable.Controls)
            {
                Button btnall = (Button)ctl;
                btnall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
        }
        public void AfterTableButtonClick(object sender)
        {
            TableButtonUnselect();
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.SystemColors.ControlDark;
            cmbTableSetupID.SelectedValue = btn.Tag;
            CalculateTotal();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            //dynamicbutton.Tag = dRow["ID"].ToString() + "rate" + dRow["SalePrice"].ToString() + "name" + dRow["ItemName"].ToString();

            string ButtonTag = ((Button)sender).Tag.ToString();
            string ButtonText = ((Button)sender).Text.ToString();
            string _ItemShortName = ((Button)sender).Text;

            if (ButtonTag.StartsWith("Deal_"))
            {
                ///deal items
                ///
                string _DealID = ButtonTag.Substring(ButtonTag.IndexOf("Deal_") + 5);

                DataTable dtDeal = (new frmDeals_cls()).GetAll_Deals(_DealID).Tables[1];

                foreach (DataRow drDeal in dtDeal.Rows)
                {
                    string _ItemID = drDeal["ItemID"].ToString();
                    string _SalePrice = drDeal["DealPrice"].ToString();
                    string _Tax_Perc = drDeal["Tax_Perc"].ToString();
                    string _ItemName = drDeal["ItemName"].ToString();
                    string _DealName = ButtonText;

                    float _Tax_Amnt = _Tax_Perc == string.Empty ? 0 : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100);
                    float _Net_Price = _Tax_Amnt == 0 ? float.Parse(_SalePrice) : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100) + float.Parse(_SalePrice);



                    bool isPresent = false;

                    foreach (DataGridViewRow dgvRow in dgvOrderItems.Rows)
                    {

                        if (dgvRow.Cells["DealID"].Value != null)
                        {
                            if (dgvRow.Cells["DealID"].Value.ToString() == _DealID && dgvRow.Cells["ItemID"].Value.ToString() == _ItemID)
                            {
                                isPresent = true;
                                dgvRow.Cells["SaleQnty"].Value = (int.Parse(dgvRow.Cells["SaleQnty"].Value.ToString()) + 1).ToString();
                                dgvRow.Cells["Tax_Perc"].Value = _Tax_Perc;
                                dgvRow.Cells["Tax_Amnt"].Value = _Tax_Amnt * float.Parse(dgvRow.Cells["SaleQnty"].Value.ToString());

                                dgvRow.Cells["SaleAmnt"].Value = (_Net_Price * float.Parse(dgvRow.Cells["SaleQnty"].Value.ToString())).ToString();
                                //   float.Parse(dgvRow.Cells["OrderAmount"].Value.ToString()) +
                                //float.Parse(ButtonTag.Substring(ButtonTag.IndexOf("**") + 2))).ToString();
                            }
                        }
                    }
                    if (!isPresent)
                    {

                        object[] cellValues = new object[10];
                        cellValues[0] = "0";
                        cellValues[1] = _ItemID;
                        cellValues[2] = _DealID;
                        cellValues[3] = ButtonText;
                        cellValues[4] = _ItemName;
                        cellValues[5] = 1; //qnty
                        cellValues[6] = _SalePrice; //price
                        cellValues[7] = _Tax_Perc; //Tax Perc
                        cellValues[8] = _Tax_Amnt; //tax Amount
                        cellValues[9] = _Net_Price * 1; //Amount


                        //cellValues[6] = "0";

                        dgvOrderItems.Rows.Add(cellValues);

                        //dgvOrderItems.Rows.Add(cellValues);

                    }

                }

            }
            else
            {
                ////single items
                string _ItemID = ButtonTag.Substring(0, ButtonTag.IndexOf("Tax_Perc"));
                string _SalePrice = ButtonTag.Substring(ButtonTag.IndexOf("rate") + 4, ButtonTag.IndexOf("name") - (ButtonTag.IndexOf("rate") + 4)).ToString();
                string _Tax_Perc = ButtonTag.Substring(ButtonTag.IndexOf("Tax_Perc") + 8, ButtonTag.IndexOf("rate") - (ButtonTag.IndexOf("Tax_Perc") + 8)).ToString();
                string _ItemName = ButtonTag.Substring(ButtonTag.IndexOf("name") + 4);

                float _Tax_Amnt = _Tax_Perc == string.Empty ? 0 : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100);
                float _Net_Price = _Tax_Amnt == 0 ? float.Parse(_SalePrice) : (float.Parse(_Tax_Perc) * float.Parse(_SalePrice) / 100) + float.Parse(_SalePrice);



                bool isPresent = false;
                //string subItemID = ButtonTag.Substring(0, ButtonTag.IndexOf("__"));

                //DataTable dtPrevItems = (DataTable) dgvOrderItems.DataSource;

                foreach (DataGridViewRow dgvRow in dgvOrderItems.Rows)
                {

                    if (dgvRow.Cells["DealID"].Value == null && dgvRow.Cells["DealID"].Value == string.Empty && dgvRow.Cells["DealID"].Value != "0")
                    {
                        if (dgvRow.Cells["ItemID"].Value != null)
                        {
                            if (dgvRow.Cells["ItemID"].Value.ToString() == _ItemID)
                            {
                                isPresent = true;
                                dgvRow.Cells["SaleQnty"].Value = (int.Parse(dgvRow.Cells["SaleQnty"].Value.ToString()) + 1).ToString();
                                dgvRow.Cells["Tax_Perc"].Value = _Tax_Perc;
                                dgvRow.Cells["Tax_Amnt"].Value = _Tax_Amnt * float.Parse(dgvRow.Cells["SaleQnty"].Value.ToString());

                                dgvRow.Cells["SaleAmnt"].Value = (_Net_Price * float.Parse(dgvRow.Cells["SaleQnty"].Value.ToString())).ToString();
                                //   float.Parse(dgvRow.Cells["OrderAmount"].Value.ToString()) +
                                //float.Parse(ButtonTag.Substring(ButtonTag.IndexOf("**") + 2))).ToString();
                            }
                        }
                    }
                }
                if (!isPresent)
                {

                    object[] cellValues = new object[10];
                    cellValues[0] = "0";
                    cellValues[1] = _ItemID;
                    cellValues[2] = "0";
                    cellValues[3] = "N/A";
                    cellValues[4] = _ItemName;
                    cellValues[5] = 1; //qnty
                    cellValues[6] = _SalePrice; //price
                    cellValues[7] = _Tax_Perc; //Tax Perc
                    cellValues[8] = _Tax_Amnt; //tax Amount
                    cellValues[9] = _Net_Price * 1; //Amount


                    //cellValues[6] = "0";

                    dgvOrderItems.Rows.Add(cellValues);

                    //dgvOrderItems.Rows.Add(cellValues);

                }
                //dgvOrderItems.DataSource = dtPrevItems;
            }


            CalculateTotal();

            if (!chkDelivery.Checked)
            {
                IsNotBilled = true;
                CustomFormProperties.DontShowMsgOnSave = true;
                btnSave.PerformClick();
                SaveMethod();

                CustomFormProperties.DontShowMsgOnSave = false;

                IsNotBilled = false;
            }

        }

        private bool IsNotBilled
        {
            get;
            set;
        }
        private void CalculateTotal()
        {
            if (txtDiscPerc.Text == string.Empty)
                txtDiscPerc.Text = "0";

            float Amnt = 0, Tax_Amnt = 0;
            for (int i = 0; i < dgvOrderItems.Rows.Count; i++)
            {
                dgvOrderItems.Rows[i].HeaderCell.Value = (i + 1).ToString();
                Amnt = Amnt + (float.Parse(dgvOrderItems.Rows[i].Cells["SaleQnty"].Value.ToString()) * float.Parse(dgvOrderItems.Rows[i].Cells["SalePrice"].Value.ToString()));
                Tax_Amnt = Tax_Amnt + float.Parse(dgvOrderItems.Rows[i].Cells["Tax_Amnt"].Value.ToString());

                if (dgvOrderItems.Rows[i].Cells["DealID"].Value != null)
                    if (dgvOrderItems.Rows[i].Cells["DealID"].Value != string.Empty)
                        if (dgvOrderItems.Rows[i].Cells["DealID"].Value.ToString() != "0")
                            dgvOrderItems.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
            }
            lblAmnt.Text = Amnt.ToString();
            lblTaxAmnt.Text = Tax_Amnt.ToString();
            txtDiscAmnt.Text = txtDiscAmnt.Text == string.Empty ? "0" : txtDiscAmnt.Text;
            
            CalculateDisc();

            lblNet_Amnt.Text = ((Amnt + Tax_Amnt) - float.Parse(txtDiscAmnt.Text)).ToString();

        }
        private void ItemButton_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width = btnWidth + 10;
            btn.Height = btnHeight + 10;

        }

        private void ItemButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width = btnWidth - 10;
            btn.Height = btnHeight - 10;

        }

        private void itemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCategory frm = new frmItemCategory();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.ShowDialog();
        }

        private void accountSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.ShowDialog();
        }

        private void chkCredit_CheckedChanged(object sender, EventArgs e)
        {
            cmbAcct.Enabled = chkCredit.Checked;
        }

        private void txtDiscPerc_Leave(object sender, EventArgs e)
        {
            CalculateDisc();            
        }
        private void CalculateDisc()
        {
            //if (txtDiscAmnt.Text == string.Empty || txtDiscAmnt.Text == "0")
            //    txtDiscPerc.Enabled = true;
            //else
            //    txtDiscPerc.Enabled = false;


            if (txtDiscPerc.Text == string.Empty || txtDiscPerc.Text == "0")
            {
                txtDiscAmnt.Enabled = true;
            }
            else
            {
                txtDiscAmnt.Enabled = false;
                txtDiscAmnt.Text = ((float.Parse(lblAmnt.Text) + float.Parse(lblTaxAmnt.Text)) * float.Parse(txtDiscPerc.Text) / 100).ToString();
            }
            lblNet_Amnt.Text = (float.Parse(lblAmnt.Text) + float.Parse(lblTaxAmnt.Text) - float.Parse(txtDiscAmnt.Text)).ToString();
        }

        private void txtDiscAmnt_Leave(object sender, EventArgs e)
        {
            CalculateDisc();
        }

        private void SaveMethod()
        {
            btnSave.Text = "&Complete";
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
            
            string _SelectedTableSetupID = "0";
            if (!chkCredit.Checked)
            {
                foreach (Control ctl in pnlTable.Controls)
                    if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                    {
                        if (((RadioButton)ctl).Checked)
                            _SelectedTableSetupID = ((RadioButton)ctl).Tag.ToString();
                    }
            }

                        
            if (!CustomFormProperties.SaveState)
            {

                string[] sAdditionalSaveParam = new string[2];
                sAdditionalSaveParam[0] = "@typeSaleDetail=Table1";
                sAdditionalSaveParam[1] = "@IsBilled=" + (!IsNotBilled);
                //sAdditionalSaveParam[2] = "@TableSetupID=" + _SelectedTableSetupID;

                CustomFormProperties.AdditionalSaveButtonParameters = sAdditionalSaveParam;
                CustomFormProperties.SaveButtonProcedureName = "spSaveSale";


                CustomFormProperties.SaveGridView1 = dgvOrderItems;

                btnSave.Text = "&Save";
                
            }
        }

        private void chkBill_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkDelivery.Checked)
            {
                if (dgvOrderItems.Rows.Count > 0)
                    if (MessageBox.Show("you will lose unsaved changes, do you want to continue ?", GlobalVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        chkDelivery.Checked = true;
                        return;
                    }

               
            }
            
            btnRefresh.PerformClick();
            pnlTable.Enabled = !chkDelivery.Checked;
            cmbTableSetupID.Visible = !chkDelivery.Checked;
            TableButtonUnselect();

            cmbTableSetupID.Visible = false;
            foreach (Button ctl in pnlTable.Controls.OfType<Button>())
            {
                ((Button)ctl).PerformClick();
            }
            cmbTableSetupID.Visible = !chkDelivery.Checked;

            btnSave.Text = chkDelivery.Checked ? "&Save" : "&Complete";
        }
        
       
        private void btnReportClose_Click(object sender, EventArgs e)
        {
            gbRept.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Complete")
            {
                MessageBox.Show("Please complete the button in order to print Receipt");
                return;
            }
            if (txtTranID.Text == "" || txtTranID.Text == "0")
                return;


            DataSet ds = new DataSet();
            ds = (new frmPOS_cls()).GetAll_Sale(txtTranID.Text);


            ReportParameter[] rParam = new ReportParameter[3];
            rParam[0] = new ReportParameter("CompanyName", GlobalVariables.ssCompanyName == null ? "Abc Company" : GlobalVariables.ssCompanyName);
            rParam[1] = new ReportParameter("CompanyAddress", GlobalVariables.sCompanyAddress);
            rParam[2] = new ReportParameter("CompanyLogoPath", "file:///" + GlobalVariables.sCompanyLogoPath);
            



            //ReportViewer rView = new ReportViewer();
            string reportPath = Path.Combine(Application.StartupPath, "Reports/rptReceipt.rdlc");

            
           // rView.Dock = DockStyle.Fill;
            rView.ZoomMode = ZoomMode.PageWidth;

            //gbRept.Controls.Add(rView);
            rView.LocalReport.DataSources.Clear();
            ReportDataSource rdsAct;

            rdsAct = new ReportDataSource("dsReport_SaleMaster", ds.Tables[0]);
            rView.LocalReport.DataSources.Add(rdsAct);

            rdsAct = new ReportDataSource("dsReport_SaleDetail", ds.Tables[1]);
            rView.LocalReport.DataSources.Add(rdsAct);

            
            rView.LocalReport.EnableExternalImages = true;
            rView.LocalReport.ReportPath = reportPath;
            rView.LocalReport.SetParameters(rParam);
            rView.RefreshReport();
            gbRept.Visible = true;
        }

        private void dgvOrderItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (float.Parse(dgvOrderItems.Rows[e.RowIndex].Cells["SaleQnty"].Value.ToString()) > 1)
                {
                    dgvOrderItems.Rows[e.RowIndex].Cells["SaleQnty"].Value = (float.Parse(dgvOrderItems.Rows[e.RowIndex].Cells["SaleQnty"].Value.ToString()) - 1).ToString();
                    dgvOrderItems.Rows[e.RowIndex].Cells["SaleAmnt"].Value = ((float.Parse(dgvOrderItems.Rows[e.RowIndex].Cells["SalePrice"].Value.ToString()) +
                                                                            float.Parse(dgvOrderItems.Rows[e.RowIndex].Cells["Tax_Amnt"].Value.ToString())) *
                                                                            float.Parse(dgvOrderItems.Rows[e.RowIndex].Cells["SaleQnty"].Value.ToString())).ToString();

                }
                else
                {
                    DataGridViewRow dgr = dgvOrderItems.Rows[e.RowIndex];
                    dgvOrderItems.Rows.Remove(dgr);
                }
                CalculateTotal();
            }
        }

        private void dealSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeals frm = new frmDeals();
            frm.ShowDialog();
        }


    }
}
