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
            this.uSERXBINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_X_BINTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.USER_X_BINTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERXBINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sWJobDataGrid
            // 
            this.sWJobDataGrid.AllowUserToDeleteRows = false;
            this.sWJobDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sWJobDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sWJobDataGrid.Location = new System.Drawing.Point(12, 24);
            this.sWJobDataGrid.Name = "sWJobDataGrid";
            this.sWJobDataGrid.ReadOnly = true;
            this.sWJobDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sWJobDataGrid.Size = new System.Drawing.Size(237, 289);
            this.sWJobDataGrid.StandardTab = true;
            this.sWJobDataGrid.TabIndex = 10;
            this.sWJobDataGrid.TabStop = false;
            // 
            // jobVerificationDataSet
            // 
            this.jobVerificationDataSet.DataSetName = "JobVerificationDataSet";
            this.jobVerificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERXBINBindingSource
            // 
            this.uSERXBINBindingSource.DataMember = "USER_X_BIN";
            this.uSERXBINBindingSource.DataSource = this.jobVerificationDataSet;
            // 
            // uSER_X_BINTableAdapter
            // 
            this.uSER_X_BINTableAdapter.ClearBeforeFill = true;
            // 
            // ScanningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 411);
            this.Controls.Add(this.sWJobDataGrid);
            this.Name = "ScanningWindow";
            this.Text = "ScanningWindow";
            this.Load += new System.EventHandler(this.ScanningWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERXBINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sWJobDataGrid;
        private JobVerificationDataSet jobVerificationDataSet;
        private System.Windows.Forms.BindingSource uSERXBINBindingSource;
        private JobVerificationDataSetTableAdapters.USER_X_BINTableAdapter uSER_X_BINTableAdapter;
    }
}