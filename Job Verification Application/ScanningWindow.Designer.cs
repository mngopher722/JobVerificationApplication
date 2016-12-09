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
            this.jobVerificationDataSet = new Job_Verification_Application.JobVerificationDataSet();
            this.sEQUENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEQUENCETableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.SEQUENCETableAdapter();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEQUENCEBindingSource)).BeginInit();
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
            this.sWJobDataGrid.Location = new System.Drawing.Point(12, 54);
            this.sWJobDataGrid.Name = "sWJobDataGrid";
            this.sWJobDataGrid.ReadOnly = true;
            this.sWJobDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sWJobDataGrid.Size = new System.Drawing.Size(245, 231);
            this.sWJobDataGrid.StandardTab = true;
            this.sWJobDataGrid.TabIndex = 10;
            this.sWJobDataGrid.TabStop = false;
            // 
            // jobVerificationDataSet
            // 
            this.jobVerificationDataSet.DataSetName = "JobVerificationDataSet";
            this.jobVerificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEQUENCEBindingSource
            // 
            this.sEQUENCEBindingSource.DataMember = "SEQUENCE";
            this.sEQUENCEBindingSource.DataSource = this.jobVerificationDataSet;
            // 
            // sEQUENCETableAdapter
            // 
            this.sEQUENCETableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 315);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(157, 315);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // ScanningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sWJobDataGrid);
            this.Name = "ScanningWindow";
            this.Text = "ScanningWindow";
            this.Load += new System.EventHandler(this.ScanningWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEQUENCEBindingSource)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}