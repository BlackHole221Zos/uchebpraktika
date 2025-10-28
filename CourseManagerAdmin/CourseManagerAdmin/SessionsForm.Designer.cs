namespace CourseManagerAdmin
{
    partial class SessionsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridSessions;
        private ComboBox comboCourses;
        private DateTimePicker dateTimePicker;
        private Button btnAddSession;
        private Label lblCourse;
        private Label lblDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridSessions = new DataGridView();
            comboCourses = new ComboBox();
            dateTimePicker = new DateTimePicker();
            btnAddSession = new Button();
            lblCourse = new Label();
            lblDate = new Label();

            dataGridSessions.Location = new System.Drawing.Point(20, 20);
            dataGridSessions.Size = new System.Drawing.Size(550, 180);
            dataGridSessions.ReadOnly = true;
            dataGridSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblCourse.Location = new System.Drawing.Point(20, 220);
            lblCourse.Size = new System.Drawing.Size(74, 17);
            lblCourse.Text = "Курс:";

            comboCourses.Location = new System.Drawing.Point(120, 220);
            comboCourses.Size = new System.Drawing.Size(200, 24);

            lblDate.Location = new System.Drawing.Point(20, 260);
            lblDate.Size = new System.Drawing.Size(59, 17);
            lblDate.Text = "Дата:";

            dateTimePicker.Location = new System.Drawing.Point(120, 260);
            dateTimePicker.Size = new System.Drawing.Size(200, 22);

            btnAddSession.Location = new System.Drawing.Point(120, 300);
            btnAddSession.Size = new System.Drawing.Size(140, 30);
            btnAddSession.Text = "Добавить занятие";
            btnAddSession.Click += btnAddSession_Click;

            Controls.Add(dataGridSessions);
            Controls.Add(lblCourse);
            Controls.Add(comboCourses);
            Controls.Add(lblDate);
            Controls.Add(dateTimePicker);
            Controls.Add(btnAddSession);

            Text = "Управление сессиями";
            ClientSize = new System.Drawing.Size(600, 400);
        }
    }
}
