using System.Data;
using System.Data.OleDb;

namespace CourseManagerUser
{
    public partial class StudentsForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";
        public StudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var da = new OleDbDataAdapter("SELECT FullName, GroupName FROM Users", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridStudents.DataSource = dt;
            }
        }
    }
}
