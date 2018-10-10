using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EFEntities;

namespace TestEFEntities.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void Do(Action a)
        {
            try
            {
                a.Invoke();
                //textBox1.Text += Environment.NewLine;
                //textBox1.Text += "done";
                ShowMsg("done");
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                String type = ex.GetType().ToString();
                ShowMsg("message:" + message);
                ShowMsg("type:" + type);
                //textBox1.Text += Environment.NewLine;
                //textBox1.Text += "message:" + message;
                //textBox1.Text += Environment.NewLine;
                //textBox1.Text += "type:" + type;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //添加数据
                using (var db = new TestDB1())
                {
                    db.Students.Add(new Student()
                    {
                        Age = 10,
                        Name = "lijian",
                        Courses = new HashSet<Course>
                        {
                             new Course
                             {
                                 Name = "语文",
                             }
                        },
                        Details = new StudentDetails
                        {
                            Address = "XXX"
                        }
                    });
                    db.SaveChanges();
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //删除数据（测试级联删除）
                using (var db = new TestDB1())
                {
                    var course = new Course() { ID = 1 };
                    db.Courses.Attach(course);
                    db.Courses.Remove(course);
                    //Console.WriteLine(db.SaveChanges());
                    //textBox1.Text += Environment.NewLine;
                    //textBox1.Text += "SaveChanges result:" + db.SaveChanges();
                    ShowMsg("SaveChanges result:" + db.SaveChanges());
                }
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //查询数据（测试延迟查询）
                using (var db = new TestDB1())
                {
                    //textBox1.Text += Environment.NewLine;
                    //一次性加载
                    //var stu = from s in db.Students.Include("Details")
                    //          select s;
                    //var stu = from s in db.Students
                    //          select s;
                    //textBox1.Text += "address:" + stu.ToList()?[0]?.Details?.Address;
                    var stu = db.Students.FirstOrDefault();
                    ShowMsg("stu:" + stu.Name);
                    //ShowMsg("address:" + stu?.Details?.Address);
                    ////Console.WriteLine(stu?.Details?.Address);
                    //textBox1.Text += "address:" + stu?.Details?.Address;
                }
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                TestDB1.Init(new TestDB1_DropCreateDatabaseIfModelChanges());
            });
        }

        protected void ShowMsg(String msg)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
                textBox1.Text += Environment.NewLine;
            textBox1.Text += msg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //查询数据（测试延迟查询）
                using (var db = new TestDB1())
                {
                    var stu = db.Students.FirstOrDefault();
                    ShowMsg("stu:" + stu.Name);
                    ShowMsg("address:" + stu?.Details?.Address);
                    ////Console.WriteLine(stu?.Details?.Address);
                    //textBox1.Text += "address:" + stu?.Details?.Address;
                }
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //查询数据（测试延迟查询）
                using (var db = new TestDB1())
                {
                    var stu = db.Students.FirstOrDefault();
                    ShowMsg("stu:" + stu.Name);
                    ShowMsg("address:" + stu?.Details?.Address);
                    ShowMsg("address:" + stu?.Courses.Count);
                    ////Console.WriteLine(stu?.Details?.Address);
                    //textBox1.Text += "address:" + stu?.Details?.Address;
                }
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Do(() =>
            {
                //查询数据（测试延迟查询）
                using (var db = new TestDB1())
                {
                    db.Students.Add(new Student()
                    {
                    });
                    db.SaveChanges();
                }
            });
        }
    }
}
