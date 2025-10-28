using System.Data;
using System.Data.OleDb;

namespace CourseManagerUser
{
    public partial class CoursesForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";
        public CoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var da = new OleDbDataAdapter("SELECT Title, Description FROM Courses", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridCourses.DataSource = dt;
            }
        }
    }
}
