﻿namespace Hotel_Billing_Software.GridPages
{
    partial class PurchaseMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipsPurchaseMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.btnNewPurchase = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPurchaseMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeadingButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsPurchaseMaster
            // 
            this.elipsPurchaseMaster.ElipseRadius = 0;
            this.elipsPurchaseMaster.TargetControl = this;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.btnNewPurchase);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 92);
            this.pnlHeadingButtons.TabIndex = 0;
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.ActiveBorderThickness = 1;
            this.btnNewPurchase.ActiveCornerRadius = 20;
            this.btnNewPurchase.ActiveFillColor = System.Drawing.Color.MediumPurple;
            this.btnNewPurchase.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewPurchase.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewPurchase.BackColor = System.Drawing.Color.White;
            this.btnNewPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPurchase.BackgroundImage")));
            this.btnNewPurchase.ButtonText = "New Purchase";
            this.btnNewPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPurchase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPurchase.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewPurchase.IdleBorderThickness = 1;
            this.btnNewPurchase.IdleCornerRadius = 20;
            this.btnNewPurchase.IdleFillColor = System.Drawing.Color.White;
            this.btnNewPurchase.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewPurchase.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewPurchase.Location = new System.Drawing.Point(607, 23);
            this.btnNewPurchase.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.Size = new System.Drawing.Size(157, 41);
            this.btnNewPurchase.TabIndex = 0;
            this.btnNewPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPurchase.Click += new System.EventHandler(this.btnNewPurchase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridPurchaseMaster);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 512);
            this.panel1.TabIndex = 1;
            // 
            // gridPurchaseMaster
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPurchaseMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchaseMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridPurchaseMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchaseMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchaseMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPurchaseMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPurchaseMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SR_NO,
            this.ItemName});
            this.gridPurchaseMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPurchaseMaster.DoubleBuffered = true;
            this.gridPurchaseMaster.EnableHeadersVisualStyles = false;
            this.gridPurchaseMaster.HeaderBgColor = System.Drawing.Color.Crimson;
            this.gridPurchaseMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridPurchaseMaster.Location = new System.Drawing.Point(0, 0);
            this.gridPurchaseMaster.Name = "gridPurchaseMaster";
            this.gridPurchaseMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPurchaseMaster.Size = new System.Drawing.Size(847, 512);
            this.gridPurchaseMaster.TabIndex = 1;
            // 
            // SR_NO
            // 
            this.SR_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SR_NO.HeaderText = "SR N0";
            this.SR_NO.Name = "SR_NO";
            this.SR_NO.Width = 64;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 97;
            // 
            // PurchaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeadingButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsPurchaseMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridPurchaseMaster;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn SR_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
    }
}