namespace OrganizationInfo
{
    partial class UpdateOrganization
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
            this.OrganizationName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OrganizationLegalAddress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrganizationName
            // 
            this.OrganizationName.Location = new System.Drawing.Point(10, 35);
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Size = new System.Drawing.Size(346, 20);
            this.OrganizationName.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(10, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(346, 13);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Юридический адрес:";
            // 
            // OrganizationLegalAddress
            // 
            this.OrganizationLegalAddress.Location = new System.Drawing.Point(10, 87);
            this.OrganizationLegalAddress.Name = "OrganizationLegalAddress";
            this.OrganizationLegalAddress.Size = new System.Drawing.Size(346, 20);
            this.OrganizationLegalAddress.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 13);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Название организации:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(216, 113);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 26);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(10, 113);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(140, 26);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 156);
            this.Controls.Add(this.OrganizationName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OrganizationLegalAddress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Update);
            this.Name = "UpdateOrganization";
            this.Text = "UpdateOrganization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrganizationName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox OrganizationLegalAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Update;
    }
}