using System;
using System.Windows.Forms;

namespace FS_CS_ETS_Project
{
    public partial class ViewAttendanceDialog : Form
    {
        /// <summary>
        /// The student whose attendance record we are viewing.
        /// </summary>
        Student student;

        public ViewAttendanceDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set up a new dialog of this type.
        /// </summary>
        /// <param name="student"></param>
        internal void New(Student student)
        {
            this.student = student;

            dateField.Value = DateTime.Today;

            ShowDialog();
        }

        private void dateField_ValueChanged(object sender, EventArgs e)
        {
            // If there is no student selected (shouldn't happen), let the user know that that should not happen, give them a great and heart-warming error message in the console, and force the whole program to commit death.
            if (student == null)
            {
                MessageBox.Show("No student selected for viewing attendance— wait, how did you manage that? That shouldn't have happened. Welp, time for Smart Attendance to commit death. Have a nice day!");

                Console.WriteLine("No student selected for viewing attendance— wait, how did you manage that? That shouldn't have happened. Well, anyway, shot you a message box, forced the program to commit die, and now an error here. Hope you're happy :)");

                Globals.mainForm.Close();
            }

            // With those weirdos out of the way...

            // If today has been logged, let the user know what that log is.
            if (student.attendanceRecord.ContainsKey(dateField.Value.Date))
            {
                AttendanceEvent @event = student.attendanceRecord[dateField.Value.Date];

                attendanceField.Text = @event.name;
                notesField.Text = @event.notes;
            }
            else // Otherwise, let them know nothing is recorded for that day.
            {
                attendanceField.Text = "Not recorded yet";
                notesField.Text = "";
            }
        }
    }
}