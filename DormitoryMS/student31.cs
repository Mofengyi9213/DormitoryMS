using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class student31 : Form
    {
        public student31()
        {
            InitializeComponent();
        }

        private void student31_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//清空按钮
        {
            //textBox1.Text = "";//学号
            textBox2.Text = "";//申请事由类别
            textBox3.Text = "";//电话
            textBox4.Text = "";//申请事由
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            //新增申请记录：学生提交学号、申请事由类别、电话、申请事由
            //此时系统在将记录写进数据库时除了上面的这些信息以外还要写入

            //更新：就提交申请事由类别、申请事由、电话就好啦，学号从UID获取 
            string sql=$"insert into t_学生申请记录表(SID, 申请事由类别, phoneNumber, 申请事由, 申请日期, 申请结果)values('{Data.UID}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', getdate(), '未审核')";
            Dao dao=new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("申请成功，请等待管理员审核！");
               /* this.Close();*/
              /*  Table();*/
            }
            else
            {
                MessageBox.Show("申请失败，请重新提交申请！");
            }

            //判断是不是报修申请C，如果是的话需要将该条记录新增至‘宿舍报修记录表’当中
            if (textBox2.Text == "C")
            {
                MessageBox.Show("这是一个报修申请");

                //新增至‘宿舍报修记录表’当中
                sql = $"insert into t_宿舍报修记录表(SID, 申请报修日期, 报修事由, 申请结果应答)values('{Data.UID}',getdate(), '{textBox4.Text}',  '未修')";
                Dao dao2 = new Dao();
                if (dao2.Execute(sql) > 0)
                {
                    MessageBox.Show("报修申请成功，请等待管理员审核！");
                    
                }
            }

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
