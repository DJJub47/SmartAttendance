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
    public partial class NewStudentDialog : Form
    {
        internal ClassWindow activeClass;

        public NewStudentDialog()
        {
            InitializeComponent();
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }
        private void seatNumberField_ValueChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }

        private void CheckRequiredFields()
        {
            createStudentButton.Enabled =
                nameField.Text.Trim() != "" && seatNumberField.Value > 0 && addressField1.Text.Trim() != "";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            List<StudentAttribute> attributes = new List<StudentAttribute>();
            Dictionary<DateTime, AttendanceEvent> attendanceRecord = new Dictionary<DateTime, AttendanceEvent>();

            activeClass.CreateStudent(nameField.Text, (int)seatNumberField.Value, birthdayField.Value.Date, addressField1.Text, addressField2.Text, notesField.Text, attributes, attendanceRecord);

            Close();
        }

        private void addressField1_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }
    }

    internal class Student
    {
        internal string name;
        internal int seatNumber;
        internal DateTime birthday;
        internal string address1;
        internal string address2;
        internal string notes;
        internal List<StudentAttribute> attributes;
        internal Dictionary<DateTime, AttendanceEvent> attendanceRecord;

        public Student(string name, int seatNumber, DateTime birthday, string address1, string address2, string notes, List<StudentAttribute> attributes, Dictionary<DateTime, AttendanceEvent> attendanceRecord)
        {
            this.name = name;
            this.seatNumber = seatNumber;
            this.birthday = birthday;
            this.address1 = address1;
            this.address2 = address2;
            this.notes = notes;
            this.attributes = attributes;
            this.attendanceRecord = attendanceRecord;
        }
    }
}
