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
    public partial class apartment_manager17_1 : Form
    {
        public apartment_manager17_1()
        {
            InitializeComponent();
        }
        public apartment_manager17_1(string id,string sid,string date,string reason,string res)
        {
            InitializeComponent();
            textBox2.Text = id;
            textBox3.Text = sid;
            textBox4.Text = date;
            textBox5.Text = reason;
            textBox6.Text = res;
        }
        private void button1_Click(object sender, EventArgs e)//确认修改按钮
        {
            string sql = $"update t_宿舍报修记录表 set 申请结果应答='{textBox6.Text}'where 申请编号 = '{textBox2.Text}';";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("报修记录修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("报修记录修改失败！" + sql);
            }
        }
    }
}
