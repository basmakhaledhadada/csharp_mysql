
namespace csharp_mysql
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            this.Teachers = new System.Windows.Forms.ComboBox();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.Courses = new System.Windows.Forms.ComboBox();
            this.ShowTeacher = new System.Windows.Forms.Button();
            this.ShowRoom = new System.Windows.Forms.Button();
            this.ShowCourse = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.DateTimePicker();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leave Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teacher Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Room Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Course Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Comment";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(140, 209);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(233, 20);
            this.Comment.TabIndex = 8;
            // 
            // Teachers
            // 
            this.Teachers.FormattingEnabled = true;
            this.Teachers.Location = new System.Drawing.Point(425, 82);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(154, 21);
            this.Teachers.TabIndex = 9;
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(425, 123);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(154, 21);
            this.Rooms.TabIndex = 10;
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(425, 161);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(154, 21);
            this.Courses.TabIndex = 11;
            // 
            // ShowTeacher
            // 
            this.ShowTeacher.Location = new System.Drawing.Point(585, 81);
            this.ShowTeacher.Name = "ShowTeacher";
            this.ShowTeacher.Size = new System.Drawing.Size(43, 23);
            this.ShowTeacher.TabIndex = 12;
            this.ShowTeacher.Text = "Edit";
            this.ShowTeacher.UseVisualStyleBackColor = true;
            this.ShowTeacher.Click += new System.EventHandler(this.ShowTeacher_Click);
            // 
            // ShowRoom
            // 
            this.ShowRoom.Location = new System.Drawing.Point(585, 123);
            this.ShowRoom.Name = "ShowRoom";
            this.ShowRoom.Size = new System.Drawing.Size(43, 23);
            this.ShowRoom.TabIndex = 13;
            this.ShowRoom.Text = "Edit";
            this.ShowRoom.UseVisualStyleBackColor = true;
            this.ShowRoom.Click += new System.EventHandler(this.ShowRoom_Click);
            // 
            // ShowCourse
            // 
            this.ShowCourse.Location = new System.Drawing.Point(585, 161);
            this.ShowCourse.Name = "ShowCourse";
            this.ShowCourse.Size = new System.Drawing.Size(43, 23);
            this.ShowCourse.TabIndex = 14;
            this.ShowCourse.Text = "Edit";
            this.ShowCourse.UseVisualStyleBackColor = true;
            this.ShowCourse.Click += new System.EventHandler(this.ShowCourse_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(391, 209);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(472, 209);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Location = new System.Drawing.Point(17, 243);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(686, 195);
            this.dvg1.TabIndex = 18;
            this.dvg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg1_CellClick);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(553, 209);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Leave
            // 
            this.Leave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Leave.Location = new System.Drawing.Point(154, 161);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(154, 23);
            this.Leave.TabIndex = 22;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start.Location = new System.Drawing.Point(154, 123);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(154, 23);
            this.Start.TabIndex = 21;
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(154, 81);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(154, 23);
            this.Date.TabIndex = 20;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.ShowCourse);
            this.Controls.Add(this.ShowRoom);
            this.Controls.Add(this.ShowTeacher);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.ComboBox Teachers;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.ComboBox Courses;
        private System.Windows.Forms.Button ShowTeacher;
        private System.Windows.Forms.Button ShowRoom;
        private System.Windows.Forms.Button ShowCourse;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DateTimePicker Leave;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker Date;
    }
}

