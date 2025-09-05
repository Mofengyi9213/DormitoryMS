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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class apartment_manager16 : Form
    {
        public apartment_manager16()
        {
            InitializeComponent();
            Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string bnumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string rnumber = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string  pnum= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string sid = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string  bnum= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();  

                apartment_manager16_1 am16_1 = new apartment_manager16_1(bnumber,rnumber,pnum,sid,bnum);
                am16_1.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }
        public void Table()//
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select BuildingNumber,RoomNumber,已入住人数,宿舍长学号,床数量 from t_管理员信息表,t_Room where t_Room.BuildingNumber=t_管理员信息表.管理宿舍楼号 and t_管理员信息表.工号='{Data.UID}'";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableRNum()//
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select BuildingNumber,RoomNumber,已入住人数,宿舍长学号,床数量 from t_管理员信息表,t_Room where t_Room.BuildingNumber=t_管理员信息表.管理宿舍楼号 and t_管理员信息表.工号='{Data.UID}'and t_Room.RoomNumber='{textBox3.Text}'";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }



        private void button3_Click(object sender, EventArgs e)//刷新按钮
        {
            string sql = $"update t_Room set 已入住人数=(select A.num from(select t_学生入住信息表.BuildingNumber,t_学生入住信息表.roomNumber, COUNT(*) as num from t_学生入住信息表 group by t_学生入住信息表.BuildingNumber,t_学生入住信息表.roomNumber) as A where A.BuildingNumber=t_Room.BuildingNumber and A.roomNumber=t_Room.RoomNumber);update t_Room set t_Room.已入住人数=0 where t_Room.已入住人数 is NULL;";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 1)
            {
                MessageBox.Show( "刷新成功！");//因为这个刷新涉及到表的update，因此加一个弹窗看看sql更新是否成功
                /*this.Close();*/
            }
            else
            {
                MessageBox.Show("刷新失败！");

                MessageBox.Show(sql);
            }
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "号楼" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "号寝室";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"号楼"+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString()+ "号寝室";
        }

        private void apartment_manager16_Load(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "号楼" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "号寝室";
            //label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//寝室查询按钮
        {
            TableRNum();
        }

        private void button1_Click(object sender, EventArgs e)//新增寝室按钮
        {
            apartment_manager16_2 am16_2=new apartment_manager16_2(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            am16_2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//空床查询按钮
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select BuildingNumber,RoomNumber,已入住人数,宿舍长学号,床数量 from t_管理员信息表,t_Room where t_Room.BuildingNumber=t_管理员信息表.管理宿舍楼号 and t_管理员信息表.工号='{Data.UID}'and t_Room.已入住人数<t_Room.床数量 ";
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
