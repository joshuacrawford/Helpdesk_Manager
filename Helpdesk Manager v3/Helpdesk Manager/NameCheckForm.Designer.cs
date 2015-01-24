namespace Helpdesk_Manager
{
    partial class NameCheckForm
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
            this.NameCheckLabel = new System.Windows.Forms.Label();
            this.NameCheckTextbox = new System.Windows.Forms.TextBox();
            this.NameCheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameCheckLabel
            // 
            this.NameCheckLabel.AutoSize = true;
            this.NameCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameCheckLabel.Location = new System.Drawing.Point(86, 75);
            this.NameCheckLabel.Name = "NameCheckLabel";
            this.NameCheckLabel.Size = new System.Drawing.Size(200, 18);
            this.NameCheckLabel.TabIndex = 0;
            this.NameCheckLabel.Text = "Please Enter Your Username";
            this.NameCheckLabel.Click += new System.EventHandler(this.NameCheckLabel_Click);
            // 
            // NameCheckTextbox
            // 
            this.NameCheckTextbox.Location = new System.Drawing.Point(89, 96);
            this.NameCheckTextbox.Name = "NameCheckTextbox";
            this.NameCheckTextbox.Size = new System.Drawing.Size(197, 20);
            this.NameCheckTextbox.TabIndex = 1;
            this.NameCheckTextbox.TextChanged += new System.EventHandler(this.NameCheckTextbox_TextChanged);
            // 
            // NameCheckButton
            // 
            this.NameCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NameCheckButton.Location = new System.Drawing.Point(138, 122);
            this.NameCheckButton.Name = "NameCheckButton";
            this.NameCheckButton.Size = new System.Drawing.Size(99, 40);
            this.NameCheckButton.TabIndex = 2;
            this.NameCheckButton.Text = "Continue";
            this.NameCheckButton.UseVisualStyleBackColor = true;
            this.NameCheckButton.Click += new System.EventHandler(this.NameCheckButton_Click);
            // 
            // NameCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 208);
            this.Controls.Add(this.NameCheckButton);
            this.Controls.Add(this.NameCheckTextbox);
            this.Controls.Add(this.NameCheckLabel);
            this.Name = "NameCheckForm";
            this.Text = "NameCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameCheckLabel;
        private System.Windows.Forms.TextBox NameCheckTextbox;
        private System.Windows.Forms.Button NameCheckButton;
    }
}