namespace DormitoryMS
{
    partial class system_administrator1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改宿舍楼信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑 Light", 22.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(251, 286);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 86);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "欢迎系统管理员登录！";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询学生信息ToolStripMenuItem,
            this.管理员工ToolStripMenuItem,
            this.修改宿舍楼信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 39);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询学生信息ToolStripMenuItem
            // 
            this.查询学生信息ToolStripMenuItem.Name = "查询学生信息ToolStripMenuItem";
            this.查询学生信息ToolStripMenuItem.Size = new System.Drawing.Size(130, 35);
            this.查询学生信息ToolStripMenuItem.Text = "管理用户";
            this.查询学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查询学生信息ToolStripMenuItem_Click);
            // 
            // 管理员工ToolStripMenuItem
            // 
            this.管理员工ToolStripMenuItem.Name = "管理员工ToolStripMenuItem";
            this.管理员工ToolStripMenuItem.Size = new System.Drawing.Size(130, 35);
            this.管理员工ToolStripMenuItem.Text = "管理员工";
            this.管理员工ToolStripMenuItem.Click += new System.EventHandler(this.管理员工ToolStripMenuItem_Click);
            // 
            // 修改宿舍楼信息ToolStripMenuItem
            // 
            this.修改宿舍楼信息ToolStripMenuItem.Name = "修改宿舍楼信息ToolStripMenuItem";
            this.修改宿舍楼信息ToolStripMenuItem.Size = new System.Drawing.Size(202, 35);
            this.修改宿舍楼信息ToolStripMenuItem.Text = "修改宿舍楼信息";
            this.修改宿舍楼信息ToolStripMenuItem.Click += new System.EventHandler(this.修改宿舍楼信息ToolStripMenuItem_Click);
            // 
            // system_administrator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "system_administrator1";
            this.Text = "系统管理员主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改宿舍楼信息ToolStripMenuItem;
    }
}