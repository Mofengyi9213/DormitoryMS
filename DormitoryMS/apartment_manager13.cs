using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class apartment_manager13 : Form
    {
        public apartment_manager13()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = "select * from t_学生申请记录表";
            
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[0].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void apartment_manager13_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //选中第零行第零个单元格
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string pnumber = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string reason = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string date = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string result = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                apartment_manager13_1 am13_1 = new apartment_manager13_1(no, sid, type, pnumber, reason, date, result);
                am13_1.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//学号查询
        {
            TableSID();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
  
        public void TableSID()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_学生申请记录表 where SID='{textBox1.Text}'";

            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[0].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)//类别查询
        {
            TableType();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
        public void TableType()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_学生申请记录表 where 申请事由类别='{textBox2.Text}'";

            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[0].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void TableResult()//结果查询
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_学生申请记录表 where 申请结果='{textBox3.Text}'";

            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[0].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableResult();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
