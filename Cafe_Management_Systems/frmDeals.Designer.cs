namespace Cafe_Management_Systems
{
    partial class frmDeals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDealDescription = new System.Windows.Forms.TextBox();
            this.txtTranID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInActive = new System.Windows.Forms.CheckBox();
            this.lblCostDrink = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDealPerson = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDealName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDealDetail = new System.Windows.Forms.DataGridView();
            this.txtDiscAmnt = new System.Windows.Forms.TextBox();
            this.lblNet_Amnt = new System.Windows.Forms.Label();
            this.lblTaxAmnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmnt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 75);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deal Setup";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 80);
            this.panel2.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(581, 8);
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
            this.btnFind.Location = new System.Drawing.Point(408, 8);
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
            this.btnRefresh.Location = new System.Drawing.Point(235, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 60);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(62, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.txtRemarks);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pnlItems);
            this.panel3.Controls.Add(this.txtDiscAmnt);
            this.panel3.Controls.Add(this.lblNet_Amnt);
            this.panel3.Controls.Add(this.lblTaxAmnt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblAmnt);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtDealName);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtDealPerson);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.dtEndDate);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.dtStartDate);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDealDescription);
            this.panel3.Controls.Add(this.txtTranID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chkInActive);
            this.panel3.Controls.Add(this.lblCostDrink);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1362, 507);
            this.panel3.TabIndex = 19;
            // 
            // txtDealDescription
            // 
            this.txtDealDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealDescription.Location = new System.Drawing.Point(652, 65);
            this.txtDealDescription.Name = "txtDealDescription";
            this.txtDealDescription.Size = new System.Drawing.Size(258, 38);
            this.txtDealDescription.TabIndex = 22;
            this.txtDealDescription.Tag = "DealDescription";
            // 
            // txtTranID
            // 
            this.txtTranID.Enabled = false;
            this.txtTranID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranID.Location = new System.Drawing.Point(652, 20);
            this.txtTranID.Name = "txtTranID";
            this.txtTranID.Size = new System.Drawing.Size(120, 38);
            this.txtTranID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(558, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Deal ID";
            // 
            // chkInActive
            // 
            this.chkInActive.AutoSize = true;
            this.chkInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInActive.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkInActive.Location = new System.Drawing.Point(652, 472);
            this.chkInActive.Name = "chkInActive";
            this.chkInActive.Size = new System.Drawing.Size(98, 24);
            this.chkInActive.TabIndex = 18;
            this.chkInActive.Tag = "InActive";
            this.chkInActive.Text = "&In Active";
            this.chkInActive.UseVisualStyleBackColor = true;
            // 
            // lblCostDrink
            // 
            this.lblCostDrink.AutoSize = true;
            this.lblCostDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostDrink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCostDrink.Location = new System.Drawing.Point(575, 71);
            this.lblCostDrink.Name = "lblCostDrink";
            this.lblCostDrink.Size = new System.Drawing.Size(72, 25);
            this.lblCostDrink.TabIndex = 0;
            this.lblCostDrink.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(1242, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 25);
            this.label20.TabIndex = 64;
            this.label20.Text = "Person/s";
            // 
            // txtDealPerson
            // 
            this.txtDealPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealPerson.Location = new System.Drawing.Point(1125, 22);
            this.txtDealPerson.Name = "txtDealPerson";
            this.txtDealPerson.Size = new System.Drawing.Size(113, 38);
            this.txtDealPerson.TabIndex = 63;
            this.txtDealPerson.Tag = "DealPerson";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(1030, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 25);
            this.label19.TabIndex = 62;
            this.label19.Text = "Deal for";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(1059, 109);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(179, 38);
            this.dtEndDate.TabIndex = 61;
            this.dtEndDate.Tag = "EndDate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(944, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 25);
            this.label17.TabIndex = 60;
            this.label17.Text = "End Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(652, 109);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(179, 38);
            this.dtStartDate.TabIndex = 59;
            this.dtStartDate.Tag = "StartDate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(529, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 25);
            this.label16.TabIndex = 58;
            this.label16.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(775, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Short Name";
            // 
            // txtDealName
            // 
            this.txtDealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealName.Location = new System.Drawing.Point(913, 20);
            this.txtDealName.MaxLength = 3;
            this.txtDealName.Name = "txtDealName";
            this.txtDealName.Size = new System.Drawing.Size(113, 38);
            this.txtDealName.TabIndex = 66;
            this.txtDealName.Tag = "DealName";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDealDetail);
            this.panel4.Location = new System.Drawing.Point(652, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 199);
            this.panel4.TabIndex = 67;
            // 
            // dgvDealDetail
            // 
            this.dgvDealDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDealDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDealDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDealDetail.Name = "dgvDealDetail";
            this.dgvDealDetail.Size = new System.Drawing.Size(586, 199);
            this.dgvDealDetail.TabIndex = 0;
            this.dgvDealDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealDetail_CellEndEdit);
            // 
            // txtDiscAmnt
            // 
            this.txtDiscAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscAmnt.Location = new System.Drawing.Point(1106, 362);
            this.txtDiscAmnt.Name = "txtDiscAmnt";
            this.txtDiscAmnt.Size = new System.Drawing.Size(132, 45);
            this.txtDiscAmnt.TabIndex = 76;
            this.txtDiscAmnt.Leave += new System.EventHandler(this.txtDiscAmnt_Leave);
            // 
            // lblNet_Amnt
            // 
            this.lblNet_Amnt.BackColor = System.Drawing.Color.LightPink;
            this.lblNet_Amnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNet_Amnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet_Amnt.Location = new System.Drawing.Point(1106, 415);
            this.lblNet_Amnt.Name = "lblNet_Amnt";
            this.lblNet_Amnt.Size = new System.Drawing.Size(132, 46);
            this.lblNet_Amnt.TabIndex = 74;
            this.lblNet_Amnt.Tag = "DealAmnt";
            this.lblNet_Amnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxAmnt
            // 
            this.lblTaxAmnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTaxAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmnt.Location = new System.Drawing.Point(652, 410);
            this.lblTaxAmnt.Name = "lblTaxAmnt";
            this.lblTaxAmnt.Size = new System.Drawing.Size(132, 46);
            this.lblTaxAmnt.TabIndex = 72;
            this.lblTaxAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(556, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 68;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(510, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tax Amount";
            // 
            // lblAmnt
            // 
            this.lblAmnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmnt.Location = new System.Drawing.Point(652, 362);
            this.lblAmnt.Name = "lblAmnt";
            this.lblAmnt.Size = new System.Drawing.Size(132, 46);
            this.lblAmnt.TabIndex = 71;
            this.lblAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(944, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 75;
            this.label12.Text = "Disc. Amnt.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(906, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "Net Deal Amnt.";
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(491, 507);
            this.pnlItems.TabIndex = 77;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(1025, 63);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(213, 38);
            this.txtRemarks.TabIndex = 79;
            this.txtRemarks.Tag = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(916, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Remarks";
            // 
            // frmDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDeals";
            this.Text = "frmDeals";
            this.Load += new System.EventHandler(this.frmDeals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDealDescription;
        private System.Windows.Forms.TextBox txtTranID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInActive;
        private System.Windows.Forms.Label lblCostDrink;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDealPerson;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDealName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscAmnt;
        private System.Windows.Forms.Label lblNet_Amnt;
        private System.Windows.Forms.Label lblTaxAmnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDealDetail;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
    }
}