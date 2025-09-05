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

namespace DormitoryMS
{
    public partial class apartment_manager15 : Form
    {
        public apartment_manager15()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = "select*from t_Student full join t_学生入住信息表  on t_Student.SID=t_学生入住信息表.SID WHERE t_Student.SID not in(select SID FROM t_学生入住信息表);";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(),
                    dc[9].ToString(), dc[10].ToString(), dc[11].ToString(), dc[12].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableSID()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select* from t_Student full join t_学生入住信息表  on t_Student.SID = t_学生入住信息表.SID WHERE t_Student.SID not in(select SID FROM t_学生入住信息表) and t_Student.SID='{textBox1.Text}'";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(),
                    dc[9].ToString(), dc[10].ToString(), dc[11].ToString(), dc[12].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableSName()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select* from t_Student full join t_学生入住信息表  on t_Student.SID = t_学生入住信息表.SID WHERE t_Student.SID not in(select SID FROM t_学生入住信息表) and t_Student.SName='{textBox2.Text}'";
            IDataReader dc = dao.reader(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(),
                    dc[9].ToString(), dc[10].ToString(), dc[11].ToString(), dc[12].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableSID();
            textBox1.Text = textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableSName();
            textBox1.Text = textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void apartment_manager15_Load(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                apartment_manager15_1 am15_1= new apartment_manager15_1(sid,sex);
                am15_1.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("在分配寝室时发生错误");
            }
  
        }
    }
}
