using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class system_administrator12_2 : Form
    {
        public system_administrator12_2()
        {
            InitializeComponent();
        }
        public system_administrator12_2(string id,string name,string sex,string bnumber,string pnumber)
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = sex;
            textBox4.Text = bnumber;
            textBox5.Text = pnumber;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text=textBox3.Text=textBox4.Text=textBox5.Text="";//清空
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sql = $"update t_管理员信息表 set 姓名='{textBox2.Text}',sex='{textBox3.Text}',管理宿舍楼号='{textBox4.Text}',phoneNumber='{textBox5.Text}' where 工号='{textBox1.Text}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！" + sql);
            }
        }
    }
}
