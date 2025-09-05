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
    public partial class apartment_manager14_1 : Form
    {
        public apartment_manager14_1()
        {
            InitializeComponent();
        }

        public apartment_manager14_1(string SID, string BuildingNumber, string floor, string roomNumber, string bedNumber, string phoneNumber, string 入住时间)
        {
            InitializeComponent();
            textBox1.Text =SID;
            textBox2.Text = BuildingNumber;
            textBox3.Text = floor;
            textBox4.Text = roomNumber;

            textBox5.Text = bedNumber;
        
            textBox6.Text = phoneNumber;
            textBox7.Text = 入住时间;
        }


        private void apartment_manager14_1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//清空
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_学生入住信息表 set BuildingNumber='{textBox2.Text}',floor='{textBox3.Text}',roomNumber='{textBox4.Text}',bedNumber={textBox5.Text}, phoneNumber='{textBox6.Text}',入住时间='{textBox7.Text}' where SID='{textBox1.Text}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！"+sql);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
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
