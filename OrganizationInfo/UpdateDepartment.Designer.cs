namespace OrganizationInfo
{
    partial class UpdateDepartment
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.MaxNumberOfEmployees = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(182, 150);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(142, 28);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(16, 150);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(142, 28);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // MaxNumberOfEmployees
            // 
            this.MaxNumberOfEmployees.Location = new System.Drawing.Point(15, 111);
            this.MaxNumberOfEmployees.Name = "MaxNumberOfEmployees";
            this.MaxNumberOfEmployees.Size = new System.Drawing.Size(309, 20);
            this.MaxNumberOfEmployees.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(15, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(309, 13);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Максимальное число сотрудников:";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(15, 73);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(309, 20);
            this.Address.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(15, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(309, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Местоположение";
            // 
            // DepartmentName
            // 
            this.DepartmentName.Location = new System.Drawing.Point(16, 35);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(309, 20);
            this.DepartmentName.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Название отдела:";
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 199);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.MaxNumberOfEmployees);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateDepartment";
            this.Text = "UpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox MaxNumberOfEmployees;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox DepartmentName;
        private System.Windows.Forms.TextBox textBox1;
    }
}