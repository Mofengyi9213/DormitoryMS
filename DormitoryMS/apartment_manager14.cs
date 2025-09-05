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
    public partial class 修改学生住宿信息页面 : Form
    {
        public 修改学生住宿信息页面()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            //string sql = $"select * from t_管理员信息表  where 工号='{Data.UID}'";
             string sql = $"select*from t_学生入住信息表 ";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
           
        }

        private void apartment_manager14_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //选中第零行第零个单元格
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                string sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string bn = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string f = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string rn = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string b = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string pn = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string t = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                apartment_manager14_1 am14_1 = new apartment_manager14_1(sid,bn,f,rn,b,pn,t);
                am14_1.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//    学号查询
        {
            TableID();
        }
        public void TableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            //string sql = $"select * from t_管理员信息表  where 工号='{Data.UID}'";
            string sql = $"select*from t_学生入住信息表 where SID='{textBox1.Text}' ";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //选中第零行第零个单元格
        }
     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
