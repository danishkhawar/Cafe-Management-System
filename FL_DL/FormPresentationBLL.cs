using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace FL_DL
{
    public class FormPresentationBLL
    {
        CustomFormProperties customProperties;
        public void SetFormTitleAndAuthorities(Form frm, CustomFormProperties cfm)
        {
            customProperties = cfm;
            //CustomFormProperties cfm = new CustomFormProperties();
            frm.StartPosition = FormStartPosition.CenterParent;
            //frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;

            frm.KeyPreview = true;
            frm.KeyDown += new System.Windows.Forms.KeyEventHandler(frm_KeyDown);

            //string _TranValue = CustomFormProperties.txtSrchItem.Text;
            ClearControls(frm);

            
        }
        
        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            Form frm = (Form)sender;
            
            if (e.KeyValue == 27)
            {
                if (MessageBox.Show("Are you sure you want to exit?", GlobalVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    frm.Close();
                }

            }
            
        }
        public void ClearControls(System.Windows.Forms.Control Parent)
        {
            foreach (System.Windows.Forms.Control ctrl in Parent.Controls)
            {

                
                if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrl).Enter += new EventHandler(OnFocus);
                    ((System.Windows.Forms.TextBox)ctrl).Leave += new EventHandler(LostFocus);


                    if (((System.Windows.Forms.TextBox)ctrl).Name == "txtTranID")
                    {
                        ((System.Windows.Forms.TextBox)ctrl).Text = "0";
                        ((System.Windows.Forms.TextBox)ctrl).BackColor = Color.Beige;
                        ((System.Windows.Forms.TextBox)ctrl).ForeColor = Color.Black;
                    }
                    else
                        ((System.Windows.Forms.TextBox)ctrl).Text = string.Empty;

                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.Label)))
                {
                    if (((System.Windows.Forms.Label)ctrl).Tag != null)
                        ((System.Windows.Forms.Label)ctrl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrl).Enter += new EventHandler(OnFocus);
                    ((System.Windows.Forms.ComboBox)ctrl).Leave += new EventHandler(LostFocus);
                    ((System.Windows.Forms.ComboBox)ctrl).SelectedIndex = -1;
                }
                
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrl).Enter += new EventHandler(OnFocus);
                    ((System.Windows.Forms.RadioButton)ctrl).Leave += new EventHandler(LostFocus);
                
                    ((System.Windows.Forms.RadioButton)ctrl).Checked = false;
                }

                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.DataGridView)))
                {
                    ((System.Windows.Forms.DataGridView)ctrl).DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 192);
                    ((System.Windows.Forms.DataGridView)ctrl).DefaultCellStyle.SelectionForeColor = Color.Black;


                    try
                    {
                        ((System.Windows.Forms.DataGridView)ctrl).DataSource = null;
                        ((System.Windows.Forms.DataGridView)ctrl).Rows.Clear();
                        //((System.Windows.Forms.DataGridView)ctrl).Rows.Add();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.ListView)))
                {
                    try
                    {
                        ((System.Windows.Forms.ListView)ctrl).Items.Clear();
                    }
                    catch
                    {
                    }
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(DateTimePicker)))
                {
                    try
                    {

                        ((System.Windows.Forms.DateTimePicker)ctrl).Enter += new EventHandler(OnFocus);
                        ((System.Windows.Forms.DateTimePicker)ctrl).Leave += new EventHandler(LostFocus);
                        
                        ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                        ((DateTimePicker)ctrl).CustomFormat = GlobalVariables.ApplicationDateTimePattern;

                        ((DateTimePicker)ctrl).Value = DateTime.Now;
                    }
                    catch
                    {
                    }
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.Button)))
                {
                    if (ctrl.Name == "btnFind")
                    {

                        Button btn = (Button)ctrl;
                        btn.Click -= new EventHandler(FindButton_Click);
                        btn.Click += new EventHandler(FindButton_Click);
                        

                    }
                    if (ctrl.Name == "btnSave")
                    {                        
                        Button btn = (Button)ctrl;
                        btn.Click -= new EventHandler(SaveButton_Click);
                        btn.Click += new EventHandler(SaveButton_Click);
                    }
                    if (ctrl.Name == "btnRefresh")
                    {
                        Button btn = (Button)ctrl;
                        btn.Click -= new EventHandler(RefreshButton_Click);
                        btn.Click += new EventHandler(RefreshButton_Click);
                    }
                    if (ctrl.Name == "btnExit")
                    {
                        Button btn = (Button)ctrl;
                        btn.Click -= new EventHandler(ExitButton_Click);
                        btn.Click += new EventHandler(ExitButton_Click);
                    }
                    //table buttons
                    if (ctrl.Name.StartsWith("tbutton_"))
                    {

                        Button btn = (Button)ctrl;
                        btn.Click -= new EventHandler(TableButton_Click);
                        btn.Click += new EventHandler(TableButton_Click);

                    }

                }

                if (ctrl.Controls.Count > 0)
                    ClearControls(ctrl);


            }
        }
        static List<String> lstSaveParams = new List<String>();
        private static void AddSaveParametertoList(string sParamString)
        {
            bool AlreadyExists = false;
            foreach (string lstString in lstSaveParams)
            {
                if (lstString == sParamString)
                    AlreadyExists = true;
            }
            if (!AlreadyExists)
                lstSaveParams.Add(sParamString);

        }
        
        private void CreateSaveParameters(System.Windows.Forms.Control Parent)
        {
            foreach (Control ctrl in Parent.Controls)
            {
                foreach (System.Windows.Forms.Control ctl in Parent.Controls)
                {
                    string _ctrlName = ctl.Name;
                    if (ctl.Name == "txtTranID")
                    {
                        //string TextBoxTag = ((DevExpress.XtraEditors.TextEdit)ctl).Tag.ToString();
                        AddSaveParametertoList("@TranID=" + ((TextBox)ctl).Text.ToString());

                    }
                    if (ctl.Tag != null && ctl.Tag != "")
                    {
                        if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.Label)))
                        {
                            string TextBoxTag = ((System.Windows.Forms.Label)ctl).Tag.ToString();
                            AddSaveParametertoList("@" + TextBoxTag + "=" + ((System.Windows.Forms.Label)ctl).Text.ToString());
                        }
                        else if (object.ReferenceEquals(ctl.GetType(), typeof(DateTimePicker)))
                        {
                            string TextBoxTag = ((DateTimePicker)ctl).Tag.ToString();
                            AddSaveParametertoList("@" + TextBoxTag + "=" + ((DateTimePicker)ctl).Text.ToString());
                        }
                        else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.TextBox)))
                        {
                            string TextBoxTag = ((System.Windows.Forms.TextBox)ctl).Tag.ToString();
                            AddSaveParametertoList("@" + TextBoxTag + "=" + ((System.Windows.Forms.TextBox)ctl).Text.ToString());
                        }
                        else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                        {
                            string TextBoxTag = ((System.Windows.Forms.CheckBox)ctl).Tag.ToString();
                            AddSaveParametertoList("@" + TextBoxTag + "=" + ((System.Windows.Forms.CheckBox)ctl).Checked.ToString());
                        }
                        else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                        {
                            string TextBoxTag = ((System.Windows.Forms.ComboBox)ctl).Tag.ToString();
                            AddSaveParametertoList("@" + TextBoxTag + "=" + ((((System.Windows.Forms.ComboBox)ctl).SelectedValue == null ? "0" : ((System.Windows.Forms.ComboBox)ctl).SelectedValue)).ToString());
                        }

                    }
                }
                if (ctrl.Controls.Count > 0)
                    CreateSaveParameters(ctrl);
            }
        }
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (customProperties.SaveButtonProcedureName != null)
            {
                Form frm = customProperties.Form;

                if (customProperties.SaveState == true)
                    return;

                frmWaitForm waitForm = new frmWaitForm();
                waitForm.Show(frm);


                string SQLCmd = customProperties.SaveButtonProcedureName;

                lstSaveParams = new List<string>();

                CreateSaveParameters(customProperties.Form);

                if (customProperties.AdditionalSaveButtonParameters != null)
                {
                    foreach (string sAdditionalParams in customProperties.AdditionalSaveButtonParameters)
                    {
                        AddSaveParametertoList(sAdditionalParams);
                    }
                }
                if (customProperties.SaveGridView1 != null)
                    customProperties.SaveButtonParametersTable1 = dgTodt(customProperties.SaveGridView1);

                if (customProperties.SaveGridView2 != null)
                    customProperties.SaveButtonParametersTable2 = dgTodt(customProperties.SaveGridView2);

                if (customProperties.SaveGridView3 != null)
                    customProperties.SaveButtonParametersTable3 = dgTodt(customProperties.SaveGridView3);

                SqlParameter[] _Params = new SqlParameter[lstSaveParams.Count];

                int _index = 0;
                foreach (string lstString in lstSaveParams)
                {

                    //if (_Params[_index] != null)
                    //{
                    string _ParamName = lstString.Substring(0, lstString.IndexOf('='));
                    string _ParamValue = "";

                    if (lstString.Substring(lstString.IndexOf('=') + 1) == "Table1")
                        _Params[_index] = new SqlParameter(_ParamName, customProperties.SaveButtonParametersTable1);
                    else if (lstString.Substring(lstString.IndexOf('=') + 1) == "Table2")
                        _Params[_index] = new SqlParameter(_ParamName, customProperties.SaveButtonParametersTable2);
                    else if (lstString.Substring(lstString.IndexOf('=') + 1) == "Table3")
                        _Params[_index] = new SqlParameter(_ParamName, customProperties.SaveButtonParametersTable3);
                    else if (lstString.Substring(lstString.IndexOf('=') + 1) == "Image")
                        _Params[_index] = new SqlParameter(_ParamName, customProperties.SaveImageParameter);
                    else
                        _Params[_index] = new SqlParameter(_ParamName, lstString.Substring(lstString.IndexOf('=') + 1));


                    _index++;
                    //}
                }

                try
                {
                        DataSet dsSaveRcd = SQLHelper.ExecuteQueryReturnDS(System.Data.CommandType.StoredProcedure, SQLCmd, _Params);

                    if (customProperties.ReturnTableNo != null)
                        customProperties.ReturnTableOnSave = dsSaveRcd.Tables[customProperties.ReturnTableNo];

                    if (dsSaveRcd.Tables[0].Rows[0][0].ToString() == "Duplicate")

                        MessageBox.Show(dsSaveRcd.Tables[0].Rows[0][1].ToString(),
                            GlobalVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (dsSaveRcd.Tables[0].Rows[0][0].ToString() == "Error")
                        MessageBox.Show("Saving Error. Please try again", GlobalVariables.sMessageBox, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else
                    {

                        UpdateTranNumb(customProperties.Form, dsSaveRcd.Tables[0].Rows[0][0].ToString());
                        UpdateReturnValues(dsSaveRcd.Tables[0]);
                        if (customProperties.AfterSave != null)
                        {
                            var type = customProperties.Form.GetType();
                            MethodInfo theMethod = type.GetMethod(customProperties.AfterSave);
                            theMethod.Invoke(customProperties.Form, null);
                        }

                        if (customProperties.PrintButton != null)
                        {
                            if (MessageBox.Show("Do you want to print ? ", GlobalVariables.sMessageBox,
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {


                                var type = customProperties.Form.GetType();
                                MethodInfo theMethod = type.GetMethod(customProperties.PrintButton);
                                theMethod.Invoke(customProperties.Form, null);
                            }
                        }

                        customProperties.Form.TopMost = true;
                        if(!customProperties.DontShowMsgOnSave)
                            if (MessageBox.Show("Record has been saved successfully. Do you want to add another ", GlobalVariables.sMessageBox,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                customProperties.Form.Activate();
                                RefreshButton_Click(sender, e);
                            }
                        customProperties.Form.TopMost = false;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                waitForm.Close();
            }
        }
        private void UpdateReturnValues(DataTable dt)
        {
            if (customProperties.UpdateControlValueOnSave != null)
            {
                for (int i = 0; i <= customProperties.UpdateControlValueOnSave.Length - 1; i++)
                {
                    ((TextBox)customProperties.UpdateControlValueOnSave[i]).Text = dt.Rows[0][customProperties.UpdateControlValueOnSave[i].Name.Substring(3)].ToString();
                }
            }
        }

        private static void UpdateTranNumb(System.Windows.Forms.Control Parent, string _TranNumb)
        {

            foreach (Control ctrl in Parent.Controls)
            {
                foreach (System.Windows.Forms.Control ctl in Parent.Controls)
                {
                    if (ctl.Name == "txtTranID")
                    {
                        //string TextBoxTag = ((DevExpress.XtraEditors.TextEdit)ctrl).Tag.ToString();
                        ((TextBox)ctl).Text = _TranNumb;

                    }
                }

                if (ctrl.Controls.Count > 0)
                    UpdateTranNumb(ctrl, _TranNumb);
            }
        }

        public DataTable dgTodt(DataGridView dgv)
        {
            DataTable dtReturn = new DataTable();

            try
            {
                string sortExpression = "";
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    //if (IgnoreHideColumns & !col.Visible) continue;
                    if (col.Tag == null) continue;
                    if (col.Name == string.Empty) continue;
                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                    sortExpression = sortExpression + col.Tag;
                }

                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;

                    }

                    dtSource.Rows.Add(drNewRow);
                }


                return RemoveEmptyRows(dtSource);
                //return dtSource;
            }
            catch (Exception ex)
            { return null; }

        }
        public DataTable RemoveEmptyRows(DataTable source)
        {
            DataTable dt1 = source.Clone();
            for (int i = 0; i <= source.Rows.Count - 1; i++)
            {
                DataRow currentRow = source.Rows[i];
                foreach (var colValue in currentRow.ItemArray)
                {
                    if (!string.IsNullOrEmpty(colValue.ToString()))
                    {
                        dt1.ImportRow(currentRow);
                        break;
                    }
                }
            }
            return dt1;
        }

        static void OnFocus(object sender, System.EventArgs e)
        {
            Control tb = null;
            if (sender is TextBox || sender is DateTimePicker || sender is ComboBox || sender is CheckBox)
            {
                Control cntrl = (Control)sender;
                cntrl.BackColor = Color.FromArgb(255, 255, 192);
            }

            return;
        }
        static void LostFocus(object sender, System.EventArgs e)
        {
            Control tb = null;
            if (sender is TextBox || sender is DateTimePicker || sender is ComboBox || sender is CheckBox)
            {
                Control cntrl = (Control)sender;
                cntrl.BackColor = Color.White;
            }

            return; 
        }


        public void FindButton_Click(object sender, EventArgs e)
        {
            if (customProperties.FindButtonProcedureName != null)
            {
                Form frm = customProperties.Form;

                frmWaitForm waitForm = new frmWaitForm();
                waitForm.Show(frm);

                frmSearch frmSearch = new frmSearch(customProperties.FindButtonProcedureName, customProperties.FindButtonParameters, customProperties.FindButtonColSizes, 
                        customProperties.FindButtonSearchIndex == null ? 0 : customProperties.FindButtonSearchIndex);

                SqlParameter[] _Params = new SqlParameter[customProperties.FindButtonParameters.Count()];

                //DataTable dtSearch = SQLHelper.ExecuteQueryReturnDS(CommandType.StoredProcedure, customProperties.FindButtonProcedureName, _Params).Tables[0];

                int _index = 0;
                foreach (string lstString in customProperties.FindButtonParameters)
                {

                    string _ParamName = lstString.Substring(0, lstString.IndexOf('='));
                    string _ParamValue = "";

                    _Params[_index] = new SqlParameter(_ParamName, lstString.Substring(lstString.IndexOf('=') + 1));

                    _index++;
                    //}
                }

                DataTable dtSearch = SQLHelper.ExecuteQueryReturnDS(System.Data.CommandType.StoredProcedure, 
                    customProperties.FindButtonProcedureName, _Params).Tables[0];

                waitForm.Close();
        
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    waitForm = new frmWaitForm();
                    waitForm.Show(frm);
        
                    FindAndReplaceText(frm);
                    BindDetail();


                    if (customProperties.AfterFind != null)
                    {
                        var type = customProperties.Form.GetType();
                        MethodInfo theMethod = type.GetMethod(customProperties.AfterFind);
                        theMethod.Invoke(customProperties.Form, null);
                    }

                    waitForm.Close();
        
                }
        

            }
        }
        

        
        static DataTable dtSearchValues;
        static DataTable dtSearchDetail, dtSearchDetail2, dtSearchDetail3;
        
        private void FindAndReplaceText(System.Windows.Forms.Control Parent)
        {

            try
            {

                foreach (Control ctrl in Parent.Controls)
                {
                    foreach (System.Windows.Forms.Control ctl in Parent.Controls)
                    {


                        if (ctl.Name == "txtTranID")
                        {
                            //string TextBoxTag = ((DevExpress.XtraEditors.TextEdit)ctrl).Tag.ToString();
                            if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            {
                                ((System.Windows.Forms.TextBox)ctl).Text = dtSearchValues.Rows[0][customProperties.MainTableIDFieldName].ToString();
                                customProperties.MainTableIDFieldValue = ((System.Windows.Forms.TextBox)ctl).Text;
                            }                           


                        }
                        if (ctl.Tag != null)
                            if (ctl.Tag.ToString().Trim() != "")
                            {
                                if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.Label)))
                                {
                                    string TextBoxTag = ((System.Windows.Forms.Label)ctl).Tag.ToString();
                                    ((System.Windows.Forms.Label)ctl).Text = dtSearchValues.Rows[0][TextBoxTag].ToString();
                                }
                                if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.TextBox)))
                                {
                                    string TextBoxTag = ((System.Windows.Forms.TextBox)ctl).Tag.ToString();
                                    ((System.Windows.Forms.TextBox)ctl).Text = dtSearchValues.Rows[0][TextBoxTag].ToString();
                                }

                                else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                                {
                                    string TextBoxTag = ((System.Windows.Forms.ComboBox)ctl).Tag.ToString();
                                    ((System.Windows.Forms.ComboBox)ctl).SelectedValue = dtSearchValues.Rows[0][TextBoxTag].ToString();
                                }
                                
                                else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                                {
                                    string TextBoxTag = ((System.Windows.Forms.CheckBox)ctl).Tag.ToString();
                                    ((System.Windows.Forms.CheckBox)ctl).Checked = bool.Parse(dtSearchValues.Rows[0][TextBoxTag].ToString());
                                }

                                else if (object.ReferenceEquals(ctl.GetType(), typeof(System.Windows.Forms.DateTimePicker)))
                                {
                                    string TextBoxTag = ((System.Windows.Forms.DateTimePicker)ctl).Tag.ToString();
                                    ((System.Windows.Forms.DateTimePicker)ctl).Value = DateTime.Parse(dtSearchValues.Rows[0][TextBoxTag].ToString());
                                }


                            }
                    }
                    if (ctrl.Controls.Count > 0)
                        FindAndReplaceText(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private void BindDetail()
        {
            ////if gridview present
            if (customProperties.SaveGridView1 != null)
            {

                string SQLCmd = customProperties.FindButtonProcedureName;
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter(customProperties.MainTableIDFieldName, customProperties.MainTableIDFieldValue);

                if (customProperties.MainTableIDFieldValue != null)
                {
                    try
                    {
                        DataSet dsChildTables = SQLHelper.ExecuteQueryReturnDS(System.Data.CommandType.StoredProcedure, SQLCmd, p);
                        //dtSearchDetail = dsChildTables.Tables[1];

                        if (dsChildTables.Tables[1] != null && customProperties.SaveGridView1 != null)
                        {
                            string[] colName = new string[customProperties.SaveGridView1.Columns.Count];
                            int i = 0;
                            foreach (DataGridViewColumn dgCol in customProperties.SaveGridView1.Columns)
                            {
                                colName[i] = dgCol.Name.ToString();
                                i++;
                            }

                            int RowsToDelete = customProperties.SaveGridView1.Rows.Count;
                            for (int j = 0; j < RowsToDelete; j++)
                                customProperties.SaveGridView1.Rows.RemoveAt(0);

                            int RowID = 0;
                            foreach (DataRow dRow in dsChildTables.Tables[1].Rows)
                            {
                                customProperties.SaveGridView1.Rows.Add();

                                foreach (string str in colName)
                                {

                                    DataColumnCollection columns = dsChildTables.Tables[1].Columns;
                                    if (columns.Contains(str))
                                    {
                                        customProperties.SaveGridView1.Rows[RowID].Cells[str].Value = dRow[str].ToString();

                                        if (dRow[str].GetType() == typeof(double))
                                        {
                                            customProperties.SaveGridView1.Rows[RowID].Cells[str].Value = Convert.ToDecimal(dRow[str].ToString());

                                        }
                                    }
                                }

                                RowID++;
                            }
                        }



                        if (dsChildTables.Tables.Count >= 3)
                        {
                            dtSearchDetail2 = dsChildTables.Tables[2];

                            if (dtSearchDetail2 != null && customProperties.SaveGridView2 != null)
                            {
                                //CustomFormProperties.SaveGridView2.DataSource = dtSearchDetail;
                                string[] colName = new string[customProperties.SaveGridView2.Columns.Count];
                                int i = 0;
                                foreach (DataGridViewColumn dgCol in customProperties.SaveGridView2.Columns)
                                {
                                    colName[i] = dgCol.Name.ToString();
                                    i++;
                                }

                                int RowsToDelete = customProperties.SaveGridView2.Rows.Count;
                                for (int j = 0; j < RowsToDelete; j++)
                                    customProperties.SaveGridView2.Rows.RemoveAt(0);


                                int RowID = 0;
                                foreach (DataRow dRow in dtSearchDetail2.Rows)
                                {
                                    customProperties.SaveGridView2.Rows.Add();

                                    foreach (string str in colName)
                                    {
                                        if (str != "Serial")
                                            customProperties.SaveGridView2.Rows[RowID].Cells[str].Value = dRow[str].ToString();
                                    }
                                    RowID++;
                                }
                            }
                        }
                        if (dsChildTables.Tables.Count >= 4 && customProperties.SaveGridView3 != null)
                        {
                            dtSearchDetail3 = dsChildTables.Tables[3];

                            if (dtSearchDetail3 != null)
                            {
                                //CustomFormProperties.SaveGridView2.DataSource = dtSearchDetail;
                                string[] colName = new string[customProperties.SaveGridView3.Columns.Count];
                                int i = 0;
                                foreach (DataGridViewColumn dgCol in customProperties.SaveGridView3.Columns)
                                {
                                    colName[i] = dgCol.Name.ToString();
                                    i++;
                                }

                                int RowsToDelete = customProperties.SaveGridView3.Rows.Count;
                                for (int j = 0; j < RowsToDelete; j++)
                                    customProperties.SaveGridView3.Rows.RemoveAt(0);


                                int RowID = 0;
                                foreach (DataRow dRow in dtSearchDetail3.Rows)
                                {
                                    customProperties.SaveGridView3.Rows.Add();

                                    foreach (string str in colName)
                                    {
                                        if (str != "Serial")
                                            customProperties.SaveGridView3.Rows[RowID].Cells[str].Value = dRow[str].ToString();
                                    }
                                    RowID++;
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        public static void SetReturnTable(DataTable dt)
        {
            dtSearchValues = dt;


        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {

            ClearControls(customProperties.Form);
            
            try
            {
                if (customProperties.AfterRefresh != null)
                {
                    var type = customProperties.Form.GetType();
                    MethodInfo theMethod = type.GetMethod(customProperties.AfterRefresh);
                    theMethod.Invoke(customProperties.Form, null);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", GlobalVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                customProperties.Form.Close();
            }

        }


        public void TableButton_Click(object sender, EventArgs e)
        {
            ClearControls(customProperties.Form);

            SqlParameter[] _Params = new SqlParameter[2];
            _Params[0] = new SqlParameter("IsBilled", "0");
            _Params[1] = new SqlParameter("TableSetupID", ((Button)sender).Tag);

            DataSet ds = SQLHelper.ExecuteQueryReturnDS(CommandType.StoredProcedure, "spGetAll_Sale", _Params);
            FormPresentationBLL.SetReturnTable(ds.Tables[0]);

            if (ds.Tables[0].Rows.Count > 0)
            {
                FindAndReplaceText(customProperties.Form);
                BindDetail();
            }

            if (customProperties.AfterTableButtonClick != null)
            {
                var type = customProperties.Form.GetType();
                MethodInfo theMethod = type.GetMethod(customProperties.AfterTableButtonClick);
                object[] parametersArray = new object[] { sender };

                theMethod.Invoke(customProperties.Form, parametersArray);
            }

        }
    }
    
}
