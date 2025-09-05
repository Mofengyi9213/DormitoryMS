using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class system_administrator11_1 : Form
    {
        public system_administrator11_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";//清空
        }

        private void button2_Click(object sender, EventArgs e)//确认添加
        {
            Dao dao = new Dao();
            //这里我要先确认要新增的这个账号不存在
         
            Dao dao2= new Dao();
            string sql2 = $"select 账号 from t_user_psw where 账号='{textBox1.Text}';";
            IDataReader dc = dao.reader(sql2);
            if (dc.Read())//读到已经存在的账号
            {
                MessageBox.Show("该账号已经存在！");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else{
                string sql = $"insert into t_user_psw values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}');";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
