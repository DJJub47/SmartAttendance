using System;
using System.Windows.Forms;

namespace FS_CS_ETS_Project
{
    public partial class ClassInfoDialog : Form
    {
        private Class @class;

        public ClassInfoDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set up a new dialog of this type.
        /// </summary>
        /// <param name="@class">The class we're using to set this up.</param>
        internal void New(Class @class)
        {
            // Set the class we'll be modifying to the class given to us.
            this.@class = @class ?? throw new NullReferenceException();

            // Set all of the fields to match the stats of the class before we start messing with them.
            nameField.Text = @class.name;
            teacherNameField.Text = @class.teacherName;
            roomNumberField.Text = @class.roomNumber;

            startDateField.Value = @class.startDate.Date;
            endDateField.Value = @class.endDate.Date;

            // Show the dialog.
            ShowDialog();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            // Apply changes to the class.
            @class.name = nameField.Text;
            @class.teacherName = teacherNameField.Text;
            @class.roomNumber = roomNumberField.Text;

            @class.startDate = startDateField.Value;
            @class.endDate = endDateField.Value;

            // And go away, like a good boy.
            Close();
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyFields(); // The text here has changed, check for empty fields.
        }

        private void teacherNameField_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyFields(); // The text here has changed, check for empty fields.
        }

        private void roomNumberField_TextChanged(object sender, EventArgs e)
        {
            CheckForEmptyFields(); // The text here has changed, check for empty fields.
        }

        /// <summary>
        /// Checks to see if any fields are empty. If any are, disables the apply button until all have something in them again.
        /// </summary>
        private void CheckForEmptyFields()
        {
            applyChangesButton.Enabled = !(nameField.Text.Trim() == "" || teacherNameField.Text.Trim() == "" || roomNumberField.Text.Trim() == "");
        }
    }
}