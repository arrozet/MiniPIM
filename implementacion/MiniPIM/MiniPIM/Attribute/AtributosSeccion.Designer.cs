﻿namespace MiniPIM.Attribute
{
    partial class AtributosSeccion
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
            System.Windows.Forms.Button NewAttribute;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Attributes = new System.Windows.Forms.ToolStripMenuItem();
            this.Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listAttributes = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoAttributes = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            NewAttribute = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAttributes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAttribute
            // 
            NewAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            NewAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            NewAttribute.Location = new System.Drawing.Point(593, 2);
            NewAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            NewAttribute.Name = "NewAttribute";
            NewAttribute.Size = new System.Drawing.Size(585, 78);
            NewAttribute.TabIndex = 6;
            NewAttribute.Text = "+ New attribute";
            NewAttribute.UseVisualStyleBackColor = true;
            NewAttribute.Click += new System.EventHandler(this.NewAttribute_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Attributes,
            this.Categories,
            this.accountToolStripMenuItem,
            this.relationshipsToolStripMenuItem,
            this.Export});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Indigo;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(103, 32);
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Attributes
            // 
            this.Attributes.BackColor = System.Drawing.Color.Indigo;
            this.Attributes.Enabled = false;
            this.Attributes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Attributes.ForeColor = System.Drawing.Color.Gray;
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(113, 32);
            this.Attributes.Text = "Attributes";
            this.Attributes.Click += new System.EventHandler(this.Attributes_Click);
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.Indigo;
            this.Categories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Categories.ForeColor = System.Drawing.Color.White;
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(119, 32);
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // relationshipsToolStripMenuItem
            // 
            this.relationshipsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.relationshipsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relationshipsToolStripMenuItem.Name = "relationshipsToolStripMenuItem";
            this.relationshipsToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.relationshipsToolStripMenuItem.Text = "Relationships";
            this.relationshipsToolStripMenuItem.Click += new System.EventHandler(this.relationshipsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listAttributes
            // 
            this.listAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAttributes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listAttributes.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
            this.ID,
            this.Pencil,
            this.Delete,
            this.Type,
            this.NumberOfProducts});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listAttributes.DefaultCellStyle = dataGridViewCellStyle2;
            this.listAttributes.Location = new System.Drawing.Point(0, 125);
            this.listAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAttributes.Name = "listAttributes";
            this.listAttributes.RowHeadersWidth = 51;
            this.listAttributes.RowTemplate.Height = 24;
            this.listAttributes.Size = new System.Drawing.Size(1159, 466);
            this.listAttributes.TabIndex = 3;
            this.listAttributes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAttributes_CellClick);
            // 
            // Label
            // 
            this.Label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Label.HeaderText = "Name";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            this.Label.Width = 93;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Pencil
            // 
            this.Pencil.HeaderText = "↓";
            this.Pencil.MinimumWidth = 6;
            this.Pencil.Name = "Pencil";
            this.Pencil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pencil.Text = "✏️";
            this.Pencil.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "X";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "🗑️";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // NumberOfProducts
            // 
            this.NumberOfProducts.HeaderText = "Number of products";
            this.NumberOfProducts.MinimumWidth = 6;
            this.NumberOfProducts.Name = "NumberOfProducts";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(NewAttribute, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 82);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Attributes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoAttributes
            // 
            this.NoAttributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoAttributes.AutoSize = true;
            this.NoAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NoAttributes.Location = new System.Drawing.Point(341, 329);
            this.NoAttributes.Name = "NoAttributes";
            this.NoAttributes.Size = new System.Drawing.Size(534, 58);
            this.NoAttributes.TabIndex = 5;
            this.NoAttributes.Text = "NO ATTRIBUTES YET";
            this.NoAttributes.Visible = false;
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Export.ForeColor = System.Drawing.Color.White;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(83, 32);
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // AtributosSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 590);
            this.Controls.Add(this.NoAttributes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listAttributes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AtributosSeccion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAttributes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView listAttributes;
        private System.Windows.Forms.ToolStripMenuItem Products;
        private System.Windows.Forms.ToolStripMenuItem Attributes;
        private System.Windows.Forms.ToolStripMenuItem Categories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NoAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewButtonColumn Pencil;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProducts;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationshipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Export;
    }
}