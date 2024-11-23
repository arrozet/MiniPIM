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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vista_Tabla_Button = new System.Windows.Forms.Button();
            this.Vista_Resumen_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.All_Products_label = new System.Windows.Forms.Label();
            this.New_Product_Button = new System.Windows.Forms.Button();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.attributesToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(993, 31);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Pencil,
            this.ProductTitle,
            this.ShortDescription,
            this.Thumbnail,
            this.Categories});
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(5, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(988, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // Vista_Tabla_Button
            // 
            this.Vista_Tabla_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vista_Tabla_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vista_Tabla_Button.Location = new System.Drawing.Point(615, 3);
            this.Vista_Tabla_Button.Name = "Vista_Tabla_Button";
            this.Vista_Tabla_Button.Size = new System.Drawing.Size(200, 57);
            this.Vista_Tabla_Button.TabIndex = 2;
            this.Vista_Tabla_Button.Text = "📊";
            this.Vista_Tabla_Button.UseVisualStyleBackColor = true;
            // 
            // Vista_Resumen_Button
            // 
            this.Vista_Resumen_Button.AutoSize = true;
            this.Vista_Resumen_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vista_Resumen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vista_Resumen_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Vista_Resumen_Button.Location = new System.Drawing.Point(411, 3);
            this.Vista_Resumen_Button.Name = "Vista_Resumen_Button";
            this.Vista_Resumen_Button.Size = new System.Drawing.Size(198, 57);
            this.Vista_Resumen_Button.TabIndex = 1;
            this.Vista_Resumen_Button.Text = "📋";
            this.Vista_Resumen_Button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Vista_Resumen_Button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Vista_Tabla_Button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.All_Products_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.New_Product_Button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 62);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // All_Products_label
            // 
            this.All_Products_label.AutoSize = true;
            this.All_Products_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All_Products_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Products_label.Location = new System.Drawing.Point(3, 0);
            this.All_Products_label.Name = "All_Products_label";
            this.All_Products_label.Size = new System.Drawing.Size(198, 63);
            this.All_Products_label.TabIndex = 3;
            this.All_Products_label.Text = "All Products";
            this.All_Products_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_Product_Button
            // 
            this.New_Product_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New_Product_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Product_Button.Location = new System.Drawing.Point(207, 3);
            this.New_Product_Button.Name = "New_Product_Button";
            this.New_Product_Button.Size = new System.Drawing.Size(198, 57);
            this.New_Product_Button.TabIndex = 4;
            this.New_Product_Button.Text = "+ New Product";
            this.New_Product_Button.UseVisualStyleBackColor = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "text";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Pencil
            // 
            this.Pencil.HeaderText = "⬇";
            this.Pencil.Name = "Pencil";
            this.Pencil.ReadOnly = true;
            this.Pencil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pencil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Pencil.Text = "✏️";
            this.Pencil.UseColumnTextForButtonValue = true;
            // 
            // ProductTitle
            // 
            this.ProductTitle.HeaderText = "Product Title";
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            // 
            // ShortDescription
            // 
            this.ShortDescription.HeaderText = "Short Description";
            this.ShortDescription.Name = "ShortDescription";
            this.ShortDescription.ReadOnly = true;
            // 
            // Thumbnail
            // 
            this.Thumbnail.HeaderText = "Thumbnail";
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.ReadOnly = true;
            // 
            // Categories
            // 
            this.Categories.HeaderText = "Categories";
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            // 
            // ProductosResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(993, 471);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewButtonColumn lapiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Short_description;
        private System.Windows.Forms.DataGridViewImageColumn Thumnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.Button Vista_Tabla_Button;
        private System.Windows.Forms.Button Vista_Resumen_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label All_Products_label;
        private System.Windows.Forms.Button New_Product_Button;
        private System.Windows.Forms.DataGridViewButtonColumn Pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortDescription;
        private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
    }
}