namespace Hotel_Billing_Software.Transaction
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblTableNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBill = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtItemId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnRelease = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMerge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSwitch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtIGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCGST = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbPaymentModel = new System.Windows.Forms.ComboBox();
            this.cmbWaiter = new System.Windows.Forms.ComboBox();
            this.txtGrandTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSubTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gridBillDescription = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBillDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Controls.Add(this.cmbCustomerName);
            this.panel1.Controls.Add(this.lblTableNo);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 78);
            this.panel1.TabIndex = 55;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 68);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(459, 10);
            this.bunifuSeparator2.TabIndex = 37;
            this.bunifuSeparator2.Transparency = 100;
            this.bunifuSeparator2.Vertical = false;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.BackColor = System.Drawing.Color.Silver;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbCustomerName.Location = new System.Drawing.Point(216, 41);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(187, 21);
            this.cmbCustomerName.TabIndex = 40;
            this.cmbCustomerName.Text = "ग्राहकाचे नाव";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(146, 42);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(24, 19);
            this.lblTableNo.TabIndex = 38;
            this.lblTableNo.Text = "---";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 19);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "टेबल नंबर";
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.MediumPurple;
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.White;
            this.lblBill.Location = new System.Drawing.Point(0, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblBill.Size = new System.Drawing.Size(459, 35);
            this.lblBill.TabIndex = 55;
            this.lblBill.Text = "बिल तपशील";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.cmbItemName);
            this.panel2.Controls.Add(this.cmbSubCategory);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtItemId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 149);
            this.panel2.TabIndex = 56;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbItemName
            // 
            this.cmbItemName.BackColor = System.Drawing.Color.Silver;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbItemName.Location = new System.Drawing.Point(313, 41);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(125, 21);
            this.cmbItemName.TabIndex = 59;
            this.cmbItemName.Text = "ग्राहकाचे नाव";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbSubCategory.Location = new System.Drawing.Point(167, 41);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(125, 21);
            this.cmbSubCategory.TabIndex = 60;
            this.cmbSubCategory.Text = "ग्राहकाचे नाव";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbCategory.Location = new System.Drawing.Point(21, 41);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(125, 21);
            this.cmbCategory.TabIndex = 61;
            this.cmbCategory.Text = "ग्राहकाचे नाव";
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ButtonText = "मिळवा";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::Hotel_Billing_Software.Properties.Resources.plus;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(125, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(88, 29);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "मिळवा";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtQty
            // 
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.HintForeColor = System.Drawing.Color.Empty;
            this.txtQty.HintText = "प्रमाण";
            this.txtQty.isPassword = false;
            this.txtQty.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtQty.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQty.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtQty.LineThickness = 2;
            this.txtQty.Location = new System.Drawing.Point(21, 70);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(125, 29);
            this.txtQty.TabIndex = 54;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "एकूण";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtTotal.LineThickness = 2;
            this.txtTotal.Location = new System.Drawing.Point(313, 70);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 29);
            this.txtTotal.TabIndex = 55;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "किंमत";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtPrice.LineThickness = 2;
            this.txtPrice.Location = new System.Drawing.Point(167, 70);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 29);
            this.txtPrice.TabIndex = 56;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtItemId
            // 
            this.txtItemId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemId.HintForeColor = System.Drawing.Color.Empty;
            this.txtItemId.HintText = "आयटम कोड";
            this.txtItemId.isPassword = false;
            this.txtItemId.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtItemId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemId.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtItemId.LineThickness = 2;
            this.txtItemId.Location = new System.Drawing.Point(21, 7);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(85, 29);
            this.txtItemId.TabIndex = 57;
            this.txtItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 139);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(459, 10);
            this.bunifuSeparator3.TabIndex = 62;
            this.bunifuSeparator3.Transparency = 100;
            this.bunifuSeparator3.Vertical = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridBillDescription);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 160);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuSeparator4);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnKot);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 47);
            this.panel4.TabIndex = 58;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.ButtonText = "    Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 50D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(260, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnPrint.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(86, 32);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "    Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnKot
            // 
            this.btnKot.Activecolor = System.Drawing.Color.Tomato;
            this.btnKot.BackColor = System.Drawing.Color.Tomato;
            this.btnKot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKot.BorderRadius = 5;
            this.btnKot.ButtonText = "KOT";
            this.btnKot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKot.DisabledColor = System.Drawing.Color.Gray;
            this.btnKot.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKot.Iconimage")));
            this.btnKot.Iconimage_right = null;
            this.btnKot.Iconimage_right_Selected = null;
            this.btnKot.Iconimage_Selected = null;
            this.btnKot.IconMarginLeft = 0;
            this.btnKot.IconMarginRight = 0;
            this.btnKot.IconRightVisible = true;
            this.btnKot.IconRightZoom = 0D;
            this.btnKot.IconVisible = true;
            this.btnKot.IconZoom = 90D;
            this.btnKot.IsTab = false;
            this.btnKot.Location = new System.Drawing.Point(352, 12);
            this.btnKot.Name = "btnKot";
            this.btnKot.Normalcolor = System.Drawing.Color.Tomato;
            this.btnKot.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnKot.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKot.selected = false;
            this.btnKot.Size = new System.Drawing.Size(86, 32);
            this.btnKot.TabIndex = 53;
            this.btnKot.Text = "KOT";
            this.btnKot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKot.Textcolor = System.Drawing.Color.White;
            this.btnKot.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Green;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "जतन करा";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(172, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Green;
            this.btnSave.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(82, 32);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "जतन करा";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(459, 10);
            this.bunifuSeparator4.TabIndex = 56;
            this.bunifuSeparator4.Transparency = 100;
            this.bunifuSeparator4.Vertical = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbPaymentModel);
            this.panel5.Controls.Add(this.cmbWaiter);
            this.panel5.Controls.Add(this.txtGrandTotal);
            this.panel5.Controls.Add(this.txtSubTotal);
            this.panel5.Controls.Add(this.txtIGST);
            this.panel5.Controls.Add(this.btnSGST);
            this.panel5.Controls.Add(this.txtCGST);
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.btnRelease);
            this.panel5.Controls.Add(this.btnMerge);
            this.panel5.Controls.Add(this.btnSwitch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 387);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 89);
            this.panel5.TabIndex = 60;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(459, 10);
            this.bunifuSeparator1.TabIndex = 40;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnRelease
            // 
            this.btnRelease.Activecolor = System.Drawing.Color.Tomato;
            this.btnRelease.BackColor = System.Drawing.Color.Tomato;
            this.btnRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelease.BorderRadius = 5;
            this.btnRelease.ButtonText = "रिलीझ करा";
            this.btnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelease.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelease.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelease.Iconimage = global::Hotel_Billing_Software.Properties.Resources.verified;
            this.btnRelease.Iconimage_right = null;
            this.btnRelease.Iconimage_right_Selected = null;
            this.btnRelease.Iconimage_Selected = null;
            this.btnRelease.IconMarginLeft = 0;
            this.btnRelease.IconMarginRight = 0;
            this.btnRelease.IconRightVisible = true;
            this.btnRelease.IconRightZoom = 0D;
            this.btnRelease.IconVisible = true;
            this.btnRelease.IconZoom = 50D;
            this.btnRelease.IsTab = false;
            this.btnRelease.Location = new System.Drawing.Point(302, 33);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Normalcolor = System.Drawing.Color.Tomato;
            this.btnRelease.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnRelease.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelease.selected = false;
            this.btnRelease.Size = new System.Drawing.Size(99, 32);
            this.btnRelease.TabIndex = 36;
            this.btnRelease.Text = "रिलीझ करा";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelease.Textcolor = System.Drawing.Color.White;
            this.btnRelease.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Visible = false;
            // 
            // btnMerge
            // 
            this.btnMerge.Activecolor = System.Drawing.Color.Tomato;
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.btnMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMerge.BorderRadius = 5;
            this.btnMerge.ButtonText = "विलीन";
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.DisabledColor = System.Drawing.Color.Gray;
            this.btnMerge.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMerge.Iconimage = global::Hotel_Billing_Software.Properties.Resources.arrows_merge_pointing_to_right;
            this.btnMerge.Iconimage_right = null;
            this.btnMerge.Iconimage_right_Selected = null;
            this.btnMerge.Iconimage_Selected = null;
            this.btnMerge.IconMarginLeft = 0;
            this.btnMerge.IconMarginRight = 0;
            this.btnMerge.IconRightVisible = true;
            this.btnMerge.IconRightZoom = 0D;
            this.btnMerge.IconVisible = true;
            this.btnMerge.IconZoom = 50D;
            this.btnMerge.IsTab = false;
            this.btnMerge.Location = new System.Drawing.Point(235, 16);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.btnMerge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMerge.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMerge.selected = false;
            this.btnMerge.Size = new System.Drawing.Size(99, 32);
            this.btnMerge.TabIndex = 37;
            this.btnMerge.Text = "विलीन";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMerge.Textcolor = System.Drawing.Color.White;
            this.btnMerge.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Visible = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Activecolor = System.Drawing.Color.Tomato;
            this.btnSwitch.BackColor = System.Drawing.Color.Orange;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.BorderRadius = 5;
            this.btnSwitch.ButtonText = "स्विच करा";
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSwitch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSwitch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Iconimage")));
            this.btnSwitch.Iconimage_right = null;
            this.btnSwitch.Iconimage_right_Selected = null;
            this.btnSwitch.Iconimage_Selected = null;
            this.btnSwitch.IconMarginLeft = 0;
            this.btnSwitch.IconMarginRight = 0;
            this.btnSwitch.IconRightVisible = true;
            this.btnSwitch.IconRightZoom = 0D;
            this.btnSwitch.IconVisible = true;
            this.btnSwitch.IconZoom = 50D;
            this.btnSwitch.IsTab = false;
            this.btnSwitch.Location = new System.Drawing.Point(130, 16);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Normalcolor = System.Drawing.Color.Orange;
            this.btnSwitch.OnHovercolor = System.Drawing.Color.Gold;
            this.btnSwitch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSwitch.selected = false;
            this.btnSwitch.Size = new System.Drawing.Size(99, 32);
            this.btnSwitch.TabIndex = 38;
            this.btnSwitch.Text = "स्विच करा";
            this.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSwitch.Textcolor = System.Drawing.Color.White;
            this.btnSwitch.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Visible = false;
            // 
            // txtIGST
            // 
            this.txtIGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIGST.HintForeColor = System.Drawing.Color.Empty;
            this.txtIGST.HintText = "";
            this.txtIGST.isPassword = false;
            this.txtIGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtIGST.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtIGST.LineThickness = 2;
            this.txtIGST.Location = new System.Drawing.Point(236, 45);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Size = new System.Drawing.Size(158, 29);
            this.txtIGST.TabIndex = 43;
            this.txtIGST.Text = "IGST";
            this.txtIGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIGST.Visible = false;
            // 
            // btnSGST
            // 
            this.btnSGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSGST.HintForeColor = System.Drawing.Color.Empty;
            this.btnSGST.HintText = "";
            this.btnSGST.isPassword = false;
            this.btnSGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.btnSGST.LineIdleColor = System.Drawing.Color.Gray;
            this.btnSGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.btnSGST.LineThickness = 2;
            this.btnSGST.Location = new System.Drawing.Point(22, 70);
            this.btnSGST.Margin = new System.Windows.Forms.Padding(4);
            this.btnSGST.Name = "btnSGST";
            this.btnSGST.Size = new System.Drawing.Size(159, 29);
            this.btnSGST.TabIndex = 44;
            this.btnSGST.Text = "SGST";
            this.btnSGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSGST.Visible = false;
            // 
            // txtCGST
            // 
            this.txtCGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCGST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCGST.HintForeColor = System.Drawing.Color.Empty;
            this.txtCGST.HintText = "";
            this.txtCGST.isPassword = false;
            this.txtCGST.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtCGST.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCGST.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtCGST.LineThickness = 2;
            this.txtCGST.Location = new System.Drawing.Point(21, 33);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(159, 29);
            this.txtCGST.TabIndex = 45;
            this.txtCGST.Text = "CGST";
            this.txtCGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCGST.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "काढून टाका";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(235, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(88, 31);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "काढून टाका";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbPaymentModel
            // 
            this.cmbPaymentModel.BackColor = System.Drawing.Color.Silver;
            this.cmbPaymentModel.FormattingEnabled = true;
            this.cmbPaymentModel.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit",
            "Net Banking",
            "Not Paid"});
            this.cmbPaymentModel.Location = new System.Drawing.Point(49, 53);
            this.cmbPaymentModel.Name = "cmbPaymentModel";
            this.cmbPaymentModel.Size = new System.Drawing.Size(150, 21);
            this.cmbPaymentModel.TabIndex = 50;
            this.cmbPaymentModel.Text = "पे मोड";
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.BackColor = System.Drawing.Color.Silver;
            this.cmbWaiter.FormattingEnabled = true;
            this.cmbWaiter.Location = new System.Drawing.Point(49, 16);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Size = new System.Drawing.Size(150, 21);
            this.cmbWaiter.TabIndex = 51;
            this.cmbWaiter.Text = "वेटर";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrandTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtGrandTotal.HintText = "";
            this.txtGrandTotal.isPassword = false;
            this.txtGrandTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtGrandTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGrandTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtGrandTotal.LineThickness = 2;
            this.txtGrandTotal.Location = new System.Drawing.Point(249, 45);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(159, 29);
            this.txtGrandTotal.TabIndex = 48;
            this.txtGrandTotal.Text = " एकूण रककम";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtSubTotal.HintText = "";
            this.txtSubTotal.isPassword = false;
            this.txtSubTotal.LineFocusedColor = System.Drawing.Color.Tomato;
            this.txtSubTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSubTotal.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.txtSubTotal.LineThickness = 2;
            this.txtSubTotal.Location = new System.Drawing.Point(249, 8);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(158, 29);
            this.txtSubTotal.TabIndex = 49;
            this.txtSubTotal.Text = "उप एकूण";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gridBillDescription
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridBillDescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBillDescription.BackgroundColor = System.Drawing.Color.White;
            this.gridBillDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBillDescription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBillDescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBillDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBillDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBillDescription.DoubleBuffered = true;
            this.gridBillDescription.EnableHeadersVisualStyles = false;
            this.gridBillDescription.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridBillDescription.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridBillDescription.Location = new System.Drawing.Point(0, 0);
            this.gridBillDescription.Name = "gridBillDescription";
            this.gridBillDescription.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridBillDescription.Size = new System.Drawing.Size(459, 160);
            this.gridBillDescription.TabIndex = 9;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 523);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBillDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBill;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTableNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnKot;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIGST;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnSGST;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCGST;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelease;
        private Bunifu.Framework.UI.BunifuFlatButton btnMerge;
        private Bunifu.Framework.UI.BunifuFlatButton btnSwitch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.ComboBox cmbPaymentModel;
        private System.Windows.Forms.ComboBox cmbWaiter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGrandTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSubTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridBillDescription;
    }
}