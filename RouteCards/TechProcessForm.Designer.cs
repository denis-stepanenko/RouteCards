
namespace RouteCards
{
    partial class TechProcessForm
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
            this.components = new System.ComponentModel.Container();
            this.selectProductButton = new System.Windows.Forms.Button();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshOperationsButton = new System.Windows.Forms.Button();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openDocumentButton = new System.Windows.Forms.Button();
            this.removeDocumentButton = new System.Windows.Forms.Button();
            this.addDocumentButton = new System.Windows.Forms.Button();
            this.refreshDocumentsButton = new System.Windows.Forms.Button();
            this.documentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removePurchasedProductsButton = new System.Windows.Forms.Button();
            this.addToPurchasedProductsButton = new System.Windows.Forms.Button();
            this.purchasedProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showProductRelationsButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.productRelationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pickerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            this.operationsContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDataGridView)).BeginInit();
            this.documentsContextMenuStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRelationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectProductButton
            // 
            this.selectProductButton.Location = new System.Drawing.Point(752, 22);
            this.selectProductButton.Name = "selectProductButton";
            this.selectProductButton.Size = new System.Drawing.Size(36, 23);
            this.selectProductButton.TabIndex = 55;
            this.selectProductButton.Text = "...";
            this.selectProductButton.UseVisualStyleBackColor = true;
            this.selectProductButton.Click += new System.EventHandler(this.selectProductButton_Click);
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(12, 24);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(734, 20);
            this.productTextBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Продукт";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(716, 193);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 56;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 71);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(779, 20);
            this.descriptionTextBox.TabIndex = 57;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 222);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 439);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moveDownButton);
            this.tabPage1.Controls.Add(this.moveUpButton);
            this.tabPage1.Controls.Add(this.openButton);
            this.tabPage1.Controls.Add(this.removeButton);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.refreshOperationsButton);
            this.tabPage1.Controls.Add(this.operationsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Операции";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(415, 7);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(75, 23);
            this.moveDownButton.TabIndex = 6;
            this.moveDownButton.Text = "Вниз";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(333, 7);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 5;
            this.moveUpButton.Text = "Вверх";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(170, 7);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Изменить";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(251, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(89, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshOperationsButton
            // 
            this.refreshOperationsButton.Location = new System.Drawing.Point(7, 7);
            this.refreshOperationsButton.Name = "refreshOperationsButton";
            this.refreshOperationsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshOperationsButton.TabIndex = 1;
            this.refreshOperationsButton.Text = "Обновить";
            this.refreshOperationsButton.UseVisualStyleBackColor = true;
            this.refreshOperationsButton.Click += new System.EventHandler(this.refreshOperationsButton_Click);
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AllowUserToAddRows = false;
            this.operationsDataGridView.AllowUserToDeleteRows = false;
            this.operationsDataGridView.AllowUserToResizeRows = false;
            this.operationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.operationsDataGridView.ContextMenuStrip = this.operationsContextMenuStrip;
            this.operationsDataGridView.Location = new System.Drawing.Point(7, 34);
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.ReadOnly = true;
            this.operationsDataGridView.RowHeadersVisible = false;
            this.operationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationsDataGridView.Size = new System.Drawing.Size(758, 480);
            this.operationsDataGridView.TabIndex = 0;
            this.operationsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.operationsDataGridView_CellDoubleClick);
            this.operationsDataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.operationsDataGridView_ColumnAdded);
            this.operationsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.operationsDataGridView_KeyDown);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Position";
            this.Column6.FillWeight = 30.45685F;
            this.Column6.HeaderText = "№";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code";
            this.Column1.FillWeight = 113.9086F;
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.FillWeight = 113.9086F;
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Department";
            this.Column3.FillWeight = 113.9086F;
            this.Column3.HeaderText = "Подразделение";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Count";
            this.Column4.FillWeight = 113.9086F;
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.FillWeight = 113.9086F;
            this.Column5.HeaderText = "Примечание";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // operationsContextMenuStrip
            // 
            this.operationsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.operationsContextMenuStrip.Name = "operationsContextMenuStrip";
            this.operationsContextMenuStrip.Size = new System.Drawing.Size(140, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.openDocumentButton);
            this.tabPage2.Controls.Add(this.removeDocumentButton);
            this.tabPage2.Controls.Add(this.addDocumentButton);
            this.tabPage2.Controls.Add(this.refreshDocumentsButton);
            this.tabPage2.Controls.Add(this.documentsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Документы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openDocumentButton
            // 
            this.openDocumentButton.Location = new System.Drawing.Point(170, 6);
            this.openDocumentButton.Name = "openDocumentButton";
            this.openDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.openDocumentButton.TabIndex = 8;
            this.openDocumentButton.Text = "Изменить";
            this.openDocumentButton.UseVisualStyleBackColor = true;
            this.openDocumentButton.Click += new System.EventHandler(this.openDocumentButton_Click);
            // 
            // removeDocumentButton
            // 
            this.removeDocumentButton.Location = new System.Drawing.Point(251, 6);
            this.removeDocumentButton.Name = "removeDocumentButton";
            this.removeDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.removeDocumentButton.TabIndex = 7;
            this.removeDocumentButton.Text = "Удалить";
            this.removeDocumentButton.UseVisualStyleBackColor = true;
            this.removeDocumentButton.Click += new System.EventHandler(this.removeDocumentButton_Click);
            // 
            // addDocumentButton
            // 
            this.addDocumentButton.Location = new System.Drawing.Point(89, 6);
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.addDocumentButton.TabIndex = 6;
            this.addDocumentButton.Text = "Добавить";
            this.addDocumentButton.UseVisualStyleBackColor = true;
            this.addDocumentButton.Click += new System.EventHandler(this.addDocumentButton_Click);
            // 
            // refreshDocumentsButton
            // 
            this.refreshDocumentsButton.Location = new System.Drawing.Point(7, 6);
            this.refreshDocumentsButton.Name = "refreshDocumentsButton";
            this.refreshDocumentsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshDocumentsButton.TabIndex = 5;
            this.refreshDocumentsButton.Text = "Обновить";
            this.refreshDocumentsButton.UseVisualStyleBackColor = true;
            this.refreshDocumentsButton.Click += new System.EventHandler(this.refreshDocumentsButton_Click);
            // 
            // documentsDataGridView
            // 
            this.documentsDataGridView.AllowUserToAddRows = false;
            this.documentsDataGridView.AllowUserToDeleteRows = false;
            this.documentsDataGridView.AllowUserToResizeRows = false;
            this.documentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.documentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.documentsDataGridView.ContextMenuStrip = this.documentsContextMenuStrip;
            this.documentsDataGridView.Location = new System.Drawing.Point(7, 34);
            this.documentsDataGridView.Name = "documentsDataGridView";
            this.documentsDataGridView.ReadOnly = true;
            this.documentsDataGridView.RowHeadersVisible = false;
            this.documentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documentsDataGridView.Size = new System.Drawing.Size(758, 480);
            this.documentsDataGridView.TabIndex = 1;
            this.documentsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.documentsDataGridView_CellDoubleClick);
            this.documentsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.documentsDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.FillWeight = 113.9086F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // documentsContextMenuStrip
            // 
            this.documentsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1});
            this.documentsContextMenuStrip.Name = "documentsContextMenuStrip";
            this.documentsContextMenuStrip.Size = new System.Drawing.Size(140, 48);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removePurchasedProductsButton);
            this.tabPage3.Controls.Add(this.addToPurchasedProductsButton);
            this.tabPage3.Controls.Add(this.purchasedProductsDataGridView);
            this.tabPage3.Controls.Add(this.showProductRelationsButton);
            this.tabPage3.Controls.Add(this.filterTextBox);
            this.tabPage3.Controls.Add(this.productRelationsDataGridView);
            this.tabPage3.Controls.Add(this.productsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(771, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Комплектовочная ведомость";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // removePurchasedProductsButton
            // 
            this.removePurchasedProductsButton.Location = new System.Drawing.Point(428, 12);
            this.removePurchasedProductsButton.Name = "removePurchasedProductsButton";
            this.removePurchasedProductsButton.Size = new System.Drawing.Size(75, 23);
            this.removePurchasedProductsButton.TabIndex = 6;
            this.removePurchasedProductsButton.Text = "Удалить";
            this.removePurchasedProductsButton.UseVisualStyleBackColor = true;
            this.removePurchasedProductsButton.Click += new System.EventHandler(this.removePurchasedProductsButton_Click);
            // 
            // addToPurchasedProductsButton
            // 
            this.addToPurchasedProductsButton.Location = new System.Drawing.Point(350, 245);
            this.addToPurchasedProductsButton.Name = "addToPurchasedProductsButton";
            this.addToPurchasedProductsButton.Size = new System.Drawing.Size(75, 23);
            this.addToPurchasedProductsButton.TabIndex = 5;
            this.addToPurchasedProductsButton.Text = ">>";
            this.addToPurchasedProductsButton.UseVisualStyleBackColor = true;
            this.addToPurchasedProductsButton.Click += new System.EventHandler(this.addToPurchasedProductsButton_Click);
            // 
            // purchasedProductsDataGridView
            // 
            this.purchasedProductsDataGridView.AllowUserToAddRows = false;
            this.purchasedProductsDataGridView.AllowUserToResizeRows = false;
            this.purchasedProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasedProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasedProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.purchasedProductsDataGridView.Location = new System.Drawing.Point(428, 41);
            this.purchasedProductsDataGridView.Name = "purchasedProductsDataGridView";
            this.purchasedProductsDataGridView.ReadOnly = true;
            this.purchasedProductsDataGridView.RowHeadersVisible = false;
            this.purchasedProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasedProductsDataGridView.Size = new System.Drawing.Size(340, 369);
            this.purchasedProductsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // showProductRelationsButton
            // 
            this.showProductRelationsButton.Location = new System.Drawing.Point(4, 197);
            this.showProductRelationsButton.Name = "showProductRelationsButton";
            this.showProductRelationsButton.Size = new System.Drawing.Size(340, 42);
            this.showProductRelationsButton.TabIndex = 3;
            this.showProductRelationsButton.Text = "Показать входящие ПКИ и ДСЕ по алгоритму комплектовочной ведомости в ВПР";
            this.showProductRelationsButton.UseVisualStyleBackColor = true;
            this.showProductRelationsButton.Click += new System.EventHandler(this.showProductRelationsButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(4, 15);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(340, 20);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // productRelationsDataGridView
            // 
            this.productRelationsDataGridView.AllowUserToAddRows = false;
            this.productRelationsDataGridView.AllowUserToResizeRows = false;
            this.productRelationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productRelationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productRelationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column9});
            this.productRelationsDataGridView.Location = new System.Drawing.Point(4, 245);
            this.productRelationsDataGridView.Name = "productRelationsDataGridView";
            this.productRelationsDataGridView.ReadOnly = true;
            this.productRelationsDataGridView.RowHeadersVisible = false;
            this.productRelationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productRelationsDataGridView.Size = new System.Drawing.Size(340, 165);
            this.productRelationsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Count";
            this.Column9.HeaderText = "Количество";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.productsDataGridView.Location = new System.Drawing.Point(3, 41);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(341, 150);
            this.productsDataGridView.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Code";
            this.Column7.HeaderText = "Код";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Наименование";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Комплектовщик";
            // 
            // pickerTextBox
            // 
            this.pickerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickerTextBox.Location = new System.Drawing.Point(12, 117);
            this.pickerTextBox.Name = "pickerTextBox";
            this.pickerTextBox.Size = new System.Drawing.Size(779, 20);
            this.pickerTextBox.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Получатель";
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipientTextBox.Location = new System.Drawing.Point(12, 167);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(779, 20);
            this.recipientTextBox.TabIndex = 64;
            // 
            // TechProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recipientTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickerTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.selectProductButton);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.label2);
            this.Name = "TechProcessForm";
            this.Text = "Эталонный маршрутный лист";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            this.operationsContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsDataGridView)).EndInit();
            this.documentsContextMenuStrip.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRelationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectProductButton;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button refreshOperationsButton;
        private System.Windows.Forms.DataGridView operationsDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button openDocumentButton;
        private System.Windows.Forms.Button removeDocumentButton;
        private System.Windows.Forms.Button addDocumentButton;
        private System.Windows.Forms.Button refreshDocumentsButton;
        private System.Windows.Forms.DataGridView documentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip operationsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip documentsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView productRelationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button showProductRelationsButton;
        private System.Windows.Forms.DataGridView purchasedProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button addToPurchasedProductsButton;
        private System.Windows.Forms.Button removePurchasedProductsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pickerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recipientTextBox;
    }
}