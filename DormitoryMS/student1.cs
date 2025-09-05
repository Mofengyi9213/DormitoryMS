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
    public partial class student1 : Form
    {
        public student1()
        {
            InitializeComponent();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student2 student=new student2();
            student.ShowDialog();
        }

        private void 申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student3 student=new student3();
            student.ShowDialog();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 出入记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student4 student = new student4();
            student.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
