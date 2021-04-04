using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace csharp_mysql
{
    public partial class frcourse : Form

    {
        private string id = "";
        public frcourse()
        {
            InitializeComponent();
        }

        private void frcourse_Load(object sender, EventArgs e)
        {
            LoadData();
            Reset();
            dvg1.MultiSelect = false;
            dvg1.AutoGenerateColumns = true;
            dvg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void Reset()
        {
            Course_name.Text = "";
        }
        private void LoadData()
        {
            CRUD.sql = "SELECT * FROM teacher_attendance.courses";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            DataTable dt = CRUD.PreformCRUD(CRUD.cmd);

            dvg1.DataSource = dt;
        }
        private void execute(string mysql, string param)
        {
            CRUD.cmd = new MySqlCommand(mysql, CRUD.con);
            addparameters(param);
            DataTable dt = CRUD.PreformCRUD(CRUD.cmd);
        }
        private void addparameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("name", Course_name.Text.Trim());
            if (str == "update" || str == "delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            CRUD.sql = "INSERT INTO teacher_attendance.courses (`name`) VALUES (@name); ";
            execute(CRUD.sql, "insert");
            LoadData();
            Reset();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.id = Convert.ToString(dvg1.CurrentRow.Cells[0].Value);
                Course_id.Text = this.id;
                Course_name.Text = dvg1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            CRUD.sql = "UPDATE teacher_attendance.courses SET `name` = @name WHERE `courses`.`id` = @id; ";
            execute(CRUD.sql, "update");
            LoadData();
            Reset();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CRUD.sql = "DELETE FROM teacher_attendance.courses WHERE `courses`.`id` = @id ";
            execute(CRUD.sql, "delete");
            LoadData();
            Reset();
        }

    }
}
