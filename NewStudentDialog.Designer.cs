namespace FS_CS_ETS_Project
{
    partial class NewStudentDialog
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
            this.BodyAndFootSplit = new System.Windows.Forms.SplitContainer();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.seatNumberLabel = new System.Windows.Forms.Label();
            this.seatNumberField = new System.Windows.Forms.NumericUpDown();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayField = new System.Windows.Forms.DateTimePicker();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.addressField1 = new System.Windows.Forms.TextBox();
            this.addressLabel2 = new System.Windows.Forms.Label();
            this.addressField2 = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesField = new System.Windows.Forms.TextBox();
            this.requiredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BodyAndFootSplit)).BeginInit();
            this.BodyAndFootSplit.Panel1.SuspendLayout();
            this.BodyAndFootSplit.Panel2.SuspendLayout();
            this.BodyAndFootSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyAndFootSplit
            // 
            this.BodyAndFootSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyAndFootSplit.Location = new System.Drawing.Point(0, 0);
            this.BodyAndFootSplit.Name = "BodyAndFootSplit";
            this.BodyAndFootSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BodyAndFootSplit.Panel1
            // 
            this.BodyAndFootSplit.Panel1.Controls.Add(this.nameLabel);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.nameField);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.seatNumberLabel);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.seatNumberField);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.birthdayLabel);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.birthdayField);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.addressLabel1);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.addressField1);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.addressLabel2);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.addressField2);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.notesLabel);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.notesField);
            this.BodyAndFootSplit.Panel1.Controls.Add(this.requiredLabel);
            // 
            // BodyAndFootSplit.Panel2
            // 
            this.BodyAndFootSplit.Panel2.Controls.Add(this.createStudentButton);
            this.BodyAndFootSplit.Size = new System.Drawing.Size(319, 361);
            this.BodyAndFootSplit.SplitterDistance = 332;
            this.BodyAndFootSplit.TabIndex = 0;
            // 
            // createStudentButton
            // 
            this.createStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createStudentButton.Enabled = false;
            this.createStudentButton.Location = new System.Drawing.Point(0, 0);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(319, 25);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Name*";
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(82, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(225, 20);
            this.nameField.TabIndex = 18;
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberLabel.AutoSize = true;
            this.seatNumberLabel.Location = new System.Drawing.Point(12, 41);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(43, 13);
            this.seatNumberLabel.TabIndex = 19;
            this.seatNumberLabel.Text = "Seat #*";
            // 
            // seatNumberField
            // 
            this.seatNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberField.Location = new System.Drawing.Point(82, 39);
            this.seatNumberField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.seatNumberField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatNumberField.Name = "seatNumberField";
            this.seatNumberField.Size = new System.Drawing.Size(225, 20);
            this.seatNumberField.TabIndex = 20;
            this.seatNumberField.ThousandsSeparator = true;
            this.seatNumberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(12, 72);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdayLabel.TabIndex = 21;
            this.birthdayLabel.Text = "Birthday*";
            // 
            // birthdayField
            // 
            this.birthdayField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayField.Location = new System.Drawing.Point(82, 67);
            this.birthdayField.Name = "birthdayField";
            this.birthdayField.Size = new System.Drawing.Size(225, 20);
            this.birthdayField.TabIndex = 22;
            this.birthdayField.Value = new System.DateTime(2021, 6, 18, 13, 31, 8, 0);
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Location = new System.Drawing.Point(12, 99);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(58, 13);
            this.addressLabel1.TabIndex = 23;
            this.addressLabel1.Text = "Address 1*";
            // 
            // addressField1
            // 
            this.addressField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField1.Location = new System.Drawing.Point(82, 96);
            this.addressField1.Name = "addressField1";
            this.addressField1.Size = new System.Drawing.Size(225, 20);
            this.addressField1.TabIndex = 24;
            // 
            // addressLabel2
            // 
            this.addressLabel2.AutoSize = true;
            this.addressLabel2.Location = new System.Drawing.Point(12, 128);
            this.addressLabel2.Name = "addressLabel2";
            this.addressLabel2.Size = new System.Drawing.Size(54, 13);
            this.addressLabel2.TabIndex = 25;
            this.addressLabel2.Text = "Address 2";
            // 
            // addressField2
            // 
            this.addressField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField2.Location = new System.Drawing.Point(82, 125);
            this.addressField2.Name = "addressField2";
            this.addressField2.Size = new System.Drawing.Size(225, 20);
            this.addressField2.TabIndex = 26;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(12, 157);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 28;
            this.notesLabel.Text = "Notes";
            // 
            // notesField
            // 
            this.notesField.AcceptsReturn = true;
            this.notesField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesField.Location = new System.Drawing.Point(82, 154);
            this.notesField.Multiline = true;
            this.notesField.Name = "notesField";
            this.notesField.Size = new System.Drawing.Size(225, 143);
            this.notesField.TabIndex = 27;
            // 
            // requiredLabel
            // 
            this.requiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.requiredLabel.Location = new System.Drawing.Point(12, 309);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(57, 13);
            this.requiredLabel.TabIndex = 29;
            this.requiredLabel.Text = "* Required";
            // 
            // NewStudentDialog
            // 
            this.AcceptButton = this.createStudentButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 361);
            this.Controls.Add(this.BodyAndFootSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStudentDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Student";
            this.BodyAndFootSplit.Panel1.ResumeLayout(false);
            this.BodyAndFootSplit.Panel1.PerformLayout();
            this.BodyAndFootSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BodyAndFootSplit)).EndInit();
            this.BodyAndFootSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer BodyAndFootSplit;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label seatNumberLabel;
        internal System.Windows.Forms.NumericUpDown seatNumberField;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.DateTimePicker birthdayField;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.TextBox addressField1;
        private System.Windows.Forms.Label addressLabel2;
        private System.Windows.Forms.TextBox addressField2;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesField;
        private System.Windows.Forms.Label requiredLabel;
    }
}