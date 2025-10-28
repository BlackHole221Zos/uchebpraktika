namespace CourseManagerUser
{
    partial class SessionsForm
    {
        private DataGridView dataGridSessions;

        private void InitializeComponent()
        {
            dataGridSessions = new DataGridView();
            dataGridSessions.Location = new System.Drawing.Point(20, 20);
            dataGridSessions.Size = new System.Drawing.Size(500, 300);
            dataGridSessions.ReadOnly = true;

            Controls.Add(dataGridSessions);
            Text = "Сессии (занятия)";
            ClientSize = new System.Drawing.Size(550, 350);
        }
    }
}
