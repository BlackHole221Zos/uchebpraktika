using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseManagerAdmin
{
    public partial class AttendanceForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";

        public AttendanceForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadSessions();
            LoadAttendance();
        }

        private void LoadUsers()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT Id, FullName, GroupName FROM Users", conn);
                var rdr = cmd.ExecuteReader();
                comboUsers.Items.Clear();
                while (rdr.Read())
                {
                    string text = rdr.GetString(1) + " (" + rdr.GetString(2) + ")";
                    comboUsers.Items.Add(new ComboBoxItem(rdr.GetInt32(0), text));
                }
                if (comboUsers.Items.Count > 0)
                    comboUsers.SelectedIndex = 0;
            }
        }

        private void LoadSessions()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT S.Id, C.Title & ' ' & S.[Date] AS Info FROM Sessions S INNER JOIN Courses C ON S.CourseId = C.Id", conn);
                var rdr = cmd.ExecuteReader();
                comboSessions.Items.Clear();
                while (rdr.Read())
                    comboSessions.Items.Add(new ComboBoxItem(rdr.GetInt32(0), rdr.GetString(1)));
                if (comboSessions.Items.Count > 0)
                    comboSessions.SelectedIndex = 0;
            }
        }

        private void LoadAttendance()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var query = "SELECT A.Id, U.FullName, U.GroupName, C.Title, S.[Date], A.Present " +
                            "FROM ((Attendance A " +
                            "INNER JOIN Users U ON A.UserId = U.Id) " +
                            "INNER JOIN Sessions S ON A.SessionId = S.Id) " +
                            "INNER JOIN Courses C ON S.CourseId = C.Id";
                var da = new OleDbDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridAttendance.DataSource = dt;
            }
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            if (comboUsers.SelectedItem == null || comboSessions.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента и занятие.");
                return;
            }
            var user = (ComboBoxItem)comboUsers.SelectedItem;
            var session = (ComboBoxItem)comboSessions.SelectedItem;
            bool present = chkPresent.Checked;
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("INSERT INTO Attendance (UserId, SessionId, Present) VALUES (?, ?, ?)", conn);
                cmd.Parameters.AddWithValue("?", user.Id);
                cmd.Parameters.AddWithValue("?", session.Id);
                cmd.Parameters.AddWithValue("?", present);
                cmd.ExecuteNonQuery();
            }
            LoadAttendance();
        }
    }
}
