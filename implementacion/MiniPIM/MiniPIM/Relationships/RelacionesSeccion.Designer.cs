namespace MiniPIM.Relationships
{
    partial class RelacionesSeccion
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
            System.Windows.Forms.Button NewRelation;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Attributes = new System.Windows.Forms.ToolStripMenuItem();
            this.Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.Relationships = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listRelations = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoRelationships = new System.Windows.Forms.Label();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            NewRelation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRelations)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRelation
            // 
            NewRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            NewRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            NewRelation.Location = new System.Drawing.Point(289, 3);
            NewRelation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            NewRelation.Name = "NewRelation";
            NewRelation.Size = new System.Drawing.Size(283, 62);
            NewRelation.TabIndex = 6;
            NewRelation.Text = "+ New relationship";
            NewRelation.UseVisualStyleBackColor = true;
            NewRelation.Click += new System.EventHandler(this.NewRelation_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Attributes,
            this.Categories,
            this.Relationships,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(574, 27);
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
            this.Attributes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Attributes.ForeColor = System.Drawing.Color.White;
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(90, 25);
            this.Attributes.Text = "Attributes";
            this.Attributes.Click += new System.EventHandler(this.Attributes_Click_1);
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.Indigo;
            this.Categories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Categories.ForeColor = System.Drawing.Color.White;
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(96, 25);
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Relationships
            // 
            this.Relationships.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Relationships.ForeColor = System.Drawing.Color.Gray;
            this.Relationships.Name = "Relationships";
            this.Relationships.Size = new System.Drawing.Size(115, 25);
            this.Relationships.Text = "Relationships";
            this.Relationships.Click += new System.EventHandler(this.Relationships_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listRelations
            // 
            this.listRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRelations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listRelations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listRelations.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listRelations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRelations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
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
            this.listRelations.DefaultCellStyle = dataGridViewCellStyle2;
            this.listRelations.Location = new System.Drawing.Point(7, 101);
            this.listRelations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listRelations.Name = "listRelations";
            this.listRelations.RowHeadersWidth = 51;
            this.listRelations.RowTemplate.Height = 24;
            this.listRelations.Size = new System.Drawing.Size(557, 265);
            this.listRelations.TabIndex = 3;
            this.listRelations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listRelations_CellClick);
            // 
            // Label
            // 
            this.Label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Label.HeaderText = "Name";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            this.Label.Width = 93;
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
            this.tableLayoutPanel1.Controls.Add(NewRelation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 68);
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
            this.label1.Size = new System.Drawing.Size(283, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Relationships";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoRelationships
            // 
            this.NoRelationships.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoRelationships.AutoSize = true;
            this.NoRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NoRelationships.Location = new System.Drawing.Point(47, 233);
            this.NoRelationships.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoRelationships.Name = "NoRelationships";
            this.NoRelationships.Size = new System.Drawing.Size(498, 46);
            this.NoRelationships.TabIndex = 5;
            this.NoRelationships.Text = "NO RELATIONSHIPS YET";
            this.NoRelationships.Visible = false;
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
            // RelacionesSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 365);
            this.Controls.Add(this.NoRelationships);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listRelations);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RelacionesSeccion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRelations)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView listRelations;
        private System.Windows.Forms.ToolStripMenuItem Products;
        private System.Windows.Forms.ToolStripMenuItem Categories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NoRelationships;
        private System.Windows.Forms.ToolStripMenuItem Relationships;
        private System.Windows.Forms.ToolStripMenuItem Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewButtonColumn Pencil;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProducts;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
    }
}