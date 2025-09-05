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
    public partial class system_administrator11 : Form
    {
        public system_administrator11()
        {
            InitializeComponent();
     
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = "select*from t_user_psw;";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();
            
        }
        public void Table_AccounNumber()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql =$"select*from t_user_psw where 账号='{textBox1.Text}';";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table_AccounNumber();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void system_administrator11_Load(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Table();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                
                label2.Text =  dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除该账号吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_user_psw where 账号='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");//此时该用户已经不能登录了
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

        private void button4_Click(object sender, EventArgs e)
        {
            system_administrator11_1 sa11_1=new system_administrator11_1();
            sa11_1.ShowDialog();
            Table();
        }
    }
}
