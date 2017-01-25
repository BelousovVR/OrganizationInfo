namespace OrganizationInfo
{
    partial class CreateOrganization
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
            this.Create = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OrganizationLegalAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OrganizationName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 116);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(140, 26);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(218, 116);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Название организации:";
            // 
            // OrganizationLegalAddress
            // 
            this.OrganizationLegalAddress.Location = new System.Drawing.Point(12, 90);
            this.OrganizationLegalAddress.Name = "OrganizationLegalAddress";
            this.OrganizationLegalAddress.Size = new System.Drawing.Size(346, 20);
            this.OrganizationLegalAddress.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(346, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Юридический адрес:";
            // 
            // OrganizationName
            // 
            this.OrganizationName.Location = new System.Drawing.Point(12, 38);
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Size = new System.Drawing.Size(346, 20);
            this.OrganizationName.TabIndex = 6;
            // 
            // CreateOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 158);
            this.Controls.Add(this.OrganizationName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OrganizationLegalAddress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create);
            this.Name = "CreateOrganization";
            this.Text = "Create new organization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox OrganizationLegalAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox OrganizationName;
    }
}