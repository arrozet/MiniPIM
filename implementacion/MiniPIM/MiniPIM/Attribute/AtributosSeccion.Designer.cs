namespace MiniPIM.Attribute
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listAttributes = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.Attributes = new System.Windows.Forms.ToolStripMenuItem();
            this.Products = new System.Windows.Forms.ToolStripMenuItem();
            NewAttribute = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // NewAttribute
            // 
            NewAttribute.AutoSize = true;
            NewAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            NewAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            NewAttribute.Location = new System.Drawing.Point(0, 36);
            NewAttribute.Name = "NewAttribute";
            NewAttribute.Size = new System.Drawing.Size(765, 39);
            NewAttribute.TabIndex = 2;
            NewAttribute.Text = "+ New attribute";
            NewAttribute.UseVisualStyleBackColor = true;
            NewAttribute.Click += new System.EventHandler(this.NewAttribute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Attributes,
            this.Categories});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listAttributes
            // 
            this.listAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAttributes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAttributes.Location = new System.Drawing.Point(0, 76);
            this.listAttributes.Name = "listAttributes";
            this.listAttributes.RowHeadersWidth = 51;
            this.listAttributes.RowTemplate.Height = 24;
            this.listAttributes.Size = new System.Drawing.Size(765, 374);
            this.listAttributes.TabIndex = 3;
            this.listAttributes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAttributes_CellClick);
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
            // Attributes
            // 
            this.Attributes.BackColor = System.Drawing.Color.Indigo;
            this.Attributes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Attributes.ForeColor = System.Drawing.Color.White;
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(113, 32);
            this.Attributes.Text = "Attributes";
            this.Attributes.Click += new System.EventHandler(this.Attributes_Click);
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
            // AtributosSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.listAttributes);
            this.Controls.Add(NewAttribute);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AtributosSeccion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAttributes)).EndInit();
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
    }
}