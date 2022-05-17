
namespace RouteCards
{
    partial class CardFramelessComponentForm
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daysBeforeSealingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateOfSealingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfIssueForProductionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.daysBeforeSealingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(24, 34);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(197, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(24, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(197, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Срок до герметизации (дни):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата герметизации:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Дата выдачи в производство:";
            // 
            // daysBeforeSealingNumericUpDown
            // 
            this.daysBeforeSealingNumericUpDown.Location = new System.Drawing.Point(21, 298);
            this.daysBeforeSealingNumericUpDown.Name = "daysBeforeSealingNumericUpDown";
            this.daysBeforeSealingNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.daysBeforeSealingNumericUpDown.TabIndex = 11;
            // 
            // dateOfSealingDateTimePicker
            // 
            this.dateOfSealingDateTimePicker.Location = new System.Drawing.Point(21, 225);
            this.dateOfSealingDateTimePicker.Name = "dateOfSealingDateTimePicker";
            this.dateOfSealingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfSealingDateTimePicker.TabIndex = 10;
            // 
            // dateOfIssueForProductionDateTimePicker
            // 
            this.dateOfIssueForProductionDateTimePicker.Location = new System.Drawing.Point(21, 166);
            this.dateOfIssueForProductionDateTimePicker.Name = "dateOfIssueForProductionDateTimePicker";
            this.dateOfIssueForProductionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfIssueForProductionDateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Код:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Наименование:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(239, 358);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CardFramelessComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysBeforeSealingNumericUpDown);
            this.Controls.Add(this.dateOfSealingDateTimePicker);
            this.Controls.Add(this.dateOfIssueForProductionDateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Name = "CardFramelessComponentForm";
            this.Text = "Бескорпусная комплектующая";
            ((System.ComponentModel.ISupportInitialize)(this.daysBeforeSealingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown daysBeforeSealingNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateOfSealingDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfIssueForProductionDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
    }
}