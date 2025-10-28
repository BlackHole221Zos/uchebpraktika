namespace CourseManagerAdmin
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridUsers;
        private TextBox txtFio, txtGroup;
        private Button btnAddUser, btnDeleteUser;
        private Label lblFio, lblGroup;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridUsers = new DataGridView();
            txtFio = new TextBox();
            txtGroup = new TextBox();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            lblFio = new Label();
            lblGroup = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsers
            // 
            dataGridUsers.Location = new Point(20, 20);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.Size = new Size(559, 180);
            dataGridUsers.TabIndex = 0;
            // 
            // txtFio
            // 
            txtFio.Location = new Point(110, 220);
            txtFio.Name = "txtFio";
            txtFio.Size = new Size(180, 23);
            txtFio.TabIndex = 2;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(110, 260);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(180, 23);
            txtGroup.TabIndex = 4;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(20, 300);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 30);
            btnAddUser.TabIndex = 5;
            btnAddUser.Text = "Добавить";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(170, 300);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(120, 30);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Удалить";
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // lblFio
            // 
            lblFio.Location = new Point(20, 220);
            lblFio.Name = "lblFio";
            lblFio.Size = new Size(80, 24);
            lblFio.TabIndex = 1;
            lblFio.Text = "ФИО:";
            // 
            // lblGroup
            // 
            lblGroup.Location = new Point(20, 260);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(80, 24);
            lblGroup.TabIndex = 3;
            lblGroup.Text = "Группа:";
            // 
            // UsersForm
            // 
            ClientSize = new Size(609, 410);
            Controls.Add(dataGridUsers);
            Controls.Add(lblFio);
            Controls.Add(txtFio);
            Controls.Add(lblGroup);
            Controls.Add(txtGroup);
            Controls.Add(btnAddUser);
            Controls.Add(btnDeleteUser);
            Name = "UsersForm";
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
