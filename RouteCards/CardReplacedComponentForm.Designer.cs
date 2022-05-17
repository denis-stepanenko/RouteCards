
namespace RouteCards
{
    partial class CardReplacedComponentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.factoryNumberTextBox = new System.Windows.Forms.TextBox();
            this.replacementReasonTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.executorTextBox = new System.Windows.Forms.TextBox();
            this.selectExecutorButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Заводской номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Причина замены:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(12, 388);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 16;
            // 
            // factoryNumberTextBox
            // 
            this.factoryNumberTextBox.Location = new System.Drawing.Point(12, 338);
            this.factoryNumberTextBox.Name = "factoryNumberTextBox";
            this.factoryNumberTextBox.Size = new System.Drawing.Size(225, 20);
            this.factoryNumberTextBox.TabIndex = 15;
            // 
            // replacementReasonTextBox
            // 
            this.replacementReasonTextBox.Location = new System.Drawing.Point(12, 224);
            this.replacementReasonTextBox.Multiline = true;
            this.replacementReasonTextBox.Name = "replacementReasonTextBox";
            this.replacementReasonTextBox.Size = new System.Drawing.Size(391, 81);
            this.replacementReasonTextBox.TabIndex = 14;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(16, 42);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(387, 20);
            this.codeTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Код:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(391, 20);
            this.nameTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Наименование:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Исполнитель:";
            // 
            // executorTextBox
            // 
            this.executorTextBox.Location = new System.Drawing.Point(12, 157);
            this.executorTextBox.Name = "executorTextBox";
            this.executorTextBox.ReadOnly = true;
            this.executorTextBox.Size = new System.Drawing.Size(355, 20);
            this.executorTextBox.TabIndex = 24;
            // 
            // selectExecutorButton
            // 
            this.selectExecutorButton.Location = new System.Drawing.Point(374, 157);
            this.selectExecutorButton.Name = "selectExecutorButton";
            this.selectExecutorButton.Size = new System.Drawing.Size(29, 23);
            this.selectExecutorButton.TabIndex = 26;
            this.selectExecutorButton.Text = "...";
            this.selectExecutorButton.UseVisualStyleBackColor = true;
            this.selectExecutorButton.Click += new System.EventHandler(this.selectExecutorButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(421, 415);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CardReplacedComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectExecutorButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.executorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.factoryNumberTextBox);
            this.Controls.Add(this.replacementReasonTextBox);
            this.Name = "CardReplacedComponentForm";
            this.Text = "Комплектующая на замену";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox factoryNumberTextBox;
        private System.Windows.Forms.TextBox replacementReasonTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox executorTextBox;
        private System.Windows.Forms.Button selectExecutorButton;
        private System.Windows.Forms.Button okButton;
    }
}