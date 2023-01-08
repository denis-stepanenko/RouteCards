
namespace RouteCards
{
    partial class NewCardForm
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
            this.productCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.getNewCardNumberButton = new System.Windows.Forms.Button();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.getRouteButton = new System.Windows.Forms.Button();
            this.routeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codeFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.nameFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productCountNumericUpDown
            // 
            this.productCountNumericUpDown.Location = new System.Drawing.Point(17, 78);
            this.productCountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.productCountNumericUpDown.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.productCountNumericUpDown.Name = "productCountNumericUpDown";
            this.productCountNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.productCountNumericUpDown.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(672, 542);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 19);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(16, 36);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(182, 20);
            this.numberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Подразделение";
            // 
            // departmentNumericUpDown
            // 
            this.departmentNumericUpDown.Location = new System.Drawing.Point(17, 131);
            this.departmentNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.departmentNumericUpDown.Name = "departmentNumericUpDown";
            this.departmentNumericUpDown.Size = new System.Drawing.Size(188, 20);
            this.departmentNumericUpDown.TabIndex = 31;
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
            this.itemsDataGridView.Location = new System.Drawing.Point(16, 263);
            this.itemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.Size = new System.Drawing.Size(711, 275);
            this.itemsDataGridView.TabIndex = 35;
            this.itemsDataGridView.SelectionChanged += new System.EventHandler(this.itemsDataGridView_SelectionChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Продукт:";
            // 
            // getNewCardNumberButton
            // 
            this.getNewCardNumberButton.Location = new System.Drawing.Point(203, 33);
            this.getNewCardNumberButton.Name = "getNewCardNumberButton";
            this.getNewCardNumberButton.Size = new System.Drawing.Size(102, 23);
            this.getNewCardNumberButton.TabIndex = 45;
            this.getNewCardNumberButton.Text = "Получить новый";
            this.getNewCardNumberButton.UseVisualStyleBackColor = true;
            this.getNewCardNumberButton.Click += new System.EventHandler(this.getNewCardNumberButton_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(328, 36);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Дата";
            // 
            // getRouteButton
            // 
            this.getRouteButton.Location = new System.Drawing.Point(218, 174);
            this.getRouteButton.Name = "getRouteButton";
            this.getRouteButton.Size = new System.Drawing.Size(75, 23);
            this.getRouteButton.TabIndex = 63;
            this.getRouteButton.Text = "Рассчитать";
            this.getRouteButton.UseVisualStyleBackColor = true;
            this.getRouteButton.Click += new System.EventHandler(this.getRouteButton_Click);
            // 
            // routeTextBox
            // 
            this.routeTextBox.Location = new System.Drawing.Point(18, 178);
            this.routeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.routeTextBox.Name = "routeTextBox";
            this.routeTextBox.ReadOnly = true;
            this.routeTextBox.Size = new System.Drawing.Size(195, 20);
            this.routeTextBox.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Маршрут";
            // 
            // codeFilterPlaceholderTextBox
            // 
            this.codeFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.codeFilterPlaceholderTextBox.Location = new System.Drawing.Point(16, 238);
            this.codeFilterPlaceholderTextBox.Name = "codeFilterPlaceholderTextBox";
            this.codeFilterPlaceholderTextBox.Placeholder = "Код";
            this.codeFilterPlaceholderTextBox.Size = new System.Drawing.Size(306, 20);
            this.codeFilterPlaceholderTextBox.TabIndex = 36;
            this.codeFilterPlaceholderTextBox.Text = "Код";
            this.codeFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.filterPlaceholderTextBox_TextChanged);
            // 
            // nameFilterPlaceholderTextBox
            // 
            this.nameFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameFilterPlaceholderTextBox.Location = new System.Drawing.Point(328, 238);
            this.nameFilterPlaceholderTextBox.Name = "nameFilterPlaceholderTextBox";
            this.nameFilterPlaceholderTextBox.Placeholder = "Наименование";
            this.nameFilterPlaceholderTextBox.Size = new System.Drawing.Size(306, 20);
            this.nameFilterPlaceholderTextBox.TabIndex = 46;
            this.nameFilterPlaceholderTextBox.Text = "Наименование";
            this.nameFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.nameFilterPlaceholderTextBox_TextChanged);
            // 
            // NewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.getRouteButton);
            this.Controls.Add(this.routeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.nameFilterPlaceholderTextBox);
            this.Controls.Add(this.getNewCardNumberButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeFilterPlaceholderTextBox);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.departmentNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.productCountNumericUpDown);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewCardForm";
            this.Text = "Добавление маршрутного листа";
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown productCountNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown departmentNumericUpDown;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button getNewCardNumberButton;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getRouteButton;
        private System.Windows.Forms.TextBox routeTextBox;
        private System.Windows.Forms.Label label5;
        private PlaceholderTextBox codeFilterPlaceholderTextBox;
        private PlaceholderTextBox nameFilterPlaceholderTextBox;
    }
}