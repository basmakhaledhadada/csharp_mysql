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
    public partial class Teacher : Form
    {
        private String teachername;
        DataSet ds = new DataSet();
        connection db = new connection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
       
        public Teacher()
        {

            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM teacher_attendance.teachers", db.con);
            adapter.SelectCommand = cmd ;
            adapter.Fill(ds, "teacher_attendance");
            dataGridView1.DataSource = ds.Tables["teacher_attendance"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teachername = textBox1.Text;
            string query = "INSERT INTO teacher_attendance.teachers (name) VALUES('hello')";     
            db.Insert(query);
            adapter.Update(ds);
        }
    }
}
