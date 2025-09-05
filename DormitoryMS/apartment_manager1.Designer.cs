namespace DormitoryMS
{
    partial class apartment_manager1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核学生申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生住宿信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分配宿舍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理宿舍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.寝室报修记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaToolStripMenuItem,
            this.查询学生信息ToolStripMenuItem,
            this.审核学生申请ToolStripMenuItem,
            this.修改学生住宿信息ToolStripMenuItem,
            this.分配宿舍ToolStripMenuItem,
            this.管理宿舍ToolStripMenuItem,
            this.寝室报修记录查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1419, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // chaToolStripMenuItem
            // 
            this.chaToolStripMenuItem.Name = "chaToolStripMenuItem";
            this.chaToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.chaToolStripMenuItem.Text = "查询基本信息";
            this.chaToolStripMenuItem.Click += new System.EventHandler(this.chaToolStripMenuItem_Click);
            // 
            // 查询学生信息ToolStripMenuItem
            // 
            this.查询学生信息ToolStripMenuItem.Name = "查询学生信息ToolStripMenuItem";
            this.查询学生信息ToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.查询学生信息ToolStripMenuItem.Text = "查询学生信息";
            this.查询学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查询学生信息ToolStripMenuItem_Click);
            // 
            // 审核学生申请ToolStripMenuItem
            // 
            this.审核学生申请ToolStripMenuItem.Name = "审核学生申请ToolStripMenuItem";
            this.审核学生申请ToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.审核学生申请ToolStripMenuItem.Text = "审核学生申请";
            this.审核学生申请ToolStripMenuItem.Click += new System.EventHandler(this.审核学生申请ToolStripMenuItem_Click);
            // 
            // 修改学生住宿信息ToolStripMenuItem
            // 
            this.修改学生住宿信息ToolStripMenuItem.Name = "修改学生住宿信息ToolStripMenuItem";
            this.修改学生住宿信息ToolStripMenuItem.Size = new System.Drawing.Size(226, 35);
            this.修改学生住宿信息ToolStripMenuItem.Text = "修改学生住宿信息";
            this.修改学生住宿信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生住宿信息ToolStripMenuItem_Click);
            // 
            // 分配宿舍ToolStripMenuItem
            // 
            this.分配宿舍ToolStripMenuItem.Name = "分配宿舍ToolStripMenuItem";
            this.分配宿舍ToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.分配宿舍ToolStripMenuItem.Text = "新生分配寝室";
            this.分配宿舍ToolStripMenuItem.Click += new System.EventHandler(this.分配宿舍ToolStripMenuItem_Click);
            // 
            // 管理宿舍ToolStripMenuItem
            // 
            this.管理宿舍ToolStripMenuItem.Name = "管理宿舍ToolStripMenuItem";
            this.管理宿舍ToolStripMenuItem.Size = new System.Drawing.Size(130, 35);
            this.管理宿舍ToolStripMenuItem.Text = "管理宿舍";
            this.管理宿舍ToolStripMenuItem.Click += new System.EventHandler(this.管理宿舍ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑 Light", 22.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(419, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 86);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "欢迎宿舍管理员登录！";
            // 
            // 寝室报修记录查询ToolStripMenuItem
            // 
            this.寝室报修记录查询ToolStripMenuItem.Name = "寝室报修记录查询ToolStripMenuItem";
            this.寝室报修记录查询ToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.寝室报修记录查询ToolStripMenuItem.Text = "报修记录查询";
            this.寝室报修记录查询ToolStripMenuItem.Click += new System.EventHandler(this.寝室报修记录查询ToolStripMenuItem_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // apartment_manager1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 730);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "apartment_manager1";
            this.Text = "宿舍管理员主页面";
            this.Load += new System.EventHandler(this.apartment_manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审核学生申请ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生住宿信息ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 分配宿舍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理宿舍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 寝室报修记录查询ToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}