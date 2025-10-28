namespace CourseManagerAdmin
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridAttendance;
        private ComboBox comboUsers;
        private ComboBox comboSessions;
        private CheckBox chkPresent;
        private Button btnAddAttendance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridAttendance = new DataGridView();
            comboUsers = new ComboBox();
            comboSessions = new ComboBox();
            chkPresent = new CheckBox();
            btnAddAttendance = new Button();

            dataGridAttendance.Location = new System.Drawing.Point(20, 20);
            dataGridAttendance.Size = new System.Drawing.Size(550, 180);
            dataGridAttendance.ReadOnly = true;

            comboUsers.Location = new System.Drawing.Point(20, 215);
            comboUsers.Size = new System.Drawing.Size(200, 24);

            comboSessions.Location = new System.Drawing.Point(240, 215);
            comboSessions.Size = new System.Drawing.Size(200, 24);

            chkPresent.Location = new System.Drawing.Point(460, 215);
            chkPresent.Size = new System.Drawing.Size(110, 24);
            chkPresent.Text = "Присутствовал";

            btnAddAttendance.Location = new System.Drawing.Point(20, 250);
            btnAddAttendance.Size = new System.Drawing.Size(200, 28);
            btnAddAttendance.Text = "Добавить посещение";
            btnAddAttendance.Click += btnAddAttendance_Click;

            Controls.Add(dataGridAttendance);
            Controls.Add(comboUsers);
            Controls.Add(comboSessions);
            Controls.Add(chkPresent);
            Controls.Add(btnAddAttendance);

            Text = "Журнал посещаемости";
            ClientSize = new System.Drawing.Size(600, 300);
        }
    }
}
