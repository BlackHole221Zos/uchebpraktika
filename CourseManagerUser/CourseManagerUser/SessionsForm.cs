using System.Data;
using System.Data.OleDb;

namespace CourseManagerUser
{
    public partial class SessionsForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";
        public SessionsForm()
        {
            InitializeComponent();
            LoadSessions();
        }

        private void LoadSessions()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var sql = "SELECT S.Id, C.Title AS [Курс], S.[Date] AS [Дата] FROM Sessions S INNER JOIN Courses C ON S.CourseId = C.Id";
                var da = new OleDbDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridSessions.DataSource = dt;
            }
        }
    }
}
