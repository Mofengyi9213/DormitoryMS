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
    public partial class apartment_manager17 : Form
    {
        public apartment_manager17()
        {
            InitializeComponent();
            Table();
        }
        public void Table()//
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select*from t_宿舍报修记录表";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//修改按钮
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string  sid= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string reason = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string res = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                apartment_manager17_1 am17_1 = new apartment_manager17_1(id,sid,date,reason,res);
                am17_1.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
