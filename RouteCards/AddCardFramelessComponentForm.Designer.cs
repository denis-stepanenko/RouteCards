
namespace RouteCards
{
    partial class AddCardFramelessComponentForm
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
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.dateOfIssueForProductionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfSealingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.daysBeforeSealingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBeforeSealingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToResizeRows = false;
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.itemsDataGridView.Location = new System.Drawing.Point(12, 78);
            this.itemsDataGridView.MultiSelect = false;
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.Size = new System.Drawing.Size(573, 334);
            this.itemsDataGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(13, 20);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(756, 389);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dateOfIssueForProductionDateTimePicker
            // 
            this.dateOfIssueForProductionDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfIssueForProductionDateTimePicker.Location = new System.Drawing.Point(608, 78);
            this.dateOfIssueForProductionDateTimePicker.Name = "dateOfIssueForProductionDateTimePicker";
            this.dateOfIssueForProductionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfIssueForProductionDateTimePicker.TabIndex = 3;
            // 
            // dateOfSealingDateTimePicker
            // 
            this.dateOfSealingDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfSealingDateTimePicker.Location = new System.Drawing.Point(608, 137);
            this.dateOfSealingDateTimePicker.Name = "dateOfSealingDateTimePicker";
            this.dateOfSealingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfSealingDateTimePicker.TabIndex = 4;
            // 
            // daysBeforeSealingNumericUpDown
            // 
            this.daysBeforeSealingNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.daysBeforeSealingNumericUpDown.Location = new System.Drawing.Point(608, 210);
            this.daysBeforeSealingNumericUpDown.Name = "daysBeforeSealingNumericUpDown";
            this.daysBeforeSealingNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.daysBeforeSealingNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата выдачи в производство:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата герметизации:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Срок до герметизации (дни):";
            // 
            // filterPlaceholderTextBox
            // 
            this.filterPlaceholderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.filterPlaceholderTextBox.Location = new System.Drawing.Point(13, 50);
            this.filterPlaceholderTextBox.Name = "filterPlaceholderTextBox";
            this.filterPlaceholderTextBox.Placeholder = "Поиск";
            this.filterPlaceholderTextBox.Size = new System.Drawing.Size(572, 20);
            this.filterPlaceholderTextBox.TabIndex = 9;
            this.filterPlaceholderTextBox.Text = "Поиск";
            this.filterPlaceholderTextBox.TextChanged += new System.EventHandler(this.filterPlaceholderTextBox_TextChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code";
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // AddCardFramelessComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 424);
            this.Controls.Add(this.filterPlaceholderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysBeforeSealingNumericUpDown);
            this.Controls.Add(this.dateOfSealingDateTimePicker);
            this.Controls.Add(this.dateOfIssueForProductionDateTimePicker);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.itemsDataGridView);
            this.Name = "AddCardFramelessComponentForm";
            this.Text = "Добавление бескорпусных комплектующих";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBeforeSealingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DateTimePicker dateOfIssueForProductionDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfSealingDateTimePicker;
        private System.Windows.Forms.NumericUpDown daysBeforeSealingNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PlaceholderTextBox filterPlaceholderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}