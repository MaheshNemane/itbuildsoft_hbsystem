﻿namespace Hotel_Billing_Software.GridPages
{
    partial class WineCategoryMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WineCategoryMaster));
            this.elipsWineCategoryMaster = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridWineCategoryMaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlHeadingButtons = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnNewWineCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gridWineCategoryMaster)).BeginInit();
            this.pnlHeadingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsWineCategoryMaster
            // 
            this.elipsWineCategoryMaster.ElipseRadius = 5;
            this.elipsWineCategoryMaster.TargetControl = this;
            // 
            // gridWineCategoryMaster
            // 
            this.gridWineCategoryMaster.AllowUserToAddRows = false;
            this.gridWineCategoryMaster.AllowUserToDeleteRows = false;
            this.gridWineCategoryMaster.AllowUserToOrderColumns = true;
            this.gridWineCategoryMaster.AllowUserToResizeColumns = false;
            this.gridWineCategoryMaster.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridWineCategoryMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridWineCategoryMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridWineCategoryMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridWineCategoryMaster.BackgroundColor = System.Drawing.Color.White;
            this.gridWineCategoryMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridWineCategoryMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridWineCategoryMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWineCategoryMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridWineCategoryMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWineCategoryMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWineCategoryMaster.DoubleBuffered = true;
            this.gridWineCategoryMaster.EnableHeadersVisualStyles = false;
            this.gridWineCategoryMaster.HeaderBgColor = System.Drawing.Color.MediumPurple;
            this.gridWineCategoryMaster.HeaderForeColor = System.Drawing.Color.White;
            this.gridWineCategoryMaster.Location = new System.Drawing.Point(0, 65);
            this.gridWineCategoryMaster.Name = "gridWineCategoryMaster";
            this.gridWineCategoryMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridWineCategoryMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWineCategoryMaster.Size = new System.Drawing.Size(847, 539);
            this.gridWineCategoryMaster.TabIndex = 11;
            // 
            // pnlHeadingButtons
            // 
            this.pnlHeadingButtons.Controls.Add(this.bunifuSeparator1);
            this.pnlHeadingButtons.Controls.Add(this.btnNewWineCategory);
            this.pnlHeadingButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadingButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadingButtons.Name = "pnlHeadingButtons";
            this.pnlHeadingButtons.Size = new System.Drawing.Size(847, 65);
            this.pnlHeadingButtons.TabIndex = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 55);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(847, 10);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 100;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnNewWineCategory
            // 
            this.btnNewWineCategory.ActiveBorderThickness = 1;
            this.btnNewWineCategory.ActiveCornerRadius = 20;
            this.btnNewWineCategory.ActiveFillColor = System.Drawing.Color.White;
            this.btnNewWineCategory.ActiveForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewWineCategory.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewWineCategory.BackColor = System.Drawing.Color.White;
            this.btnNewWineCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewWineCategory.BackgroundImage")));
            this.btnNewWineCategory.ButtonText = "नवीन वाईनचा प्रकार";
            this.btnNewWineCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewWineCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWineCategory.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnNewWineCategory.IdleBorderThickness = 1;
            this.btnNewWineCategory.IdleCornerRadius = 20;
            this.btnNewWineCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnNewWineCategory.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.btnNewWineCategory.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.btnNewWineCategory.Location = new System.Drawing.Point(610, 15);
            this.btnNewWineCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewWineCategory.Name = "btnNewWineCategory";
            this.btnNewWineCategory.Size = new System.Drawing.Size(148, 35);
            this.btnNewWineCategory.TabIndex = 0;
            this.btnNewWineCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewWineCategory.Click += new System.EventHandler(this.btnNewWineCategory_Click);
            // 
            // WineCategoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 604);
            this.Controls.Add(this.gridWineCategoryMaster);
            this.Controls.Add(this.pnlHeadingButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WineCategoryMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wine Category Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridWineCategoryMaster)).EndInit();
            this.pnlHeadingButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipsWineCategoryMaster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridWineCategoryMaster;
        private System.Windows.Forms.Panel pnlHeadingButtons;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewWineCategory;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}