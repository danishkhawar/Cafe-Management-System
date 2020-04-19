namespace Cafe_Management_Systems
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAppHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsMainMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.accountSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblAppVer = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbRept = new System.Windows.Forms.GroupBox();
            this.rView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReportClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmbTableSetupID = new System.Windows.Forms.ComboBox();
            this.txtTranID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAcct = new System.Windows.Forms.ComboBox();
            this.chkCredit = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCatgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiscPerc = new System.Windows.Forms.TextBox();
            this.txtDiscAmnt = new System.Windows.Forms.TextBox();
            this.lblNet_Amnt = new System.Windows.Forms.Label();
            this.lblTaxAmnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmnt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.dealSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbRept.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblAppHeader
            // 
            this.lblAppHeader.AutoSize = true;
            this.lblAppHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppHeader.Location = new System.Drawing.Point(12, 33);
            this.lblAppHeader.Name = "lblAppHeader";
            this.lblAppHeader.Size = new System.Drawing.Size(882, 76);
            this.lblAppHeader.TabIndex = 0;
            this.lblAppHeader.Text = "Cafe Management Systems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.lblAppVer);
            this.panel1.Controls.Add(this.lblAppHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 124);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMainMenu,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1496, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dealSetupToolStripMenuItem,
            this.toolStripMenuItem2,
            this.accountSetupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.itemCategoryToolStripMenuItem,
            this.toolStripMenuItem3});
            this.tsMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMainMenu.Image")));
            this.tsMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(38, 22);
            this.tsMainMenu.Text = "Fil&e";
            // 
            // accountSetupToolStripMenuItem
            // 
            this.accountSetupToolStripMenuItem.Name = "accountSetupToolStripMenuItem";
            this.accountSetupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountSetupToolStripMenuItem.Text = "&Account Setup";
            this.accountSetupToolStripMenuItem.Click += new System.EventHandler(this.accountSetupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Table Setup";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // itemCategoryToolStripMenuItem
            // 
            this.itemCategoryToolStripMenuItem.Name = "itemCategoryToolStripMenuItem";
            this.itemCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemCategoryToolStripMenuItem.Text = "Item &Category";
            this.itemCategoryToolStripMenuItem.Click += new System.EventHandler(this.itemCategoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "&Item Setup";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "&Reports";
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saleReportToolStripMenuItem.Text = "&Sale Report";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "&Help";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton1.Text = "E&xit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblAppVer
            // 
            this.lblAppVer.AutoSize = true;
            this.lblAppVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppVer.Location = new System.Drawing.Point(1113, 103);
            this.lblAppVer.Name = "lblAppVer";
            this.lblAppVer.Size = new System.Drawing.Size(41, 13);
            this.lblAppVer.TabIndex = 2;
            this.lblAppVer.Text = "label3";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.pnlItems);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 124);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1496, 757);
            this.panel8.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.gbRept);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(491, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 753);
            this.panel6.TabIndex = 11;
            // 
            // gbRept
            // 
            this.gbRept.Controls.Add(this.rView);
            this.gbRept.Controls.Add(this.btnReportClose);
            this.gbRept.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbRept.Location = new System.Drawing.Point(751, 81);
            this.gbRept.Name = "gbRept";
            this.gbRept.Size = new System.Drawing.Size(321, 442);
            this.gbRept.TabIndex = 38;
            this.gbRept.TabStop = false;
            this.gbRept.Text = "Receipt";
            // 
            // rView
            // 
            this.rView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rView.Location = new System.Drawing.Point(3, 51);
            this.rView.Name = "rView";
            this.rView.Size = new System.Drawing.Size(315, 388);
            this.rView.TabIndex = 5;
            // 
            // btnReportClose
            // 
            this.btnReportClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReportClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportClose.Location = new System.Drawing.Point(3, 16);
            this.btnReportClose.Name = "btnReportClose";
            this.btnReportClose.Size = new System.Drawing.Size(315, 35);
            this.btnReportClose.TabIndex = 4;
            this.btnReportClose.Text = "&Close";
            this.btnReportClose.UseVisualStyleBackColor = false;
            this.btnReportClose.Click += new System.EventHandler(this.btnReportClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.chkDelivery);
            this.panel3.Controls.Add(this.txtRemarks);
            this.panel3.Controls.Add(this.cmbTableSetupID);
            this.panel3.Controls.Add(this.txtTranID);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbAcct);
            this.panel3.Controls.Add(this.chkCredit);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtCatgName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnlTable);
            this.panel3.Location = new System.Drawing.Point(3, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 664);
            this.panel3.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(226, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Remarks";
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkDelivery.Location = new System.Drawing.Point(219, 4);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(91, 24);
            this.chkDelivery.TabIndex = 50;
            this.chkDelivery.Text = "&Delivery";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkBill_CheckedChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(219, 148);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(512, 68);
            this.txtRemarks.TabIndex = 38;
            this.txtRemarks.Tag = "Remarks";
            // 
            // cmbTableSetupID
            // 
            this.cmbTableSetupID.Enabled = false;
            this.cmbTableSetupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableSetupID.FormattingEnabled = true;
            this.cmbTableSetupID.Location = new System.Drawing.Point(309, 27);
            this.cmbTableSetupID.Name = "cmbTableSetupID";
            this.cmbTableSetupID.Size = new System.Drawing.Size(114, 39);
            this.cmbTableSetupID.TabIndex = 49;
            this.cmbTableSetupID.Tag = "TableSetupID";
            // 
            // txtTranID
            // 
            this.txtTranID.Enabled = false;
            this.txtTranID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranID.Location = new System.Drawing.Point(219, 27);
            this.txtTranID.Name = "txtTranID";
            this.txtTranID.Size = new System.Drawing.Size(87, 38);
            this.txtTranID.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(181, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 38);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Tag = "SaleDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(161, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(425, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Account";
            // 
            // cmbAcct
            // 
            this.cmbAcct.Enabled = false;
            this.cmbAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcct.FormattingEnabled = true;
            this.cmbAcct.Location = new System.Drawing.Point(526, 27);
            this.cmbAcct.Name = "cmbAcct";
            this.cmbAcct.Size = new System.Drawing.Size(205, 39);
            this.cmbAcct.TabIndex = 43;
            this.cmbAcct.Tag = "AcctID";
            // 
            // chkCredit
            // 
            this.chkCredit.AutoSize = true;
            this.chkCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkCredit.Location = new System.Drawing.Point(461, 4);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Size = new System.Drawing.Size(76, 24);
            this.chkCredit.TabIndex = 42;
            this.chkCredit.Tag = "SaleType";
            this.chkCredit.Text = "&Credit";
            this.chkCredit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(526, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 38);
            this.textBox1.TabIndex = 41;
            this.textBox1.Tag = "CellNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(426, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cell No.";
            // 
            // txtCatgName
            // 
            this.txtCatgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatgName.Location = new System.Drawing.Point(526, 68);
            this.txtCatgName.Name = "txtCatgName";
            this.txtCatgName.Size = new System.Drawing.Size(205, 38);
            this.txtCatgName.TabIndex = 39;
            this.txtCatgName.Tag = "Walk_Cust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(450, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvOrderItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(155, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 442);
            this.panel2.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDiscPerc);
            this.panel4.Controls.Add(this.txtDiscAmnt);
            this.panel4.Controls.Add(this.lblNet_Amnt);
            this.panel4.Controls.Add(this.lblTaxAmnt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblAmnt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 227);
            this.panel4.TabIndex = 19;
            // 
            // txtDiscPerc
            // 
            this.txtDiscPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPerc.Location = new System.Drawing.Point(435, 19);
            this.txtDiscPerc.Name = "txtDiscPerc";
            this.txtDiscPerc.Size = new System.Drawing.Size(132, 45);
            this.txtDiscPerc.TabIndex = 26;
            this.txtDiscPerc.Tag = "DiscPerc";
            this.txtDiscPerc.Leave += new System.EventHandler(this.txtDiscPerc_Leave);
            // 
            // txtDiscAmnt
            // 
            this.txtDiscAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscAmnt.Location = new System.Drawing.Point(435, 72);
            this.txtDiscAmnt.Name = "txtDiscAmnt";
            this.txtDiscAmnt.Size = new System.Drawing.Size(132, 45);
            this.txtDiscAmnt.TabIndex = 25;
            this.txtDiscAmnt.Tag = "DiscAmnt";
            this.txtDiscAmnt.Leave += new System.EventHandler(this.txtDiscAmnt_Leave);
            // 
            // lblNet_Amnt
            // 
            this.lblNet_Amnt.BackColor = System.Drawing.Color.LightPink;
            this.lblNet_Amnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNet_Amnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet_Amnt.Location = new System.Drawing.Point(435, 127);
            this.lblNet_Amnt.Name = "lblNet_Amnt";
            this.lblNet_Amnt.Size = new System.Drawing.Size(132, 46);
            this.lblNet_Amnt.TabIndex = 13;
            this.lblNet_Amnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxAmnt
            // 
            this.lblTaxAmnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTaxAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmnt.Location = new System.Drawing.Point(150, 75);
            this.lblTaxAmnt.Name = "lblTaxAmnt";
            this.lblTaxAmnt.Size = new System.Drawing.Size(132, 46);
            this.lblTaxAmnt.TabIndex = 10;
            this.lblTaxAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(51, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(5, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tax Amount";
            // 
            // lblAmnt
            // 
            this.lblAmnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmnt.Location = new System.Drawing.Point(150, 22);
            this.lblAmnt.Name = "lblAmnt";
            this.lblAmnt.Size = new System.Drawing.Size(132, 46);
            this.lblAmnt.TabIndex = 9;
            this.lblAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(298, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Disc. Amnt.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(299, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Discount %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(275, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Net Bill Amnt.";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItems.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.Size = new System.Drawing.Size(586, 442);
            this.dgvOrderItems.TabIndex = 0;
            this.dgvOrderItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellDoubleClick);
            // 
            // pnlTable
            // 
            this.pnlTable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTable.Location = new System.Drawing.Point(0, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(155, 664);
            this.pnlTable.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.btnPrint);
            this.panel9.Controls.Add(this.btnExit);
            this.panel9.Controls.Add(this.btnFind);
            this.panel9.Controls.Add(this.btnRefresh);
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1001, 80);
            this.panel9.TabIndex = 35;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(497, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 60);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(663, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFind.Location = new System.Drawing.Point(331, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(167, 60);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(166, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 60);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Reset";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(0, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(491, 753);
            this.pnlItems.TabIndex = 10;
            // 
            // dealSetupToolStripMenuItem
            // 
            this.dealSetupToolStripMenuItem.Name = "dealSetupToolStripMenuItem";
            this.dealSetupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dealSetupToolStripMenuItem.Text = "Deal Setup";
            this.dealSetupToolStripMenuItem.Click += new System.EventHandler(this.dealSetupToolStripMenuItem_Click);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 881);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gbRept.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label lblAppHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAppVer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTaxAmnt;
        private System.Windows.Forms.Label lblAmnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton tsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem itemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSetupToolStripMenuItem;
        private System.Windows.Forms.Label lblNet_Amnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscPerc;
        private System.Windows.Forms.TextBox txtDiscAmnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.ComboBox cmbTableSetupID;
        private System.Windows.Forms.TextBox txtTranID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAcct;
        private System.Windows.Forms.CheckBox chkCredit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCatgName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox gbRept;
        private System.Windows.Forms.Button btnReportClose;
        private Microsoft.Reporting.WinForms.ReportViewer rView;
        private System.Windows.Forms.ToolStripMenuItem dealSetupToolStripMenuItem;
    }
}