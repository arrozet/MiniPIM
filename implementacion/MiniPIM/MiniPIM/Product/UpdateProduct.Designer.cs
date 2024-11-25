using System.Drawing;

namespace MiniPIM.Product
{
    partial class UpdateProductControl
    {
        private System.ComponentModel.IContainer components = null;

        // Método para limpiar los recursos usados.



        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblGTIN = new System.Windows.Forms.Label();
            this.txtGTIN = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.pictureBoxThumbnail = new System.Windows.Forms.PictureBox();
            this.btnLoadThumbnail = new System.Windows.Forms.Button();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtLongDescription = new System.Windows.Forms.TextBox();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.textBoxA5 = new System.Windows.Forms.TextBox();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(148, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Product Details";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.lblSKU, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtSKU, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblGTIN, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtGTIN, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblProductName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtProductName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblShortDescription, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtShortDescription, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblThumbnail, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxThumbnail, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnLoadThumbnail, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.lblLongDescription, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblCategories, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtLongDescription, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.checkedListBoxCategories, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxA1, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.textBoxA2, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.textBoxA3, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.textBoxA4, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.textBoxA5, 1, 11);
            this.tableLayoutPanel.Controls.Add(this.lblA1, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.lblA2, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.lblA3, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.lblA4, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.lblA5, 0, 11);
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 12;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(781, 488);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblSKU
            // 
            this.lblSKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSKU.Location = new System.Drawing.Point(3, 0);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(150, 30);
            this.lblSKU.TabIndex = 0;
            this.lblSKU.Text = "SKU:";
            this.lblSKU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSKU
            // 
            this.txtSKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSKU.Location = new System.Drawing.Point(159, 3);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(462, 20);
            this.txtSKU.TabIndex = 1;
            this.txtSKU.TextChanged += new System.EventHandler(this.txtSKU_TextChanged);
            // 
            // lblGTIN
            // 
            this.lblGTIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGTIN.Location = new System.Drawing.Point(3, 30);
            this.lblGTIN.Name = "lblGTIN";
            this.lblGTIN.Size = new System.Drawing.Size(150, 30);
            this.lblGTIN.TabIndex = 2;
            this.lblGTIN.Text = "GTIN:";
            this.lblGTIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGTIN
            // 
            this.txtGTIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGTIN.Location = new System.Drawing.Point(159, 33);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(462, 20);
            this.txtGTIN.TabIndex = 3;
            this.txtGTIN.TextChanged += new System.EventHandler(this.txtGTIN_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Location = new System.Drawing.Point(3, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(150, 30);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(159, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(462, 20);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShortDescription.Location = new System.Drawing.Point(3, 90);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(150, 48);
            this.lblShortDescription.TabIndex = 6;
            this.lblShortDescription.Text = "Short Description:";
            this.lblShortDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShortDescription.Location = new System.Drawing.Point(159, 93);
            this.txtShortDescription.Multiline = true;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(462, 42);
            this.txtShortDescription.TabIndex = 7;
            this.txtShortDescription.TextChanged += new System.EventHandler(this.txtShortDescription_TextChanged);
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThumbnail.Location = new System.Drawing.Point(3, 138);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(150, 63);
            this.lblThumbnail.TabIndex = 8;
            this.lblThumbnail.Text = "Thumbnail:";
            this.lblThumbnail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxThumbnail
            // 
            this.pictureBoxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxThumbnail.Location = new System.Drawing.Point(159, 141);
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.Size = new System.Drawing.Size(462, 57);
            this.pictureBoxThumbnail.TabIndex = 9;
            this.pictureBoxThumbnail.TabStop = false;
            this.pictureBoxThumbnail.Click += new System.EventHandler(this.pictureBoxThumbnail_Click);
            // 
            // btnLoadThumbnail
            // 
            this.btnLoadThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadThumbnail.Location = new System.Drawing.Point(627, 141);
            this.btnLoadThumbnail.Name = "btnLoadThumbnail";
            this.btnLoadThumbnail.Size = new System.Drawing.Size(151, 57);
            this.btnLoadThumbnail.TabIndex = 10;
            this.btnLoadThumbnail.Text = "Load...";
            this.btnLoadThumbnail.Click += new System.EventHandler(this.BtnLoadThumbnail_Click);
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLongDescription.Location = new System.Drawing.Point(3, 201);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(150, 85);
            this.lblLongDescription.TabIndex = 11;
            this.lblLongDescription.Text = "Long Description:";
            this.lblLongDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategories
            // 
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategories.Location = new System.Drawing.Point(3, 286);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(150, 56);
            this.lblCategories.TabIndex = 13;
            this.lblCategories.Text = "Categories:";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLongDescription
            // 
            this.txtLongDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLongDescription.Location = new System.Drawing.Point(159, 204);
            this.txtLongDescription.Multiline = true;
            this.txtLongDescription.Name = "txtLongDescription";
            this.txtLongDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLongDescription.Size = new System.Drawing.Size(462, 79);
            this.txtLongDescription.TabIndex = 15;
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(159, 289);
            this.checkedListBoxCategories.MultiColumn = true;
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.ScrollAlwaysVisible = true;
            this.checkedListBoxCategories.Size = new System.Drawing.Size(462, 49);
            this.checkedListBoxCategories.TabIndex = 3;
            // 
            // textBoxA1
            // 
            this.textBoxA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA1.Enabled = false;
            this.textBoxA1.Location = new System.Drawing.Point(159, 345);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(462, 20);
            this.textBoxA1.TabIndex = 16;
            this.textBoxA1.Visible = false;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA2.Enabled = false;
            this.textBoxA2.Location = new System.Drawing.Point(159, 374);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(462, 20);
            this.textBoxA2.TabIndex = 17;
            this.textBoxA2.Visible = false;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA3.Enabled = false;
            this.textBoxA3.Location = new System.Drawing.Point(159, 403);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(462, 20);
            this.textBoxA3.TabIndex = 18;
            this.textBoxA3.Visible = false;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA4.Enabled = false;
            this.textBoxA4.Location = new System.Drawing.Point(159, 432);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.Size = new System.Drawing.Size(462, 20);
            this.textBoxA4.TabIndex = 19;
            this.textBoxA4.Visible = false;
            // 
            // textBoxA5
            // 
            this.textBoxA5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA5.Enabled = false;
            this.textBoxA5.Location = new System.Drawing.Point(159, 461);
            this.textBoxA5.Name = "textBoxA5";
            this.textBoxA5.Size = new System.Drawing.Size(462, 20);
            this.textBoxA5.TabIndex = 20;
            this.textBoxA5.Visible = false;
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA1.Enabled = false;
            this.lblA1.Location = new System.Drawing.Point(3, 342);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(150, 29);
            this.lblA1.TabIndex = 21;
            this.lblA1.Text = "Attribute 1:";
            this.lblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA1.Visible = false;
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA2.Enabled = false;
            this.lblA2.Location = new System.Drawing.Point(3, 371);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(150, 29);
            this.lblA2.TabIndex = 22;
            this.lblA2.Text = "Attribute 2: ";
            this.lblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA2.Visible = false;
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA3.Enabled = false;
            this.lblA3.Location = new System.Drawing.Point(3, 400);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(150, 29);
            this.lblA3.TabIndex = 23;
            this.lblA3.Text = "Attribute 3: ";
            this.lblA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA3.Visible = false;
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA4.Enabled = false;
            this.lblA4.Location = new System.Drawing.Point(3, 429);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(150, 29);
            this.lblA4.TabIndex = 24;
            this.lblA4.Text = "Attribute 4:";
            this.lblA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA4.Visible = false;
            // 
            // lblA5
            // 
            this.lblA5.AutoSize = true;
            this.lblA5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA5.Enabled = false;
            this.lblA5.Location = new System.Drawing.Point(3, 458);
            this.lblA5.Name = "lblA5";
            this.lblA5.Size = new System.Drawing.Size(150, 30);
            this.lblA5.TabIndex = 25;
            this.lblA5.Text = "Attribute 5: ";
            this.lblA5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA5.Visible = false;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.btnCancel);
            this.flowLayoutPanelButtons.Controls.Add(this.btnCreate);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(14, 544);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(774, 40);
            this.flowLayoutPanelButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(691, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Indigo;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(605, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Update";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // UpdateProductControl
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Name = "UpdateProductControl";
            this.Size = new System.Drawing.Size(794, 585);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblGTIN;
        private System.Windows.Forms.TextBox txtGTIN;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.PictureBox pictureBoxThumbnail;
        private System.Windows.Forms.Button btnLoadThumbnail;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
        private System.Windows.Forms.TextBox txtLongDescription;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxA5;
        public System.Windows.Forms.Label lblA1;
        public System.Windows.Forms.Label lblA2;
        public System.Windows.Forms.Label lblA3;
        public System.Windows.Forms.Label lblA4;
        public System.Windows.Forms.Label lblA5;
        private Producto productToUpdate;
        private bool isUpdate;
        private Image imagenOriginal;
    }
}
