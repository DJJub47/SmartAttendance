namespace FS_CS_ETS_Project
{
    partial class NewClassDialog
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.teacherNameField = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberField = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateField = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateField = new System.Windows.Forms.DateTimePicker();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.createClassButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name*";
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(85, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(237, 20);
            this.nameField.TabIndex = 7;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Location = new System.Drawing.Point(15, 41);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(51, 13);
            this.teacherNameLabel.TabIndex = 8;
            this.teacherNameLabel.Text = "Teacher*";
            // 
            // teacherNameField
            // 
            this.teacherNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherNameField.Location = new System.Drawing.Point(85, 38);
            this.teacherNameField.Name = "teacherNameField";
            this.teacherNameField.Size = new System.Drawing.Size(237, 20);
            this.teacherNameField.TabIndex = 9;
            this.teacherNameField.TextChanged += new System.EventHandler(this.teacherNameField_TextChanged);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(15, 67);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(49, 13);
            this.roomNumberLabel.TabIndex = 10;
            this.roomNumberLabel.Text = "Room #*";
            // 
            // roomNumberField
            // 
            this.roomNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNumberField.Location = new System.Drawing.Point(85, 64);
            this.roomNumberField.Name = "roomNumberField";
            this.roomNumberField.Size = new System.Drawing.Size(237, 20);
            this.roomNumberField.TabIndex = 11;
            this.roomNumberField.TextChanged += new System.EventHandler(this.roomNumberField_TextChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(15, 93);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(59, 13);
            this.startDateLabel.TabIndex = 12;
            this.startDateLabel.Text = "Start Date*";
            // 
            // startDateField
            // 
            this.startDateField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateField.Location = new System.Drawing.Point(85, 91);
            this.startDateField.Name = "startDateField";
            this.startDateField.Size = new System.Drawing.Size(237, 20);
            this.startDateField.TabIndex = 13;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(15, 119);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 14;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateField
            // 
            this.endDateField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateField.Location = new System.Drawing.Point(85, 117);
            this.endDateField.Name = "endDateField";
            this.endDateField.Size = new System.Drawing.Size(237, 20);
            this.endDateField.TabIndex = 15;
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplit.IsSplitterFixed = true;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.nameLabel);
            this.mainSplit.Panel1.Controls.Add(this.nameField);
            this.mainSplit.Panel1.Controls.Add(this.teacherNameLabel);
            this.mainSplit.Panel1.Controls.Add(this.teacherNameField);
            this.mainSplit.Panel1.Controls.Add(this.roomNumberLabel);
            this.mainSplit.Panel1.Controls.Add(this.roomNumberField);
            this.mainSplit.Panel1.Controls.Add(this.startDateLabel);
            this.mainSplit.Panel1.Controls.Add(this.startDateField);
            this.mainSplit.Panel1.Controls.Add(this.endDateLabel);
            this.mainSplit.Panel1.Controls.Add(this.endDateField);
            this.mainSplit.Panel1.Controls.Add(this.requiredLabel);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.createClassButton);
            this.mainSplit.Size = new System.Drawing.Size(334, 220);
            this.mainSplit.SplitterDistance = 185;
            this.mainSplit.TabIndex = 16;
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.requiredLabel.Location = new System.Drawing.Point(15, 159);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(57, 13);
            this.requiredLabel.TabIndex = 17;
            this.requiredLabel.Text = "* Required";
            // 
            // createClassButton
            // 
            this.createClassButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createClassButton.Enabled = false;
            this.createClassButton.Location = new System.Drawing.Point(0, 0);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(334, 31);
            this.createClassButton.TabIndex = 0;
            this.createClassButton.Text = "Create Class";
            this.createClassButton.UseVisualStyleBackColor = true;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // NewClassDialog
            // 
            this.AcceptButton = this.createClassButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 220);
            this.Controls.Add(this.mainSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewClassDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Class";
            this.TopMost = true;
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel1.PerformLayout();
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.TextBox teacherNameField;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumberField;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateField;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateField;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.Button createClassButton;
        private System.Windows.Forms.Label requiredLabel;
    }
}