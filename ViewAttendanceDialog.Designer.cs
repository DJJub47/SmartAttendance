namespace FS_CS_ETS_Project
{
    partial class ViewAttendanceDialog
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
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.attendanceField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.notesField = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.mainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.notesLabel);
            this.mainGroup.Controls.Add(this.notesField);
            this.mainGroup.Controls.Add(this.dateLabel);
            this.mainGroup.Controls.Add(this.dateField);
            this.mainGroup.Controls.Add(this.attendanceLabel);
            this.mainGroup.Controls.Add(this.attendanceField);
            this.mainGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroup.Location = new System.Drawing.Point(0, 0);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(284, 199);
            this.mainGroup.TabIndex = 0;
            this.mainGroup.TabStop = false;
            this.mainGroup.Text = "Attendance Record";
            // 
            // attendanceField
            // 
            this.attendanceField.Location = new System.Drawing.Point(81, 45);
            this.attendanceField.Name = "attendanceField";
            this.attendanceField.ReadOnly = true;
            this.attendanceField.Size = new System.Drawing.Size(191, 20);
            this.attendanceField.TabIndex = 0;
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(81, 19);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(191, 20);
            this.dateField.TabIndex = 1;
            this.dateField.ValueChanged += new System.EventHandler(this.dateField_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Location = new System.Drawing.Point(13, 48);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(62, 13);
            this.attendanceLabel.TabIndex = 3;
            this.attendanceLabel.Text = "Attendance";
            // 
            // notesField
            // 
            this.notesField.Location = new System.Drawing.Point(81, 71);
            this.notesField.Multiline = true;
            this.notesField.Name = "notesField";
            this.notesField.ReadOnly = true;
            this.notesField.Size = new System.Drawing.Size(191, 116);
            this.notesField.TabIndex = 5;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(13, 74);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "Notes";
            // 
            // ViewAttendanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.mainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewAttendanceDialog";
            this.Text = "View Attendance Record";
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.TextBox attendanceField;
        private System.Windows.Forms.TextBox notesField;
        private System.Windows.Forms.Label notesLabel;
    }
}