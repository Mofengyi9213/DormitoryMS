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
    public partial class system_administrator13 : Form
    {
        public system_administrator13()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = "select*from t_Building;";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[3].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();

        }

        public void TableBuildingNumber()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao = new Dao();
            string sql = $"select*from t_Building where buildingNumber='{textBox1.Text}'";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[3].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();

        }

        private void button3_Click(object sender, EventArgs e)//刷新
        {
            
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void system_administrator13_Load(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Table();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableBuildingNumber();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            system_administrator13_1 sa13_1=new system_administrator13_1();
            sa13_1.ShowDialog();
            Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               /* string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();*/
                DialogResult dr = MessageBox.Show("确认删除该栋宿舍吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_Building where BuildingNumber='{dataGridView1.SelectedRows[0].Cells[0].Value}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
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

        private void button5_Click(object sender, EventArgs e)//修改按钮
        {
            try
            {

                system_administrator13_2 sa13_2 = new system_administrator13_2(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                sa13_2.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("请先在表中选中要修改的表格记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
