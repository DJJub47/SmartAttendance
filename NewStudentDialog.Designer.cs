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
            this.BodySplit = new System.Windows.Forms.SplitContainer();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.attributeLabel = new System.Windows.Forms.Label();
            this.createStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BodyAndFootSplit)).BeginInit();
            this.BodyAndFootSplit.Panel1.SuspendLayout();
            this.BodyAndFootSplit.Panel2.SuspendLayout();
            this.BodyAndFootSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BodySplit)).BeginInit();
            this.BodySplit.Panel1.SuspendLayout();
            this.BodySplit.Panel2.SuspendLayout();
            this.BodySplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.BodyAndFootSplit.Panel1.Controls.Add(this.BodySplit);
            // 
            // BodyAndFootSplit.Panel2
            // 
            this.BodyAndFootSplit.Panel2.Controls.Add(this.createStudentButton);
            this.BodyAndFootSplit.Size = new System.Drawing.Size(584, 361);
            this.BodyAndFootSplit.SplitterDistance = 332;
            this.BodyAndFootSplit.TabIndex = 0;
            // 
            // BodySplit
            // 
            this.BodySplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodySplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodySplit.Location = new System.Drawing.Point(0, 0);
            this.BodySplit.Name = "BodySplit";
            // 
            // BodySplit.Panel1
            // 
            this.BodySplit.Panel1.Controls.Add(this.nameLabel);
            this.BodySplit.Panel1.Controls.Add(this.nameField);
            this.BodySplit.Panel1.Controls.Add(this.seatNumberLabel);
            this.BodySplit.Panel1.Controls.Add(this.seatNumberField);
            this.BodySplit.Panel1.Controls.Add(this.birthdayLabel);
            this.BodySplit.Panel1.Controls.Add(this.birthdayField);
            this.BodySplit.Panel1.Controls.Add(this.addressLabel1);
            this.BodySplit.Panel1.Controls.Add(this.addressField1);
            this.BodySplit.Panel1.Controls.Add(this.addressLabel2);
            this.BodySplit.Panel1.Controls.Add(this.addressField2);
            this.BodySplit.Panel1.Controls.Add(this.notesLabel);
            this.BodySplit.Panel1.Controls.Add(this.notesField);
            this.BodySplit.Panel1.Controls.Add(this.requiredLabel);
            // 
            // BodySplit.Panel2
            // 
            this.BodySplit.Panel2.Controls.Add(this.splitContainer1);
            this.BodySplit.Size = new System.Drawing.Size(584, 332);
            this.BodySplit.SplitterDistance = 290;
            this.BodySplit.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name*";
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(80, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(195, 20);
            this.nameField.TabIndex = 5;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberLabel.AutoSize = true;
            this.seatNumberLabel.Location = new System.Drawing.Point(10, 41);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(43, 13);
            this.seatNumberLabel.TabIndex = 6;
            this.seatNumberLabel.Text = "Seat #*";
            // 
            // seatNumberField
            // 
            this.seatNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberField.Location = new System.Drawing.Point(80, 39);
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
            this.seatNumberField.Size = new System.Drawing.Size(195, 20);
            this.seatNumberField.TabIndex = 7;
            this.seatNumberField.ThousandsSeparator = true;
            this.seatNumberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatNumberField.ValueChanged += new System.EventHandler(this.seatNumberField_ValueChanged);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(10, 72);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdayLabel.TabIndex = 8;
            this.birthdayLabel.Text = "Birthday*";
            // 
            // birthdayField
            // 
            this.birthdayField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayField.Location = new System.Drawing.Point(80, 67);
            this.birthdayField.Name = "birthdayField";
            this.birthdayField.Size = new System.Drawing.Size(195, 20);
            this.birthdayField.TabIndex = 9;
            this.birthdayField.Value = new System.DateTime(2021, 6, 18, 13, 31, 8, 0);
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Location = new System.Drawing.Point(10, 99);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(58, 13);
            this.addressLabel1.TabIndex = 10;
            this.addressLabel1.Text = "Address 1*";
            // 
            // addressField1
            // 
            this.addressField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField1.Location = new System.Drawing.Point(80, 96);
            this.addressField1.Name = "addressField1";
            this.addressField1.Size = new System.Drawing.Size(195, 20);
            this.addressField1.TabIndex = 11;
            this.addressField1.TextChanged += new System.EventHandler(this.addressField1_TextChanged);
            // 
            // addressLabel2
            // 
            this.addressLabel2.AutoSize = true;
            this.addressLabel2.Location = new System.Drawing.Point(10, 128);
            this.addressLabel2.Name = "addressLabel2";
            this.addressLabel2.Size = new System.Drawing.Size(54, 13);
            this.addressLabel2.TabIndex = 12;
            this.addressLabel2.Text = "Address 2";
            // 
            // addressField2
            // 
            this.addressField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField2.Location = new System.Drawing.Point(80, 125);
            this.addressField2.Name = "addressField2";
            this.addressField2.Size = new System.Drawing.Size(195, 20);
            this.addressField2.TabIndex = 13;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(10, 157);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 15;
            this.notesLabel.Text = "Notes";
            // 
            // notesField
            // 
            this.notesField.AcceptsReturn = true;
            this.notesField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesField.Location = new System.Drawing.Point(80, 154);
            this.notesField.Multiline = true;
            this.notesField.Name = "notesField";
            this.notesField.Size = new System.Drawing.Size(195, 143);
            this.notesField.TabIndex = 14;
            // 
            // requiredLabel
            // 
            this.requiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.requiredLabel.Location = new System.Drawing.Point(10, 309);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(57, 13);
            this.requiredLabel.TabIndex = 16;
            this.requiredLabel.Text = "* Required";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.attributeLabel);
            this.splitContainer1.Size = new System.Drawing.Size(288, 330);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // attributeLabel
            // 
            this.attributeLabel.AutoSize = true;
            this.attributeLabel.Location = new System.Drawing.Point(3, 9);
            this.attributeLabel.Name = "attributeLabel";
            this.attributeLabel.Size = new System.Drawing.Size(89, 13);
            this.attributeLabel.TabIndex = 0;
            this.attributeLabel.Text = "Custom Attributes";
            // 
            // createStudentButton
            // 
            this.createStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createStudentButton.Enabled = false;
            this.createStudentButton.Location = new System.Drawing.Point(0, 0);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(584, 25);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // NewStudentDialog
            // 
            this.AcceptButton = this.createStudentButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BodyAndFootSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStudentDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Student";
            this.BodyAndFootSplit.Panel1.ResumeLayout(false);
            this.BodyAndFootSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BodyAndFootSplit)).EndInit();
            this.BodyAndFootSplit.ResumeLayout(false);
            this.BodySplit.Panel1.ResumeLayout(false);
            this.BodySplit.Panel1.PerformLayout();
            this.BodySplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BodySplit)).EndInit();
            this.BodySplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.SplitContainer BodySplit;
        private System.Windows.Forms.Label seatNumberLabel;
        internal System.Windows.Forms.NumericUpDown seatNumberField;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.DateTimePicker birthdayField;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.TextBox addressField1;
        private System.Windows.Forms.TextBox addressField2;
        private System.Windows.Forms.Label addressLabel2;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesField;
        private System.Windows.Forms.SplitContainer BodyAndFootSplit;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label attributeLabel;
    }
}