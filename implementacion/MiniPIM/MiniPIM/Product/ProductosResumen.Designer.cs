﻿namespace MiniPIM.Product
{
    partial class ProductosResumen
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
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.relationshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pencil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.All_Products_label = new System.Windows.Forms.Label();
            this.New_Product_Button = new System.Windows.Forms.Button();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.NoAttributes = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // attributesToolStripMenuItem
            // 
            this.attributesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            this.attributesToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.attributesToolStripMenuItem.Text = "Attributes";
            this.attributesToolStripMenuItem.Click += new System.EventHandler(this.attributesToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.attributesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.relationshipsToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(993, 29);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // relationshipsToolStripMenuItem
            // 
            this.relationshipsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.relationshipsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relationshipsToolStripMenuItem.Name = "relationshipsToolStripMenuItem";
            this.relationshipsToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.relationshipsToolStripMenuItem.Text = "Relationships";
            this.relationshipsToolStripMenuItem.Click += new System.EventHandler(this.relationshipsToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pencil,
            this.Delete,
            this.Thumbnail,
            this.SKU,
            this.ProductTitle,
            this.ShortDescription,
            this.Categories});
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(5, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(988, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Pencil
            // 
            this.Pencil.FillWeight = 63.85116F;
            this.Pencil.HeaderText = "⬇";
            this.Pencil.MinimumWidth = 6;
            this.Pencil.Name = "Pencil";
            this.Pencil.ReadOnly = true;
            this.Pencil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pencil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Pencil.Text = "✏️";
            this.Pencil.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 71.06602F;
            this.Delete.HeaderText = "X";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "🗑️";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Thumbnail
            // 
            this.Thumbnail.FillWeight = 113.0166F;
            this.Thumbnail.HeaderText = "Thumbnail";
            this.Thumbnail.MinimumWidth = 6;
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "text";
            this.SKU.FillWeight = 113.0166F;
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // ProductTitle
            // 
            this.ProductTitle.FillWeight = 113.0166F;
            this.ProductTitle.HeaderText = "Product Title";
            this.ProductTitle.MinimumWidth = 6;
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            // 
            // ShortDescription
            // 
            this.ShortDescription.FillWeight = 113.0166F;
            this.ShortDescription.HeaderText = "Short Description";
            this.ShortDescription.MinimumWidth = 6;
            this.ShortDescription.Name = "ShortDescription";
            this.ShortDescription.ReadOnly = true;
            // 
            // Categories
            // 
            this.Categories.FillWeight = 113.0166F;
            this.Categories.HeaderText = "Categories";
            this.Categories.MinimumWidth = 6;
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV.AutoSize = true;
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnExportCSV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportCSV.Location = new System.Drawing.Point(499, 3);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(242, 57);
            this.btnExportCSV.TabIndex = 1;
            this.btnExportCSV.Text = "➥";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnExportCSV, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.All_Products_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.New_Product_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoriesListBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 62);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // All_Products_label
            // 
            this.All_Products_label.AutoSize = true;
            this.All_Products_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All_Products_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Products_label.Location = new System.Drawing.Point(3, 0);
            this.All_Products_label.Name = "All_Products_label";
            this.All_Products_label.Size = new System.Drawing.Size(242, 63);
            this.All_Products_label.TabIndex = 3;
            this.All_Products_label.Text = "All Products";
            this.All_Products_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_Product_Button
            // 
            this.New_Product_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New_Product_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Product_Button.Location = new System.Drawing.Point(251, 3);
            this.New_Product_Button.Name = "New_Product_Button";
            this.New_Product_Button.Size = new System.Drawing.Size(242, 57);
            this.New_Product_Button.TabIndex = 4;
            this.New_Product_Button.Text = "+ New Product";
            this.New_Product_Button.UseVisualStyleBackColor = true;
            this.New_Product_Button.Click += new System.EventHandler(this.New_Product_Button_Click);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 20;
            this.categoriesListBox.Location = new System.Drawing.Point(747, 3);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(243, 57);
            this.categoriesListBox.TabIndex = 5;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // NoAttributes
            // 
            this.NoAttributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoAttributes.AutoSize = true;
            this.NoAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NoAttributes.Location = new System.Drawing.Point(281, 232);
            this.NoAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoAttributes.Name = "NoAttributes";
            this.NoAttributes.Size = new System.Drawing.Size(404, 46);
            this.NoAttributes.TabIndex = 6;
            this.NoAttributes.Text = "NO PRODUCTS YET";
            this.NoAttributes.Visible = false;
            this.NoAttributes.Click += new System.EventHandler(this.NoAttributes_Click);
            // 
            // ProductosResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(993, 471);
            this.Controls.Add(this.NoAttributes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductosResumen";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn lapiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Short_description;
        private System.Windows.Forms.DataGridViewImageColumn Thumnail;
        private System.Windows.Forms.Button Vista_Tabla_Button;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label All_Products_label;
        private System.Windows.Forms.Button New_Product_Button;
        private System.Windows.Forms.DataGridViewButtonColumn Pencil;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.Label NoAttributes;
        private System.Windows.Forms.ToolStripMenuItem relationshipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ListBox categoriesListBox;
    }
}