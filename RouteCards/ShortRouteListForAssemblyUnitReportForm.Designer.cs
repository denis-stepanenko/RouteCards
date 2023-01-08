
namespace RouteCards
{
    partial class ShortRouteListForAssemblyUnitReportForm
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.refreshButton = new System.Windows.Forms.Button();
            this.PDBWorkerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TCBWorkerNameTextBox = new System.Windows.Forms.TextBox();
            this.TechnologistNameTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseWorkerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Location = new System.Drawing.Point(12, 82);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1029, 356);
            this.reportViewer.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 53);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // PDBWorkerNameTextBox
            // 
            this.PDBWorkerNameTextBox.Location = new System.Drawing.Point(13, 27);
            this.PDBWorkerNameTextBox.Name = "PDBWorkerNameTextBox";
            this.PDBWorkerNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.PDBWorkerNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Представитель ПРБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Представитель БТК";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Технолог";
            // 
            // TCBWorkerNameTextBox
            // 
            this.TCBWorkerNameTextBox.Location = new System.Drawing.Point(231, 27);
            this.TCBWorkerNameTextBox.Name = "TCBWorkerNameTextBox";
            this.TCBWorkerNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.TCBWorkerNameTextBox.TabIndex = 6;
            // 
            // TechnologistNameTextBox
            // 
            this.TechnologistNameTextBox.Location = new System.Drawing.Point(481, 27);
            this.TechnologistNameTextBox.Name = "TechnologistNameTextBox";
            this.TechnologistNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.TechnologistNameTextBox.TabIndex = 7;
            // 
            // WarehouseWorkerNameTextBox
            // 
            this.WarehouseWorkerNameTextBox.Location = new System.Drawing.Point(718, 27);
            this.WarehouseWorkerNameTextBox.Name = "WarehouseWorkerNameTextBox";
            this.WarehouseWorkerNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.WarehouseWorkerNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Работник склада";
            // 
            // MechanicalDepartmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.WarehouseWorkerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TechnologistNameTextBox);
            this.Controls.Add(this.TCBWorkerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PDBWorkerNameTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.reportViewer);
            this.Name = "MechanicalDepartmentReportForm";
            this.Text = "Отчет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox PDBWorkerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TCBWorkerNameTextBox;
        private System.Windows.Forms.TextBox TechnologistNameTextBox;
        private System.Windows.Forms.TextBox WarehouseWorkerNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}