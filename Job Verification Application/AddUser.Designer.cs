namespace Job_Verification_Application
{
    partial class AddUser
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
            this.uWFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.uWLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uWCancelButton = new System.Windows.Forms.Button();
            this.uWSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uWFirstNameTextBox
            // 
            this.uWFirstNameTextBox.Location = new System.Drawing.Point(140, 41);
            this.uWFirstNameTextBox.Name = "uWFirstNameTextBox";
            this.uWFirstNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.uWFirstNameTextBox.TabIndex = 0;
            this.uWFirstNameTextBox.Leave += new System.EventHandler(this.uWFirstNameTextBox_Leave);
            // 
            // uWLastNameTextBox
            // 
            this.uWLastNameTextBox.Location = new System.Drawing.Point(140, 85);
            this.uWLastNameTextBox.Name = "uWLastNameTextBox";
            this.uWLastNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.uWLastNameTextBox.TabIndex = 1;
            this.uWLastNameTextBox.Leave += new System.EventHandler(this.uWLastNameTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Last Name";
            // 
            // uWCancelButton
            // 
            this.uWCancelButton.Location = new System.Drawing.Point(42, 153);
            this.uWCancelButton.Name = "uWCancelButton";
            this.uWCancelButton.Size = new System.Drawing.Size(75, 23);
            this.uWCancelButton.TabIndex = 4;
            this.uWCancelButton.Text = "Cancel";
            this.uWCancelButton.UseVisualStyleBackColor = true;
            this.uWCancelButton.Click += new System.EventHandler(this.uWCancelButton_Click);
            // 
            // uWSubmitButton
            // 
            this.uWSubmitButton.Location = new System.Drawing.Point(194, 153);
            this.uWSubmitButton.Name = "uWSubmitButton";
            this.uWSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.uWSubmitButton.TabIndex = 5;
            this.uWSubmitButton.Text = "Submit";
            this.uWSubmitButton.UseVisualStyleBackColor = true;
            this.uWSubmitButton.Click += new System.EventHandler(this.uWSubmitButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 203);
            this.Controls.Add(this.uWSubmitButton);
            this.Controls.Add(this.uWCancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uWLastNameTextBox);
            this.Controls.Add(this.uWFirstNameTextBox);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uWFirstNameTextBox;
        private System.Windows.Forms.TextBox uWLastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uWCancelButton;
        private System.Windows.Forms.Button uWSubmitButton;
    }
}