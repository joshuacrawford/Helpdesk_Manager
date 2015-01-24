namespace Helpdesk_Manager
{
    partial class HelpdeskManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpdeskToolsButton = new System.Windows.Forms.Button();
            this.FileIssueButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.HelpdeskManagerData = new System.Windows.Forms.DataGridView();
            this.DataLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLaptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCharger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpdeskManagerData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.26951F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HelpdeskManagerData, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpdeskToolsButton);
            this.panel1.Controls.Add(this.FileIssueButton);
            this.panel1.Controls.Add(this.CheckInButton);
            this.panel1.Controls.Add(this.CheckOutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 454);
            this.panel1.TabIndex = 0;
            // 
            // HelpdeskToolsButton
            // 
            this.HelpdeskToolsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpdeskToolsButton.Location = new System.Drawing.Point(19, 327);
            this.HelpdeskToolsButton.Name = "HelpdeskToolsButton";
            this.HelpdeskToolsButton.Size = new System.Drawing.Size(137, 61);
            this.HelpdeskToolsButton.TabIndex = 0;
            this.HelpdeskToolsButton.Text = "Helpdesk Tools";
            this.HelpdeskToolsButton.UseVisualStyleBackColor = true;
            this.HelpdeskToolsButton.Click += new System.EventHandler(this.HelpdeskToolsButton_Click);
            // 
            // FileIssueButton
            // 
            this.FileIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileIssueButton.Location = new System.Drawing.Point(19, 233);
            this.FileIssueButton.Name = "FileIssueButton";
            this.FileIssueButton.Size = new System.Drawing.Size(137, 61);
            this.FileIssueButton.TabIndex = 0;
            this.FileIssueButton.Text = "File An Issue";
            this.FileIssueButton.UseVisualStyleBackColor = true;
            this.FileIssueButton.Click += new System.EventHandler(this.FileIssueButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInButton.Location = new System.Drawing.Point(19, 143);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(137, 61);
            this.CheckInButton.TabIndex = 0;
            this.CheckInButton.Text = "Check-In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(19, 49);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(137, 61);
            this.CheckOutButton.TabIndex = 0;
            this.CheckOutButton.Text = "Check-Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // HelpdeskManagerData
            // 
            this.HelpdeskManagerData.AllowUserToAddRows = false;
            this.HelpdeskManagerData.AllowUserToDeleteRows = false;
            this.HelpdeskManagerData.AllowUserToResizeColumns = false;
            this.HelpdeskManagerData.AllowUserToResizeRows = false;
            this.HelpdeskManagerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HelpdeskManagerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelpdeskManagerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataLastName,
            this.DataFirstName,
            this.DataLaptop,
            this.DataCharger});
            this.HelpdeskManagerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpdeskManagerData.Location = new System.Drawing.Point(183, 3);
            this.HelpdeskManagerData.Name = "HelpdeskManagerData";
            this.HelpdeskManagerData.ReadOnly = true;
            this.HelpdeskManagerData.Size = new System.Drawing.Size(775, 454);
            this.HelpdeskManagerData.TabIndex = 1;
            // 
            // DataLastName
            // 
            this.DataLastName.HeaderText = "Last Name";
            this.DataLastName.Name = "DataLastName";
            this.DataLastName.ReadOnly = true;
            // 
            // DataFirstName
            // 
            this.DataFirstName.HeaderText = "First Name";
            this.DataFirstName.Name = "DataFirstName";
            this.DataFirstName.ReadOnly = true;
            // 
            // DataLaptop
            // 
            this.DataLaptop.HeaderText = "Laptop";
            this.DataLaptop.Name = "DataLaptop";
            this.DataLaptop.ReadOnly = true;
            // 
            // DataCharger
            // 
            this.DataCharger.HeaderText = "Charger";
            this.DataCharger.Name = "DataCharger";
            this.DataCharger.ReadOnly = true;
            // 
            // HelpdeskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HelpdeskManager";
            this.Text = "Helpdesk Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpdeskManagerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HelpdeskToolsButton;
        private System.Windows.Forms.Button FileIssueButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.DataGridView HelpdeskManagerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCharger;
    }
}

