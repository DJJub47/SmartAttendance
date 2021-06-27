using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FS_CS_ETS_Project
{
    public partial class ClassWindow : Form
    {
        public string activeFilePath;

        Class @class;

        /// <summary>
        /// The index we're working with at the moment. If it's -1, then the selection is null.
        /// </summary>
        int selectedIndex = -1;

        public ClassWindow()
        {
            InitializeComponent();
        }

        internal void New(string name, string teacherName, string roomNumber, DateTime startDate, DateTime endDate, List<AttendanceEvent> events = null)
        {
            List<AttendanceEvent> defaultEvents = new List<AttendanceEvent>
            {
                AttendanceEvent.Present,
                AttendanceEvent.Tardy,
                AttendanceEvent.Absent
            };

            if (events != null)
            {
                defaultEvents.AddRange(events);
            }

            @class = new Class(name, teacherName, roomNumber, startDate.Date, endDate.Date, new List<Student>(), defaultEvents);

            MdiParent = Globals.mainForm;
            Text = @class.name;
        }

        internal Class GetClass()
        {
            return @class;
        }

        /// <summary>
        /// When we click "Add Student", add a student.
        /// </summary>
        /// <param name="sender">I dunno</param>
        /// <param name="e">I really dunno, this satisfies the <see cref="EventHandler"/> gods</param>
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            NewStudentDialog dialog = new NewStudentDialog();

            dialog.activeClass = this;
            dialog.seatNumberField.Value = @class.students.Count + 1;
            dialog.ShowDialog();
        }

        /// <summary>
        /// When we click "Remove Student", remove a student.
        /// </summary>
        /// <param name="sender">See <see cref="addStudentButton"/>.</param>
        /// <param name="e">See <see cref="addStudentButton"/>.</param>
        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this student?", "Remove Student", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Check if the selection is null, and if it isn't, remove it
                if (selectedIndex > -1)
                {
                    studentListContainer.Items.Remove(studentListContainer.SelectedItems[0]);
                }
            }
        }

        internal void CreateStudent(string name, int seatNumber, DateTime birthday, string address1, string address2, string notes, Dictionary<DateTime, AttendanceEvent> attendanceRecord)
        {
            // Create the student
            @class.CreateStudent(name, seatNumber, birthday, address1, address2, notes, attendanceRecord);

            // Add them to the visible list
            studentListContainer.Items.Add(attendanceRecord.ContainsKey(DateTime.Today) ?
                $"{name} - {attendanceRecord[DateTime.Today].name}" :
                name);

            // Write to the console (make sure this whole thing actually got done
            Console.WriteLine("Added a student.");

            // Mark this class as unsaved.
            MarkSavedState();
        }

        internal void MarkSavedState(bool saved = false)
        {
            // If we say it isn't saved...
            if (!saved)
            {
                Text = @class.name + "*"; // Mark it as unsaved.
            }
            else // If we say it IS saved...
            {
                Text = @class.name; // Mark it as saved.
            }
        }

        private void studentListContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the button's enabled to whether or not a student is selected
            removeStudentButton.Enabled = studentListContainer.SelectedItems != null;

            // Set our selection index appropriately
            if (studentListContainer.SelectedItems.Count > 0)
            {
                selectedIndex = studentListContainer.Items.IndexOf(studentListContainer.SelectedItems[0]);
                UpdateInspector();
            }
            else
            {
                selectedIndex = -1;
                UpdateInspector();
            }

            MarkSavedState();
        }

        private void UpdateInspector()
        {
            InspectorBodySplit.Visible = (selectedIndex > -1);

            if (selectedIndex > -1)
            {
                Student selectedStudent = @class.students[selectedIndex];

                nameField.Text = selectedStudent.name;
                seatNumberField.Value = selectedStudent.seatNumber;
                birthdayField.Value = selectedStudent.birthday;
                addressField1.Text = selectedStudent.address1;
                addressField2.Text = selectedStudent.address2;
                notesField.Text = selectedStudent.notes;

                // Manage custom attributes here

            }
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].name = nameField.Text;

            MarkSavedState();
        }

        private void seatNumberField_ValueChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].seatNumber =
                (int)seatNumberField.Value;

            MarkSavedState();
        }

        private void birthdayField_ValueChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].birthday = birthdayField.Value;

            MarkSavedState();
        }

        private void addressField1_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].address1 = addressField1.Text;

            MarkSavedState();
        }

        private void addressField2_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].address2 = addressField2.Text;

            MarkSavedState();
        }

        private void notesField_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            @class.students[selectedIndex].notes = notesField.Text;
            Console.WriteLine("Updated notes for {0}.", @class.students[selectedIndex].name);

            MarkSavedState();
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            if (!@class.students[selectedIndex].attendanceRecord.ContainsKey(DateTime.Today))
            {
                @class.students[selectedIndex].attendanceRecord.Add(DateTime.Today, AttendanceEvent.Present);
                Console.WriteLine("Newly marked present for today!");
            }
            else
            {
                @class.students[selectedIndex].attendanceRecord[DateTime.Today] = AttendanceEvent.Present;
                Console.WriteLine("Erased the last mark and remarked as present.");
            }

            studentListContainer.SelectedItems[0].Text = @class.students[selectedIndex].name + " - Present";

            MarkSavedState();
        }

        private void tardyButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            if (!@class.students[selectedIndex].attendanceRecord.ContainsKey(DateTime.Today))
            {
                @class.students[selectedIndex].attendanceRecord.Add(DateTime.Today, AttendanceEvent.Tardy);
                Console.WriteLine("Newly marked tardy for today!");
            }
            else
            {
                @class.students[selectedIndex].attendanceRecord[DateTime.Today] = AttendanceEvent.Tardy;
                Console.WriteLine("Erased the last mark and remarked as tardy.");
            }

            studentListContainer.SelectedItems[0].Text = @class.students[selectedIndex].name + " - Tardy";

            MarkSavedState();
        }

        private void absentButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1) return;

            if (!@class.students[selectedIndex].attendanceRecord.ContainsKey(DateTime.Today))
            {
                @class.students[selectedIndex].attendanceRecord.Add(DateTime.Today, AttendanceEvent.Absent);
                Console.WriteLine("Newly marked absent for today!");
            }
            else
            {
                @class.students[selectedIndex].attendanceRecord[DateTime.Today] = AttendanceEvent.Absent;
                Console.WriteLine("Erased the last mark and remarked as absent.");
            }

            studentListContainer.SelectedItems[0].Text = @class.students[selectedIndex].name + " - Absent";

            MarkSavedState();
        }

        private void moreAttendanceOptionsButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Not implemented yet. Move along!", "Not yet...");

            AttendanceDialog dialog = new AttendanceDialog();

            dialog.New(this, @class.students[selectedIndex], @class.attendanceEvents);
        }

        private void ClassWindow_Load(object sender, EventArgs e)
        {
            if (MdiParent is Form1 parentForm)
            {
                parentForm.CheckForWelcomeVisible(true);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (MdiParent is Form1 parentForm)
            {
                parentForm.CheckForWelcomeVisible();
            }
        }

        private void viewAttendanceButton_Click(object sender, EventArgs e)
        {
            ViewAttendanceDialog dialog = new ViewAttendanceDialog();

            dialog.New(@class.students[selectedIndex]);
        }

        internal void UpdateStudentAttendanceOnList(Student student, string eventName)
        {
            if (!@class.students.Contains(student)) throw new NullReferenceException();

            studentListContainer.Items[@class.students.IndexOf(student)].Text = @class.students[selectedIndex].name + " - " + eventName;
        }
    }

    internal class Class
    {
        internal string name;
        internal string teacherName;
        internal string roomNumber;
        internal DateTime startDate;
        internal DateTime endDate;

        internal List<Student> students = new List<Student>();
        internal List<AttendanceEvent> attendanceEvents = new List<AttendanceEvent>();

        public Class(string name, string teacherName, string roomNumber, DateTime startDate, DateTime endDate, List<Student> students, List<AttendanceEvent> attendanceEvents)
        {
            this.name = name;
            this.teacherName = teacherName;
            this.roomNumber = roomNumber;
            this.startDate = startDate;
            this.endDate = endDate;
            this.students = students;

            this.attendanceEvents = attendanceEvents;
        }

        /// <summary>
        /// Creates a student.
        /// </summary>
        /// <param name="name">Name of the student.</param>
        /// <param name="seatNumber">Student's seat number.</param>
        /// <param name="birthday">Student's birthday.</param>
        /// <param name="address1">Student's primary address.</param>
        /// <param name="address2">Student's secondary address.</param>
        /// <param name="notes">Notes about the student.</param>
        internal void CreateStudent(string name, int seatNumber, DateTime birthday, string address1, string address2, string notes, Dictionary<DateTime, AttendanceEvent> attendanceRecord)
        {
            Student student = new Student(name, seatNumber, birthday, address1, address2, notes, attendanceRecord);

            if (students == null) { students = new List<Student>(); }

            students.Add(student);
        }
    }

    internal class AttendanceEvent
    {
        internal string name;
        internal string notes;

        public AttendanceEvent(string name, string notes)
        {
            this.name = name;
            this.notes = notes;
        }

        internal static AttendanceEvent Present = new AttendanceEvent("Present", "");
        internal static AttendanceEvent Tardy = new AttendanceEvent("Tardy", "");
        internal static AttendanceEvent Absent = new AttendanceEvent("Absent", "");
    }
}