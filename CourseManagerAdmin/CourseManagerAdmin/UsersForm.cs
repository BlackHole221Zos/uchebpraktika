using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseManagerAdmin
{
    public partial class UsersForm : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AdminDB.accdb";

        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var da = new OleDbDataAdapter("SELECT * FROM Users", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridUsers.DataSource = dt;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("INSERT INTO Users (FullName, GroupName) VALUES (?, ?)", conn);
                cmd.Parameters.AddWithValue("?", txtFio.Text);
                cmd.Parameters.AddWithValue("?", txtGroup.Text);
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
            txtFio.Clear();
            txtGroup.Clear();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow == null) return;
            int userId = Convert.ToInt32(dataGridUsers.CurrentRow.Cells["Id"].Value);
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand("DELETE FROM Users WHERE Id = ?", conn);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }
    }
}
