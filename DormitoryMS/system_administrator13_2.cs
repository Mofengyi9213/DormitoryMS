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
    public partial class system_administrator13_2 : Form
    {
        public system_administrator13_2()
        {
            InitializeComponent();
        }
        public system_administrator13_2(string bnumber,string address,string num,string usability)
        {
            InitializeComponent();
            textBox1.Text = bnumber;
            textBox2.Text = address;
            textBox3.Text = num;
            textBox4.Text = usability;
        }

        private void button2_Click(object sender, EventArgs e)//确认
        {
            try
            {
                /* string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                 label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();*/
                DialogResult dr = MessageBox.Show("确认修改该栋宿舍吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    string sql = $"update t_Building  set 宿舍楼位置='{textBox2.Text}',寝室房间数量='{textBox3.Text}',可用性='{textBox4.Text}' where BuildingNumber='{textBox1.Text}';";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("修改成功");  
                    }
                    else
                    {
                        MessageBox.Show("修改失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先在表中选中要修改的表格记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void system_administrator13_2_Load(object sender, EventArgs e)
        {

        }
    }
}
