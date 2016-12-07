namespace Job_Verification_Application
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.configJobButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.addJobButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.startProcessButton = new System.Windows.Forms.Button();
            this.mWJobComboBox = new System.Windows.Forms.ComboBox();
            this.jOBXBINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobVerificationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobVerificationDataSet = new Job_Verification_Application.JobVerificationDataSet();
            this.jOBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mWBinComboBox = new System.Windows.Forms.ComboBox();
            this.bINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bINTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.BINTableAdapter();
            this.jOBTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.JOBTableAdapter();
            this.mWUser1ComboBox = new System.Windows.Forms.ComboBox();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mWUser2ComboBox = new System.Windows.Forms.ComboBox();
            this.uSERTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.USERTableAdapter();
            this.xqtyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jOB_X_BINTableAdapter = new Job_Verification_Application.JobVerificationDataSetTableAdapters.JOB_X_BINTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jOBXBINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // configJobButton
            // 
            this.configJobButton.Location = new System.Drawing.Point(50, 244);
            this.configJobButton.Name = "configJobButton";
            this.configJobButton.Size = new System.Drawing.Size(75, 23);
            this.configJobButton.TabIndex = 6;
            this.configJobButton.Text = "Configure Job";
            this.configJobButton.UseVisualStyleBackColor = true;
            this.configJobButton.Click += new System.EventHandler(this.configJobButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(131, 244);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(75, 23);
            this.addClientButton.TabIndex = 7;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // addJobButton
            // 
            this.addJobButton.Location = new System.Drawing.Point(212, 244);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(75, 23);
            this.addJobButton.TabIndex = 8;
            this.addJobButton.Text = "Add Job";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.addJobButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(293, 244);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(374, 244);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(75, 23);
            this.reportsButton.TabIndex = 10;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // startProcessButton
            // 
            this.startProcessButton.Location = new System.Drawing.Point(339, 184);
            this.startProcessButton.Name = "startProcessButton";
            this.startProcessButton.Size = new System.Drawing.Size(122, 35);
            this.startProcessButton.TabIndex = 5;
            this.startProcessButton.Text = "Start Processing";
            this.startProcessButton.UseVisualStyleBackColor = true;
            this.startProcessButton.Click += new System.EventHandler(this.startProcessButton_Click);
            // 
            // mWJobComboBox
            // 
            this.mWJobComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jOBXBINBindingSource, "JobID_X_BinID", true));
            this.mWJobComboBox.FormattingEnabled = true;
            this.mWJobComboBox.Location = new System.Drawing.Point(108, 108);
            this.mWJobComboBox.Name = "mWJobComboBox";
            this.mWJobComboBox.Size = new System.Drawing.Size(136, 21);
            this.mWJobComboBox.TabIndex = 0;
            this.mWJobComboBox.SelectionChangeCommitted += new System.EventHandler(this.mWJobComboBox_SelectionChangeCommitted);
            // 
            // jOBXBINBindingSource
            // 
            this.jOBXBINBindingSource.DataMember = "JOB_X_BIN";
            this.jOBXBINBindingSource.DataSource = this.jobVerificationDataSetBindingSource;
            // 
            // jobVerificationDataSetBindingSource
            // 
            this.jobVerificationDataSetBindingSource.DataSource = this.jobVerificationDataSet;
            this.jobVerificationDataSetBindingSource.Position = 0;
            // 
            // jobVerificationDataSet
            // 
            this.jobVerificationDataSet.DataSetName = "JobVerificationDataSet";
            this.jobVerificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBBindingSource
            // 
            this.jOBBindingSource.DataMember = "JOB";
            this.jOBBindingSource.DataSource = this.jobVerificationDataSetBindingSource;
            // 
            // jOBBindingSource1
            // 
            this.jOBBindingSource1.DataMember = "JOB";
            this.jOBBindingSource1.DataSource = this.jobVerificationDataSetBindingSource;
            // 
            // mWBinComboBox
            // 
            this.mWBinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bINBindingSource, "BinID", true));
            this.mWBinComboBox.DataSource = this.jOBXBINBindingSource;
            this.mWBinComboBox.DisplayMember = "FK_BinID";
            this.mWBinComboBox.FormattingEnabled = true;
            this.mWBinComboBox.Location = new System.Drawing.Point(108, 146);
            this.mWBinComboBox.Name = "mWBinComboBox";
            this.mWBinComboBox.Size = new System.Drawing.Size(136, 21);
            this.mWBinComboBox.TabIndex = 1;
            this.mWBinComboBox.ValueMember = "FK_BinID";
            this.mWBinComboBox.SelectionChangeCommitted += new System.EventHandler(this.mWBinComboBox_SelectionChangeCommitted);
            // 
            // bINBindingSource
            // 
            this.bINBindingSource.DataMember = "BIN";
            this.bINBindingSource.DataSource = this.jobVerificationDataSetBindingSource;
            // 
            // bINTableAdapter
            // 
            this.bINTableAdapter.ClearBeforeFill = true;
            // 
            // jOBTableAdapter
            // 
            this.jOBTableAdapter.ClearBeforeFill = true;
            // 
            // mWUser1ComboBox
            // 
            this.mWUser1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSERBindingSource, "UserID", true));
            this.mWUser1ComboBox.FormattingEnabled = true;
            this.mWUser1ComboBox.Location = new System.Drawing.Point(340, 108);
            this.mWUser1ComboBox.Name = "mWUser1ComboBox";
            this.mWUser1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.mWUser1ComboBox.TabIndex = 3;
            this.mWUser1ComboBox.SelectionChangeCommitted += new System.EventHandler(this.mWUser1ComboBox_SelectionChangeCommitted);
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.jobVerificationDataSetBindingSource;
            // 
            // mWUser2ComboBox
            // 
            this.mWUser2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSERBindingSource, "UserID", true));
            this.mWUser2ComboBox.FormattingEnabled = true;
            this.mWUser2ComboBox.Location = new System.Drawing.Point(340, 146);
            this.mWUser2ComboBox.Name = "mWUser2ComboBox";
            this.mWUser2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.mWUser2ComboBox.TabIndex = 4;
            this.mWUser2ComboBox.SelectionChangeCommitted += new System.EventHandler(this.mWUser2ComboBox_SelectionChangeCommitted);
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // xqtyTextBox
            // 
            this.xqtyTextBox.Location = new System.Drawing.Point(108, 188);
            this.xqtyTextBox.Mask = "00000";
            this.xqtyTextBox.Name = "xqtyTextBox";
            this.xqtyTextBox.Size = new System.Drawing.Size(136, 20);
            this.xqtyTextBox.TabIndex = 2;
            this.xqtyTextBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Job Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bin Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "User 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Expected Qty :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Verification_Application.Properties.Resources.MailHausLogo_2C;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // jOB_X_BINTableAdapter
            // 
            this.jOB_X_BINTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xqtyTextBox);
            this.Controls.Add(this.mWUser2ComboBox);
            this.Controls.Add(this.mWUser1ComboBox);
            this.Controls.Add(this.mWBinComboBox);
            this.Controls.Add(this.mWJobComboBox);
            this.Controls.Add(this.startProcessButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.configJobButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jOBXBINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobVerificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configJobButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addJobButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button startProcessButton;
        private System.Windows.Forms.ComboBox mWJobComboBox;
        private System.Windows.Forms.ComboBox mWBinComboBox;
        private System.Windows.Forms.BindingSource jobVerificationDataSetBindingSource;
        private JobVerificationDataSet jobVerificationDataSet;
        private System.Windows.Forms.BindingSource bINBindingSource;
        private JobVerificationDataSetTableAdapters.BINTableAdapter bINTableAdapter;
        private System.Windows.Forms.BindingSource jOBBindingSource;
        private JobVerificationDataSetTableAdapters.JOBTableAdapter jOBTableAdapter;
        private System.Windows.Forms.BindingSource jOBBindingSource1;
        private System.Windows.Forms.ComboBox mWUser1ComboBox;
        private System.Windows.Forms.ComboBox mWUser2ComboBox;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private JobVerificationDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private System.Windows.Forms.MaskedTextBox xqtyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource jOBXBINBindingSource;
        private JobVerificationDataSetTableAdapters.JOB_X_BINTableAdapter jOB_X_BINTableAdapter;
    }
}