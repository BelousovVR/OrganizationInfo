﻿namespace OrganizationInfo
{
    partial class UpdateEmployee
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
            this.Salary = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TaxNumber = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(174, 219);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(149, 26);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(10, 219);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(149, 26);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(10, 193);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(313, 20);
            this.Salary.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(10, 167);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(313, 13);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "З/П:";
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(10, 141);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(313, 20);
            this.Post.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(10, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(313, 13);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Должность:";
            // 
            // TaxNumber
            // 
            this.TaxNumber.Location = new System.Drawing.Point(10, 89);
            this.TaxNumber.Name = "TaxNumber";
            this.TaxNumber.Size = new System.Drawing.Size(313, 20);
            this.TaxNumber.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(10, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(313, 13);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "ИНН:";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(10, 37);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(313, 20);
            this.EmployeeName.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(313, 13);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "ФИО:";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TaxNumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TaxNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox textBox1;

    }
}