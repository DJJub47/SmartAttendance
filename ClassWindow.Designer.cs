namespace FS_CS_ETS_Project
{
    partial class ClassWindow
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
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.sidebarSplit = new System.Windows.Forms.SplitContainer();
            this.studentsGroup = new System.Windows.Forms.GroupBox();
            this.studentsSplit = new System.Windows.Forms.SplitContainer();
            this.studentListContainer = new System.Windows.Forms.ListView();
            this.studentButtonSplit = new System.Windows.Forms.SplitContainer();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.InspectorBodySplit = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.propertiesLabel = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.viewAttendanceButton = new System.Windows.Forms.Button();
            this.presentButton = new System.Windows.Forms.Button();
            this.tardyButton = new System.Windows.Forms.Button();
            this.absentButton = new System.Windows.Forms.Button();
            this.moreAttendanceOptionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSplit)).BeginInit();
            this.sidebarSplit.Panel1.SuspendLayout();
            this.sidebarSplit.SuspendLayout();
            this.studentsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsSplit)).BeginInit();
            this.studentsSplit.Panel1.SuspendLayout();
            this.studentsSplit.Panel2.SuspendLayout();
            this.studentsSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentButtonSplit)).BeginInit();
            this.studentButtonSplit.Panel1.SuspendLayout();
            this.studentButtonSplit.Panel2.SuspendLayout();
            this.studentButtonSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorBodySplit)).BeginInit();
            this.InspectorBodySplit.Panel1.SuspendLayout();
            this.InspectorBodySplit.Panel2.SuspendLayout();
            this.InspectorBodySplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplit
            // 
            this.mainSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.sidebarSplit);
            this.mainSplit.Panel1MinSize = 200;
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.InspectorBodySplit);
            this.mainSplit.Panel2MinSize = 365;
            this.mainSplit.Size = new System.Drawing.Size(754, 561);
            this.mainSplit.SplitterDistance = 205;
            this.mainSplit.TabIndex = 1;
            // 
            // sidebarSplit
            // 
            this.sidebarSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarSplit.Location = new System.Drawing.Point(0, 0);
            this.sidebarSplit.Name = "sidebarSplit";
            this.sidebarSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sidebarSplit.Panel1
            // 
            this.sidebarSplit.Panel1.Controls.Add(this.studentsGroup);
            this.sidebarSplit.Panel1MinSize = 200;
            this.sidebarSplit.Panel2MinSize = 100;
            this.sidebarSplit.Size = new System.Drawing.Size(203, 559);
            this.sidebarSplit.SplitterDistance = 276;
            this.sidebarSplit.TabIndex = 0;
            // 
            // studentsGroup
            // 
            this.studentsGroup.Controls.Add(this.studentsSplit);
            this.studentsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsGroup.Location = new System.Drawing.Point(0, 0);
            this.studentsGroup.Name = "studentsGroup";
            this.studentsGroup.Size = new System.Drawing.Size(203, 276);
            this.studentsGroup.TabIndex = 0;
            this.studentsGroup.TabStop = false;
            this.studentsGroup.Text = "Students";
            // 
            // studentsSplit
            // 
            this.studentsSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.studentsSplit.IsSplitterFixed = true;
            this.studentsSplit.Location = new System.Drawing.Point(3, 16);
            this.studentsSplit.Name = "studentsSplit";
            this.studentsSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // studentsSplit.Panel1
            // 
            this.studentsSplit.Panel1.Controls.Add(this.studentListContainer);
            // 
            // studentsSplit.Panel2
            // 
            this.studentsSplit.Panel2.Controls.Add(this.studentButtonSplit);
            this.studentsSplit.Panel2MinSize = 32;
            this.studentsSplit.Size = new System.Drawing.Size(197, 257);
            this.studentsSplit.SplitterDistance = 221;
            this.studentsSplit.TabIndex = 1;
            // 
            // studentListContainer
            // 
            this.studentListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentListContainer.FullRowSelect = true;
            this.studentListContainer.HideSelection = false;
            this.studentListContainer.LabelWrap = false;
            this.studentListContainer.Location = new System.Drawing.Point(0, 0);
            this.studentListContainer.MultiSelect = false;
            this.studentListContainer.Name = "studentListContainer";
            this.studentListContainer.Size = new System.Drawing.Size(197, 221);
            this.studentListContainer.TabIndex = 0;
            this.studentListContainer.UseCompatibleStateImageBehavior = false;
            this.studentListContainer.View = System.Windows.Forms.View.List;
            this.studentListContainer.SelectedIndexChanged += new System.EventHandler(this.studentListContainer_SelectedIndexChanged);
            // 
            // studentButtonSplit
            // 
            this.studentButtonSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentButtonSplit.IsSplitterFixed = true;
            this.studentButtonSplit.Location = new System.Drawing.Point(0, 0);
            this.studentButtonSplit.Name = "studentButtonSplit";
            // 
            // studentButtonSplit.Panel1
            // 
            this.studentButtonSplit.Panel1.Controls.Add(this.addStudentButton);
            // 
            // studentButtonSplit.Panel2
            // 
            this.studentButtonSplit.Panel2.Controls.Add(this.removeStudentButton);
            this.studentButtonSplit.Size = new System.Drawing.Size(197, 32);
            this.studentButtonSplit.SplitterDistance = 96;
            this.studentButtonSplit.TabIndex = 2;
            // 
            // addStudentButton
            // 
            this.addStudentButton.AutoSize = true;
            this.addStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentButton.Location = new System.Drawing.Point(0, 0);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(96, 32);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.AutoSize = true;
            this.removeStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeStudentButton.Enabled = false;
            this.removeStudentButton.Location = new System.Drawing.Point(0, 0);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(97, 32);
            this.removeStudentButton.TabIndex = 1;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // InspectorBodySplit
            // 
            this.InspectorBodySplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InspectorBodySplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectorBodySplit.Location = new System.Drawing.Point(0, 0);
            this.InspectorBodySplit.Name = "InspectorBodySplit";
            this.InspectorBodySplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InspectorBodySplit.Panel1
            // 
            this.InspectorBodySplit.Panel1.Controls.Add(this.splitContainer3);
            // 
            // InspectorBodySplit.Panel2
            // 
            this.InspectorBodySplit.Panel2.Controls.Add(this.panel1);
            this.InspectorBodySplit.Panel2MinSize = 150;
            this.InspectorBodySplit.Size = new System.Drawing.Size(545, 561);
            this.InspectorBodySplit.SplitterDistance = 353;
            this.InspectorBodySplit.TabIndex = 0;
            this.InspectorBodySplit.Visible = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.propertiesLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.nameLabel);
            this.splitContainer3.Panel2.Controls.Add(this.nameField);
            this.splitContainer3.Panel2.Controls.Add(this.seatNumberLabel);
            this.splitContainer3.Panel2.Controls.Add(this.seatNumberField);
            this.splitContainer3.Panel2.Controls.Add(this.birthdayLabel);
            this.splitContainer3.Panel2.Controls.Add(this.birthdayField);
            this.splitContainer3.Panel2.Controls.Add(this.addressLabel1);
            this.splitContainer3.Panel2.Controls.Add(this.addressField1);
            this.splitContainer3.Panel2.Controls.Add(this.addressLabel2);
            this.splitContainer3.Panel2.Controls.Add(this.addressField2);
            this.splitContainer3.Panel2.Controls.Add(this.notesLabel);
            this.splitContainer3.Panel2.Controls.Add(this.notesField);
            this.splitContainer3.Panel2.Controls.Add(this.requiredLabel);
            this.splitContainer3.Size = new System.Drawing.Size(543, 351);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 17;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Location = new System.Drawing.Point(4, 6);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(54, 13);
            this.propertiesLabel.TabIndex = 0;
            this.propertiesLabel.Text = "Properties";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name*";
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(80, 5);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(450, 20);
            this.nameField.TabIndex = 17;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberLabel.AutoSize = true;
            this.seatNumberLabel.Location = new System.Drawing.Point(10, 34);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(43, 13);
            this.seatNumberLabel.TabIndex = 18;
            this.seatNumberLabel.Text = "Seat #*";
            // 
            // seatNumberField
            // 
            this.seatNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumberField.Location = new System.Drawing.Point(80, 32);
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
            this.seatNumberField.Size = new System.Drawing.Size(450, 20);
            this.seatNumberField.TabIndex = 19;
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
            this.birthdayLabel.Location = new System.Drawing.Point(10, 65);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdayLabel.TabIndex = 20;
            this.birthdayLabel.Text = "Birthday*";
            // 
            // birthdayField
            // 
            this.birthdayField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayField.Location = new System.Drawing.Point(80, 60);
            this.birthdayField.Name = "birthdayField";
            this.birthdayField.Size = new System.Drawing.Size(450, 20);
            this.birthdayField.TabIndex = 21;
            this.birthdayField.Value = new System.DateTime(2021, 6, 18, 13, 31, 8, 0);
            this.birthdayField.ValueChanged += new System.EventHandler(this.birthdayField_ValueChanged);
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Location = new System.Drawing.Point(10, 92);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(58, 13);
            this.addressLabel1.TabIndex = 22;
            this.addressLabel1.Text = "Address 1*";
            // 
            // addressField1
            // 
            this.addressField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField1.Location = new System.Drawing.Point(80, 89);
            this.addressField1.Name = "addressField1";
            this.addressField1.Size = new System.Drawing.Size(450, 20);
            this.addressField1.TabIndex = 23;
            this.addressField1.TextChanged += new System.EventHandler(this.addressField1_TextChanged);
            // 
            // addressLabel2
            // 
            this.addressLabel2.AutoSize = true;
            this.addressLabel2.Location = new System.Drawing.Point(10, 121);
            this.addressLabel2.Name = "addressLabel2";
            this.addressLabel2.Size = new System.Drawing.Size(54, 13);
            this.addressLabel2.TabIndex = 24;
            this.addressLabel2.Text = "Address 2";
            // 
            // addressField2
            // 
            this.addressField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField2.Location = new System.Drawing.Point(80, 118);
            this.addressField2.Name = "addressField2";
            this.addressField2.Size = new System.Drawing.Size(450, 20);
            this.addressField2.TabIndex = 25;
            this.addressField2.TextChanged += new System.EventHandler(this.addressField2_TextChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(10, 150);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 27;
            this.notesLabel.Text = "Notes";
            // 
            // notesField
            // 
            this.notesField.AcceptsReturn = true;
            this.notesField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesField.Location = new System.Drawing.Point(80, 147);
            this.notesField.Multiline = true;
            this.notesField.Name = "notesField";
            this.notesField.Size = new System.Drawing.Size(450, 149);
            this.notesField.TabIndex = 26;
            this.notesField.TextChanged += new System.EventHandler(this.notesField_TextChanged);
            // 
            // requiredLabel
            // 
            this.requiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.requiredLabel.Location = new System.Drawing.Point(7, 299);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(57, 13);
            this.requiredLabel.TabIndex = 28;
            this.requiredLabel.Text = "* Required";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 202);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.attendanceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewAttendanceButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.presentButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tardyButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.absentButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.moreAttendanceOptionsButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Location = new System.Drawing.Point(3, 0);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(62, 13);
            this.attendanceLabel.TabIndex = 4;
            this.attendanceLabel.Text = "Attendance";
            // 
            // viewAttendanceButton
            // 
            this.viewAttendanceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAttendanceButton.Location = new System.Drawing.Point(3, 23);
            this.viewAttendanceButton.Name = "viewAttendanceButton";
            this.viewAttendanceButton.Size = new System.Drawing.Size(537, 30);
            this.viewAttendanceButton.TabIndex = 5;
            this.viewAttendanceButton.Text = "View Attendance Record";
            this.viewAttendanceButton.UseVisualStyleBackColor = true;
            this.viewAttendanceButton.Click += new System.EventHandler(this.viewAttendanceButton_Click);
            // 
            // presentButton
            // 
            this.presentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presentButton.Location = new System.Drawing.Point(3, 59);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(537, 30);
            this.presentButton.TabIndex = 0;
            this.presentButton.Text = "Present for today";
            this.presentButton.UseVisualStyleBackColor = true;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // tardyButton
            // 
            this.tardyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tardyButton.Location = new System.Drawing.Point(3, 95);
            this.tardyButton.Name = "tardyButton";
            this.tardyButton.Size = new System.Drawing.Size(537, 30);
            this.tardyButton.TabIndex = 1;
            this.tardyButton.Text = "Tardy for today";
            this.tardyButton.UseVisualStyleBackColor = true;
            this.tardyButton.Click += new System.EventHandler(this.tardyButton_Click);
            // 
            // absentButton
            // 
            this.absentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absentButton.Location = new System.Drawing.Point(3, 131);
            this.absentButton.Name = "absentButton";
            this.absentButton.Size = new System.Drawing.Size(537, 30);
            this.absentButton.TabIndex = 2;
            this.absentButton.Text = "Absent for today";
            this.absentButton.UseVisualStyleBackColor = true;
            this.absentButton.Click += new System.EventHandler(this.absentButton_Click);
            // 
            // moreAttendanceOptionsButton
            // 
            this.moreAttendanceOptionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreAttendanceOptionsButton.Location = new System.Drawing.Point(3, 167);
            this.moreAttendanceOptionsButton.Name = "moreAttendanceOptionsButton";
            this.moreAttendanceOptionsButton.Size = new System.Drawing.Size(537, 32);
            this.moreAttendanceOptionsButton.TabIndex = 3;
            this.moreAttendanceOptionsButton.Text = "More Attendance Options...";
            this.moreAttendanceOptionsButton.UseVisualStyleBackColor = true;
            this.moreAttendanceOptionsButton.Click += new System.EventHandler(this.moreAttendanceOptionsButton_Click);
            // 
            // ClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.mainSplit);
            this.Name = "ClassWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "new";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.ClassWindow_Load);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.sidebarSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSplit)).EndInit();
            this.sidebarSplit.ResumeLayout(false);
            this.studentsGroup.ResumeLayout(false);
            this.studentsSplit.Panel1.ResumeLayout(false);
            this.studentsSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsSplit)).EndInit();
            this.studentsSplit.ResumeLayout(false);
            this.studentButtonSplit.Panel1.ResumeLayout(false);
            this.studentButtonSplit.Panel1.PerformLayout();
            this.studentButtonSplit.Panel2.ResumeLayout(false);
            this.studentButtonSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentButtonSplit)).EndInit();
            this.studentButtonSplit.ResumeLayout(false);
            this.InspectorBodySplit.Panel1.ResumeLayout(false);
            this.InspectorBodySplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InspectorBodySplit)).EndInit();
            this.InspectorBodySplit.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void NotesField_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.SplitContainer sidebarSplit;
        private System.Windows.Forms.GroupBox studentsGroup;
        private System.Windows.Forms.SplitContainer studentsSplit;
        private System.Windows.Forms.SplitContainer studentButtonSplit;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.ListView studentListContainer;
        private System.Windows.Forms.SplitContainer InspectorBodySplit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button presentButton;
        private System.Windows.Forms.Button tardyButton;
        private System.Windows.Forms.Button absentButton;
        private System.Windows.Forms.Button moreAttendanceOptionsButton;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label propertiesLabel;
        internal System.Windows.Forms.Label nameLabel;
        internal System.Windows.Forms.TextBox nameField;
        internal System.Windows.Forms.Label seatNumberLabel;
        internal System.Windows.Forms.NumericUpDown seatNumberField;
        internal System.Windows.Forms.Label birthdayLabel;
        internal System.Windows.Forms.DateTimePicker birthdayField;
        internal System.Windows.Forms.Label addressLabel1;
        internal System.Windows.Forms.TextBox addressField1;
        internal System.Windows.Forms.Label addressLabel2;
        internal System.Windows.Forms.TextBox addressField2;
        internal System.Windows.Forms.Label notesLabel;
        internal System.Windows.Forms.TextBox notesField;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.Button viewAttendanceButton;
    }
}