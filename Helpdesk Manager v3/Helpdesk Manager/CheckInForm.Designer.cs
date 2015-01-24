namespace Helpdesk_Manager
{
    partial class CheckInForm
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
            this.FirstNameLabel_In = new System.Windows.Forms.Label();
            this.LastNameLabel_In = new System.Windows.Forms.Label();
            this.UINLabel_In = new System.Windows.Forms.Label();
            this.LaptopMakeLabel_In = new System.Windows.Forms.Label();
            this.LaptopNumberLabel_In = new System.Windows.Forms.Label();
            this.ChargerLabel_In = new System.Windows.Forms.Label();
            this.FirstNameTextbox_In = new System.Windows.Forms.TextBox();
            this.LastNameTextbox_In = new System.Windows.Forms.TextBox();
            this.UINTextbox_In = new System.Windows.Forms.TextBox();
            this.LaptopMakeListbox_In = new System.Windows.Forms.ListBox();
            this.LaptopNumberCombobox_In = new System.Windows.Forms.ComboBox();
            this.ChargerCheckbox_In = new System.Windows.Forms.CheckBox();
            this.SubmitButton_In = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel_In
            // 
            this.FirstNameLabel_In.AutoSize = true;
            this.FirstNameLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel_In.Location = new System.Drawing.Point(211, 29);
            this.FirstNameLabel_In.Name = "FirstNameLabel_In";
            this.FirstNameLabel_In.Size = new System.Drawing.Size(85, 18);
            this.FirstNameLabel_In.TabIndex = 0;
            this.FirstNameLabel_In.Text = "First Name:";
            // 
            // LastNameLabel_In
            // 
            this.LastNameLabel_In.AutoSize = true;
            this.LastNameLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel_In.Location = new System.Drawing.Point(211, 70);
            this.LastNameLabel_In.Name = "LastNameLabel_In";
            this.LastNameLabel_In.Size = new System.Drawing.Size(84, 18);
            this.LastNameLabel_In.TabIndex = 0;
            this.LastNameLabel_In.Text = "Last Name:";
            // 
            // UINLabel_In
            // 
            this.UINLabel_In.AutoSize = true;
            this.UINLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UINLabel_In.Location = new System.Drawing.Point(258, 110);
            this.UINLabel_In.Name = "UINLabel_In";
            this.UINLabel_In.Size = new System.Drawing.Size(37, 18);
            this.UINLabel_In.TabIndex = 0;
            this.UINLabel_In.Text = "UIN:";
            // 
            // LaptopMakeLabel_In
            // 
            this.LaptopMakeLabel_In.AutoSize = true;
            this.LaptopMakeLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaptopMakeLabel_In.Location = new System.Drawing.Point(197, 146);
            this.LaptopMakeLabel_In.Name = "LaptopMakeLabel_In";
            this.LaptopMakeLabel_In.Size = new System.Drawing.Size(98, 18);
            this.LaptopMakeLabel_In.TabIndex = 0;
            this.LaptopMakeLabel_In.Text = "Laptop Make:";
            this.LaptopMakeLabel_In.Click += new System.EventHandler(this.label4_Click);
            // 
            // LaptopNumberLabel_In
            // 
            this.LaptopNumberLabel_In.AutoSize = true;
            this.LaptopNumberLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaptopNumberLabel_In.Location = new System.Drawing.Point(182, 195);
            this.LaptopNumberLabel_In.Name = "LaptopNumberLabel_In";
            this.LaptopNumberLabel_In.Size = new System.Drawing.Size(114, 18);
            this.LaptopNumberLabel_In.TabIndex = 0;
            this.LaptopNumberLabel_In.Text = "Laptop Number:";
            // 
            // ChargerLabel_In
            // 
            this.ChargerLabel_In.AutoSize = true;
            this.ChargerLabel_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerLabel_In.Location = new System.Drawing.Point(231, 237);
            this.ChargerLabel_In.Name = "ChargerLabel_In";
            this.ChargerLabel_In.Size = new System.Drawing.Size(65, 18);
            this.ChargerLabel_In.TabIndex = 0;
            this.ChargerLabel_In.Text = "Charger:";
            this.ChargerLabel_In.Click += new System.EventHandler(this.ChargerLabel_Out_Click);
            // 
            // FirstNameTextbox_In
            // 
            this.FirstNameTextbox_In.Location = new System.Drawing.Point(349, 29);
            this.FirstNameTextbox_In.Name = "FirstNameTextbox_In";
            this.FirstNameTextbox_In.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextbox_In.TabIndex = 1;
            // 
            // LastNameTextbox_In
            // 
            this.LastNameTextbox_In.Location = new System.Drawing.Point(349, 68);
            this.LastNameTextbox_In.Name = "LastNameTextbox_In";
            this.LastNameTextbox_In.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextbox_In.TabIndex = 2;
            // 
            // UINTextbox_In
            // 
            this.UINTextbox_In.Location = new System.Drawing.Point(349, 108);
            this.UINTextbox_In.Name = "UINTextbox_In";
            this.UINTextbox_In.Size = new System.Drawing.Size(100, 20);
            this.UINTextbox_In.TabIndex = 3;
            // 
            // LaptopMakeListbox_In
            // 
            this.LaptopMakeListbox_In.FormattingEnabled = true;
            this.LaptopMakeListbox_In.Items.AddRange(new object[] {
            "Dell",
            "Mac"});
            this.LaptopMakeListbox_In.Location = new System.Drawing.Point(349, 146);
            this.LaptopMakeListbox_In.Name = "LaptopMakeListbox_In";
            this.LaptopMakeListbox_In.Size = new System.Drawing.Size(120, 30);
            this.LaptopMakeListbox_In.TabIndex = 4;
            // 
            // LaptopNumberCombobox_In
            // 
            this.LaptopNumberCombobox_In.FormattingEnabled = true;
            this.LaptopNumberCombobox_In.Items.AddRange(new object[] {
            "Charger Only",
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
            "29",
            "30"});
            this.LaptopNumberCombobox_In.Location = new System.Drawing.Point(349, 192);
            this.LaptopNumberCombobox_In.Name = "LaptopNumberCombobox_In";
            this.LaptopNumberCombobox_In.Size = new System.Drawing.Size(121, 21);
            this.LaptopNumberCombobox_In.TabIndex = 5;
            // 
            // ChargerCheckbox_In
            // 
            this.ChargerCheckbox_In.AutoSize = true;
            this.ChargerCheckbox_In.Location = new System.Drawing.Point(349, 237);
            this.ChargerCheckbox_In.Name = "ChargerCheckbox_In";
            this.ChargerCheckbox_In.Size = new System.Drawing.Size(143, 17);
            this.ChargerCheckbox_In.TabIndex = 6;
            this.ChargerCheckbox_In.Text = "Yes, I returned a charger";
            this.ChargerCheckbox_In.UseVisualStyleBackColor = true;
            // 
            // SubmitButton_In
            // 
            this.SubmitButton_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton_In.Location = new System.Drawing.Point(261, 302);
            this.SubmitButton_In.Name = "SubmitButton_In";
            this.SubmitButton_In.Size = new System.Drawing.Size(137, 42);
            this.SubmitButton_In.TabIndex = 7;
            this.SubmitButton_In.Text = "Submit";
            this.SubmitButton_In.UseVisualStyleBackColor = true;
            this.SubmitButton_In.Click += new System.EventHandler(this.SubmitButton_Out_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 356);
            this.Controls.Add(this.SubmitButton_In);
            this.Controls.Add(this.FirstNameLabel_In);
            this.Controls.Add(this.ChargerCheckbox_In);
            this.Controls.Add(this.LastNameLabel_In);
            this.Controls.Add(this.LaptopNumberCombobox_In);
            this.Controls.Add(this.UINLabel_In);
            this.Controls.Add(this.LaptopMakeListbox_In);
            this.Controls.Add(this.LaptopMakeLabel_In);
            this.Controls.Add(this.UINTextbox_In);
            this.Controls.Add(this.LaptopNumberLabel_In);
            this.Controls.Add(this.LastNameTextbox_In);
            this.Controls.Add(this.ChargerLabel_In);
            this.Controls.Add(this.FirstNameTextbox_In);
            this.Name = "CheckInForm";
            this.Text = "Check-In Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel_In;
        private System.Windows.Forms.Label LastNameLabel_In;
        private System.Windows.Forms.Label UINLabel_In;
        private System.Windows.Forms.Label LaptopMakeLabel_In;
        private System.Windows.Forms.Label LaptopNumberLabel_In;
        private System.Windows.Forms.Label ChargerLabel_In;
        private System.Windows.Forms.TextBox FirstNameTextbox_In;
        private System.Windows.Forms.TextBox LastNameTextbox_In;
        private System.Windows.Forms.TextBox UINTextbox_In;
        private System.Windows.Forms.ListBox LaptopMakeListbox_In;
        private System.Windows.Forms.ComboBox LaptopNumberCombobox_In;
        private System.Windows.Forms.CheckBox ChargerCheckbox_In;
        private System.Windows.Forms.Button SubmitButton_In;

    }
}