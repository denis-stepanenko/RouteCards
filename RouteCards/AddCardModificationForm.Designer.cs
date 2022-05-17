
namespace RouteCards
{
    partial class AddCardModificationForm
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
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executorsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.refreshOperationsButton = new System.Windows.Forms.Button();
            this.refreshExecutorsButton = new System.Windows.Forms.Button();
            this.operationsPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.executorsPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AllowUserToAddRows = false;
            this.operationsDataGridView.AllowUserToDeleteRows = false;
            this.operationsDataGridView.AllowUserToResizeRows = false;
            this.operationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2});
            this.operationsDataGridView.Location = new System.Drawing.Point(-3, 61);
            this.operationsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.operationsDataGridView.MultiSelect = false;
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.ReadOnly = true;
            this.operationsDataGridView.RowHeadersVisible = false;
            this.operationsDataGridView.RowHeadersWidth = 51;
            this.operationsDataGridView.Size = new System.Drawing.Size(488, 349);
            this.operationsDataGridView.TabIndex = 12;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Department";
            this.Column5.HeaderText = "Подразделение";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.executorsDataGridView.Size = new System.Drawing.Size(459, 347);
            this.executorsDataGridView.TabIndex = 13;
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
            // documentNumberTextBox
            // 
            this.documentNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.documentNumberTextBox.Location = new System.Drawing.Point(12, 443);
            this.documentNumberTextBox.Name = "documentNumberTextBox";
            this.documentNumberTextBox.Size = new System.Drawing.Size(501, 20);
            this.documentNumberTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Документ:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(896, 457);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // refreshOperationsButton
            // 
            this.refreshOperationsButton.Location = new System.Drawing.Point(0, 3);
            this.refreshOperationsButton.Name = "refreshOperationsButton";
            this.refreshOperationsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshOperationsButton.TabIndex = 17;
            this.refreshOperationsButton.Text = "Обновить";
            this.refreshOperationsButton.UseVisualStyleBackColor = true;
            this.refreshOperationsButton.Click += new System.EventHandler(this.refreshOperationsButton_Click);
            // 
            // refreshExecutorsButton
            // 
            this.refreshExecutorsButton.Location = new System.Drawing.Point(3, 3);
            this.refreshExecutorsButton.Name = "refreshExecutorsButton";
            this.refreshExecutorsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshExecutorsButton.TabIndex = 18;
            this.refreshExecutorsButton.Text = "Обновить";
            this.refreshExecutorsButton.UseVisualStyleBackColor = true;
            this.refreshExecutorsButton.Click += new System.EventHandler(this.refreshExecutorsButton_Click);
            // 
            // operationsPlaceholderTextBox
            // 
            this.operationsPlaceholderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.operationsPlaceholderTextBox.Location = new System.Drawing.Point(0, 36);
            this.operationsPlaceholderTextBox.Name = "operationsPlaceholderTextBox";
            this.operationsPlaceholderTextBox.Placeholder = "Поиск";
            this.operationsPlaceholderTextBox.Size = new System.Drawing.Size(484, 20);
            this.operationsPlaceholderTextBox.TabIndex = 19;
            this.operationsPlaceholderTextBox.Text = "Поиск";
            this.operationsPlaceholderTextBox.TextChanged += new System.EventHandler(this.operationsPlaceholderTextBox_TextChanged);
            // 
            // executorsPlaceholderTextBox
            // 
            this.executorsPlaceholderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executorsPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.executorsPlaceholderTextBox.Location = new System.Drawing.Point(3, 36);
            this.executorsPlaceholderTextBox.Name = "executorsPlaceholderTextBox";
            this.executorsPlaceholderTextBox.Placeholder = "Поиск";
            this.executorsPlaceholderTextBox.Size = new System.Drawing.Size(459, 20);
            this.executorsPlaceholderTextBox.TabIndex = 20;
            this.executorsPlaceholderTextBox.Text = "Поиск";
            this.executorsPlaceholderTextBox.TextChanged += new System.EventHandler(this.executorsPlaceholderTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(14, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refreshOperationsButton);
            this.splitContainer1.Panel1.Controls.Add(this.operationsDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.operationsPlaceholderTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.refreshExecutorsButton);
            this.splitContainer1.Panel2.Controls.Add(this.executorsPlaceholderTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.executorsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(956, 412);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.TabIndex = 21;
            // 
            // AddCardModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documentNumberTextBox);
            this.Name = "AddCardModificationForm";
            this.Text = "Добавление доработок";
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView operationsDataGridView;
        private System.Windows.Forms.DataGridView executorsDataGridView;
        private System.Windows.Forms.TextBox documentNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button refreshOperationsButton;
        private System.Windows.Forms.Button refreshExecutorsButton;
        private PlaceholderTextBox operationsPlaceholderTextBox;
        private PlaceholderTextBox executorsPlaceholderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}