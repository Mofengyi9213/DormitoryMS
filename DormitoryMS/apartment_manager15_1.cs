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
    public partial class apartment_manager15_1 : Form
    {
        String SID = "";
        String Sex="";
        public apartment_manager15_1()
        {
            InitializeComponent();
        }
        public apartment_manager15_1(string sid,string sex)
        {
            InitializeComponent();
            SID = sid;
            Sex = sex;
            textBox1.Text = SID;
            textBox8.Text=Sex;


        }

        private void button2_Click(object sender, EventArgs e)
        {
/*            string sql = $"insert into t_学生申请记录表(SID, 申请事由类别, phoneNumber, 申请事由, 申请日期, 申请结果)values('{Data.UID}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', getdate(), '未审核')"*/

            string sql = $"insert into t_学生入住信息表 (SID,BuildingNumber,floor,roomNumber,bedNumber,phoneNumber,入住时间)values ('{SID}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}',getdate());";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                
                MessageBox.Show(sql+"寝室分配成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("寝室分配失败！");

                MessageBox.Show(sql);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void apartment_manager15_1_Load(object sender, EventArgs e)
        {

        }
    }
}
