
namespace RouteCards
{
    partial class AddCardReplacedComponentForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.refreshProductsButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executorsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshExecutorsButton = new System.Windows.Forms.Button();
            this.replacementReasonTextBox = new System.Windows.Forms.TextBox();
            this.factoryNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productsFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.executorsFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(1040, 611);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // refreshProductsButton
            // 
            this.refreshProductsButton.Location = new System.Drawing.Point(0, 3);
            this.refreshProductsButton.Name = "refreshProductsButton";
            this.refreshProductsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshProductsButton.TabIndex = 4;
            this.refreshProductsButton.Text = "Обновить";
            this.refreshProductsButton.UseVisualStyleBackColor = true;
            this.refreshProductsButton.Click += new System.EventHandler(this.refreshProductsButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.productsDataGridView.Location = new System.Drawing.Point(-1, 61);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.Size = new System.Drawing.Size(555, 315);
            this.productsDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code";
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 400;
            // 
            // executorsDataGridView
            // 
            this.executorsDataGridView.AllowUserToAddRows = false;
            this.executorsDataGridView.AllowUserToDeleteRows = false;
            this.executorsDataGridView.AllowUserToResizeRows = false;
            this.executorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3});
            this.executorsDataGridView.Location = new System.Drawing.Point(3, 62);
            this.executorsDataGridView.MultiSelect = false;
            this.executorsDataGridView.Name = "executorsDataGridView";
            this.executorsDataGridView.ReadOnly = true;
            this.executorsDataGridView.RowHeadersVisible = false;
            this.executorsDataGridView.Size = new System.Drawing.Size(537, 315);
            this.executorsDataGridView.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Department";
            this.Column4.HeaderText = "Подразделение";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SecondName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Patronymic";
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // refreshExecutorsButton
            // 
            this.refreshExecutorsButton.Location = new System.Drawing.Point(3, 4);
            this.refreshExecutorsButton.Name = "refreshExecutorsButton";
            this.refreshExecutorsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshExecutorsButton.TabIndex = 7;
            this.refreshExecutorsButton.Text = "Обновить";
            this.refreshExecutorsButton.UseVisualStyleBackColor = true;
            this.refreshExecutorsButton.Click += new System.EventHandler(this.refreshExecutorsButton_Click);
            // 
            // replacementReasonTextBox
            // 
            this.replacementReasonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replacementReasonTextBox.Location = new System.Drawing.Point(11, 428);
            this.replacementReasonTextBox.Multiline = true;
            this.replacementReasonTextBox.Name = "replacementReasonTextBox";
            this.replacementReasonTextBox.Size = new System.Drawing.Size(391, 81);
            this.replacementReasonTextBox.TabIndex = 8;
            // 
            // factoryNumberTextBox
            // 
            this.factoryNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryNumberTextBox.Location = new System.Drawing.Point(11, 542);
            this.factoryNumberTextBox.Name = "factoryNumberTextBox";
            this.factoryNumberTextBox.Size = new System.Drawing.Size(225, 20);
            this.factoryNumberTextBox.TabIndex = 9;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(11, 592);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Причина замены:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Заводской номер:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата:";
            // 
            // productsFilterPlaceholderTextBox
            // 
            this.productsFilterPlaceholderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.productsFilterPlaceholderTextBox.Location = new System.Drawing.Point(3, 33);
            this.productsFilterPlaceholderTextBox.Name = "productsFilterPlaceholderTextBox";
            this.productsFilterPlaceholderTextBox.Placeholder = "Поиск";
            this.productsFilterPlaceholderTextBox.Size = new System.Drawing.Size(551, 20);
            this.productsFilterPlaceholderTextBox.TabIndex = 14;
            this.productsFilterPlaceholderTextBox.Text = "Поиск";
            this.productsFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.productsFilterPlaceholderTextBox_TextChanged);
            // 
            // executorsFilterPlaceholderTextBox
            // 
            this.executorsFilterPlaceholderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executorsFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.executorsFilterPlaceholderTextBox.Location = new System.Drawing.Point(3, 33);
            this.executorsFilterPlaceholderTextBox.Name = "executorsFilterPlaceholderTextBox";
            this.executorsFilterPlaceholderTextBox.Placeholder = "Поиск";
            this.executorsFilterPlaceholderTextBox.Size = new System.Drawing.Size(537, 20);
            this.executorsFilterPlaceholderTextBox.TabIndex = 15;
            this.executorsFilterPlaceholderTextBox.Text = "Поиск";
            this.executorsFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.executorFilterPlaceholderTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refreshProductsButton);
            this.splitContainer1.Panel1.Controls.Add(this.productsDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.productsFilterPlaceholderTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.refreshExecutorsButton);
            this.splitContainer1.Panel2.Controls.Add(this.executorsFilterPlaceholderTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.executorsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 380);
            this.splitContainer1.SplitterDistance = 557;
            this.splitContainer1.TabIndex = 16;
            // 
            // AddCardReplacedComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.factoryNumberTextBox);
            this.Controls.Add(this.replacementReasonTextBox);
            this.Controls.Add(this.okButton);
            this.Name = "AddCardReplacedComponentForm";
            this.Text = "Добавление о замене комплектующих";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorsDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button refreshProductsButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridView executorsDataGridView;
        private System.Windows.Forms.Button refreshExecutorsButton;
        private System.Windows.Forms.TextBox replacementReasonTextBox;
        private System.Windows.Forms.TextBox factoryNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PlaceholderTextBox productsFilterPlaceholderTextBox;
        private PlaceholderTextBox executorsFilterPlaceholderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}