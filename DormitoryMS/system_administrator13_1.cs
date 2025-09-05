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
    public partial class system_administrator13_1 : Form
    {
        public system_administrator13_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//清空按钮
        {
            textBox1.Text=textBox2.Text=textBox3.Text=textBox4.Text="";
        }

        private void button2_Click(object sender, EventArgs e)//确认
        {
            Dao dao = new Dao();
            //这里我要先确认要新增的这个楼号不存在

            Dao dao2 = new Dao();
            string sql2 = $"select BuildingNumber from t_Building where BuildingNumber='{textBox1.Text}';";
            IDataReader dc = dao.reader(sql2);
            if (dc.Read())
            {
                MessageBox.Show("该楼已经存在！");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                string sql = $"insert into t_Building values('{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{textBox3.Text}');";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
