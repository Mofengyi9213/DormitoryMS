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
    public partial class system_administrator12_1 : Form
    {
        public system_administrator12_1()
        {
            InitializeComponent();
        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text=textBox3.Text=textBox5.Text=textBox6.Text="";//清空
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dao dao2 = new Dao();
            string sql2 = $"select 工号 from t_管理员信息表  where 工号='{textBox1.Text}';";
            IDataReader dc = dao2.reader(sql2);
            if (dc.Read())//读到已经存在的账号
            {
                MessageBox.Show("该名员工已经存在！");

            }
            else
            {
                Dao dao = new Dao();
                string sql = $"insert into t_管理员信息表(工号,姓名,sex,用户权限等级,管理宿舍楼号,phoneNumber) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}',2,'{textBox5.Text}','{textBox6.Text}');";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = "";

            }
        }
    }
}
