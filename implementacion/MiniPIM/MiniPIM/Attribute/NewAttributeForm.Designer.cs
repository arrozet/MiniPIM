namespace MiniPIM.Attribute
{
    partial class NewAttributeForm
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
            this.AttributteNameLabel = new System.Windows.Forms.Label();
            this.AttributeTypeLabel = new System.Windows.Forms.Label();
            this.AttributeNameText = new System.Windows.Forms.TextBox();
            this.AttributeTypeText = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttributteNameLabel
            // 
            this.AttributteNameLabel.AutoSize = true;
            this.AttributteNameLabel.Location = new System.Drawing.Point(123, 164);
            this.AttributteNameLabel.Name = "AttributteNameLabel";
            this.AttributteNameLabel.Size = new System.Drawing.Size(114, 20);
            this.AttributteNameLabel.TabIndex = 0;
            this.AttributteNameLabel.Text = "Attribute name";
            // 
            // AttributeTypeLabel
            // 
            this.AttributeTypeLabel.AutoSize = true;
            this.AttributeTypeLabel.Location = new System.Drawing.Point(123, 366);
            this.AttributeTypeLabel.Name = "AttributeTypeLabel";
            this.AttributeTypeLabel.Size = new System.Drawing.Size(104, 20);
            this.AttributeTypeLabel.TabIndex = 1;
            this.AttributeTypeLabel.Text = "Attribute type\r\n";
            // 
            // AttributeNameText
            // 
            this.AttributeNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeNameText.Location = new System.Drawing.Point(126, 204);
            this.AttributeNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AttributeNameText.Name = "AttributeNameText";
            this.AttributeNameText.Size = new System.Drawing.Size(888, 26);
            this.AttributeNameText.TabIndex = 2;
            // 
            // AttributeTypeText
            // 
            this.AttributeTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeTypeText.FormattingEnabled = true;
            this.AttributeTypeText.Items.AddRange(new object[] {
            "Text",
            "Number",
            "Boolean",
            "Video",
            "Photo"});
            this.AttributeTypeText.Location = new System.Drawing.Point(126, 415);
            this.AttributeTypeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AttributeTypeText.Name = "AttributeTypeText";
            this.AttributeTypeText.Size = new System.Drawing.Size(888, 28);
            this.AttributeTypeText.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(683, 552);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 60);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(867, 552);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(136, 60);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create attribute";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NewAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 650);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AttributeTypeText);
            this.Controls.Add(this.AttributeNameText);
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.AttributteNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewAttributeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttributteNameLabel;
        private System.Windows.Forms.Label AttributeTypeLabel;
        private System.Windows.Forms.TextBox AttributeNameText;
        private System.Windows.Forms.ComboBox AttributeTypeText;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateButton;
    }
}