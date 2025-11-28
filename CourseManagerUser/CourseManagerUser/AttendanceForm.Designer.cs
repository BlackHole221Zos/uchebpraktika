namespace CourseManagerUser
{
    partial class AttendanceForm
    {
        private DataGridView dataGridAttendance;
        private ComboBox comboStudents;

        private void InitializeComponent()
        {
            comboStudents = new ComboBox();
            comboStudents.Location = new System.Drawing.Point(20, 20);
            comboStudents.Size = new System.Drawing.Size(300, 24);

            dataGridAttendance = new DataGridView();
            dataGridAttendance.Location = new System.Drawing.Point(20, 60);
            dataGridAttendance.Size = new System.Drawing.Size(500, 250);
            dataGridAttendance.ReadOnly = true;

            Controls.Add(comboStudents);
            Controls.Add(dataGridAttendance);

            Text = "Моя посещаемость";
            ClientSize = new System.Drawing.Size(550, 330);
        }
    }
}
