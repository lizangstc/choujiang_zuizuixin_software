namespace Lucky_Draw
{
    partial class LD_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LD_Main));
            this.lblGrade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbAwaList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timLD = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblT5 = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblG3 = new System.Windows.Forms.Label();
            this.lblG2 = new System.Windows.Forms.Label();
            this.lblG1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGrade.Location = new System.Drawing.Point(440, 332);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(181, 56);
            this.lblGrade.TabIndex = 59;
            this.lblGrade.Text = "幸运奖";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lsbAwaList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(728, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 600);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 获 奖 名 单";
            // 
            // lsbAwaList
            // 
            this.lsbAwaList.BackColor = System.Drawing.Color.Red;
            this.lsbAwaList.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbAwaList.ForeColor = System.Drawing.Color.Transparent;
            this.lsbAwaList.ItemHeight = 20;
            this.lsbAwaList.Location = new System.Drawing.Point(6, 20);
            this.lsbAwaList.Name = "lsbAwaList";
            this.lsbAwaList.Size = new System.Drawing.Size(217, 564);
            this.lsbAwaList.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Location = new System.Drawing.Point(302, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 66);
            this.panel4.TabIndex = 55;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("黑体", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(3, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(414, 48);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "开　奖　区";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Transparent;
            this.btnBegin.ForeColor = System.Drawing.Color.Transparent;
            this.btnBegin.Image = ((System.Drawing.Image)(resources.GetObject("btnBegin.Image")));
            this.btnBegin.Location = new System.Drawing.Point(78, 284);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBegin.Size = new System.Drawing.Size(216, 40);
            this.btnBegin.TabIndex = 51;
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(78, 349);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(216, 40);
            this.btnOpen.TabIndex = 52;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // timLD
            // 
            this.timLD.Interval = 1;
            this.timLD.Tick += new System.EventHandler(this.timLD_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 46);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle2.Location = new System.Drawing.Point(0, 68);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(1000, 46);
            this.lblTitle2.TabIndex = 70;
            this.lblTitle2.Text = "label1";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(102, 172);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(100, 23);
            this.lblClass.TabIndex = 65;
            this.lblClass.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(102, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 54;
            this.lblName.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新开始ToolStripMenuItem,
            this.基本设置ToolStripMenuItem,
            this.数据管理ToolStripMenuItem,
            this.导出结果ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.基本设置ToolStripMenuItem.Text = "基本设置";
            this.基本设置ToolStripMenuItem.Click += new System.EventHandler(this.基本设置ToolStripMenuItem_Click);
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            this.数据管理ToolStripMenuItem.Click += new System.EventHandler(this.数据管理ToolStripMenuItem_Click);
            // 
            // 导出结果ToolStripMenuItem
            // 
            this.导出结果ToolStripMenuItem.Name = "导出结果ToolStripMenuItem";
            this.导出结果ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.导出结果ToolStripMenuItem.Text = "导出结果";
            this.导出结果ToolStripMenuItem.Click += new System.EventHandler(this.导出结果ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click_1);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblT5);
            this.panel1.Controls.Add(this.lblTL);
            this.panel1.Controls.Add(this.lblT3);
            this.panel1.Controls.Add(this.lblT2);
            this.panel1.Controls.Add(this.lblT1);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblGL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblG3);
            this.panel1.Controls.Add(this.lblG2);
            this.panel1.Controls.Add(this.lblG1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(78, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 160);
            this.panel1.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(144, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 30);
            this.label8.TabIndex = 99;
            this.label8.Text = "名";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(144, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 30);
            this.label4.TabIndex = 98;
            this.label4.Text = "名";
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(144, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 97;
            this.label3.Text = "名";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(144, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 30);
            this.label2.TabIndex = 96;
            this.label2.Text = "名";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(144, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 30);
            this.label1.TabIndex = 95;
            this.label1.Text = "名";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // lblT5
            // 
            this.lblT5.AutoSize = true;
            this.lblT5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblT5.Location = new System.Drawing.Point(176, 122);
            this.lblT5.Name = "lblT5";
            this.lblT5.Size = new System.Drawing.Size(32, 21);
            this.lblT5.TabIndex = 94;
            this.lblT5.Text = "无";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTL.Location = new System.Drawing.Point(176, 95);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(32, 21);
            this.lblTL.TabIndex = 93;
            this.lblTL.Text = "无";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblT3.Location = new System.Drawing.Point(176, 65);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(32, 21);
            this.lblT3.TabIndex = 92;
            this.lblT3.Text = "无";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblT2.Location = new System.Drawing.Point(176, 36);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(32, 21);
            this.lblT2.TabIndex = 91;
            this.lblT2.Text = "无";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblT1.Location = new System.Drawing.Point(176, 7);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(32, 21);
            this.lblT1.TabIndex = 90;
            this.lblT1.Text = "无";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl5.Location = new System.Drawing.Point(115, 124);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(22, 21);
            this.lbl5.TabIndex = 89;
            this.lbl5.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(36, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "幸运奖：";
            // 
            // lblGL
            // 
            this.lblGL.AutoSize = true;
            this.lblGL.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGL.Location = new System.Drawing.Point(115, 94);
            this.lblGL.Name = "lblGL";
            this.lblGL.Size = new System.Drawing.Size(22, 21);
            this.lblGL.TabIndex = 86;
            this.lblGL.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(36, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "三等奖：";
            // 
            // lblG3
            // 
            this.lblG3.AutoSize = true;
            this.lblG3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblG3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblG3.Location = new System.Drawing.Point(115, 65);
            this.lblG3.Name = "lblG3";
            this.lblG3.Size = new System.Drawing.Size(22, 21);
            this.lblG3.TabIndex = 84;
            this.lblG3.Text = "0";
            // 
            // lblG2
            // 
            this.lblG2.AutoSize = true;
            this.lblG2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblG2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblG2.Location = new System.Drawing.Point(115, 35);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(22, 21);
            this.lblG2.TabIndex = 83;
            this.lblG2.Text = "0";
            // 
            // lblG1
            // 
            this.lblG1.AutoSize = true;
            this.lblG1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblG1.Location = new System.Drawing.Point(115, 7);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(22, 21);
            this.lblG1.TabIndex = 82;
            this.lblG1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(36, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "二等奖：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(36, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 80;
            this.label9.Text = "一等奖：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(36, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "特等奖：";
            // 
            // rdb1
            // 
            this.rdb1.BackColor = System.Drawing.Color.Transparent;
            this.rdb1.Location = new System.Drawing.Point(163, 432);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(98, 24);
            this.rdb1.TabIndex = 75;
            this.rdb1.Text = "特等奖";
            this.rdb1.UseVisualStyleBackColor = false;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.BackColor = System.Drawing.Color.Transparent;
            this.rdb2.Location = new System.Drawing.Point(162, 455);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(104, 24);
            this.rdb2.TabIndex = 77;
            this.rdb2.Text = "一等奖";
            this.rdb2.UseVisualStyleBackColor = false;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.BackColor = System.Drawing.Color.Transparent;
            this.rdb3.Location = new System.Drawing.Point(163, 478);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(99, 24);
            this.rdb3.TabIndex = 76;
            this.rdb3.Text = "二等奖";
            this.rdb3.UseVisualStyleBackColor = false;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // rdbL
            // 
            this.rdbL.BackColor = System.Drawing.Color.Transparent;
            this.rdbL.Location = new System.Drawing.Point(163, 502);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(92, 24);
            this.rdbL.TabIndex = 78;
            this.rdbL.Text = "三等奖";
            this.rdbL.UseVisualStyleBackColor = false;
            this.rdbL.CheckedChanged += new System.EventHandler(this.rdbL_CheckedChanged);
            // 
            // rad5
            // 
            this.rad5.BackColor = System.Drawing.Color.Transparent;
            this.rad5.Checked = true;
            this.rad5.Location = new System.Drawing.Point(163, 528);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(99, 24);
            this.rad5.TabIndex = 79;
            this.rad5.TabStop = true;
            this.rad5.Text = "幸运奖";
            this.rad5.UseVisualStyleBackColor = false;
            this.rad5.CheckedChanged += new System.EventHandler(this.rad5_CheckedChanged);
            // 
            // LD_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 732);
            this.Controls.Add(this.rad5);
            this.Controls.Add(this.rdbL);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "LD_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LD_Main_Load);
            this.Click += new System.EventHandler(this.LD_Main_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LD_Main_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbAwaList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timLD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblG3;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.Label lblT5;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出结果ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}