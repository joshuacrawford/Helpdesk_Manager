namespace Helpdesk_Manager
{
    partial class LaptopCountForm
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
            this.DellGroupbox = new System.Windows.Forms.GroupBox();
            this.MacGroupbox = new System.Windows.Forms.GroupBox();
            this.CheckedInLabel_Dell = new System.Windows.Forms.Label();
            this.CheckedOutLabel_Dell = new System.Windows.Forms.Label();
            this.CheckedInLabel_Mac = new System.Windows.Forms.Label();
            this.CheckedOutLabel_Mac = new System.Windows.Forms.Label();
            this.CheckedInCombobox_Dell = new System.Windows.Forms.ComboBox();
            this.CheckedOutCombobox_Dell = new System.Windows.Forms.ComboBox();
            this.CheckedInCombobox_Mac = new System.Windows.Forms.ComboBox();
            this.CheckedOutCombobox_Mac = new System.Windows.Forms.ComboBox();
            this.SubmitButton_In = new System.Windows.Forms.Button();
            this.DellGroupbox.SuspendLayout();
            this.MacGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DellGroupbox
            // 
            this.DellGroupbox.Controls.Add(this.CheckedOutCombobox_Dell);
            this.DellGroupbox.Controls.Add(this.CheckedInCombobox_Dell);
            this.DellGroupbox.Controls.Add(this.CheckedOutLabel_Dell);
            this.DellGroupbox.Controls.Add(this.CheckedInLabel_Dell);
            this.DellGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DellGroupbox.Location = new System.Drawing.Point(12, 12);
            this.DellGroupbox.Name = "DellGroupbox";
            this.DellGroupbox.Size = new System.Drawing.Size(260, 116);
            this.DellGroupbox.TabIndex = 0;
            this.DellGroupbox.TabStop = false;
            this.DellGroupbox.Text = "Dell";
            // 
            // MacGroupbox
            // 
            this.MacGroupbox.Controls.Add(this.CheckedOutCombobox_Mac);
            this.MacGroupbox.Controls.Add(this.CheckedInCombobox_Mac);
            this.MacGroupbox.Controls.Add(this.CheckedOutLabel_Mac);
            this.MacGroupbox.Controls.Add(this.CheckedInLabel_Mac);
            this.MacGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MacGroupbox.Location = new System.Drawing.Point(12, 129);
            this.MacGroupbox.Name = "MacGroupbox";
            this.MacGroupbox.Size = new System.Drawing.Size(260, 116);
            this.MacGroupbox.TabIndex = 0;
            this.MacGroupbox.TabStop = false;
            this.MacGroupbox.Text = "Mac";
            // 
            // CheckedInLabel_Dell
            // 
            this.CheckedInLabel_Dell.AutoSize = true;
            this.CheckedInLabel_Dell.Location = new System.Drawing.Point(19, 28);
            this.CheckedInLabel_Dell.Name = "CheckedInLabel_Dell";
            this.CheckedInLabel_Dell.Size = new System.Drawing.Size(87, 18);
            this.CheckedInLabel_Dell.TabIndex = 0;
            this.CheckedInLabel_Dell.Text = "Checked-In:";
            // 
            // CheckedOutLabel_Dell
            // 
            this.CheckedOutLabel_Dell.AutoSize = true;
            this.CheckedOutLabel_Dell.Location = new System.Drawing.Point(6, 80);
            this.CheckedOutLabel_Dell.Name = "CheckedOutLabel_Dell";
            this.CheckedOutLabel_Dell.Size = new System.Drawing.Size(100, 18);
            this.CheckedOutLabel_Dell.TabIndex = 1;
            this.CheckedOutLabel_Dell.Text = "Checked-Out:";
            // 
            // CheckedInLabel_Mac
            // 
            this.CheckedInLabel_Mac.AutoSize = true;
            this.CheckedInLabel_Mac.Location = new System.Drawing.Point(19, 30);
            this.CheckedInLabel_Mac.Name = "CheckedInLabel_Mac";
            this.CheckedInLabel_Mac.Size = new System.Drawing.Size(87, 18);
            this.CheckedInLabel_Mac.TabIndex = 0;
            this.CheckedInLabel_Mac.Text = "Checked-In:";
            // 
            // CheckedOutLabel_Mac
            // 
            this.CheckedOutLabel_Mac.AutoSize = true;
            this.CheckedOutLabel_Mac.Location = new System.Drawing.Point(6, 81);
            this.CheckedOutLabel_Mac.Name = "CheckedOutLabel_Mac";
            this.CheckedOutLabel_Mac.Size = new System.Drawing.Size(100, 18);
            this.CheckedOutLabel_Mac.TabIndex = 1;
            this.CheckedOutLabel_Mac.Text = "Checked-Out:";
            // 
            // CheckedInCombobox_Dell
            // 
            this.CheckedInCombobox_Dell.FormattingEnabled = true;
            this.CheckedInCombobox_Dell.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29"});
            this.CheckedInCombobox_Dell.Location = new System.Drawing.Point(124, 25);
            this.CheckedInCombobox_Dell.Name = "CheckedInCombobox_Dell";
            this.CheckedInCombobox_Dell.Size = new System.Drawing.Size(121, 26);
            this.CheckedInCombobox_Dell.TabIndex = 2;
            // 
            // CheckedOutCombobox_Dell
            // 
            this.CheckedOutCombobox_Dell.FormattingEnabled = true;
            this.CheckedOutCombobox_Dell.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29"});
            this.CheckedOutCombobox_Dell.Location = new System.Drawing.Point(124, 77);
            this.CheckedOutCombobox_Dell.Name = "CheckedOutCombobox_Dell";
            this.CheckedOutCombobox_Dell.Size = new System.Drawing.Size(121, 26);
            this.CheckedOutCombobox_Dell.TabIndex = 3;
            // 
            // CheckedInCombobox_Mac
            // 
            this.CheckedInCombobox_Mac.FormattingEnabled = true;
            this.CheckedInCombobox_Mac.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.CheckedInCombobox_Mac.Location = new System.Drawing.Point(124, 27);
            this.CheckedInCombobox_Mac.Name = "CheckedInCombobox_Mac";
            this.CheckedInCombobox_Mac.Size = new System.Drawing.Size(121, 26);
            this.CheckedInCombobox_Mac.TabIndex = 2;
            // 
            // CheckedOutCombobox_Mac
            // 
            this.CheckedOutCombobox_Mac.FormattingEnabled = true;
            this.CheckedOutCombobox_Mac.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.CheckedOutCombobox_Mac.Location = new System.Drawing.Point(124, 78);
            this.CheckedOutCombobox_Mac.Name = "CheckedOutCombobox_Mac";
            this.CheckedOutCombobox_Mac.Size = new System.Drawing.Size(121, 26);
            this.CheckedOutCombobox_Mac.TabIndex = 3;
            // 
            // SubmitButton_In
            // 
            this.SubmitButton_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton_In.Location = new System.Drawing.Point(68, 251);
            this.SubmitButton_In.Name = "SubmitButton_In";
            this.SubmitButton_In.Size = new System.Drawing.Size(137, 42);
            this.SubmitButton_In.TabIndex = 8;
            this.SubmitButton_In.Text = "Submit";
            this.SubmitButton_In.UseVisualStyleBackColor = true;
            this.SubmitButton_In.Click += new System.EventHandler(this.SubmitButton_In_Click);
            // 
            // LaptopCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.SubmitButton_In);
            this.Controls.Add(this.DellGroupbox);
            this.Controls.Add(this.MacGroupbox);
            this.Name = "LaptopCountForm";
            this.Text = "LaptopCountForm";
            this.DellGroupbox.ResumeLayout(false);
            this.DellGroupbox.PerformLayout();
            this.MacGroupbox.ResumeLayout(false);
            this.MacGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DellGroupbox;
        private System.Windows.Forms.ComboBox CheckedOutCombobox_Dell;
        private System.Windows.Forms.ComboBox CheckedInCombobox_Dell;
        private System.Windows.Forms.Label CheckedOutLabel_Dell;
        private System.Windows.Forms.Label CheckedInLabel_Dell;
        private System.Windows.Forms.GroupBox MacGroupbox;
        private System.Windows.Forms.ComboBox CheckedOutCombobox_Mac;
        private System.Windows.Forms.ComboBox CheckedInCombobox_Mac;
        private System.Windows.Forms.Label CheckedOutLabel_Mac;
        private System.Windows.Forms.Label CheckedInLabel_Mac;
        private System.Windows.Forms.Button SubmitButton_In;

    }
}