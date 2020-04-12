using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FL_DL
{

    public partial class frmSearch : Form
    {
        public string[] RetVal;
        private string _sqlstring = "";
        private string _spName = "";
        private string[] _spParams;

        public string FieldName = "";
        public string[,] ValColor;
        private int[] _colsize;
        private int[] _colreturn;

        private int _searchIndex;
        private string _searchString;

        DataSet ds = new DataSet();
        ListViewItem lvItem;

        private ListViewColumnSorter lvwColumnSorter = null;
        public string[] ReturnValue
        {
            get { return RetVal; }
        }
        private void myInitializeComponent()
        {
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstSearch.ListViewItemSorter = lvwColumnSorter;
            this.lstSearch.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSearch.AutoArrange = true;

            lvwColumnSorter._SortModifier = ListViewColumnSorter.SortModifiers.SortByText;
            //this.listView_example.Sort();
        }
        private void DisposeMyComponent()
        {
            lvwColumnSorter = null;
            //this.lstSearch.ListViewItemSorter = lvwColumnSorter;
            this.lstSearch.Sorting = System.Windows.Forms.SortOrder.None;
            
            //lvwColumnSorter._SortModifier = ListViewColumnSorter.SortModifiers.SortByText;
        }

        public frmSearch(string SQLQuery, int[] ColSize, int[] RetCols)
        {
            InitializeComponent();
            _sqlstring = SQLQuery;
            _colsize = ColSize;
            _colreturn = RetCols;
            //myInitializeComponent();
        }
        public frmSearch(string spName, string[] spParams, int[] ColSize, int[] RetCols, int SearchIndex)
        {
            InitializeComponent();
            _sqlstring = "";
            _spName = spName;
            _spParams = spParams;
            _colsize = ColSize;
            _searchIndex = SearchIndex;
            _colreturn = RetCols;
            //myInitializeComponent();
        }
        public frmSearch(string spName, string[] spParams, int[] ColSize, int[] RetCols, int SearchIndex, string SearchString)
        {
            InitializeComponent();
            _sqlstring = "";
            _spName = spName;
            _spParams = spParams;
               _colsize = ColSize;
            _searchIndex = SearchIndex;
            _searchString = SearchString;
            _colreturn = RetCols;
            //myInitializeComponent();
        }

        public frmSearch(string spName, string[] spParams, int[] ColSize, int SearchIndex)
        {
            InitializeComponent();
            _sqlstring = "";
            _spName = spName;
            _spParams = spParams;
            _colsize = ColSize;
            _searchIndex = SearchIndex;
            //_colreturn = RetCols;
            //myInitializeComponent();
        }

        private void FillComboBox()
        {
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataColumn col in dt.Columns)
                {
                    cmbSearchBy.Items.Add(col.ColumnName);
                }
                cmbSearchBy.SelectedIndex = _searchIndex;
                this.ActiveControl = txtSearch;
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if (_sqlstring != "")
            {
                GetData();
            }
            else
            {
                GetDataBySp();
            }
            if (ds.Tables.Count > 0)
            {
                FillComboBox();
                SetListViewColumn();
                PopulateTreeList();
            }
            cmbSearchBy.SelectedIndex = _searchIndex;
            txtSearch.Text = _searchString;
            this.Text = GlobalVariables.sMessageBox;
            
        }
        private void GetDataBySp()
        {

            string SQLCmd = _spName; ;

            SqlParameter[] p = new SqlParameter[_spParams.Length];

            for (int i = 0; i < _spParams.Length; i++)
            {

                if (_spParams[i] != null)
                {
                    string _ParamName = _spParams[i].Substring(0, _spParams[i].IndexOf('='));
                    string _ParamValue = _spParams[i].Substring(_spParams[i].IndexOf('=') + 1);

                    p[i] = new SqlParameter(_ParamName, _ParamValue.Trim());
                }
            }
            try
            {
                ds = SQLHelper.ExecuteQueryReturnDS(System.Data.CommandType.StoredProcedure, SQLCmd, p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }

        }
        private void GetData()
        {
            ds = SQLHelper.GetDataSet(_sqlstring);
        }

        private void SetListViewColumn()
        {
            try
            {
                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    lstSearch.Cursor = Cursors.Hand;
                    lstSearch.View = View.Details;
                    lstSearch.GridLines = true;
                    lstSearch.LabelEdit = true;
                    lstSearch.AllowColumnReorder = true;
                    lstSearch.FullRowSelect = true;
                    int index = 0;

                    foreach (DataColumn col in dt.Columns)
                    {
                        lstSearch.Columns.Add(col.Caption, _colsize[index], HorizontalAlignment.Left);
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
 
            }
        }

        private void PopulateTreeList()
        {
            lstSearch.BeginUpdate();
            lstSearch.Items.Clear();
            //int index = 0;

            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                lvItem = new ListViewItem(drow[0].ToString());

                for (int col = 1; col <= ds.Tables[0].Columns.Count - 1; col++)
                {
                    lvItem.SubItems.Add(drow[col].ToString());
                    //index++;
                }
                if (FieldName != "")
                    for (int row = 0; row < ValColor.GetLength(0); row++)
                    {
                        if (drow[FieldName].ToString() == ValColor[row, 0].ToString())
                        {
                            string s = ValColor[row, 1].ToString();
                            string[] colorCode;
                            colorCode = s.Split(',');

                            lvItem.BackColor = Color.FromArgb(Convert.ToInt16(colorCode[0].ToString()), Convert.ToInt16(colorCode[1].ToString()), Convert.ToInt16(colorCode[2].ToString()));
                            lvItem.Font = new Font("Arial", 10, FontStyle.Bold);
                            break;
                        }
                    }
                lstSearch.Items.Add(lvItem);
            }
            lstSearch.EndUpdate();
            myInitializeComponent();
        }

        private void lstSearch_DoubleClick(object sender, EventArgs e)
        {
            DataTable dtReturn = new DataTable();
            foreach (ColumnHeader lstCol in lstSearch.Columns)
            {
                dtReturn.Columns.Add(lstCol.Text);
            }
            //foreach (ListViewItem item in lstSearch.FocusedItem)
            //{
            DataRow row = dtReturn.NewRow();
            for (int i = 0; i < lstSearch.FocusedItem.SubItems.Count; i++)
            {
                row[i] = lstSearch.FocusedItem.SubItems[i].Text;
            }
            dtReturn.Rows.Add(row);
            //}
            dtReturn.AcceptChanges();

            FormPresentationBLL.SetReturnTable(dtReturn);

            this.DialogResult = DialogResult.OK;
            this.Close();
            if (_colreturn != null)
            {
                if (_colreturn.Length > 0)
                {
                    int index = 0;
                    this.RetVal = new string[_colreturn.Length];
                    try
                    {
                        foreach (int rCol in _colreturn)
                        {
                            RetVal[index] = lstSearch.FocusedItem.SubItems[rCol].Text;
                            index++;
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.Text != "")
            {
                DisposeMyComponent();
                try
                {
                    String selectString = String.Format("convert([" + cmbSearchBy.Text + "], 'System.String') Like '%{0}%'", txtSearch.Text);
                    DataRow[] findRows = ds.Tables[0].Select(selectString, cmbSearchBy.Text);

                    lstSearch.Items.Clear();
                    int index;

                    foreach (DataRow drow in findRows)
                    {
                        lvItem = new ListViewItem(drow[0].ToString());
                        index = 1;

                        for (int col = 1; col <= ds.Tables[0].Columns.Count - 1; col++)
                        {
                            lvItem.SubItems.Add(drow[col].ToString());
                            index++;
                        }

                        lstSearch.Items.Add(lvItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, GlobalVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myInitializeComponent();
            }
        }

        private void frmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 27)
            {

                this.Close();
            }
        }

      

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (lstSearch.Items.Count > 0)
                {
                    lstSearch.Items[0].Focused = true;
                    lstSearch_DoubleClick(sender, null);
                }
            }
        }

        private void lstSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (lstSearch.Items.Count > 0)
                {
                    //lstSearch.Items[0].Focused = true;
                    lstSearch_DoubleClick(sender, null);
                }
            }
        }

        
        private void lstSearch_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }


        

       


    }
}