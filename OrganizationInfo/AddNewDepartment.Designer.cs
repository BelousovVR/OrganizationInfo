namespace OrganizationInfo
{
    partial class AddNewDepartment
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.MaxNumberOfEmployees = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Название отдела:";
            // 
            // Name
            // 
            this.DepartmentName.Location = new System.Drawing.Point(13, 32);
            this.DepartmentName.Name = "Name";
            this.DepartmentName.Size = new System.Drawing.Size(309, 20);
            this.DepartmentName.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(309, 13);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Местоположение";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(12, 70);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(309, 20);
            this.Address.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(12, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(309, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Максимальное число сотрудников:";
            // 
            // MaxNumberOfEmployees
            // 
            this.MaxNumberOfEmployees.Location = new System.Drawing.Point(12, 108);
            this.MaxNumberOfEmployees.Name = "MaxNumberOfEmployees";
            this.MaxNumberOfEmployees.Size = new System.Drawing.Size(309, 20);
            this.MaxNumberOfEmployees.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(13, 147);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(142, 28);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(179, 147);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(142, 28);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 188);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.MaxNumberOfEmployees);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.textBox1);
            this.Name = "AddNewDepartment";
            this.Text = "AddNewDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DepartmentName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox MaxNumberOfEmployees;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}