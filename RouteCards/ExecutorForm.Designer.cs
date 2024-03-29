﻿
namespace RouteCards
{
    partial class ExecutorForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.departmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(23, 44);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(22, 111);
            this.secondNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.secondNameTextBox.TabIndex = 1;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(22, 164);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(193, 20);
            this.patronymicTextBox.TabIndex = 2;
            // 
            // departmentNumericUpDown
            // 
            this.departmentNumericUpDown.Location = new System.Drawing.Point(22, 207);
            this.departmentNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.departmentNumericUpDown.Name = "departmentNumericUpDown";
            this.departmentNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.departmentNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Подразделение";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(351, 194);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 19);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 309);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentNumericUpDown);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExecutorForm";
            this.Text = "Исполнитель";
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.NumericUpDown departmentNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
    }
}