
namespace RouteCards
{
    partial class CardsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.duplicateButton = new System.Windows.Forms.Button();
            this.filterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.codeNameStageFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.addUsingTechProcessButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
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
            this.Column9,
            this.Column15,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column14,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.itemsDataGridView.Location = new System.Drawing.Point(10, 63);
            this.itemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.RowTemplate.Height = 24;
            this.itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new System.Drawing.Size(930, 509);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "Номер";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Department";
            this.Column9.HeaderText = "Подразделение";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column15.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column15.HeaderText = "Дата";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductCode";
            this.Column2.HeaderText = "Код";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductName";
            this.Column3.HeaderText = "Наименование";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductCount";
            this.Column4.HeaderText = "Количество";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Order";
            this.Column14.HeaderText = "Заказ";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Stage";
            this.Column5.HeaderText = "Этап";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GroupName";
            this.Column6.HeaderText = "Группа направлений деятельности";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Direction";
            this.Column7.HeaderText = "Направление деятельности";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ClientOrder";
            this.Column8.HeaderText = "Заказ клиента";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Route";
            this.Column10.HeaderText = "Маршрут";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "FactoryNumber";
            this.Column11.HeaderText = "Заводской номер";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "PickingListNumber";
            this.Column12.HeaderText = "Номер накладной";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "OwnerProductName";
            this.Column13.HeaderText = "Изделие";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(468, 9);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(66, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(538, 9);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(66, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(608, 9);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // duplicateButton
            // 
            this.duplicateButton.Location = new System.Drawing.Point(372, 9);
            this.duplicateButton.Name = "duplicateButton";
            this.duplicateButton.Size = new System.Drawing.Size(91, 23);
            this.duplicateButton.TabIndex = 5;
            this.duplicateButton.Text = "Дублировать";
            this.duplicateButton.UseVisualStyleBackColor = true;
            this.duplicateButton.Click += new System.EventHandler(this.duplicateButton_Click);
            // 
            // filterPlaceholderTextBox
            // 
            this.filterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.filterPlaceholderTextBox.Location = new System.Drawing.Point(10, 38);
            this.filterPlaceholderTextBox.Name = "filterPlaceholderTextBox";
            this.filterPlaceholderTextBox.Placeholder = "Поиск по номеру М/Л";
            this.filterPlaceholderTextBox.Size = new System.Drawing.Size(136, 20);
            this.filterPlaceholderTextBox.TabIndex = 6;
            this.filterPlaceholderTextBox.Text = "Поиск по номеру М/Л";
            this.filterPlaceholderTextBox.TextChanged += new System.EventHandler(this.filterPlaceholderTextBox_TextChanged);
            // 
            // codeNameStageFilterPlaceholderTextBox
            // 
            this.codeNameStageFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.codeNameStageFilterPlaceholderTextBox.Location = new System.Drawing.Point(152, 38);
            this.codeNameStageFilterPlaceholderTextBox.Name = "codeNameStageFilterPlaceholderTextBox";
            this.codeNameStageFilterPlaceholderTextBox.Placeholder = "Поиск по ДСЕ, Наименованию, Этапу";
            this.codeNameStageFilterPlaceholderTextBox.Size = new System.Drawing.Size(294, 20);
            this.codeNameStageFilterPlaceholderTextBox.TabIndex = 7;
            this.codeNameStageFilterPlaceholderTextBox.Text = "Поиск по ДСЕ, Наименованию, Этапу";
            this.codeNameStageFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.filterPlaceholderDseNameEtapTextBox_TextChanged);
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Items.AddRange(new object[] {
            "Все",
            "4",
            "5",
            "6",
            "13",
            "17",
            "80",
            "82"});
            this.departmentsComboBox.Location = new System.Drawing.Point(453, 38);
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentsComboBox.TabIndex = 8;
            this.departmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentsComboBox_SelectedIndexChanged);
            // 
            // addUsingTechProcessButton
            // 
            this.addUsingTechProcessButton.Location = new System.Drawing.Point(90, 9);
            this.addUsingTechProcessButton.Margin = new System.Windows.Forms.Padding(2);
            this.addUsingTechProcessButton.Name = "addUsingTechProcessButton";
            this.addUsingTechProcessButton.Size = new System.Drawing.Size(277, 23);
            this.addUsingTechProcessButton.TabIndex = 9;
            this.addUsingTechProcessButton.Text = "Добавить на основе эталонного марш. листа";
            this.addUsingTechProcessButton.UseVisualStyleBackColor = true;
            this.addUsingTechProcessButton.Click += new System.EventHandler(this.addUsingTechProcessButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 582);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addUsingTechProcessButton);
            this.Controls.Add(this.departmentsComboBox);
            this.Controls.Add(this.codeNameStageFilterPlaceholderTextBox);
            this.Controls.Add(this.filterPlaceholderTextBox);
            this.Controls.Add(this.duplicateButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.itemsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardsForm";
            this.Text = "Маршрутные листы";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button duplicateButton;
        private PlaceholderTextBox filterPlaceholderTextBox;
        private PlaceholderTextBox codeNameStageFilterPlaceholderTextBox;
        private System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button addUsingTechProcessButton;
        private System.Windows.Forms.Button addButton;
    }
}