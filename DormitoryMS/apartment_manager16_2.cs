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
    public partial class apartment_manager16_2 : Form
    {
        public apartment_manager16_2()
        {
            InitializeComponent();
        }
        public apartment_manager16_2(string bnum)//
        {
            InitializeComponent();
            textBox1.Text = bnum;
        }
        private void button1_Click(object sender, EventArgs e)//确认新增寝室按钮
        {
            string sql = $"insert into t_Room (BuildingNumber,RoomNumber,已入住人数,宿舍长学号,床数量)values ('{textBox1.Text}','{textBox3.Text}',0,null,'{textBox6.Text}');";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("寝室添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("寝室添加失败！");

                MessageBox.Show(sql);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
