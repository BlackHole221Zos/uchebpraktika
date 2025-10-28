namespace CourseManagerAdmin
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnUsers;
        private Button btnCourses;
        private Button btnSessions;
        private Button btnAttendance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnUsers = new Button();
            btnCourses = new Button();
            btnSessions = new Button();
            btnAttendance = new Button();

            btnUsers.Location = new System.Drawing.Point(50, 30);
            btnUsers.Size = new System.Drawing.Size(300, 30);
            btnUsers.Text = "Пользователи";
            btnUsers.Click += btnUsers_Click;

            btnCourses.Location = new System.Drawing.Point(50, 70);
            btnCourses.Size = new System.Drawing.Size(300, 30);
            btnCourses.Text = "Курсы";
            btnCourses.Click += btnCourses_Click;

            btnSessions.Location = new System.Drawing.Point(50, 110);
            btnSessions.Size = new System.Drawing.Size(300, 30);
            btnSessions.Text = "Сессии";
            btnSessions.Click += btnSessions_Click;

            btnAttendance.Location = new System.Drawing.Point(50, 150);
            btnAttendance.Size = new System.Drawing.Size(300, 30);
            btnAttendance.Text = "Посещаемость";
            btnAttendance.Click += btnAttendance_Click;

            Controls.Add(btnUsers);
            Controls.Add(btnCourses);
            Controls.Add(btnSessions);
            Controls.Add(btnAttendance);

            Text = "Главное меню администратора";
            ClientSize = new System.Drawing.Size(400, 220);
        }
    }
}
