using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace csharp_mysql
{
    public partial class Attendance : Form
    {
        private string id = "";
        public Attendance()
        {
            InitializeComponent();
            Reset();
            Fill_combo();
        }

        private void Reset()
        {
            Date.Text = "";
            Start.Text = "";
            Leave.Text = "";
            Teachers.SelectedIndex = -1;
            Courses.SelectedIndex = -1;
            Rooms.SelectedIndex = -1;
            Comment.Text = "";
        }
        private void LoadData()
        {
            CRUD.sql = "SELECT * FROM teacher_attendance.attendance_management";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            DataTable dt = CRUD.PreformCRUD(CRUD.cmd);
            dvg1.DataSource = dt;
        }
        private void execute(string mysql, string param)
        {
            CRUD.cmd = new MySqlCommand(mysql, CRUD.con);
            addparameters(param);
            CRUD.PreformCRUD(CRUD.cmd);
        }
        private void addparameters(string str)
        {

            CRUD.cmd.Parameters.Clear();
            if (str == "fill")
            {
                return;
            }

            if (str == "update" || str == "delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }

            CRUD.cmd.Parameters.AddWithValue("date", Date.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("start_time", Start.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("leave_time", Leave.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("teacher_id", Teachers.SelectedValue.ToString());
            CRUD.cmd.Parameters.AddWithValue("room_id", Rooms.SelectedValue.ToString());
            CRUD.cmd.Parameters.AddWithValue("course_id", Courses.SelectedValue.ToString());
            CRUD.cmd.Parameters.AddWithValue("comment", Comment.Text.Trim());
        }
        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadData();
            dvg1.MultiSelect = false;
            dvg1.AutoGenerateColumns = true;
            dvg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Reset();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            CRUD.sql = "INSERT INTO teacher_attendance.attendance_management (`date`, `start_time`, `leave_time`, `teacher_id`, `room_id`, `course_id`, `comment`) VALUES (@date, @start_time, @leave_time, @teacher_id, @room_id, @course_id, @comment); ";
            execute(CRUD.sql, "insert");
            LoadData();
            Reset();
        }

        private void dvg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && Convert.ToString(dvg1.CurrentRow.Cells[0].Value)!= null)
            {
                this.id = Convert.ToString(dvg1.CurrentRow.Cells[0].Value);
                Date.Text = dvg1.CurrentRow.Cells[1].Value.ToString();
                Start.Text = dvg1.CurrentRow.Cells[2].Value.ToString();
                Leave.Text = dvg1.CurrentRow.Cells[3].Value.ToString();
                Teachers.SelectedValue = dvg1.CurrentRow.Cells[4].Value;
                Rooms.SelectedValue= dvg1.CurrentRow.Cells[5].Value;
                Courses.SelectedValue = dvg1.CurrentRow.Cells[6].Value;
                Comment.Text = Convert.ToString(dvg1.CurrentRow.Cells[7].Value);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            CRUD.sql = "UPDATE teacher_attendance.attendance_management SET `date` = @date, `start_time` = @start_time, `leave_time` = @leave_time, `teacher_id` = @teacher_id, `room_id` = @room_id, `course_id` = @course_id, `comment` = @comment WHERE `attendance_management`.`id` = @id; ";
            execute(CRUD.sql, "update");
            LoadData();
            Reset();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CRUD.sql = "DELETE FROM teacher_attendance.attendance_management WHERE `attendance_management`.`id` = @id ";
            execute(CRUD.sql, "delete");
            LoadData();
            Reset();
        }


        private void ShowRoom_Click(object sender, EventArgs e)
        {
            frroom room = new frroom();
            room.ShowDialog();
            Fill_combo();
            CRUD.sql = "DELETE FROM teacher_attendance.attendance_management WHERE room_id NOT IN (SELECT rooms.id FROM teacher_attendance.rooms)";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            dvg1.DataSource = CRUD.PreformCRUD(CRUD.cmd);
            LoadData();
            Reset();
        }

        private void ShowCourse_Click(object sender, EventArgs e)
        {
            frcourse course = new frcourse();
            course.ShowDialog();
            Fill_combo();
            CRUD.sql = "DELETE FROM teacher_attendance.attendance_management WHERE course_id NOT IN (SELECT courses.id FROM teacher_attendance.courses)";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            dvg1.DataSource = CRUD.PreformCRUD(CRUD.cmd);
            LoadData();
            Reset();
        }
        private void Fill_combo()
        {
             
            CRUD.sql = "SELECT * FROM teacher_attendance.teachers";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            Teachers.ValueMember = "id";
            Teachers.DisplayMember = "name";
            DataTable dt_teacher = CRUD.PreformCRUD(CRUD.cmd);
            Teachers.DataSource = dt_teacher;


            CRUD.sql = "SELECT * FROM teacher_attendance.courses";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            Courses.ValueMember = "id";
            Courses.DisplayMember = "name";
            DataTable dt_course = CRUD.PreformCRUD(CRUD.cmd);
            Courses.DataSource = dt_course;


            CRUD.sql = "SELECT * FROM teacher_attendance.rooms";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            Rooms.ValueMember = "id";
            Rooms.DisplayMember = "name";
            DataTable dt_room = CRUD.PreformCRUD(CRUD.cmd);
            Rooms.DataSource = dt_room;

        }

        private void ShowTeacher_Click(object sender, EventArgs e)
        {
            frteacher teacher = new frteacher();
            teacher.ShowDialog();
            Fill_combo();
            CRUD.sql = "DELETE FROM teacher_attendance.attendance_management WHERE teacher_id NOT IN (SELECT teachers.id FROM teacher_attendance.teachers)";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            dvg1.DataSource = CRUD.PreformCRUD(CRUD.cmd);
            LoadData();
            Reset();
        }
    }
}
