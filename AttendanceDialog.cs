using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS_CS_ETS_Project
{
    /// <summary>
    /// Represents the "More Attendance Options..." dialog.
    /// </summary>
    public partial class AttendanceDialog : Form
    {
        /// <summary>
        /// The ClassWindow that called this function.
        /// </summary>
        internal ClassWindow parent;

        /// <summary>
        /// The student whose record we're modifying.
        /// </summary>
        internal Student student;

        public AttendanceDialog()
        {
            InitializeComponent();
        }

        internal void New(ClassWindow parent, Student student, List<AttendanceEvent> attendanceEvents, bool show = true)
        {
            // Tell this dialog what class and student we're modifying
            this.parent = parent;
            this.student = student;

            // Clear the event list so that we don't have duplicates
            attendanceTypeList.Items.Clear();

            // Fill the event list
            foreach (AttendanceEvent @event in attendanceEvents)
            {
                attendanceTypeList.Items.Add(@event.name);
            }

            attendanceTypeList.Items.Add("Add New Event...");

            if (show) Show(); // If we need to show the dialog, then show it.
        }

        private void attendanceTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If we're about to make a custom event, then make the field for that visible. Otherwise, hide it.
            nameField.Visible = attendanceTypeList.SelectedItem.ToString() == "Add New Event...";
            nameLabel.Visible = attendanceTypeList.SelectedItem.ToString() == "Add New Event...";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // If we're making a custom event...
            if (attendanceTypeList.SelectedItem.ToString() == "Add New Event...")
            {
                AttendanceEvent customEvent = new AttendanceEvent(nameField.Text, ""); // Create it in the code

                parent.GetClass().attendanceEvents.Add(customEvent); // Add it to the class.

                // Check to see if today has been logged already or not. If it hasn't...
                if (!student.attendanceRecord.ContainsKey(dateField.Value.Date))
                {
                    // Add the event to today on the student's record
                    student.attendanceRecord.Add(dateField.Value.Date, new AttendanceEvent(nameField.Text, notesField.Text));
                }
                else // If it has...
                {
                    // Edit today's attendnace log for this student.
                    student.attendanceRecord[dateField.Value.Date] = new AttendanceEvent(nameField.Text, notesField.Text);
                }
            }
            else // On the other hand, we're logging an existing event to the student.
            {
                // If we haven't logged today yet...
                if (!student.attendanceRecord.ContainsKey(dateField.Value.Date))
                {
                    student.attendanceRecord.Add(dateField.Value.Date, new AttendanceEvent(attendanceTypeList.Text, notesField.Text)); // Do so.
                }
                else // If we have...
                {
                    student.attendanceRecord[dateField.Value.Date] = new AttendanceEvent(attendanceTypeList.Text, notesField.Text); // Edit today's log to match the new event.
                }
            }

            // Mark the class as unsaved, and close this dialog.
            parent.MarkSavedState();
            Close();
        }
    }
}
