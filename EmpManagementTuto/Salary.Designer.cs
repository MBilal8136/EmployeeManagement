namespace EmpManagementTuto
{
    partial class Salary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.btnHome = new ns1.BunifuThinButton2();
            this.btnEdit = new ns1.BunifuThinButton2();
            this.brnDelete = new ns1.BunifuThinButton2();
            this.btnAdd = new ns1.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new ns1.BunifuMaterialTextbox();
            this.txtPhone = new ns1.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new ns1.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Label();
            this.txtGender = new ns1.BunifuMaterialTextbox();
            this.txtPostion = new ns1.BunifuMaterialTextbox();
            this.btnSearch = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.brnDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtPostion);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 437);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Gray;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(476, 38);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(517, 358);
            this.bunifuCustomDataGrid1.TabIndex = 7;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            this.bunifuCustomDataGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellDoubleClick);
            // 
            // btnHome
            // 
            this.btnHome.ActiveBorderThickness = 1;
            this.btnHome.ActiveCornerRadius = 20;
            this.btnHome.ActiveFillColor = System.Drawing.Color.Red;
            this.btnHome.ActiveForecolor = System.Drawing.Color.White;
            this.btnHome.ActiveLineColor = System.Drawing.Color.White;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IdleBorderThickness = 1;
            this.btnHome.IdleCornerRadius = 20;
            this.btnHome.IdleFillColor = System.Drawing.Color.Red;
            this.btnHome.IdleForecolor = System.Drawing.Color.White;
            this.btnHome.IdleLineColor = System.Drawing.Color.Red;
            this.btnHome.Location = new System.Drawing.Point(322, 373);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 39);
            this.btnHome.TabIndex = 6;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.Red;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.White;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.Red;
            this.btnEdit.IdleForecolor = System.Drawing.Color.White;
            this.btnEdit.IdleLineColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(123, 373);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 39);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // brnDelete
            // 
            this.brnDelete.ActiveBorderThickness = 1;
            this.brnDelete.ActiveCornerRadius = 20;
            this.brnDelete.ActiveFillColor = System.Drawing.Color.Red;
            this.brnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.brnDelete.ActiveLineColor = System.Drawing.Color.White;
            this.brnDelete.BackColor = System.Drawing.Color.White;
            this.brnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnDelete.BackgroundImage")));
            this.brnDelete.ButtonText = "Delete";
            this.brnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDelete.ForeColor = System.Drawing.Color.White;
            this.brnDelete.IdleBorderThickness = 1;
            this.brnDelete.IdleCornerRadius = 20;
            this.brnDelete.IdleFillColor = System.Drawing.Color.Red;
            this.brnDelete.IdleForecolor = System.Drawing.Color.White;
            this.brnDelete.IdleLineColor = System.Drawing.Color.Red;
            this.brnDelete.Location = new System.Drawing.Point(221, 373);
            this.brnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.Size = new System.Drawing.Size(86, 39);
            this.brnDelete.TabIndex = 5;
            this.brnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.Red;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.White;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Red;
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(13, 373);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(263, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Employee Gender\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(272, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Employee Phone\r\n";
            // 
            // txtSalary
            // 
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalary.HintForeColor = System.Drawing.Color.Empty;
            this.txtSalary.HintText = "";
            this.txtSalary.isPassword = false;
            this.txtSalary.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSalary.LineIdleColor = System.Drawing.Color.Red;
            this.txtSalary.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSalary.LineThickness = 4;
            this.txtSalary.Location = new System.Drawing.Point(278, 248);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(171, 35);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Red;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(13, 248);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 35);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Position\r\n";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Red;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(264, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 35);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(260, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Name";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtID.LineIdleColor = System.Drawing.Color.Red;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtID.LineThickness = 4;
            this.txtID.Location = new System.Drawing.Point(4, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 35);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID";
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.White;
            this.lblSalary.Image = ((System.Drawing.Image)(resources.GetObject("lblSalary.Image")));
            this.lblSalary.Location = new System.Drawing.Point(33, 12);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 60);
            this.lblSalary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblSalary.TabIndex = 8;
            this.lblSalary.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(968, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGender
            // 
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGender.HintForeColor = System.Drawing.Color.Empty;
            this.txtGender.HintText = "";
            this.txtGender.isPassword = false;
            this.txtGender.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGender.LineIdleColor = System.Drawing.Color.Red;
            this.txtGender.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGender.LineThickness = 4;
            this.txtGender.Location = new System.Drawing.Point(267, 157);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 35);
            this.txtGender.TabIndex = 10;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPostion
            // 
            this.txtPostion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostion.Enabled = false;
            this.txtPostion.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPostion.HintForeColor = System.Drawing.Color.Empty;
            this.txtPostion.HintText = "";
            this.txtPostion.isPassword = false;
            this.txtPostion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPostion.LineIdleColor = System.Drawing.Color.Red;
            this.txtPostion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPostion.LineThickness = 4;
            this.txtPostion.Location = new System.Drawing.Point(11, 157);
            this.txtPostion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPostion.Name = "txtPostion";
            this.txtPostion.Size = new System.Drawing.Size(171, 35);
            this.txtPostion.TabIndex = 10;
            this.txtPostion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.White;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.Red;
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(141, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1020, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private ns1.BunifuThinButton2 btnHome;
        private ns1.BunifuThinButton2 btnEdit;
        private ns1.BunifuThinButton2 brnDelete;
        private ns1.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuMaterialTextbox txtPhone;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuMaterialTextbox txtSalary;
        private System.Windows.Forms.PictureBox lblSalary;
        private System.Windows.Forms.Label btnExit;
        private ns1.BunifuMaterialTextbox txtGender;
        private ns1.BunifuMaterialTextbox txtPostion;
        private ns1.BunifuThinButton2 btnSearch;
    }
}