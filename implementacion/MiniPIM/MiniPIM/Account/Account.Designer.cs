namespace MiniPIM.Account
{
    partial class Account
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblRelationships = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblCreationDateValue = new System.Windows.Forms.Label();
            this.lblProductsValue = new System.Windows.Forms.Label();
            this.lblAttributesValue = new System.Windows.Forms.Label();
            this.lblCategoriesValue = new System.Windows.Forms.Label();
            this.lblRelationshipsValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Profile";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.Indigo;
            this.lblUsername.Location = new System.Drawing.Point(302, 110);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Indigo;
            this.lblEmail.Location = new System.Drawing.Point(302, 146);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCreationDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblCreationDate.Location = new System.Drawing.Point(302, 180);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(95, 16);
            this.lblCreationDate.TabIndex = 3;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Arial", 10F);
            this.lblProducts.ForeColor = System.Drawing.Color.Indigo;
            this.lblProducts.Location = new System.Drawing.Point(302, 212);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(131, 16);
            this.lblProducts.TabIndex = 4;
            this.lblProducts.Text = "Number of products";
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAttributes.ForeColor = System.Drawing.Color.Indigo;
            this.lblAttributes.Location = new System.Drawing.Point(302, 251);
            this.lblAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(135, 16);
            this.lblAttributes.TabIndex = 5;
            this.lblAttributes.Text = "Number of attributes";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCategories.ForeColor = System.Drawing.Color.Indigo;
            this.lblCategories.Location = new System.Drawing.Point(302, 290);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(142, 16);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Number of categories";
            this.lblCategories.Click += new System.EventHandler(this.lblCategories_Click);
            // 
            // lblRelationships
            // 
            this.lblRelationships.AutoSize = true;
            this.lblRelationships.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRelationships.ForeColor = System.Drawing.Color.Indigo;
            this.lblRelationships.Location = new System.Drawing.Point(302, 324);
            this.lblRelationships.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRelationships.Name = "lblRelationships";
            this.lblRelationships.Size = new System.Drawing.Size(156, 16);
            this.lblRelationships.TabIndex = 7;
            this.lblRelationships.Text = "Number of relationships";
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblUsernameValue.Location = new System.Drawing.Point(557, 110);
            this.lblUsernameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(79, 16);
            this.lblUsernameValue.TabIndex = 8;
            this.lblUsernameValue.Text = "[Username]";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEmailValue.Location = new System.Drawing.Point(557, 146);
            this.lblEmailValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(49, 16);
            this.lblEmailValue.TabIndex = 9;
            this.lblEmailValue.Text = "[Email]";
            // 
            // lblCreationDateValue
            // 
            this.lblCreationDateValue.AutoSize = true;
            this.lblCreationDateValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCreationDateValue.Location = new System.Drawing.Point(557, 180);
            this.lblCreationDateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationDateValue.Name = "lblCreationDateValue";
            this.lblCreationDateValue.Size = new System.Drawing.Size(99, 16);
            this.lblCreationDateValue.TabIndex = 10;
            this.lblCreationDateValue.Text = "[CreationDate]";
            // 
            // lblProductsValue
            // 
            this.lblProductsValue.AutoSize = true;
            this.lblProductsValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblProductsValue.Location = new System.Drawing.Point(557, 212);
            this.lblProductsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductsValue.Name = "lblProductsValue";
            this.lblProductsValue.Size = new System.Drawing.Size(71, 16);
            this.lblProductsValue.TabIndex = 11;
            this.lblProductsValue.Text = "[Products]";
            // 
            // lblAttributesValue
            // 
            this.lblAttributesValue.AutoSize = true;
            this.lblAttributesValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAttributesValue.Location = new System.Drawing.Point(557, 251);
            this.lblAttributesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttributesValue.Name = "lblAttributesValue";
            this.lblAttributesValue.Size = new System.Drawing.Size(75, 16);
            this.lblAttributesValue.TabIndex = 12;
            this.lblAttributesValue.Text = "[Attributes]";
            // 
            // lblCategoriesValue
            // 
            this.lblCategoriesValue.AutoSize = true;
            this.lblCategoriesValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCategoriesValue.Location = new System.Drawing.Point(557, 290);
            this.lblCategoriesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriesValue.Name = "lblCategoriesValue";
            this.lblCategoriesValue.Size = new System.Drawing.Size(84, 16);
            this.lblCategoriesValue.TabIndex = 13;
            this.lblCategoriesValue.Text = "[Categories]";
            // 
            // lblRelationshipsValue
            // 
            this.lblRelationshipsValue.AutoSize = true;
            this.lblRelationshipsValue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRelationshipsValue.Location = new System.Drawing.Point(557, 324);
            this.lblRelationshipsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRelationshipsValue.Name = "lblRelationshipsValue";
            this.lblRelationshipsValue.Size = new System.Drawing.Size(100, 16);
            this.lblRelationshipsValue.TabIndex = 14;
            this.lblRelationshipsValue.Text = "[Relationships]";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(886, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 24);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(788, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 595);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblAttributes);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblRelationships);
            this.Controls.Add(this.lblUsernameValue);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblCreationDateValue);
            this.Controls.Add(this.lblProductsValue);
            this.Controls.Add(this.lblAttributesValue);
            this.Controls.Add(this.lblCategoriesValue);
            this.Controls.Add(this.lblRelationshipsValue);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account";
            this.Text = "My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblRelationships;

        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblCreationDateValue;
        private System.Windows.Forms.Label lblProductsValue;
        private System.Windows.Forms.Label lblAttributesValue;
        private System.Windows.Forms.Label lblCategoriesValue;
        private System.Windows.Forms.Label lblRelationshipsValue;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExport;
    }
}