namespace FinalSemesterProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCustomer = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.TabJob = new System.Windows.Forms.TabPage();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtSqFt02 = new System.Windows.Forms.TextBox();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtWidth0 = new System.Windows.Forms.TextBox();
            this.TxtLaborCost = new System.Windows.Forms.TextBox();
            this.TxtEstimateTotal = new System.Windows.Forms.TextBox();
            this.TxtMaterialCost = new System.Windows.Forms.TextBox();
            this.TxtLaborCharge = new System.Windows.Forms.TextBox();
            this.TxtSqFt01 = new System.Windows.Forms.TextBox();
            this.LblLaborCost = new System.Windows.Forms.Label();
            this.LblEstTotal = new System.Windows.Forms.Label();
            this.LblLaborCharge = new System.Windows.Forms.Label();
            this.LblMaterialCost = new System.Windows.Forms.Label();
            this.LblSqFt = new System.Windows.Forms.Label();
            this.LblLegth = new System.Windows.Forms.Label();
            this.TxtWidth = new System.Windows.Forms.Label();
            this.TxtMaterialName = new System.Windows.Forms.TextBox();
            this.TxtMaterialPrice = new System.Windows.Forms.TextBox();
            this.TxtMaterialDesc = new System.Windows.Forms.TextBox();
            this.txtJobOutput = new System.Windows.Forms.TextBox();
            this.DgMaterials = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GbxInstallation = new System.Windows.Forms.GroupBox();
            this.RdoSelfInstall = new System.Windows.Forms.RadioButton();
            this.RdoProfessional = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCustomer.SuspendLayout();
            this.TabJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.GbxInstallation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.OpenJobQuote_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Enabled = false;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.fileToolStripMenuItem1.Text = "&File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCustomer);
            this.tabControl1.Controls.Add(this.TabJob);
            this.tabControl1.Location = new System.Drawing.Point(17, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 642);
            this.tabControl1.TabIndex = 1;
            // 
            // TabCustomer
            // 
            this.TabCustomer.Controls.Add(this.btnSubmit);
            this.TabCustomer.Controls.Add(this.comboState);
            this.TabCustomer.Controls.Add(this.lblZip);
            this.TabCustomer.Controls.Add(this.lblState);
            this.TabCustomer.Controls.Add(this.lblCity);
            this.TabCustomer.Controls.Add(this.TxtZip);
            this.TabCustomer.Controls.Add(this.txtOutput);
            this.TabCustomer.Controls.Add(this.TxtCity);
            this.TabCustomer.Controls.Add(this.TxtAddressLine2);
            this.TabCustomer.Controls.Add(this.lblAddress2);
            this.TabCustomer.Controls.Add(this.lblAddress);
            this.TabCustomer.Controls.Add(this.TxtAddress);
            this.TabCustomer.Controls.Add(this.TxtName);
            this.TabCustomer.Controls.Add(this.lblName);
            this.TabCustomer.Location = new System.Drawing.Point(4, 30);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomer.Size = new System.Drawing.Size(853, 608);
            this.TabCustomer.TabIndex = 0;
            this.TabCustomer.Text = "Customer";
            this.TabCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 34);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(188, 199);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 29);
            this.comboState.Sorted = true;
            this.comboState.TabIndex = 12;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(6, 253);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 21);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(6, 202);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 21);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 154);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 21);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(188, 250);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(186, 29);
            this.TxtZip.TabIndex = 8;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(423, 17);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(422, 262);
            this.txtOutput.TabIndex = 7;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(188, 151);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(186, 29);
            this.TxtCity.TabIndex = 6;
            // 
            // TxtAddressLine2
            // 
            this.TxtAddressLine2.Location = new System.Drawing.Point(188, 100);
            this.TxtAddressLine2.Name = "TxtAddressLine2";
            this.TxtAddressLine2.Size = new System.Drawing.Size(186, 29);
            this.TxtAddressLine2.TabIndex = 5;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(6, 103);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(104, 21);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "AddressLine2";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(188, 52);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(186, 29);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(188, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(186, 29);
            this.TxtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // TabJob
            // 
            this.TabJob.Controls.Add(this.GbxInstallation);
            this.TabJob.Controls.Add(this.BtnCalculate);
            this.TabJob.Controls.Add(this.TxtSqFt02);
            this.TabJob.Controls.Add(this.TxtLength);
            this.TabJob.Controls.Add(this.TxtWidth0);
            this.TabJob.Controls.Add(this.TxtLaborCost);
            this.TabJob.Controls.Add(this.TxtEstimateTotal);
            this.TabJob.Controls.Add(this.TxtMaterialCost);
            this.TabJob.Controls.Add(this.TxtLaborCharge);
            this.TabJob.Controls.Add(this.TxtSqFt01);
            this.TabJob.Controls.Add(this.LblLaborCost);
            this.TabJob.Controls.Add(this.LblEstTotal);
            this.TabJob.Controls.Add(this.LblLaborCharge);
            this.TabJob.Controls.Add(this.LblMaterialCost);
            this.TabJob.Controls.Add(this.LblSqFt);
            this.TabJob.Controls.Add(this.LblLegth);
            this.TabJob.Controls.Add(this.TxtWidth);
            this.TabJob.Controls.Add(this.TxtMaterialName);
            this.TabJob.Controls.Add(this.TxtMaterialPrice);
            this.TabJob.Controls.Add(this.TxtMaterialDesc);
            this.TabJob.Controls.Add(this.txtJobOutput);
            this.TabJob.Controls.Add(this.DgMaterials);
            this.TabJob.Location = new System.Drawing.Point(4, 30);
            this.TabJob.Name = "TabJob";
            this.TabJob.Padding = new System.Windows.Forms.Padding(3);
            this.TabJob.Size = new System.Drawing.Size(853, 608);
            this.TabJob.TabIndex = 1;
            this.TabJob.Text = "Job Info";
            this.TabJob.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(378, 429);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(100, 58);
            this.BtnCalculate.TabIndex = 20;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtSqFt02
            // 
            this.TxtSqFt02.Location = new System.Drawing.Point(378, 391);
            this.TxtSqFt02.Name = "TxtSqFt02";
            this.TxtSqFt02.ReadOnly = true;
            this.TxtSqFt02.Size = new System.Drawing.Size(191, 29);
            this.TxtSqFt02.TabIndex = 19;
            this.TxtSqFt02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(155, 346);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(191, 29);
            this.TxtLength.TabIndex = 18;
            this.TxtLength.Text = "1";
            this.TxtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtWidth0
            // 
            this.TxtWidth0.Location = new System.Drawing.Point(155, 304);
            this.TxtWidth0.Name = "TxtWidth0";
            this.TxtWidth0.Size = new System.Drawing.Size(191, 29);
            this.TxtWidth0.TabIndex = 17;
            this.TxtWidth0.Text = "1";
            this.TxtWidth0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtLaborCost
            // 
            this.TxtLaborCost.Location = new System.Drawing.Point(155, 463);
            this.TxtLaborCost.Name = "TxtLaborCost";
            this.TxtLaborCost.ReadOnly = true;
            this.TxtLaborCost.Size = new System.Drawing.Size(191, 29);
            this.TxtLaborCost.TabIndex = 16;
            this.TxtLaborCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtEstimateTotal
            // 
            this.TxtEstimateTotal.Location = new System.Drawing.Point(155, 502);
            this.TxtEstimateTotal.Name = "TxtEstimateTotal";
            this.TxtEstimateTotal.ReadOnly = true;
            this.TxtEstimateTotal.Size = new System.Drawing.Size(191, 29);
            this.TxtEstimateTotal.TabIndex = 15;
            this.TxtEstimateTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtMaterialCost
            // 
            this.TxtMaterialCost.Location = new System.Drawing.Point(155, 426);
            this.TxtMaterialCost.Name = "TxtMaterialCost";
            this.TxtMaterialCost.ReadOnly = true;
            this.TxtMaterialCost.Size = new System.Drawing.Size(191, 29);
            this.TxtMaterialCost.TabIndex = 14;
            this.TxtMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtLaborCharge
            // 
            this.TxtLaborCharge.Location = new System.Drawing.Point(155, 540);
            this.TxtLaborCharge.Name = "TxtLaborCharge";
            this.TxtLaborCharge.Size = new System.Drawing.Size(191, 29);
            this.TxtLaborCharge.TabIndex = 13;
            this.TxtLaborCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtSqFt01
            // 
            this.TxtSqFt01.Location = new System.Drawing.Point(155, 391);
            this.TxtSqFt01.Name = "TxtSqFt01";
            this.TxtSqFt01.ReadOnly = true;
            this.TxtSqFt01.Size = new System.Drawing.Size(191, 29);
            this.TxtSqFt01.TabIndex = 12;
            this.TxtSqFt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblLaborCost
            // 
            this.LblLaborCost.AutoSize = true;
            this.LblLaborCost.Location = new System.Drawing.Point(6, 466);
            this.LblLaborCost.Name = "LblLaborCost";
            this.LblLaborCost.Size = new System.Drawing.Size(85, 21);
            this.LblLaborCost.TabIndex = 11;
            this.LblLaborCost.Text = "Labor Cost";
            // 
            // LblEstTotal
            // 
            this.LblEstTotal.AutoSize = true;
            this.LblEstTotal.Location = new System.Drawing.Point(6, 505);
            this.LblEstTotal.Name = "LblEstTotal";
            this.LblEstTotal.Size = new System.Drawing.Size(105, 21);
            this.LblEstTotal.TabIndex = 10;
            this.LblEstTotal.Text = "Estimate Total";
            // 
            // LblLaborCharge
            // 
            this.LblLaborCharge.AutoSize = true;
            this.LblLaborCharge.Location = new System.Drawing.Point(6, 543);
            this.LblLaborCharge.Name = "LblLaborCharge";
            this.LblLaborCharge.Size = new System.Drawing.Size(104, 21);
            this.LblLaborCharge.TabIndex = 9;
            this.LblLaborCharge.Text = "Labor Charge";
            // 
            // LblMaterialCost
            // 
            this.LblMaterialCost.AutoSize = true;
            this.LblMaterialCost.Location = new System.Drawing.Point(6, 429);
            this.LblMaterialCost.Name = "LblMaterialCost";
            this.LblMaterialCost.Size = new System.Drawing.Size(80, 21);
            this.LblMaterialCost.TabIndex = 8;
            this.LblMaterialCost.Text = "Mat\'l Cost";
            // 
            // LblSqFt
            // 
            this.LblSqFt.AutoSize = true;
            this.LblSqFt.Location = new System.Drawing.Point(6, 394);
            this.LblSqFt.Name = "LblSqFt";
            this.LblSqFt.Size = new System.Drawing.Size(45, 21);
            this.LblSqFt.TabIndex = 7;
            this.LblSqFt.Text = "Sq Ft";
            // 
            // LblLegth
            // 
            this.LblLegth.AutoSize = true;
            this.LblLegth.Location = new System.Drawing.Point(6, 354);
            this.LblLegth.Name = "LblLegth";
            this.LblLegth.Size = new System.Drawing.Size(58, 21);
            this.LblLegth.TabIndex = 6;
            this.LblLegth.Text = "Length";
            // 
            // TxtWidth
            // 
            this.TxtWidth.AutoSize = true;
            this.TxtWidth.Location = new System.Drawing.Point(6, 307);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(52, 21);
            this.TxtWidth.TabIndex = 5;
            this.TxtWidth.Text = "Width";
            // 
            // TxtMaterialName
            // 
            this.TxtMaterialName.Location = new System.Drawing.Point(166, 233);
            this.TxtMaterialName.Name = "TxtMaterialName";
            this.TxtMaterialName.Size = new System.Drawing.Size(100, 29);
            this.TxtMaterialName.TabIndex = 4;
            // 
            // TxtMaterialPrice
            // 
            this.TxtMaterialPrice.Location = new System.Drawing.Point(319, 233);
            this.TxtMaterialPrice.Name = "TxtMaterialPrice";
            this.TxtMaterialPrice.Size = new System.Drawing.Size(100, 29);
            this.TxtMaterialPrice.TabIndex = 3;
            // 
            // TxtMaterialDesc
            // 
            this.TxtMaterialDesc.Location = new System.Drawing.Point(22, 233);
            this.TxtMaterialDesc.Name = "TxtMaterialDesc";
            this.TxtMaterialDesc.Size = new System.Drawing.Size(100, 29);
            this.TxtMaterialDesc.TabIndex = 2;
            // 
            // txtJobOutput
            // 
            this.txtJobOutput.Location = new System.Drawing.Point(491, 6);
            this.txtJobOutput.Multiline = true;
            this.txtJobOutput.Name = "txtJobOutput";
            this.txtJobOutput.ReadOnly = true;
            this.txtJobOutput.Size = new System.Drawing.Size(341, 221);
            this.txtJobOutput.TabIndex = 1;
            // 
            // DgMaterials
            // 
            this.DgMaterials.AllowUserToAddRows = false;
            this.DgMaterials.AllowUserToDeleteRows = false;
            this.DgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMaterials.Location = new System.Drawing.Point(22, 6);
            this.DgMaterials.Name = "DgMaterials";
            this.DgMaterials.ReadOnly = true;
            this.DgMaterials.RowTemplate.Height = 25;
            this.DgMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgMaterials.Size = new System.Drawing.Size(397, 221);
            this.DgMaterials.TabIndex = 0;
            this.DgMaterials.SelectionChanged += new System.EventHandler(this.DgMaterials_SelectionChanged);
            // 
            // GbxInstallation
            // 
            this.GbxInstallation.Controls.Add(this.RdoProfessional);
            this.GbxInstallation.Controls.Add(this.RdoSelfInstall);
            this.GbxInstallation.Location = new System.Drawing.Point(378, 292);
            this.GbxInstallation.Name = "GbxInstallation";
            this.GbxInstallation.Size = new System.Drawing.Size(191, 93);
            this.GbxInstallation.TabIndex = 21;
            this.GbxInstallation.TabStop = false;
            this.GbxInstallation.Text = "Installation";
            // 
            // RdoSelfInstall
            // 
            this.RdoSelfInstall.AutoSize = true;
            this.RdoSelfInstall.Location = new System.Drawing.Point(6, 28);
            this.RdoSelfInstall.Name = "RdoSelfInstall";
            this.RdoSelfInstall.Size = new System.Drawing.Size(101, 25);
            this.RdoSelfInstall.TabIndex = 0;
            this.RdoSelfInstall.TabStop = true;
            this.RdoSelfInstall.Text = "Self-Install";
            this.RdoSelfInstall.UseVisualStyleBackColor = true;
            // 
            // RdoProfessional
            // 
            this.RdoProfessional.AutoSize = true;
            this.RdoProfessional.Location = new System.Drawing.Point(6, 65);
            this.RdoProfessional.Name = "RdoProfessional";
            this.RdoProfessional.Size = new System.Drawing.Size(158, 25);
            this.RdoProfessional.TabIndex = 1;
            this.RdoProfessional.TabStop = true;
            this.RdoProfessional.Text = "Professional Install";
            this.RdoProfessional.UseVisualStyleBackColor = true;
            this.RdoProfessional.CheckedChanged += new System.EventHandler(this.RdoProfessional_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabCustomer.ResumeLayout(false);
            this.TabCustomer.PerformLayout();
            this.TabJob.ResumeLayout(false);
            this.TabJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.GbxInstallation.ResumeLayout(false);
            this.GbxInstallation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage TabCustomer;
        private TabPage TabJob;
        private TextBox TxtName;
        private Label lblName;
        private Label lblAddress;
        private TextBox TxtAddress;
        private Label lblZip;
        private Label lblState;
        private Label lblCity;
        private TextBox TxtZip;
        private TextBox txtOutput;
        private TextBox TxtCity;
        private TextBox TxtAddressLine2;
        private Label lblAddress2;
        private Button btnSubmit;
        private ComboBox comboState;
        private DataGridView DgMaterials;
        private BindingSource bindingSource1;
        private TextBox txtJobOutput;
        private TextBox TxtMaterialName;
        private TextBox TxtMaterialPrice;
        private TextBox TxtMaterialDesc;
        private Label TxtWidth;
        private Label LblLaborCost;
        private Label LblEstTotal;
        private Label LblLaborCharge;
        private Label LblMaterialCost;
        private Label LblSqFt;
        private Label LblLegth;
        private TextBox TxtLength;
        private TextBox TxtWidth0;
        private TextBox TxtLaborCost;
        private TextBox TxtEstimateTotal;
        private TextBox TxtMaterialCost;
        private TextBox TxtLaborCharge;
        private TextBox TxtSqFt01;
        private TextBox TxtSqFt02;
        private Button BtnCalculate;
        private GroupBox GbxInstallation;
        private RadioButton RdoProfessional;
        private RadioButton RdoSelfInstall;
    }
}