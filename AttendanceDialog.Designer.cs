namespace FS_CS_ETS_Project
{
    partial class AttendanceDialog
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
            this.attendanceGroup = new System.Windows.Forms.GroupBox();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.attendanceTypeLabel = new System.Windows.Forms.Label();
            this.attendanceTypeList = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.notesSplit = new System.Windows.Forms.SplitContainer();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesField = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.attendanceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesSplit)).BeginInit();
            this.notesSplit.Panel1.SuspendLayout();
            this.notesSplit.Panel2.SuspendLayout();
            this.notesSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendanceGroup
            // 
            this.attendanceGroup.Controls.Add(this.mainSplit);
            this.attendanceGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceGroup.Location = new System.Drawing.Point(0, 0);
            this.attendanceGroup.Name = "attendanceGroup";
            this.attendanceGroup.Size = new System.Drawing.Size(268, 308);
            this.attendanceGroup.TabIndex = 1;
            this.attendanceGroup.TabStop = false;
            this.attendanceGroup.Text = "Attendance Options";
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplit.IsSplitterFixed = true;
            this.mainSplit.Location = new System.Drawing.Point(3, 16);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.attendanceTypeLabel);
            this.mainSplit.Panel1.Controls.Add(this.attendanceTypeList);
            this.mainSplit.Panel1.Controls.Add(this.nameLabel);
            this.mainSplit.Panel1.Controls.Add(this.nameField);
            this.mainSplit.Panel1.Controls.Add(this.dateLabel);
            this.mainSplit.Panel1.Controls.Add(this.dateField);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.notesSplit);
            this.mainSplit.Size = new System.Drawing.Size(262, 289);
            this.mainSplit.SplitterDistance = 85;
            this.mainSplit.TabIndex = 7;
            // 
            // attendanceTypeLabel
            // 
            this.attendanceTypeLabel.AutoSize = true;
            this.attendanceTypeLabel.Location = new System.Drawing.Point(11, 6);
            this.attendanceTypeLabel.Name = "attendanceTypeLabel";
            this.attendanceTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.attendanceTypeLabel.TabIndex = 2;
            this.attendanceTypeLabel.Text = "Type";
            // 
            // attendanceTypeList
            // 
            this.attendanceTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attendanceTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attendanceTypeList.FormattingEnabled = true;
            this.attendanceTypeList.Items.AddRange(new object[] {
            "Present",
            "Tardy",
            "Absent",
            "Custom..."});
            this.attendanceTypeList.Location = new System.Drawing.Point(56, 3);
            this.attendanceTypeList.Name = "attendanceTypeList";
            this.attendanceTypeList.Size = new System.Drawing.Size(200, 21);
            this.attendanceTypeList.TabIndex = 3;
            this.attendanceTypeList.SelectedIndexChanged += new System.EventHandler(this.attendanceTypeList_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(56, 30);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(200, 20);
            this.nameField.TabIndex = 1;
            this.nameField.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(11, 60);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date";
            // 
            // dateField
            // 
            this.dateField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateField.Location = new System.Drawing.Point(56, 56);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(200, 20);
            this.dateField.TabIndex = 5;
            // 
            // notesSplit
            // 
            this.notesSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.notesSplit.IsSplitterFixed = true;
            this.notesSplit.Location = new System.Drawing.Point(0, 0);
            this.notesSplit.Name = "notesSplit";
            this.notesSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // notesSplit.Panel1
            // 
            this.notesSplit.Panel1.Controls.Add(this.notesLabel);
            this.notesSplit.Panel1.Controls.Add(this.notesField);
            // 
            // notesSplit.Panel2
            // 
            this.notesSplit.Panel2.Controls.Add(this.applyButton);
            this.notesSplit.Size = new System.Drawing.Size(262, 200);
            this.notesSplit.SplitterDistance = 169;
            this.notesSplit.TabIndex = 6;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(11, 11);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Text = "Notes";
            // 
            // notesField
            // 
            this.notesField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesField.Location = new System.Drawing.Point(8, 27);
            this.notesField.Multiline = true;
            this.notesField.Name = "notesField";
            this.notesField.Size = new System.Drawing.Size(246, 134);
            this.notesField.TabIndex = 5;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(0, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(262, 27);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AttendanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 308);
            this.Controls.Add(this.attendanceGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceDialog";
            this.Text = "More Attendance Options...";
            this.attendanceGroup.ResumeLayout(false);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel1.PerformLayout();
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.notesSplit.Panel1.ResumeLayout(false);
            this.notesSplit.Panel1.PerformLayout();
            this.notesSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesSplit)).EndInit();
            this.notesSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox attendanceGroup;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.Label attendanceTypeLabel;
        private System.Windows.Forms.ComboBox attendanceTypeList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesField;
        private System.Windows.Forms.SplitContainer notesSplit;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Label dateLabel;
    }
}