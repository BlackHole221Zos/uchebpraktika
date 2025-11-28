namespace CourseManagerUser
{
    partial class StudentsForm
    {
        private DataGridView dataGridStudents;

        private void InitializeComponent()
        {
            dataGridStudents = new DataGridView();
            dataGridStudents.Location = new System.Drawing.Point(20, 20);
            dataGridStudents.Size = new System.Drawing.Size(450, 300);
            dataGridStudents.ReadOnly = true;

            Controls.Add(dataGridStudents);
            Text = "Список студентов";
            ClientSize = new System.Drawing.Size(500, 350);
        }
    }
}
