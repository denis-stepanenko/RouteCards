
namespace RouteCards
{
    partial class UserForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.departmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.generatePsdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // departmentNumericUpDown
            // 
            this.departmentNumericUpDown.Location = new System.Drawing.Point(13, 97);
            this.departmentNumericUpDown.Name = "departmentNumericUpDown";
            this.departmentNumericUpDown.Size = new System.Drawing.Size(221, 20);
            this.departmentNumericUpDown.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(13, 155);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(221, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Подразделение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // roleIdNumericUpDown
            // 
            this.roleIdNumericUpDown.Location = new System.Drawing.Point(13, 211);
            this.roleIdNumericUpDown.Name = "roleIdNumericUpDown";
            this.roleIdNumericUpDown.Size = new System.Drawing.Size(221, 20);
            this.roleIdNumericUpDown.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Роль:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(340, 267);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // generatePsdButton
            // 
            this.generatePsdButton.Location = new System.Drawing.Point(240, 155);
            this.generatePsdButton.Name = "generatePsdButton";
            this.generatePsdButton.Size = new System.Drawing.Size(72, 23);
            this.generatePsdButton.TabIndex = 9;
            this.generatePsdButton.Text = "Получить";
            this.generatePsdButton.UseVisualStyleBackColor = true;
            this.generatePsdButton.Click += new System.EventHandler(this.generatePsdButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 317);
            this.Controls.Add(this.generatePsdButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleIdNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.departmentNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown departmentNumericUpDown;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown roleIdNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button generatePsdButton;
    }
}