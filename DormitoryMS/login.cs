using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryMS
{
    public partial class login : System.Windows.Forms.Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("账号或密码有空，请重新输入！");
            }
        }

        public void Login()
        {
            //学生登录
            if (radioStudent.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select *from t_user_psw where 账号='{textBox1.Text}'and 密码='{textBox2.Text}' and 用户权限等级='3';";
                IDataReader dc = dao.reader(sql);
                if (dc.Read())
                {
                    Data.UID = dc["账号"].ToString();  
                    
                    MessageBox.Show("欢迎学生"+"登录成功！");
                    student1 student=new student1();
                    this.Hide();//隐藏登录窗口
                    student.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }

            //宿舍管理员登录
            else if (radiodorm_supervisor.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select *from t_user_psw where 账号='{textBox1.Text}'and 密码='{textBox2.Text}' and (用户权限等级='2' or 用户权限等级='1')";//宿管员等级=2
                IDataReader dc = dao.reader(sql);
                if (dc.Read())
                {
                    Data.UID = dc["账号"].ToString();
                    MessageBox.Show("欢迎宿舍管理员登录成功！");
                    apartment_manager1 am=new apartment_manager1();
                    this.Hide();//隐藏登录窗口
                    am.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }

            //系统管理员登录

            else if(radioSystem_administrator.Checked==true)
            {
                Dao dao = new Dao();
                string sql = $"select *from t_user_psw where 账号='{textBox1.Text}'and 密码='{textBox2.Text}'and 用户权限等级='1'";
                IDataReader dc = dao.reader(sql);
                if (dc.Read())
                {
                    Data.UID = dc["账号"].ToString();
                   

                    MessageBox.Show("欢迎系统管理员登录成功！");
                    system_administrator1 sa1 = new system_administrator1();
                    this.Hide();//隐藏登录窗口
                    sa1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
        }
    }
}
