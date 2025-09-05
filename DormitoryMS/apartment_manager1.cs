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
    public partial class apartment_manager1 : Form
    {
        public apartment_manager1()
        {
            InitializeComponent();
        }

        private void chaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager11 am11= new apartment_manager11();
            am11.ShowDialog();
        }

        private void apartment_manager_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 查询学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager12 am12= new apartment_manager12();
            am12.ShowDialog();
        }

        private void 审核学生申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager13 am13 = new apartment_manager13();
            am13.ShowDialog();
        }

        private void 修改学生住宿信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改学生住宿信息页面 am14 = new 修改学生住宿信息页面();
            am14.ShowDialog();
        }

        private void 修改宿舍楼信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 分配宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager15 am15 = new apartment_manager15();
            am15.ShowDialog();
        }

        private void 管理宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager16 am16 = new apartment_manager16();
            am16.ShowDialog();
        }

        private void 寝室报修记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartment_manager17 am17 = new apartment_manager17();
            am17.ShowDialog();
        }
    }
}
