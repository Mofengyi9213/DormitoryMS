using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DormitoryMS
{
    public partial class apartment_manager13_1 : Form
    {
        String NO = "";
        String Type = "";//用来判断是不是一个报修申请
        String Reason = "";
        public apartment_manager13_1()
        {
            InitializeComponent();
        }
        public apartment_manager13_1(string no, string sid, string type, string pnumber, string reason, string date, string result)
        {
            InitializeComponent();
            NO=textBox1.Text =no;
            textBox2.Text =sid;

            Type=textBox3.Text =type;

            textBox4.Text = pnumber;

            Reason=textBox5.Text = reason;

            textBox6.Text = date;
            textBox7.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_学生申请记录表 set 申请结果='{textBox7.Text}' where 申请编号='{NO}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");

                MessageBox.Show(sql);
            }

            //假如Type==C
            if (Type == "C")
            {
                if (textBox7.Text=="同意")
                {
                    string str = "待处理";
                    sql = $"update t_宿舍报修记录表 set 申请结果应答='{str}' where 报修事由='{Reason}'";
                    dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("修改报修记录表成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改报修记录表失败！");

                        MessageBox.Show(sql);
                    }
                }
               
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void apartment_manager13_1_Load(object sender, EventArgs e)
        {

        }
    }
}
