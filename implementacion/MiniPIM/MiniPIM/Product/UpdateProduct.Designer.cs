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
            this.lblCategories = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.cmbAttributes = new System.Windows.Forms.ComboBox();
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
            this.lblHeader.Size = new System.Drawing.Size(190, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Product Details";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel.Controls.Add(this.lblCategories, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.cmbCategories, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblAttributes, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.cmbAttributes, 1, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(500, 300);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblSKU
            // 
            this.lblSKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSKU.Location = new System.Drawing.Point(3, 0);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(144, 30);
            this.lblSKU.TabIndex = 0;
            this.lblSKU.Text = "SKU:";
            this.lblSKU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSKU
            // 
            this.txtSKU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSKU.Location = new System.Drawing.Point(153, 3);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(244, 22);
            this.txtSKU.TabIndex = 1;
            // 
            // lblGTIN
            // 
            this.lblGTIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGTIN.Location = new System.Drawing.Point(3, 30);
            this.lblGTIN.Name = "lblGTIN";
            this.lblGTIN.Size = new System.Drawing.Size(144, 30);
            this.lblGTIN.TabIndex = 2;
            this.lblGTIN.Text = "GTIN:";
            this.lblGTIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGTIN
            // 
            this.txtGTIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGTIN.Location = new System.Drawing.Point(153, 33);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(244, 22);
            this.txtGTIN.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Location = new System.Drawing.Point(3, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(144, 30);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(153, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(244, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShortDescription.Location = new System.Drawing.Point(3, 90);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(144, 60);
            this.lblShortDescription.TabIndex = 6;
            this.lblShortDescription.Text = "Short Description:";
            this.lblShortDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShortDescription.Location = new System.Drawing.Point(153, 93);
            this.txtShortDescription.Multiline = true;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(244, 54);
            this.txtShortDescription.TabIndex = 7;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThumbnail.Location = new System.Drawing.Point(3, 150);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(144, 80);
            this.lblThumbnail.TabIndex = 8;
            this.lblThumbnail.Text = "Thumbnail:";
            this.lblThumbnail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxThumbnail
            // 
            this.pictureBoxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxThumbnail.Location = new System.Drawing.Point(153, 153);
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.Size = new System.Drawing.Size(244, 74);
            this.pictureBoxThumbnail.TabIndex = 9;
            this.pictureBoxThumbnail.TabStop = false;
            // 
            // btnLoadThumbnail
            // 
            this.btnLoadThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadThumbnail.Location = new System.Drawing.Point(403, 153);
            this.btnLoadThumbnail.Name = "btnLoadThumbnail";
            this.btnLoadThumbnail.Size = new System.Drawing.Size(94, 74);
            this.btnLoadThumbnail.TabIndex = 10;
            this.btnLoadThumbnail.Text = "Load...";
            this.btnLoadThumbnail.Click += new System.EventHandler(this.BtnLoadThumbnail_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategories.Location = new System.Drawing.Point(3, 230);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(144, 30);
            this.lblCategories.TabIndex = 11;
            this.lblCategories.Text = "Categories:";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Location = new System.Drawing.Point(153, 233);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(244, 24);
            this.cmbCategories.TabIndex = 12;
            // 
            // lblAttributes
            // 
            this.lblAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttributes.Location = new System.Drawing.Point(3, 260);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(144, 40);
            this.lblAttributes.TabIndex = 13;
            this.lblAttributes.Text = "Attributes:";
            this.lblAttributes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbAttributes
            // 
            this.cmbAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttributes.Location = new System.Drawing.Point(153, 263);
            this.cmbAttributes.Name = "cmbAttributes";
            this.cmbAttributes.Size = new System.Drawing.Size(244, 24);
            this.cmbAttributes.TabIndex = 14;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.btnCancel);
            this.flowLayoutPanelButtons.Controls.Add(this.btnCreate);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(10, 360);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(500, 40);
            this.flowLayoutPanelButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(417, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Indigo;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(331, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Update";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // UpdateProductControl
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Name = "UpdateProductControl";
            this.Size = new System.Drawing.Size(518, 418);
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
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.ComboBox cmbAttributes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}
