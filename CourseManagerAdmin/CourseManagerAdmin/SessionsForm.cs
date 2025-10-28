using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseManagerAdmin
{
    public partial class SessionsForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";

        public SessionsForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSessions();
        }

        private void LoadCourses()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT Id, Title FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                comboCourses.Items.Clear();
                while (reader.Read())
                {
                    comboCourses.Items.Add(new ComboBoxItem(reader.GetInt32(0), reader.GetString(1)));
                }
                if (comboCourses.Items.Count > 0)
                    comboCourses.SelectedIndex = 0;
            }
        }

        private void LoadSessions()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT S.Id, C.Title, S.[Date] FROM Sessions S INNER JOIN Courses C ON S.CourseId = C.Id";
                var da = new OleDbDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridSessions.DataSource = dt;
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (comboCourses.SelectedItem == null)
            {
                MessageBox.Show("Выберите курс");
                return;
            }
            var selected = (ComboBoxItem)comboCourses.SelectedItem;
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("INSERT INTO Sessions (CourseId, [Date]) VALUES (?, ?)", conn);
                cmd.Parameters.AddWithValue("?", selected.Id);
                cmd.Parameters.AddWithValue("?", dateTimePicker.Value);
                cmd.ExecuteNonQuery();
            }
            LoadSessions();
        }
    }
}
