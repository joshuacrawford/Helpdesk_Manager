namespace Helpdesk_Manager
{
    partial class FileIssueForm
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
            this.FirstNameLabel_Issue = new System.Windows.Forms.Label();
            this.LastNameLabel_Issue = new System.Windows.Forms.Label();
            this.UINLabel_Issue = new System.Windows.Forms.Label();
            this.DescribeIssueLabel_Issue = new System.Windows.Forms.Label();
            this.FirstNameTextbox_Issue = new System.Windows.Forms.TextBox();
            this.LastNameTextbox_Issue = new System.Windows.Forms.TextBox();
            this.UINTextbox_Issue = new System.Windows.Forms.TextBox();
            this.DiscribeIssueTextbox_Issue = new System.Windows.Forms.TextBox();
            this.SolvedCheckbox_Issue = new System.Windows.Forms.CheckBox();
            this.SubmitButton_Issue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel_Issue
            // 
            this.FirstNameLabel_Issue.AutoSize = true;
            this.FirstNameLabel_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FirstNameLabel_Issue.Location = new System.Drawing.Point(30, 47);
            this.FirstNameLabel_Issue.Name = "FirstNameLabel_Issue";
            this.FirstNameLabel_Issue.Size = new System.Drawing.Size(85, 18);
            this.FirstNameLabel_Issue.TabIndex = 0;
            this.FirstNameLabel_Issue.Text = "First Name:";
            // 
            // LastNameLabel_Issue
            // 
            this.LastNameLabel_Issue.AutoSize = true;
            this.LastNameLabel_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LastNameLabel_Issue.Location = new System.Drawing.Point(31, 120);
            this.LastNameLabel_Issue.Name = "LastNameLabel_Issue";
            this.LastNameLabel_Issue.Size = new System.Drawing.Size(84, 18);
            this.LastNameLabel_Issue.TabIndex = 1;
            this.LastNameLabel_Issue.Text = "Last Name:";
            this.LastNameLabel_Issue.Click += new System.EventHandler(this.LastNameLabel_Issue_Click);
            // 
            // UINLabel_Issue
            // 
            this.UINLabel_Issue.AutoSize = true;
            this.UINLabel_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UINLabel_Issue.Location = new System.Drawing.Point(78, 194);
            this.UINLabel_Issue.Name = "UINLabel_Issue";
            this.UINLabel_Issue.Size = new System.Drawing.Size(37, 18);
            this.UINLabel_Issue.TabIndex = 1;
            this.UINLabel_Issue.Text = "UIN:";
            this.UINLabel_Issue.Click += new System.EventHandler(this.UINLabel_Issue_Click);
            // 
            // DescribeIssueLabel_Issue
            // 
            this.DescribeIssueLabel_Issue.AutoSize = true;
            this.DescribeIssueLabel_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DescribeIssueLabel_Issue.Location = new System.Drawing.Point(299, 27);
            this.DescribeIssueLabel_Issue.Name = "DescribeIssueLabel_Issue";
            this.DescribeIssueLabel_Issue.Size = new System.Drawing.Size(138, 18);
            this.DescribeIssueLabel_Issue.TabIndex = 1;
            this.DescribeIssueLabel_Issue.Text = "What is your issue?";
            // 
            // FirstNameTextbox_Issue
            // 
            this.FirstNameTextbox_Issue.Location = new System.Drawing.Point(140, 48);
            this.FirstNameTextbox_Issue.Name = "FirstNameTextbox_Issue";
            this.FirstNameTextbox_Issue.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextbox_Issue.TabIndex = 1;
            // 
            // LastNameTextbox_Issue
            // 
            this.LastNameTextbox_Issue.Location = new System.Drawing.Point(140, 121);
            this.LastNameTextbox_Issue.Name = "LastNameTextbox_Issue";
            this.LastNameTextbox_Issue.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextbox_Issue.TabIndex = 2;
            // 
            // UINTextbox_Issue
            // 
            this.UINTextbox_Issue.Location = new System.Drawing.Point(140, 195);
            this.UINTextbox_Issue.Name = "UINTextbox_Issue";
            this.UINTextbox_Issue.Size = new System.Drawing.Size(100, 20);
            this.UINTextbox_Issue.TabIndex = 3;
            // 
            // DiscribeIssueTextbox_Issue
            // 
            this.DiscribeIssueTextbox_Issue.Location = new System.Drawing.Point(302, 48);
            this.DiscribeIssueTextbox_Issue.Multiline = true;
            this.DiscribeIssueTextbox_Issue.Name = "DiscribeIssueTextbox_Issue";
            this.DiscribeIssueTextbox_Issue.Size = new System.Drawing.Size(352, 126);
            this.DiscribeIssueTextbox_Issue.TabIndex = 4;
            // 
            // SolvedCheckbox_Issue
            // 
            this.SolvedCheckbox_Issue.AutoSize = true;
            this.SolvedCheckbox_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SolvedCheckbox_Issue.Location = new System.Drawing.Point(302, 194);
            this.SolvedCheckbox_Issue.Name = "SolvedCheckbox_Issue";
            this.SolvedCheckbox_Issue.Size = new System.Drawing.Size(183, 22);
            this.SolvedCheckbox_Issue.TabIndex = 5;
            this.SolvedCheckbox_Issue.Text = "My problem was solved";
            this.SolvedCheckbox_Issue.UseVisualStyleBackColor = true;
            // 
            // SubmitButton_Issue
            // 
            this.SubmitButton_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton_Issue.Location = new System.Drawing.Point(261, 252);
            this.SubmitButton_Issue.Name = "SubmitButton_Issue";
            this.SubmitButton_Issue.Size = new System.Drawing.Size(137, 42);
            this.SubmitButton_Issue.TabIndex = 8;
            this.SubmitButton_Issue.Text = "Submit";
            this.SubmitButton_Issue.UseVisualStyleBackColor = true;
            this.SubmitButton_Issue.Click += new System.EventHandler(this.SubmitButton_Issue_Click);
            // 
            // FileIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 314);
            this.Controls.Add(this.SubmitButton_Issue);
            this.Controls.Add(this.SolvedCheckbox_Issue);
            this.Controls.Add(this.DiscribeIssueTextbox_Issue);
            this.Controls.Add(this.UINTextbox_Issue);
            this.Controls.Add(this.LastNameTextbox_Issue);
            this.Controls.Add(this.FirstNameTextbox_Issue);
            this.Controls.Add(this.DescribeIssueLabel_Issue);
            this.Controls.Add(this.UINLabel_Issue);
            this.Controls.Add(this.LastNameLabel_Issue);
            this.Controls.Add(this.FirstNameLabel_Issue);
            this.Name = "FileIssueForm";
            this.Text = "FileIssureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel_Issue;
        private System.Windows.Forms.Label LastNameLabel_Issue;
        private System.Windows.Forms.Label UINLabel_Issue;
        private System.Windows.Forms.Label DescribeIssueLabel_Issue;
        private System.Windows.Forms.TextBox FirstNameTextbox_Issue;
        private System.Windows.Forms.TextBox LastNameTextbox_Issue;
        private System.Windows.Forms.TextBox UINTextbox_Issue;
        private System.Windows.Forms.TextBox DiscribeIssueTextbox_Issue;
        private System.Windows.Forms.CheckBox SolvedCheckbox_Issue;
        private System.Windows.Forms.Button SubmitButton_Issue;
    }
}