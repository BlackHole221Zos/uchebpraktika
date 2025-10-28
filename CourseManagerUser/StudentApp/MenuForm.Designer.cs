namespace CourseManagerUser
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStudents, btnCourses, btnSessions, btnAttendance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStudents = new Button();
            btnCourses = new Button();
            btnSessions = new Button();
            btnAttendance = new Button();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(50, 30);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(300, 30);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Мой список одногруппников";
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(50, 70);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(300, 30);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Курсы/группы моего техникума";
            btnCourses.Click += btnCourses_Click;
            // 
            // btnSessions
            // 
            btnSessions.Location = new Point(50, 110);
            btnSessions.Name = "btnSessions";
            btnSessions.Size = new Size(300, 30);
            btnSessions.TabIndex = 2;
            btnSessions.Text = "Сессии";
            btnSessions.Click += btnSessions_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(50, 150);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(300, 30);
            btnAttendance.TabIndex = 3;
            btnAttendance.Text = "Посещаемости";
            btnAttendance.Click += btnAttendance_Click;
            // 
            // MenuForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(btnStudents);
            Controls.Add(btnCourses);
            Controls.Add(btnSessions);
            Controls.Add(btnAttendance);
            Name = "MenuForm";
            Text = "Главное меню студента";
            ResumeLayout(false);
        }
    }
}
