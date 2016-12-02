namespace Job_Verification_Application
{
    partial class ConfigJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigJob));
            this.cfgWJobNumComboBox = new System.Windows.Forms.ComboBox();
            this.cfgWBinNumComboBox = new System.Windows.Forms.ComboBox();
            this.cfgWCancelButton = new System.Windows.Forms.Button();
            this.cfgWSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cfgWJobNumComboBox
            // 
            this.cfgWJobNumComboBox.FormattingEnabled = true;
            this.cfgWJobNumComboBox.Items.AddRange(new object[] {
            "--Please Select Job--"});
            this.cfgWJobNumComboBox.Location = new System.Drawing.Point(129, 32);
            this.cfgWJobNumComboBox.Name = "cfgWJobNumComboBox";
            this.cfgWJobNumComboBox.Size = new System.Drawing.Size(121, 21);
            this.cfgWJobNumComboBox.TabIndex = 0;
            this.cfgWJobNumComboBox.Leave += new System.EventHandler(this.cfgWJobNumComboBox_Leave);
            // 
            // cfgWBinNumComboBox
            // 
            this.cfgWBinNumComboBox.FormattingEnabled = true;
            this.cfgWBinNumComboBox.Location = new System.Drawing.Point(129, 82);
            this.cfgWBinNumComboBox.Name = "cfgWBinNumComboBox";
            this.cfgWBinNumComboBox.Size = new System.Drawing.Size(121, 21);
            this.cfgWBinNumComboBox.TabIndex = 1;
            this.cfgWBinNumComboBox.Leave += new System.EventHandler(this.cfgWBinNumComboBox_Leave);
            // 
            // cfgWCancelButton
            // 
            this.cfgWCancelButton.Location = new System.Drawing.Point(35, 136);
            this.cfgWCancelButton.Name = "cfgWCancelButton";
            this.cfgWCancelButton.Size = new System.Drawing.Size(75, 23);
            this.cfgWCancelButton.TabIndex = 2;
            this.cfgWCancelButton.Text = "Cancel";
            this.cfgWCancelButton.UseVisualStyleBackColor = true;
            this.cfgWCancelButton.Click += new System.EventHandler(this.cfgWCancelButton_Click);
            // 
            // cfgWSubmitButton
            // 
            this.cfgWSubmitButton.Location = new System.Drawing.Point(177, 135);
            this.cfgWSubmitButton.Name = "cfgWSubmitButton";
            this.cfgWSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.cfgWSubmitButton.TabIndex = 3;
            this.cfgWSubmitButton.Text = "Submit";
            this.cfgWSubmitButton.UseVisualStyleBackColor = true;
            this.cfgWSubmitButton.Click += new System.EventHandler(this.cfgWSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Bins :";
            // 
            // ConfigJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cfgWSubmitButton);
            this.Controls.Add(this.cfgWCancelButton);
            this.Controls.Add(this.cfgWBinNumComboBox);
            this.Controls.Add(this.cfgWJobNumComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigJob";
            this.Load += new System.EventHandler(this.ConfigJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cfgWJobNumComboBox;
        private System.Windows.Forms.ComboBox cfgWBinNumComboBox;
        private System.Windows.Forms.Button cfgWCancelButton;
        private System.Windows.Forms.Button cfgWSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}