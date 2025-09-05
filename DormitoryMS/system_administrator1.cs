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
    public partial class system_administrator1 : Form
    {
        public system_administrator1()
        {
            InitializeComponent();
        }

        private void 查询学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system_administrator11 sa11= new system_administrator11();
            sa11.ShowDialog();
        }

        private void 管理员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system_administrator12 sa12=   new system_administrator12();
            sa12.ShowDialog();
        }

      

        private void 修改宿舍楼信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system_administrator13 sa13=new system_administrator13();
            sa13.ShowDialog();
        }
    }
}
