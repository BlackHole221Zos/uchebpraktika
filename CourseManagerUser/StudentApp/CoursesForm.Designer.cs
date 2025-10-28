namespace CourseManagerUser
{
    partial class CoursesForm
    {
        private DataGridView dataGridCourses;

        private void InitializeComponent()
        {
            dataGridCourses = new DataGridView();
            dataGridCourses.Location = new System.Drawing.Point(20, 20);
            dataGridCourses.Size = new System.Drawing.Size(500, 300);
            dataGridCourses.ReadOnly = true;

            Controls.Add(dataGridCourses);
            Text = "Курсы";
            ClientSize = new System.Drawing.Size(550, 350);
        }
    }
}
