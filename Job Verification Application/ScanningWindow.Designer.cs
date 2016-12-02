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
            this.sWJobDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sWJobDataGrid)).BeginInit();
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
            this.sWJobDataGrid.TabIndex = 10;
            this.sWJobDataGrid.TabStop = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sWJobDataGrid;
    }
}