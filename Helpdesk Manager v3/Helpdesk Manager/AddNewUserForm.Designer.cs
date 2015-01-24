namespace Helpdesk_Manager
{
    partial class AddNewUserForm
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
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.AddUserTextbox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.AutoSize = true;
            this.AddUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddUserLabel.Location = new System.Drawing.Point(65, 75);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(243, 18);
            this.AddUserLabel.TabIndex = 0;
            this.AddUserLabel.Text = "Please Enter The User Being Added";
            // 
            // AddUserTextbox
            // 
            this.AddUserTextbox.Location = new System.Drawing.Point(89, 96);
            this.AddUserTextbox.Name = "AddUserTextbox";
            this.AddUserTextbox.Size = new System.Drawing.Size(197, 20);
            this.AddUserTextbox.TabIndex = 1;
            this.AddUserTextbox.TextChanged += new System.EventHandler(this.NameCheckTextbox_TextChanged);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddUserButton.Location = new System.Drawing.Point(138, 122);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(99, 40);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Continue";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.NameCheckButton_Click);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 208);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.AddUserLabel);
            this.Controls.Add(this.AddUserTextbox);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.TextBox AddUserTextbox;
        private System.Windows.Forms.Button AddUserButton;
    }
}