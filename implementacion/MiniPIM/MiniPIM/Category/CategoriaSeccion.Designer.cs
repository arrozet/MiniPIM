namespace MiniPIM.Category
{
    partial class CategoriaSeccion
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
            System.Windows.Forms.Button NewCategory;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Attributes = new System.Windows.Forms.ToolStripMenuItem();
            this.Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listCategories = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoCategories = new System.Windows.Forms.Label();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            NewCategory = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCategory
            // 
            NewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            NewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            NewCategory.Location = new System.Drawing.Point(289, 2);
            NewCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            NewCategory.Name = "NewCategory";
            NewCategory.Size = new System.Drawing.Size(283, 63);
            NewCategory.TabIndex = 6;
            NewCategory.Text = "+ New category";
            NewCategory.UseVisualStyleBackColor = true;
            NewCategory.Click += new System.EventHandler(this.NewAttribute_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Attributes,
            this.Categories,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(574, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Indigo;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(83, 25);
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Attributes
            // 
            this.Attributes.BackColor = System.Drawing.Color.Indigo;
            this.Attributes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Attributes.ForeColor = System.Drawing.Color.White;
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(90, 25);
            this.Attributes.Text = "Attributes";
            this.Attributes.Click += new System.EventHandler(this.Attributes_Click);
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.Indigo;
            this.Categories.Enabled = false;
            this.Categories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Categories.ForeColor = System.Drawing.Color.Gray;
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(96, 25);
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listCategories
            // 
            this.listCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listCategories.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
            this.ID,
            this.Pencil,
            this.Delete,
            this.NumberOfProducts});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.listCategories.Location = new System.Drawing.Point(8, 102);
            this.listCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listCategories.Name = "listCategories";
            this.listCategories.RowHeadersWidth = 51;
            this.listCategories.RowTemplate.Height = 24;
            this.listCategories.Size = new System.Drawing.Size(557, 265);
            this.listCategories.TabIndex = 3;
            this.listCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listCategories_CellContentClick);
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
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "🗑️";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.tableLayoutPanel1.Controls.Add(NewCategory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 67);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoCategories
            // 
            this.NoCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoCategories.AutoSize = true;
            this.NoCategories.BackColor = System.Drawing.SystemColors.Control;
            this.NoCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NoCategories.Location = new System.Drawing.Point(67, 191);
            this.NoCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoCategories.Name = "NoCategories";
            this.NoCategories.Size = new System.Drawing.Size(441, 46);
            this.NoCategories.TabIndex = 5;
            this.NoCategories.Text = "NO CATEGORIES YET";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // CategoriaSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.NoCategories);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoriaSeccion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategories)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView listCategories;
        private System.Windows.Forms.ToolStripMenuItem Products;
        private System.Windows.Forms.ToolStripMenuItem Attributes;
        private System.Windows.Forms.ToolStripMenuItem Categories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewButtonColumn Pencil;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProducts;
        private System.Windows.Forms.Label NoCategories;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
    }
}