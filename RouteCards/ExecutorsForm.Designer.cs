
namespace RouteCards
{
    partial class ExecutorsForm
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.departmentPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.patronymicPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.secondNamePlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.firstNamePlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToResizeRows = false;
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.itemsDataGridView.Location = new System.Drawing.Point(9, 78);
            this.itemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new System.Drawing.Size(582, 278);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Department";
            this.Column4.HeaderText = "Подразделение";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SecondName";
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Patronymic";
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(231, 17);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(68, 19);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(156, 17);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(71, 19);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 17);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 19);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(84, 17);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(68, 19);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // departmentPlaceholderTextBox
            // 
            this.departmentPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.departmentPlaceholderTextBox.Location = new System.Drawing.Point(9, 53);
            this.departmentPlaceholderTextBox.Name = "departmentPlaceholderTextBox";
            this.departmentPlaceholderTextBox.Placeholder = "Подразделение";
            this.departmentPlaceholderTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentPlaceholderTextBox.TabIndex = 9;
            this.departmentPlaceholderTextBox.Text = "Подразделение";
            this.departmentPlaceholderTextBox.TextChanged += new System.EventHandler(this.departmentPlaceholderTextBox_TextChanged);
            // 
            // patronymicPlaceholderTextBox
            // 
            this.patronymicPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.patronymicPlaceholderTextBox.Location = new System.Drawing.Point(329, 53);
            this.patronymicPlaceholderTextBox.Name = "patronymicPlaceholderTextBox";
            this.patronymicPlaceholderTextBox.Placeholder = "Отчество";
            this.patronymicPlaceholderTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicPlaceholderTextBox.TabIndex = 8;
            this.patronymicPlaceholderTextBox.Text = "Отчество";
            this.patronymicPlaceholderTextBox.TextChanged += new System.EventHandler(this.patronymicPlaceholderTextBox_TextChanged);
            // 
            // secondNamePlaceholderTextBox
            // 
            this.secondNamePlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.secondNamePlaceholderTextBox.Location = new System.Drawing.Point(222, 53);
            this.secondNamePlaceholderTextBox.Name = "secondNamePlaceholderTextBox";
            this.secondNamePlaceholderTextBox.Placeholder = "Имя";
            this.secondNamePlaceholderTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNamePlaceholderTextBox.TabIndex = 7;
            this.secondNamePlaceholderTextBox.Text = "Имя";
            this.secondNamePlaceholderTextBox.TextChanged += new System.EventHandler(this.secondNamePlaceholderTextBox_TextChanged);
            // 
            // firstNamePlaceholderTextBox
            // 
            this.firstNamePlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.firstNamePlaceholderTextBox.Location = new System.Drawing.Point(115, 53);
            this.firstNamePlaceholderTextBox.Name = "firstNamePlaceholderTextBox";
            this.firstNamePlaceholderTextBox.Placeholder = "Фамилия";
            this.firstNamePlaceholderTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNamePlaceholderTextBox.TabIndex = 6;
            this.firstNamePlaceholderTextBox.Text = "Фамилия";
            this.firstNamePlaceholderTextBox.TextChanged += new System.EventHandler(this.firstNamePlaceholderTextBox_TextChanged);
            // 
            // ExecutorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.departmentPlaceholderTextBox);
            this.Controls.Add(this.patronymicPlaceholderTextBox);
            this.Controls.Add(this.secondNamePlaceholderTextBox);
            this.Controls.Add(this.firstNamePlaceholderTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.itemsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExecutorsForm";
            this.Text = "Исполнители";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private PlaceholderTextBox firstNamePlaceholderTextBox;
        private PlaceholderTextBox secondNamePlaceholderTextBox;
        private PlaceholderTextBox patronymicPlaceholderTextBox;
        private PlaceholderTextBox departmentPlaceholderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}