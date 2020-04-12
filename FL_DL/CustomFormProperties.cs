using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.ComponentModel;
using System.Reflection;


namespace FL_DL
{
    public class CustomFormProperties
    {



        public Form Form
        { get; set; }
        
                
        public string FindButtonProcedureName
        { get; set; }

        public string[] FindButtonParameters
        { get; set; }

        public int[] FindButtonColSizes
        { get; set; }

        public int FindButtonSearchIndex
        { get; set; }

        public string MainTableName
        { get; set; }

        public string MainTableIDFieldName
        { get; set; }

        public string MainTableIDFieldValue
        { get; set; }

        public string BarManagerName
        { get; set; }


        public string SaveButtonProcedureName
        { get; set; }



        public string[] AdditionalSaveButtonParameters
        { get; set; }

        public DataGridView SaveGridView1
        { get; set; }

        public DataGridView SaveGridView2
        { get; set; }

        public DataGridView SaveGridView3
        { get; set; }

        public DataTable ReturnTableOnSave
        { get; set; }

        public int ReturnTableNo
        { get; set; }

        public DataTable SaveButtonParametersTable1
        { get; set; }

        public DataTable SaveButtonParametersTable2
        { get; set; }

        public DataTable SaveButtonParametersTable3
        { get; set; }

        public byte[] SaveImageParameter
        { get; set; }


        public bool SaveState
        {
            get;
            set;
        }

        public bool CheckAuthority
        {
            get;
            set;
        }
        public bool DontShowSrchByTran
        {
            get;
            set;
        }
        public bool EnabelDuplicatePrint
        {
            get;
            set;
        }
        public bool EnabelDirectPrint
        {
            get;
            set;
        }
        public bool DontShowMsgOnSave
        {
            get;
            set;
        }

        public Control[] UpdateControlValueOnSave
        { get; set; }




        public System.ComponentModel.BackgroundWorker bgWorker_Rpt
        { get; set; }

        public string GetReportData
        { get; set; }

        public string PopulateReport
        { get; set; }
        public DataSet dsReportData
        { get; set; }

        public string PrintButton
        { get; set; }

        public string BeforeFind
        { get; set; }

        public string AfterRefresh
        { get; set; }

        public string AfterFind
        { get; set; }

        public string AfterSave
        { get; set; }


        public string AfterTableButtonClick
        { get; set; }


        public string SrchValue
        { get; set; }




    }

}
