namespace CourseManagerAdmin
{
    partial class CoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridCourses;
        private TextBox txtTitle;
        private TextBox txtDesc;
        private Button btnAddCourse;
        private Button btnDeleteCourse;
        private Label lblTitle;
        private Label lblDesc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridCourses = new DataGridView();
            this.txtTitle = new TextBox();
            this.txtDesc = new TextBox();
            this.btnAddCourse = new Button();
            this.btnDeleteCourse = new Button();
            this.lblTitle = new Label();
            this.lblDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCourses
            // 
            this.dataGridCourses.Location = new System.Drawing.Point(20, 20);
            this.dataGridCourses.Size = new System.Drawing.Size(550, 180);
            this.dataGridCourses.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 223);
            this.lblTitle.Size = new System.Drawing.Size(117, 17);
            this.lblTitle.Text = "Название курса:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 220);
            this.txtTitle.Size = new System.Drawing.Size(180, 22);
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(20, 263);
            this.lblDesc.Size = new System.Drawing.Size(77, 17);
            this.lblDesc.Text = "Описание:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(150, 260);
            this.txtDesc.Size = new System.Drawing.Size(420, 22);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(150, 300);
            this.btnAddCourse.Size = new System.Drawing.Size(120, 36);
            this.btnAddCourse.Text = "Добавить курс";
            this.btnAddCourse.Click += new EventHandler(this.btnAddCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(300, 300);
            this.btnDeleteCourse.Size = new System.Drawing.Size(120, 36);
            this.btnDeleteCourse.Text = "Удалить курс";
            this.btnDeleteCourse.Click += new EventHandler(this.btnDeleteCourse_Click);
            // 
            // CoursesForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dataGridCourses);
            this.Text = "Управление курсами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourses)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
