using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FS_CS_ETS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Globals.mainForm = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new class dialog and make it show up
            new NewClassDialog().ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the "Open Class" dialog
            openClassDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ClassWindow activeWindow)
            {
                Save(activeWindow);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                MessageBox.Show("No class is active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(ActiveMdiChild is ClassWindow activeWindow))
            {
                MessageBox.Show("Please highlight a class window before trying to save.");
                return;
            }

            Save(activeWindow, true);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if ((ClassWindow)form != null)
                {
                    ClassWindow window = (ClassWindow)form;

                    Save(window);
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// <see cref="https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-mdi-child-forms?view=netframeworkdesktop-4.8"/>
            /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/multiple-document-interface-mdi-applications?view=netframeworkdesktop-4.8"/>

            // Cascade all child MDI forms automatically
            LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void Save(ClassWindow target, bool alwaysShowDialog = false)
        {
            if (target == null)
            {
                MessageBox.Show("No class window is active.", "Error");
                return;
            }

            if (alwaysShowDialog || target.activeFilePath == "")
            {
                saveClassDialog.FileName = target.GetClass().name;

                // Show the "Save Class" dialog
                DialogResult result = saveClassDialog.ShowDialog();

                /// <see cref="https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8"/>

                if (result == DialogResult.OK)
                {
                    FileStream _fs = (FileStream)saveClassDialog.OpenFile();

                    if (target != null)
                    {
                        // Prepare XML writing
                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;

                        XmlWriter writer = XmlWriter.Create(_fs, settings);

                        // Get the class we're writing
                        Class @class = target.GetClass();

                        /// <see cref="https://www.c-sharpcorner.com/article/reading-and-writing-xml-in-C-Sharp/"/>

                        // Open the document.
                        writer.WriteStartDocument();

                        writer.WriteStartElement("Class");

                        // Write the class data.
                        writer.WriteStartElement("ClassInfo");

                        writer.WriteAttributeString("Name", @class.name);
                        writer.WriteAttributeString("Teacher", @class.teacherName);
                        writer.WriteAttributeString("RoomNumber", @class.roomNumber.ToString());
                        writer.WriteAttributeString("StartDate", @class.startDate.ToString());
                        writer.WriteAttributeString("EndDate", @class.endDate.ToString());

                        writer.WriteStartElement("AttendanceEvents");

                        foreach (AttendanceEvent @event in @class.attendanceEvents)
                        {
                            writer.WriteAttributeString("event" + @class.attendanceEvents.IndexOf(@event).ToString(), @event.name);
                        }

                        writer.WriteEndElement();

                        writer.WriteEndElement();

                        // Write the student data.
                        writer.WriteStartElement("Students");

                        foreach (Student student in @class.students)
                        {
                            writer.WriteStartElement("student" + @class.students.IndexOf(student).ToString());

                            writer.WriteAttributeString("Name", student.name);
                            writer.WriteAttributeString("SeatNumber", student.seatNumber.ToString());
                            writer.WriteAttributeString("Birthday", student.birthday.ToString());
                            writer.WriteAttributeString("Address1", student.address1);
                            writer.WriteAttributeString("Address2", student.address2);
                            writer.WriteAttributeString("Notes", student.notes);

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();

                        writer.WriteEndElement();

                        // Custom attributes here


                        // End and close the document.
                        writer.WriteEndDocument();
                        writer.Close();
                    }

                    target.activeFilePath = _fs.Name;
                    _fs.Close();
                }
            }
            else
            {
                /// <see cref="https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8"/>
                FileStream _fs = File.OpenWrite(target.activeFilePath);

                if (target != null)
                {
                    // Prepare XML writing
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    XmlWriter writer = XmlWriter.Create(_fs, settings);

                    // Get the class we're writing
                    Class @class = target.GetClass();

                    /// <see cref="https://www.c-sharpcorner.com/article/reading-and-writing-xml-in-C-Sharp/"/>

                    // Open the document.
                    writer.WriteStartDocument();

                    // Write the root element.
                    writer.WriteStartElement("Class");

                    // Write the class data.
                    writer.WriteStartElement("ClassInfo");

                    writer.WriteAttributeString("Name", @class.name);
                    writer.WriteAttributeString("Teacher", @class.teacherName);
                    writer.WriteAttributeString("RoomNumber", @class.roomNumber.ToString());
                    writer.WriteAttributeString("StartDate", @class.startDate.ToString());
                    writer.WriteAttributeString("EndDate", @class.endDate.ToString());

                    writer.WriteStartElement("AttendanceEvents");
                    // For each event in the attendance event list, write out its data.
                    foreach (AttendanceEvent @event in @class.attendanceEvents)
                    {
                        writer.WriteAttributeString("event" + @class.attendanceEvents.IndexOf(@event).ToString(), @event.name);
                    }

                    writer.WriteEndElement();

                    // Close the class data.
                    writer.WriteEndElement();

                    // Write the student data.
                    writer.WriteStartElement("Students");

                    // For each student in the class, write out their data.
                    foreach (Student student in @class.students)
                    {
                        writer.WriteStartElement("student" + @class.students.IndexOf(student).ToString());

                        writer.WriteAttributeString("Name", student.name);
                        writer.WriteAttributeString("SeatNumber", student.seatNumber.ToString());
                        writer.WriteAttributeString("Birthday", student.birthday.ToString());
                        writer.WriteAttributeString("Address1", student.address1);
                        writer.WriteAttributeString("Address2", student.address2);
                        writer.WriteAttributeString("Notes", student.notes);

                        // Write the attendance record data.
                        writer.WriteStartElement("AttendanceRecord");

                        foreach (KeyValuePair<DateTime, AttendanceEvent> pair in student.attendanceRecord)
                        {
                            writer.WriteStartElement("date" + student.attendanceRecord.Keys.ToList().IndexOf(pair.Key));

                            writer.WriteAttributeString("Date", pair.Key.Date.ToString());
                            writer.WriteAttributeString("Name", pair.Value.name);
                            writer.WriteAttributeString("Notes", pair.Value.notes);
                        }

                        writer.WriteEndElement();

                        writer.WriteEndElement();
                    }
                    // Close the student data.
                    writer.WriteEndElement();

                    // Close the root element.
                    writer.WriteEndElement();

                    // End and close the document.
                    writer.WriteEndDocument();
                    writer.Close();
                }

                target.activeFilePath = _fs.Name;
                _fs.Close();
            }

            target.MarkSavedState(true);
        }

        private void LoadClass(ClassWindow target)
        {
            // Open a file stream for the requested file.
            FileStream fs = (FileStream)openClassDialog.OpenFile();

            if (fs.Position > 0)
            {
                fs.Position = 0;
            }

            XElement xmlFile = XElement.Load(fs);

            XElement classInfo = xmlFile.Element("ClassInfo");

            List<AttendanceEvent> events = new List<AttendanceEvent>();

            AttendanceEvent[] defaultEvents = new AttendanceEvent[3];

            defaultEvents[0] = AttendanceEvent.Present;
            defaultEvents[1] = AttendanceEvent.Tardy;
            defaultEvents[2] = AttendanceEvent.Absent;

            foreach (XAttribute attribute in classInfo.Elements("AttendanceEvents").Attributes())
            {
                bool @default = false;

                foreach (AttendanceEvent defaultEvent in defaultEvents)
                {
                    if (defaultEvent.name == attribute.Value)
                    {
                        @default = true;
                        break;
                    }
                }

                if (!@default) events.Add(new AttendanceEvent(attribute.Value, ""));
            }

            target.New
            (
                name: classInfo.Attribute("Name").Value, // Name
                teacherName: classInfo.Attribute("Teacher").Value, // Teacher
                roomNumber: classInfo.Attribute("RoomNumber").Value, // RoomNumber
                startDate: DateTime.Parse(classInfo.Attribute("StartDate").Value), // StartDate
                endDate: DateTime.Parse(classInfo.Attribute("EndDate").Value), // EndDate
                events: events // Attendance Events
            );

            XElement[] students = xmlFile.Element("Students").Descendants().ToArray();

            foreach (XElement element in students)
            {
                if (element.Attribute("Name") != null && element.Attribute("Address1") != null)
                {
                    string name = element.Attribute("Name").Value;
                    int seatNumber = int.Parse(element.Attribute("SeatNumber").Value);
                    DateTime birthday = DateTime.Parse(element.Attribute("Birthday").Value);
                    string address1 = element.Attribute("Address1").Value;
                    string address2 = element.Attribute("Address2").Value;
                    string notes = element.Attribute("Notes").Value;

                    Dictionary<DateTime, AttendanceEvent> record = new Dictionary<DateTime, AttendanceEvent>();

                    // Read the attendance record data.
                    if (element.Element("AttendanceRecord") != null)
                    {
                        XElement[] pairs = element.Element("AttendanceRecord").Descendants().ToArray();

                        // For each pair in the pair list, parse through the data and store it.
                        foreach (XElement pair in pairs)
                        {
                            record.Add(DateTime.Parse(pair.Attribute("Date").Value), new AttendanceEvent(pair.Attribute("Name").Value, pair.Attribute("Notes").Value));
                        }
                    }

                    target.CreateStudent(name, seatNumber, birthday, address1, address2, notes, record);
                }
            }

            target.activeFilePath = fs.Name;

            fs.Close();
        }

        private void openClassDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Create a new instance of the class window
            ClassWindow activeWindow = new ClassWindow();

            // Load the class into it
            LoadClass(activeWindow);

            // Attach it to the main program and show it to the user
            activeWindow.MdiParent = this;
            activeWindow.Show();
        }

        private void editInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ClassWindow target)
            {
                ClassInfoDialog dialog = new ClassInfoDialog();

                dialog.New(target.GetClass());
            }
        }

        internal void CheckForWelcomeVisible(bool opening = false)
        {
            welcomeLabel.Visible = opening ? (MdiChildren == null || MdiChildren.Length == 0) : (MdiChildren == null || MdiChildren.Length == 1);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}