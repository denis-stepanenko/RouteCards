namespace RouteCards
{
    partial class AddCardUsingTechProcessForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.getNewCardNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.departmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.productCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.getRouteButton = new System.Windows.Forms.Button();
            this.routeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTextBox = new RouteCards.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(664, 543);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 19);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Дата";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(321, 27);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 52;
            // 
            // getNewCardNumberButton
            // 
            this.getNewCardNumberButton.Location = new System.Drawing.Point(196, 27);
            this.getNewCardNumberButton.Name = "getNewCardNumberButton";
            this.getNewCardNumberButton.Size = new System.Drawing.Size(102, 23);
            this.getNewCardNumberButton.TabIndex = 51;
            this.getNewCardNumberButton.Text = "Получить новый";
            this.getNewCardNumberButton.UseVisualStyleBackColor = true;
            this.getNewCardNumberButton.Click += new System.EventHandler(this.getNewCardNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Номер";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(9, 29);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(182, 20);
            this.numberTextBox.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Подразделение";
            // 
            // departmentNumericUpDown
            // 
            this.departmentNumericUpDown.Location = new System.Drawing.Point(8, 124);
            this.departmentNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.departmentNumericUpDown.Name = "departmentNumericUpDown";
            this.departmentNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.departmentNumericUpDown.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Количество";
            // 
            // productCountNumericUpDown
            // 
            this.productCountNumericUpDown.Location = new System.Drawing.Point(8, 73);
            this.productCountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.productCountNumericUpDown.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.productCountNumericUpDown.Name = "productCountNumericUpDown";
            this.productCountNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.productCountNumericUpDown.TabIndex = 54;
            // 
            // getRouteButton
            // 
            this.getRouteButton.Location = new System.Drawing.Point(211, 171);
            this.getRouteButton.Name = "getRouteButton";
            this.getRouteButton.Size = new System.Drawing.Size(75, 23);
            this.getRouteButton.TabIndex = 60;
            this.getRouteButton.Text = "Рассчитать";
            this.getRouteButton.UseVisualStyleBackColor = true;
            this.getRouteButton.Click += new System.EventHandler(this.getRouteButton_Click);
            // 
            // routeTextBox
            // 
            this.routeTextBox.Location = new System.Drawing.Point(11, 175);
            this.routeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.routeTextBox.Name = "routeTextBox";
            this.routeTextBox.ReadOnly = true;
            this.routeTextBox.Size = new System.Drawing.Size(195, 20);
            this.routeTextBox.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Маршрут";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToResizeRows = false;
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.itemsDataGridView.Location = new System.Drawing.Point(8, 256);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new System.Drawing.Size(719, 282);
            this.itemsDataGridView.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductCode";
            this.Column1.HeaderText = "Код";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IsConfirmed";
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "Наименование";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Описание";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CreatorName";
            this.Column4.HeaderText = "Создатель";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ConfirmUserName";
            this.Column5.HeaderText = "Утверждение";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextBox.ForeColor = System.Drawing.Color.Gray;
            this.filterTextBox.Location = new System.Drawing.Point(8, 230);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Placeholder = "Поиск";
            this.filterTextBox.Size = new System.Drawing.Size(721, 20);
            this.filterTextBox.TabIndex = 9;
            this.filterTextBox.Text = "Поиск";
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Эталонный маршрутный лист:";
            // 
            // AddCardUsingTechProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.getRouteButton);
            this.Controls.Add(this.routeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.departmentNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productCountNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.getNewCardNumberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.filterTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCardUsingTechProcessForm";
            this.Text = "Добавление на основе эталонного маршрутного листа";
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceholderTextBox filterTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button getNewCardNumberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown departmentNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown productCountNumericUpDown;
        private System.Windows.Forms.Button getRouteButton;
        private System.Windows.Forms.TextBox routeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
    }
}