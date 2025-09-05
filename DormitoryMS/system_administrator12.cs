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

namespace DormitoryMS
{
    public partial class system_administrator12 : Form
    {
        public system_administrator12()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_管理员信息表 where 工号<>'{Data.UID}' ";//在员工管理这张表上面不要出现自己的员工信息
          
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableUID()//功号查询
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_管理员信息表  where 工号='{textBox1.Text}' ";

            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableUID();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)//刷新
        {
            Table();
            textBox1.Text = "";
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
              


                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除该宿管员信息吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_管理员信息表 where 工号='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");//此时只是将这名宿管员的信息删除而已，但是该员工还是可以登录到本系统，因为账号密码都还在
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先在表中选中要删除的表格记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void system_administrator12_Load(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //修改员工信息
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string name= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string bnumber = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string pnumber = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            system_administrator12_2 sa12_2=    new system_administrator12_2(id,name,sex,bnumber,pnumber);
            sa12_2.ShowDialog();
            Table();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //新增员工信息
            system_administrator12_1 sa12_1=new system_administrator12_1();
            sa12_1.ShowDialog();
            Table();    
        }
    }
}
