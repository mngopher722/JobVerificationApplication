namespace Job_Verification_Application
{
    partial class ScanningWindow
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
            this.sWJobDataGrid = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEQUENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobVerificationDataSet = new Job_Verification_Application.JobVerificationDataSet();
            this.sEQUENCETableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.SEQUENCETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sequenceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.sWSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEQUENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sWJobDataGrid
            // 
            this.sWJobDataGrid.AllowUserToDeleteRows = false;
            this.sWJobDataGrid.AutoGenerateColumns = false;
            this.sWJobDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sWJobDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.scanDateTimeDataGridViewTextBoxColumn});
            this.sWJobDataGrid.DataSource = this.sEQUENCEBindingSource;
            this.sWJobDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sWJobDataGrid.Location = new System.Drawing.Point(18, 83);
            this.sWJobDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sWJobDataGrid.Name = "sWJobDataGrid";
            this.sWJobDataGrid.ReadOnly = true;
            this.sWJobDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sWJobDataGrid.Size = new System.Drawing.Size(368, 355);
            this.sWJobDataGrid.StandardTab = true;
            this.sWJobDataGrid.TabIndex = 10;
            this.sWJobDataGrid.TabStop = false;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scanDateTimeDataGridViewTextBoxColumn
            // 
            this.scanDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ScanDateTime";
            this.scanDateTimeDataGridViewTextBoxColumn.HeaderText = "ScanDateTime";
            this.scanDateTimeDataGridViewTextBoxColumn.Name = "scanDateTimeDataGridViewTextBoxColumn";
            this.scanDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEQUENCEBindingSource
            // 
            this.sEQUENCEBindingSource.DataMember = "SEQUENCE";
            this.sEQUENCEBindingSource.DataSource = this.jobVerificationDataSet;
            // 
            // jobVerificationDataSet
            // 
            this.jobVerificationDataSet.DataSetName = "JobVerificationDataSet";
            this.jobVerificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEQUENCETableAdapter
            // 
            this.sEQUENCETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // sequenceMaskedTextBox
            // 
            this.sequenceMaskedTextBox.Location = new System.Drawing.Point(18, 485);
            this.sequenceMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sequenceMaskedTextBox.Mask = "00000";
            this.sequenceMaskedTextBox.Name = "sequenceMaskedTextBox";
            this.sequenceMaskedTextBox.Size = new System.Drawing.Size(148, 26);
            this.sequenceMaskedTextBox.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(236, 485);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // sWSubmitButton
            // 
            this.sWSubmitButton.Location = new System.Drawing.Point(152, 551);
            this.sWSubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sWSubmitButton.Name = "sWSubmitButton";
            this.sWSubmitButton.Size = new System.Drawing.Size(112, 35);
            this.sWSubmitButton.TabIndex = 2;
            this.sWSubmitButton.Text = "Submit";
            this.sWSubmitButton.UseVisualStyleBackColor = true;
            this.sWSubmitButton.Click += new System.EventHandler(this.sWSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sequence Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bin Number";
            // 
            // ScanningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sWSubmitButton);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.sequenceMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sWJobDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScanningWindow";
            this.Text = "ScanningWindow";
            this.Load += new System.EventHandler(this.ScanningWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEQUENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sWJobDataGrid;
        private JobVerificationDataSet jobVerificationDataSet;
        private System.Windows.Forms.BindingSource sEQUENCEBindingSource;
        private JobVerificationDataSetTableAdapters.SEQUENCETableAdapter sEQUENCETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox sequenceMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button sWSubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}