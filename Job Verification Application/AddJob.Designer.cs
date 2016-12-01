namespace Job_Verification_Application
{
    partial class AddJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJob));
            this.jWJobNumMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.jobVerificationDataSet = new Job_Verification_Application.JobVerificationDataSet();
            this.jWJobDescTextBox = new System.Windows.Forms.TextBox();
            this.jWClientComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.CLIENTTableAdapter();
            this.jWCancelButton = new System.Windows.Forms.Button();
            this.jWSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jWJobNumMaskedTB
            // 
            this.jWJobNumMaskedTB.Location = new System.Drawing.Point(110, 43);
            this.jWJobNumMaskedTB.Mask = "000000";
            this.jWJobNumMaskedTB.Name = "jWJobNumMaskedTB";
            this.jWJobNumMaskedTB.Size = new System.Drawing.Size(140, 20);
            this.jWJobNumMaskedTB.TabIndex = 0;
            this.jWJobNumMaskedTB.Leave += new System.EventHandler(this.jWJobNumMaskedTB_Leave);
            // 
            // jobVerificationDataSet
            // 
            this.jobVerificationDataSet.DataSetName = "JobVerificationDataSet";
            this.jobVerificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jWJobDescTextBox
            // 
            this.jWJobDescTextBox.Location = new System.Drawing.Point(110, 90);
            this.jWJobDescTextBox.Name = "jWJobDescTextBox";
            this.jWJobDescTextBox.Size = new System.Drawing.Size(140, 20);
            this.jWJobDescTextBox.TabIndex = 1;
            this.jWJobDescTextBox.Leave += new System.EventHandler(this.jWJobDescTextBox_Leave);
            // 
            // jWClientComboBox
            // 
            this.jWClientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTBindingSource, "ClientID", true));
            this.jWClientComboBox.DataSource = this.cLIENTBindingSource;
            this.jWClientComboBox.DisplayMember = "ClientName";
            this.jWClientComboBox.FormattingEnabled = true;
            this.jWClientComboBox.Location = new System.Drawing.Point(110, 140);
            this.jWClientComboBox.Name = "jWClientComboBox";
            this.jWClientComboBox.Size = new System.Drawing.Size(140, 21);
            this.jWClientComboBox.TabIndex = 2;
            this.jWClientComboBox.ValueMember = "ClientID";
            this.jWClientComboBox.SelectedIndexChanged += new System.EventHandler(this.jWClientComboBox_SelectedIndexChanged);
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.jobVerificationDataSet;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // jWCancelButton
            // 
            this.jWCancelButton.Location = new System.Drawing.Point(35, 183);
            this.jWCancelButton.Name = "jWCancelButton";
            this.jWCancelButton.Size = new System.Drawing.Size(75, 23);
            this.jWCancelButton.TabIndex = 3;
            this.jWCancelButton.Text = "Cancel";
            this.jWCancelButton.UseVisualStyleBackColor = true;
            this.jWCancelButton.Click += new System.EventHandler(this.jWCancelButton_Click);
            // 
            // jWSubmitButton
            // 
            this.jWSubmitButton.Location = new System.Drawing.Point(162, 183);
            this.jWSubmitButton.Name = "jWSubmitButton";
            this.jWSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.jWSubmitButton.TabIndex = 4;
            this.jWSubmitButton.Text = "Submit";
            this.jWSubmitButton.UseVisualStyleBackColor = true;
            this.jWSubmitButton.Click += new System.EventHandler(this.jWSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Job Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Job Desc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Client";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jWSubmitButton);
            this.Controls.Add(this.jWCancelButton);
            this.Controls.Add(this.jWClientComboBox);
            this.Controls.Add(this.jWJobDescTextBox);
            this.Controls.Add(this.jWJobNumMaskedTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JobVerificationDataSet jobVerificationDataSet;
        private System.Windows.Forms.TextBox jWJobDescTextBox;
        private System.Windows.Forms.ComboBox jWClientComboBox;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private JobVerificationDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.Button jWCancelButton;
        private System.Windows.Forms.Button jWSubmitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox jWJobNumMaskedTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}