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
    public partial class NewClassDialog : Form
    {
        public NewClassDialog()
        {
            InitializeComponent();
        }

        void CheckRequiredFields()
        {
            createClassButton.Enabled = (nameField.Text.Trim() != "" && teacherNameField.Text.Trim() != "" && roomNumberField.Text.Trim() != "");
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }

        private void teacherNameField_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }

        private void roomNumberField_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredFields();
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {
            string name = nameField.Text.Trim();
            string teacherName = teacherNameField.Text.Trim();
            string roomNumber = roomNumberField.Text.Trim();
            DateTime startDate = startDateField.Value.Date;
            DateTime endDate = endDateField.Value.Date;

            // Pop up the window for the new class
            ClassWindow window = new ClassWindow();

            window.New(name, teacherName, roomNumber, startDate, endDate);
            window.Show();

            Close();
        }
    }
}
