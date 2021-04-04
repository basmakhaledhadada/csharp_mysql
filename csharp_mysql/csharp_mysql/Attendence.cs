using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace csharp_mysql
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection db = new connection();
            
             MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM teacher_attendance.attendance_management", db.con );
            
            DataSet ds = new DataSet();
            adapter.Fill(ds, "teacher_attendance");
            dataGridView1.DataSource = ds.Tables["teacher_attendance"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher newForm = new Teacher();
            newForm.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
