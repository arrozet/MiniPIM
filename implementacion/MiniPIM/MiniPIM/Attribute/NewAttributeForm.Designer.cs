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
            this.AttributteNameLabel.Location = new System.Drawing.Point(109, 131);
            this.AttributteNameLabel.Name = "AttributteNameLabel";
            this.AttributteNameLabel.Size = new System.Drawing.Size(92, 16);
            this.AttributteNameLabel.TabIndex = 0;
            this.AttributteNameLabel.Text = "Attribute name";
            // 
            // AttributeTypeLabel
            // 
            this.AttributeTypeLabel.AutoSize = true;
            this.AttributeTypeLabel.Location = new System.Drawing.Point(109, 293);
            this.AttributeTypeLabel.Name = "AttributeTypeLabel";
            this.AttributeTypeLabel.Size = new System.Drawing.Size(84, 16);
            this.AttributeTypeLabel.TabIndex = 1;
            this.AttributeTypeLabel.Text = "Attribute type\r\n";
            // 
            // AttributeNameText
            // 
            this.AttributeNameText.Location = new System.Drawing.Point(112, 163);
            this.AttributeNameText.Name = "AttributeNameText";
            this.AttributeNameText.Size = new System.Drawing.Size(790, 22);
            this.AttributeNameText.TabIndex = 2;
            // 
            // AttributeTypeText
            // 
            this.AttributeTypeText.FormattingEnabled = true;
            this.AttributeTypeText.Items.AddRange(new object[] {
            "Text",
            "Number",
            "Boolean",
            "Video",
            "Image"});
            this.AttributeTypeText.Location = new System.Drawing.Point(112, 332);
            this.AttributeTypeText.Name = "AttributeTypeText";
            this.AttributeTypeText.Size = new System.Drawing.Size(790, 24);
            this.AttributeTypeText.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(607, 442);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 48);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(771, 442);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(121, 48);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create attribute";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NewAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 520);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AttributeTypeText);
            this.Controls.Add(this.AttributeNameText);
            this.Controls.Add(this.AttributeTypeLabel);
            this.Controls.Add(this.AttributteNameLabel);
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