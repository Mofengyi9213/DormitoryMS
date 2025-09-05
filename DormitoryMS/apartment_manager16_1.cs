using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DormitoryMS
{
    public partial class apartment_manager16_1 : Form
    {
        public apartment_manager16_1()
        {
            InitializeComponent();
        }
        public apartment_manager16_1(string bnumber,string rnumber,string pnum,string sid,string bnum)
        {
            InitializeComponent();
            textBox2.Text = bnumber;
            textBox3.Text = rnumber;
            textBox4.Text = pnum;
            textBox5.Text = sid;
            textBox6.Text = bnum;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//修改按钮
        {
            string sql = $"update t_Room set 已入住人数='{textBox4.Text}',宿舍长学号='{textBox5.Text}', 床数量='{textBox6.Text}' where BuildingNumber='{textBox2.Text}'and RoomNumber='{textBox3.Text}';";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！" + sql);
            }
        }

        private void apartment_manager16_1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
