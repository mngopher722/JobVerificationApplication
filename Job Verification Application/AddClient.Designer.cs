namespace Job_Verification_Application
{
    partial class AddClient
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
            this.cWAddClientTextBox = new System.Windows.Forms.TextBox();
            this.cWCancelButton = new System.Windows.Forms.Button();
            this.cWSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cWAddClientTextBox
            // 
            this.cWAddClientTextBox.Location = new System.Drawing.Point(45, 55);
            this.cWAddClientTextBox.Name = "cWAddClientTextBox";
            this.cWAddClientTextBox.Size = new System.Drawing.Size(194, 20);
            this.cWAddClientTextBox.TabIndex = 0;
            this.cWAddClientTextBox.Text = "Please Enter Client Name";
            this.cWAddClientTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cWAddClientTextBox.Leave += new System.EventHandler(this.cWAddClientTextBox_Leave);
            // 
            // cWCancelButton
            // 
            this.cWCancelButton.Location = new System.Drawing.Point(45, 106);
            this.cWCancelButton.Name = "cWCancelButton";
            this.cWCancelButton.Size = new System.Drawing.Size(75, 23);
            this.cWCancelButton.TabIndex = 1;
            this.cWCancelButton.Text = "Cancel";
            this.cWCancelButton.UseVisualStyleBackColor = true;
            this.cWCancelButton.Click += new System.EventHandler(this.cWCancelButton_Click);
            // 
            // cWSubmitButton
            // 
            this.cWSubmitButton.Location = new System.Drawing.Point(163, 105);
            this.cWSubmitButton.Name = "cWSubmitButton";
            this.cWSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.cWSubmitButton.TabIndex = 2;
            this.cWSubmitButton.Text = "Submit";
            this.cWSubmitButton.UseVisualStyleBackColor = true;
            this.cWSubmitButton.Click += new System.EventHandler(this.cWSubmitButton_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 252);
            this.Controls.Add(this.cWSubmitButton);
            this.Controls.Add(this.cWCancelButton);
            this.Controls.Add(this.cWAddClientTextBox);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cWAddClientTextBox;
        private System.Windows.Forms.Button cWCancelButton;
        private System.Windows.Forms.Button cWSubmitButton;
    }
}