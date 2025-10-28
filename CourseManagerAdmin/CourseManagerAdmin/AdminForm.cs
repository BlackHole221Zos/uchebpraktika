using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseManagerAdmin
{
    public partial class AdminForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";

        public AdminForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var da = new OleDbDataAdapter("SELECT * FROM Courses", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridCourses.DataSource = dt;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("INSERT INTO Courses (Title, Description) VALUES (?, ?)", conn);
                cmd.Parameters.AddWithValue("?", txtTitle.Text);
                cmd.Parameters.AddWithValue("?", txtDesc.Text);
                cmd.ExecuteNonQuery();
            }
            LoadCourses();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridCourses.CurrentRow == null) return;
            int courseId = Convert.ToInt32(dataGridCourses.CurrentRow.Cells["Id"].Value);
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("DELETE FROM Courses WHERE Id=?", conn);
                cmd.Parameters.AddWithValue("?", courseId);
                cmd.ExecuteNonQuery();
            }
            LoadCourses();
        }
    }
}
