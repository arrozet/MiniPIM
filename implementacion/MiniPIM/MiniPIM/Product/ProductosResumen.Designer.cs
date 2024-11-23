namespace MiniPIM.Product
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
            this.New_product_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lapiz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Short_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thumnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.attributesToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(818, 31);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // New_product_Button
            // 
            this.New_product_Button.AutoSize = true;
            this.New_product_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.New_product_Button.Location = new System.Drawing.Point(160, 3);
            this.New_product_Button.Name = "New_product_Button";
            this.New_product_Button.Size = new System.Drawing.Size(155, 82);
            this.New_product_Button.TabIndex = 0;
            this.New_product_Button.Text = "+New Product";
            this.New_product_Button.UseVisualStyleBackColor = true;
            this.New_product_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.lapiz,
            this.ProductTitle,
            this.Short_description,
            this.Price,
            this.Thumnail,
            this.Categories});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 444);
            this.dataGridView1.TabIndex = 3;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "text";
            this.SKU.Frozen = true;
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 67;
            // 
            // lapiz
            // 
            this.lapiz.Frozen = true;
            this.lapiz.HeaderText = "⬇";
            this.lapiz.Name = "lapiz";
            this.lapiz.ReadOnly = true;
            this.lapiz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lapiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lapiz.Text = "✏️";
            this.lapiz.UseColumnTextForButtonValue = true;
            this.lapiz.Width = 41;
            // 
            // ProductTitle
            // 
            this.ProductTitle.Frozen = true;
            this.ProductTitle.HeaderText = "Product Title";
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            this.ProductTitle.Width = 122;
            // 
            // Short_description
            // 
            this.Short_description.Frozen = true;
            this.Short_description.HeaderText = "Short_description";
            this.Short_description.Name = "Short_description";
            this.Short_description.ReadOnly = true;
            this.Short_description.Width = 159;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 69;
            // 
            // Thumnail
            // 
            this.Thumnail.Frozen = true;
            this.Thumnail.HeaderText = "Thumbnail";
            this.Thumnail.Name = "Thumnail";
            this.Thumnail.ReadOnly = true;
            this.Thumnail.Width = 88;
            // 
            // Categories
            // 
            this.Categories.Frozen = true;
            this.Categories.HeaderText = "Categories";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            this.Categories.Width = 111;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.New_product_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 88);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 85);
            this.label2.TabIndex = 0;
            this.label2.Text = "All products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductosResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 475);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductosResumen";
            this.Text = "Form1";
            
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button New_product_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewButtonColumn lapiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Short_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Thumnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}