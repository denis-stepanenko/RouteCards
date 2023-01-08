
namespace RouteCards
{
    partial class NewTechProcessForm
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
            this.nameFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeFilterPlaceholderTextBox = new RouteCards.PlaceholderTextBox();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFilterPlaceholderTextBox
            // 
            this.nameFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameFilterPlaceholderTextBox.Location = new System.Drawing.Point(323, 35);
            this.nameFilterPlaceholderTextBox.Name = "nameFilterPlaceholderTextBox";
            this.nameFilterPlaceholderTextBox.Placeholder = "Наименование";
            this.nameFilterPlaceholderTextBox.Size = new System.Drawing.Size(306, 20);
            this.nameFilterPlaceholderTextBox.TabIndex = 50;
            this.nameFilterPlaceholderTextBox.Text = "Наименование";
            this.nameFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.nameFilterPlaceholderTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Продукт";
            // 
            // codeFilterPlaceholderTextBox
            // 
            this.codeFilterPlaceholderTextBox.ForeColor = System.Drawing.Color.Gray;
            this.codeFilterPlaceholderTextBox.Location = new System.Drawing.Point(11, 35);
            this.codeFilterPlaceholderTextBox.Name = "codeFilterPlaceholderTextBox";
            this.codeFilterPlaceholderTextBox.Placeholder = "Код";
            this.codeFilterPlaceholderTextBox.Size = new System.Drawing.Size(306, 20);
            this.codeFilterPlaceholderTextBox.TabIndex = 48;
            this.codeFilterPlaceholderTextBox.Text = "Код";
            this.codeFilterPlaceholderTextBox.TextChanged += new System.EventHandler(this.codeFilterPlaceholderTextBox_TextChanged);
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
            this.itemsDataGridView.Location = new System.Drawing.Point(11, 60);
            this.itemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.Size = new System.Drawing.Size(711, 411);
            this.itemsDataGridView.TabIndex = 47;
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 492);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(709, 20);
            this.descriptionTextBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Описание";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(640, 519);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 53;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // NewTechProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 550);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameFilterPlaceholderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeFilterPlaceholderTextBox);
            this.Controls.Add(this.itemsDataGridView);
            this.Name = "NewTechProcessForm";
            this.Text = "Новый тех. процесс";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox nameFilterPlaceholderTextBox;
        private System.Windows.Forms.Label label2;
        private PlaceholderTextBox codeFilterPlaceholderTextBox;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
    }
}