using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace Lucky_Draw
{

    public partial class LD_Main : Form
    {
        DataAccess DA = new DataAccess();//实例化数据库操作类
        private DataTable DT_stu;//员工表
        private DataTable DT_awa;//获奖表
        private DataTable DT_sys;//系统表
        private int stuCount;//员工总数
        private string strGrade;//奖项等级
        private Random RanNum;//随机数
        private int awaCount = 0;
        private int onesNums = 1;//一次抽取的人数，默认为1个
       // private ArrayList list = new ArrayList();

        public LD_Main()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks></remarks>
        /// </summary>
        private void LD_Main_Load(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * from SystemInfo";
                DT_sys = DA.GetDataTable(strSQL);
                lblG1.Text = DT_sys.Rows[0]["sys_Grade1"].ToString();
                lblG2.Text = DT_sys.Rows[0]["sys_Grade2"].ToString();
                lblG3.Text = DT_sys.Rows[0]["sys_Grade3"].ToString();
                lblGL.Text = DT_sys.Rows[0]["sys_GradeL"].ToString();
                lbl5.Text = DT_sys.Rows[0]["sys_Grade5"].ToString();
                lblT1.Text = "奖品：" + DT_sys.Rows[0]["sys_Prize1"].ToString();
                lblT2.Text = "奖品：" + DT_sys.Rows[0]["sys_Prize2"].ToString();
                lblT3.Text = "奖品：" + DT_sys.Rows[0]["sys_Prize3"].ToString();
                lblTL.Text = "奖品：" + DT_sys.Rows[0]["sys_PrizeL"].ToString();
                lblT5.Text = "奖品：" + DT_sys.Rows[0]["sys_Prize5"].ToString();
                //this.ld.Text = DT_sys.Rows[0]["sys_TopLeft"].ToString();
                lblTitle.Text = DT_sys.Rows[0]["sys_Title"].ToString();
                lblTitle2.Text = DT_sys.Rows[0]["sys_Title2"].ToString();
                strGrade = "幸运奖";
                Set_StuCount();
                Awa_View();
                btnOpen.Enabled = false;

                //添加音乐
                System.Media.SoundPlayer sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + @"/pm3.wav");
                sndPlayer.PlayLooping();


                //list.Add("aa");
                //list.Add("bb");
                //list.Add("cc");
                //list.Add("dd");
                //list.Add("dd");
            }
            catch
            { }
        }


        //#region 
        //private void getname()
        //{

        //    if (list.Count > 0)
        //    {
        //        int cont = list.Count - 1;
        //        RanNum = new Random();
        //        string tmpstr = list[RanNum.Next(0, cont)].ToString();

        //        lblName.Text = tmpstr;
        //        lblID.Text = getid(tmpstr);
        //        list.Remove(tmpstr);
        //    }
        //    else
        //    {
        //        list.Add("aa");
        //        list.Add("bb");
        //        list.Add("cc");
        //        list.Add("dd");
        //        list.Add("ee");

        //        int cont = list.Count - 1;
        //        RanNum = new Random();
        //string tmpstr = list[RanNum.Next(0, cont)].ToString();

        //        lblName.Text = tmpstr;
        //        lblID.Text = getid(tmpstr);
        //        list.Remove(tmpstr);
        //    }



        //}
        //#endregion
        /// <summary>自定义事件——提取员工人数
        ///     <remarks></remarks>
        /// </summary>
        private void Set_StuCount()
        {
            //string strSQL = "select * from StuInfo where stuName not in( 'aa','bb','ee','cc', 'ee')";
            string strSQL = "select * from StuInfo";
            DT_stu = DA.GetDataTable(strSQL);
            stuCount = DT_stu.Rows.Count;
            DataAccess.DataIsChange = false;
        }

        /// <summary>自定义事件——提取员工人数
        ///     <remarks></remarks>
        /// </summary>
        private void Set_StuCountaaa()
        {
            string strSQL = "select * from StuInfo";
            DT_stu = DA.GetDataTable(strSQL);
            stuCount = DT_stu.Rows.Count;
            DataAccess.DataIsChange = false;
        }

        /// <summary>自定义事件——浏览获奖情况
        ///     <remarks></remarks>
        /// </summary>
        private void Awa_View()
        {
            try
            {
                lsbAwaList.Items.Clear();
                string strSQL = "select * from AwardsInfo where awaGrade='" + strGrade + "'";
                DT_awa = DA.GetDataTable(strSQL);
                for (int i = 0; i < DT_awa.Rows.Count; i++)
                {
                    lsbAwaList.Items.Add("  "+DT_awa.Rows[i]["stuName"].ToString() + "      " + DT_awa.Rows[i]["awaGrade"].ToString());
                }
                awaCount = lsbAwaList.Items.Count;
                
            }
            catch
            { }
        }

        /// <summary>自定义事件——检查此人是否已中奖
        ///     <remarks></remarks>
        /// </summary>
        private bool Awa_Chk()
        {
            try
            {
                string strSQL = "select stuID from AwardsInfo";
                DataTable DT_check = DA.GetDataTable(strSQL);
                for (int i = 0; i < DT_check.Rows.Count; i++)
                {
                    if (DT_check.Rows[i]["stuID"].ToString() == lblClass.Text.Trim())
                    {
                        return false;
                    }
                }
           
            }
            catch
            { }
            return true;
        }

        /// <summary>自定义事件——添加中奖信息
        ///     <remarks></remarks>
        /// </summary>
        private void Awa_Save(string stuID, string stuName, string awaGrade)
        {
            StringBuilder sbSQL = new StringBuilder("insert into AwardsInfo(stuID,stuName,awaGrade) values('");
            sbSQL.Append(stuID + "','" + stuName + "','" + awaGrade + "')");
            DA.ExecuteSQL(sbSQL.ToString());
        }

        /// <summary>响应顶部按钮事件——关闭窗体
        ///     <remarks></remarks>
        /// </summary>
        private void tol_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>响应顶部按钮事件——最小化窗体
        ///     <remarks></remarks>
        /// </summary>
        private void tol_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>响应顶部按钮事件——最大化/正常化窗体
        ///     <remarks></remarks>
        /// </summary>
        private void tol_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>计时器事件
        ///     <remarks></remarks>
        /// </summary>
        private void timLD_Tick(object sender, EventArgs e)
        {
            int randata;
            RanNum = new Random((int)DateTime.Now.Ticks);
            randata = RanNum.Next(stuCount);
            this.lblClass.Text = DT_stu.Rows[randata]["stuID"].ToString();
            lblName.Text = DT_stu.Rows[randata]["stuName"].ToString();
            this.lblID.Text = lblName.Text;

        }

        private void getotwo(string names)
        {
            int randata;
            RanNum = new Random((int)DateTime.Now.Ticks);
            randata = RanNum.Next(stuCount);
            lblName.Text = names;
            lblClass.Text = getid(names);
            this.lblID.Text = this.lblClass.Text + "   ---  " + lblName.Text;
        }

        
        private string getid(string names)
        {
            string str = string.Empty;
            try
            {
                string ssql = "select stuID from StuInfo where stuName='" + names + "'";
                using (OleDbDataReader reder = DA.ExecuteReader(ssql))
                {
                    while (reder.Read())
                    {
                        str = reder["stuID"].ToString();

                        reder.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                
            }
            return str;
        }

        /// <summary>响应单击按钮事件——摇奖
        ///     <remarks></remarks>
        /// </summary>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            
             try
                {
                    //检查员工的数据有变化
                    if (DataAccess.DataIsChange)
                    {
                        Set_StuCount();
                    }
                    if (stuCount <= 0)
                    {
                        MessageBox.Show("对不起，还没有员工信息，不能进行抽奖！", "没有记录", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    lblID.ForeColor = Color.White;
                    timLD.Start();
                    btnOpen.Enabled = true;
                    btnOpen.Focus();
                }
                catch
                { }
            
        }

        /// <summary>响应单击按钮事件——开奖
        ///     <remarks></remarks>
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < onesNums; x++)
            {
                chouJiang();
            }
        }
        private void chouJiang()
        {
            try
            {
                string strSQL = "select stuID from AwardsInfo";
                DataTable DT_temp = DA.GetDataTable(strSQL);
                if (DT_temp.Rows.Count >= stuCount)
                {
                    timLD.Stop();
                    lblID.ForeColor = Color.Red;
                    lblID.Text = "所有人都已经获奖了!";
                    return;
                }
                while (!Awa_Chk())
                {
                    int randata;
                    RanNum = new Random((int)DateTime.Now.Ticks);
                    randata = RanNum.Next(stuCount);
                    lblClass.Text = DT_stu.Rows[randata]["stuID"].ToString();
                    lblName.Text = DT_stu.Rows[randata]["stuName"].ToString();
                    this.lblID.Text = lblName.Text;
                }
                int awaGCount = 0, i;
                timLD.Stop();
                btnOpen.Enabled = false;
                awaCount = lsbAwaList.Items.Count;
                lblID.ForeColor = Color.Red;
                if (rdb1.Checked == true)
                {

                    for (i = 0; i < awaCount; i++)
                    {
                        if (lsbAwaList.Items[i].ToString().EndsWith("特等奖"))
                        {
                            awaGCount++;
                        }
                    }
                    if (awaGCount >= Convert.ToInt32(lblG1.Text.Trim()))
                    {
                        MessageBox.Show("特等奖已经抽取完毕，请抽取其它奖项！！");
                    }
                    else
                    {
                        //getotwo("aa");
                        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                        strGrade = "特等奖";
                    }
                }
                else if (rdb2.Checked == true)
                {
                    //if(awaCount==2)
                    //{
                    //    //getotwo("bb");
                    //    for (i = 0; i < awaCount; i++)
                    //    {
                    //        if (lsbAwaList.Items[i].ToString().EndsWith("二等奖"))
                    //        {
                    //            awaGCount++;
                    //        }
                    //    }
                    //    if (awaGCount >= Convert.ToInt32(lblG2.Text.Trim()))
                    //    {
                    //        MessageBox.Show("二等奖已经抽取完毕，请抽取其它奖项！！");
                    //    }
                    //    else
                    //    {
                    //        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                    //        strGrade = "二等奖";
                    //    }
                    //}
                    //else
                    //{
                    for (i = 0; i < awaCount; i++)
                    {
                        if (lsbAwaList.Items[i].ToString().EndsWith("一等奖"))
                        {
                            awaGCount++;
                        }
                    }
                    if (awaGCount >= Convert.ToInt32(lblG2.Text.Trim()))
                    {
                        MessageBox.Show("一等奖已经抽取完毕，请抽取其它奖项！！");
                    }
                    else
                    {
                        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                        strGrade = "一等奖";
                    }
                    // }
                }
                else if (rdb3.Checked == true)
                {
                    //if (awaCount==1)
                    //{
                    //    getotwo("cc");
                    //    for (i = 0; i < awaCount; i++)
                    //    {
                    //        if (lsbAwaList.Items[i].ToString().EndsWith("三等奖"))
                    //        {
                    //            awaGCount++;
                    //        }

                    //    }
                    //    if (awaGCount >= Convert.ToInt32(lblG3.Text.Trim()))
                    //    {
                    //        MessageBox.Show("三等奖已经抽取完毕，请抽取其它奖项！！");
                    //    }
                    //    else
                    //    {
                    //        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                    //        strGrade = "三等奖";
                    //    }
                    //}
                    //if (awaCount == 4)
                    //{
                    //    getotwo("dd");
                    //    for (i = 0; i < awaCount; i++)
                    //    {
                    //        if (lsbAwaList.Items[i].ToString().EndsWith("三等奖"))
                    //        {
                    //            awaGCount++;
                    //        }

                    //    }
                    //    if (awaGCount >= Convert.ToInt32(lblG3.Text.Trim()))
                    //    {
                    //        MessageBox.Show("三等奖已经抽取完毕，请抽取其它奖项！！");
                    //    }
                    //    else
                    //    {
                    //        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                    //        strGrade = "三等奖";
                    //    }
                    //}
                    //else
                    //{

                    for (i = 0; i < awaCount; i++)
                    {
                        if (lsbAwaList.Items[i].ToString().EndsWith("二等奖"))
                        {
                            awaGCount++;
                        }

                    }
                    if (awaGCount >= Convert.ToInt32(lblG3.Text.Trim()))
                    {
                        MessageBox.Show("二等奖已经抽取完毕，请抽取其它奖项！！");
                    }
                    else
                    {
                        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                        strGrade = "二等奖";
                    }

                    // }
                }
                else if (rdbL.Checked == true)
                {

                    for (i = 0; i < awaCount; i++)
                    {
                        if (lsbAwaList.Items[i].ToString().EndsWith("三等奖"))
                        {
                            awaGCount++;
                        }
                    }
                    if (awaGCount >= Convert.ToInt32(lblGL.Text.Trim()))
                    {
                        MessageBox.Show("三等奖已经抽取完毕，请抽取其它奖项！！");
                    }
                    else
                    {
                        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                        strGrade = "三等奖";
                    }
                }
                else if (this.rad5.Checked == true)
                {
                    //if (awaCount == 7)
                    //{
                    //    getotwo("ee");
                    //    for (i = 0; i < awaCount; i++)
                    //    {
                    //        if (lsbAwaList.Items[i].ToString().EndsWith("五等奖"))
                    //        {
                    //            awaGCount++;
                    //        }

                    //    }
                    //    if (awaGCount >= Convert.ToInt32(lbl5.Text.Trim()))
                    //    {
                    //        MessageBox.Show("五等奖已经抽取完毕，请抽取其它奖项！！");
                    //    }
                    //    else
                    //    {
                    //        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                    //        strGrade = "五等奖";
                    //    }
                    //}
                    //else
                    //{
                    for (i = 0; i < awaCount; i++)
                    {
                        if (lsbAwaList.Items[i].ToString().EndsWith("幸运奖"))
                        {
                            awaGCount++;
                        }

                    }
                    if (awaGCount >= Convert.ToInt32(lbl5.Text.Trim()))
                    {
                        MessageBox.Show("幸运奖已经抽取完毕，请抽取其它奖项！！");
                    }
                    else
                    {
                        Awa_Save(lblClass.Text.Trim(), lblName.Text.Trim(), lblGrade.Text.Trim());
                        strGrade = "幸运奖";
                    }
                    // }

                }
                Awa_View();
                btnBegin.Focus();
            }
            catch
            { }
        }

        /// <summary>单选按钮选中事件——特等奖
        ///     <remarks></remarks>
        /// </summary>
        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "特等奖";
            strGrade = "特等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——一等奖
        ///     <remarks></remarks>
        /// </summary>
        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "一等奖";
            strGrade = "一等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——二等奖
        ///     <remarks></remarks>
        /// </summary>
        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "二等奖";
            strGrade = "二等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——三运奖
        ///     <remarks></remarks>
        /// </summary>
        private void rdbL_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "三等奖";
            strGrade = "三等奖";
            Awa_View();
            btnBegin.Focus();

        }

       

        /// <summary>单选按钮选中事件——重新开始
        ///     <remarks></remarks>
        /// </summary>
        private void btnSysReStart_Click(object sender, EventArgs e)
        {
            awaCount = 0;
            string strSQL = "delete from AwardsInfo";
            DA.ExecuteSQL(strSQL);
            Awa_View();
        }

        /// <summary>单选按钮选中事件——基本设置
        ///     <remarks></remarks>
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            LD_Setting LDst = new LD_Setting();
            LDst.ShowDialog();
        }

        /// <summary>单选按钮选中事件——数据管理
        ///     <remarks></remarks>
        /// </summary>
        private void btnSysData_Click(object sender, EventArgs e)
        {
            LD_DataManage LDDM = new LD_DataManage();
            LDDM.ShowDialog();
        }

        /// <summary>单选按钮选中事件——帮助
        ///     <remarks></remarks>
        /// </summary>
        private void btnSysHelp_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            hl.ShowDialog();
        }

        /// <summary>单选按钮选中事件——关于
        ///     <remarks></remarks>
        /// </summary>
        private void btnSysAbout_Click(object sender, EventArgs e)
        {
            Gy g = new Gy();
            g.ShowDialog();
        }

        /// <summary>窗体事件——单击窗体
        ///     <remarks></remarks>
        /// </summary>
        private void LD_Main_Click(object sender, EventArgs e)
        {
            
            btnBegin.Focus();
        }

        /// <summary>窗体事件——键按下时
        ///     <remarks></remarks>
        /// </summary>
        private void LD_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnBegin.Focus();
            }
        }

        private void rad5_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "幸运奖";
            strGrade = "幸运奖";
            Awa_View();
            btnBegin.Focus();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            awaCount = 0;
            string strSQL = "delete from AwardsInfo";
            DA.ExecuteSQL(strSQL);
            Awa_View();
        }

        private void 基本设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LD_Setting LDst = new LD_Setting();
            LDst.ShowDialog();
        }

        private void 数据管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LD_DataManage LDDM = new LD_DataManage();
            LDDM.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gy g = new Gy();
            g.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void 导出结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql;
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Environment.CurrentDirectory + "\\data\\LD.mdb;Persist Security Info=False;Jet OLEDB:Database Password=shiyanexperiment;";
            System.Data.OleDb.OleDbConnection cn = new System.Data.OleDb.OleDbConnection(ConnectionString);
            System.Data.OleDb.OleDbCommand cmd;
            cn.Open();

            String fileName = "抽奖结果" + System.DateTime.Now.ToString("yyyyMMddhhmmss") + ".xls";
            sql = @"select stuName as 会员编号,awaGrade as 获奖等级 into [Excel 8.0;database=" + System.Environment.CurrentDirectory + @"\"+fileName+"].[Sheet1] from AwardsInfo";
            cmd = new System.Data.OleDb.OleDbCommand(sql, cn);

            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                MessageBox.Show("没有中奖结果，您可能尚未开奖!");
            }
            else
            {
                MessageBox.Show("中奖结果已经导入" + System.Environment.CurrentDirectory + "\\" + fileName + "中");
            }
            cn.Close();
            cn.Dispose();
            cn = null;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}