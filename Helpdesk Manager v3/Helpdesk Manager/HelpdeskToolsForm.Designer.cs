namespace Helpdesk_Manager
{
    partial class HelpdeskToolsForm
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
            this.LaptopCount_Tools = new System.Windows.Forms.Button();
            this.AddNewUser_Tools = new System.Windows.Forms.Button();
            this.ExitButton_Tools = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaptopCount_Tools
            // 
            this.LaptopCount_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LaptopCount_Tools.Location = new System.Drawing.Point(28, 25);
            this.LaptopCount_Tools.Name = "LaptopCount_Tools";
            this.LaptopCount_Tools.Size = new System.Drawing.Size(96, 44);
            this.LaptopCount_Tools.TabIndex = 0;
            this.LaptopCount_Tools.Text = "Laptop Count";
            this.LaptopCount_Tools.UseVisualStyleBackColor = true;
            this.LaptopCount_Tools.Click += new System.EventHandler(this.LaptopCount_Tools_Click);
            // 
            // AddNewUser_Tools
            // 
            this.AddNewUser_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddNewUser_Tools.Location = new System.Drawing.Point(159, 25);
            this.AddNewUser_Tools.Name = "AddNewUser_Tools";
            this.AddNewUser_Tools.Size = new System.Drawing.Size(96, 44);
            this.AddNewUser_Tools.TabIndex = 1;
            this.AddNewUser_Tools.Text = "Add New User";
            this.AddNewUser_Tools.UseVisualStyleBackColor = true;
            this.AddNewUser_Tools.Click += new System.EventHandler(this.AddNewUser_Tools_Click);
            // 
            // ExitButton_Tools
            // 
            this.ExitButton_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ExitButton_Tools.Location = new System.Drawing.Point(93, 99);
            this.ExitButton_Tools.Name = "ExitButton_Tools";
            this.ExitButton_Tools.Size = new System.Drawing.Size(96, 44);
            this.ExitButton_Tools.TabIndex = 2;
            this.ExitButton_Tools.Text = "Exit Tools";
            this.ExitButton_Tools.UseVisualStyleBackColor = true;
            this.ExitButton_Tools.Click += new System.EventHandler(this.ExitButton_Tools_Click);
            // 
            // HelpdeskToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.ExitButton_Tools);
            this.Controls.Add(this.AddNewUser_Tools);
            this.Controls.Add(this.LaptopCount_Tools);
            this.Name = "HelpdeskToolsForm";
            this.Text = "HelpdeskToolsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LaptopCount_Tools;
        private System.Windows.Forms.Button AddNewUser_Tools;
        private System.Windows.Forms.Button ExitButton_Tools;
    }
}