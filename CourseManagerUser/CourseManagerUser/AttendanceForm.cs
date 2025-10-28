using System.Data;
using System.Data.OleDb;

namespace CourseManagerUser
{
    public partial class AttendanceForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";
        public AttendanceForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT Id, FullName, GroupName FROM Users", conn);
                var rdr = cmd.ExecuteReader();
                comboStudents.Items.Clear();
                while (rdr.Read())
                {
                    string text = rdr.GetString(1) + " (" + rdr.GetString(2) + ")";
                    comboStudents.Items.Add(new ComboBoxItem(rdr.GetInt32(0), text));
                }
                if (comboStudents.Items.Count > 0)
                {
                    comboStudents.SelectedIndex = 0;
                    LoadAttendance();
                }
            }
            comboStudents.SelectedIndexChanged += (sender, args) => LoadAttendance();
        }

        private void LoadAttendance()
        {
            if (comboStudents.SelectedItem == null) return;
            var student = (ComboBoxItem)comboStudents.SelectedItem;
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var query = "SELECT C.Title AS [Курс], S.[Date] AS [Дата], A.Present AS [Был] " +
                            "FROM ((Attendance A INNER JOIN Sessions S ON A.SessionId = S.Id) " +
                            "INNER JOIN Courses C ON S.CourseId = C.Id) " +
                            "WHERE A.UserId = ?";
                var da = new OleDbDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", student.Id);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridAttendance.DataSource = dt;
            }
        }
    }
}
