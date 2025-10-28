using System;
using System.Windows.Forms;

namespace CourseManagerAdmin
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            new CoursesForm().ShowDialog();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            new SessionsForm().ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceForm().ShowDialog();
        }
    }
}
