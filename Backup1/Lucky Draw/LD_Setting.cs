
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky_Draw
{
    public partial class LD_Setting : Form
    {
        DataAccess DA = new DataAccess();

        public LD_Setting()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks></remarks>
        /// </summary>
        private void LD_Setting_Load(object sender, EventArgs e)
        {
            Ini_Txt();
        }

        /// <summary>自定义事件——初始化文本框
        ///     <remarks></remarks>
        /// </summary>
        private void Ini_Txt()
        {
            string strSQL = "select * from SystemInfo";
            DataTable DT_sys = DA.GetDataTable(strSQL);
            txtTopLeft.Text = DT_sys.Rows[0]["sys_TopLeft"].ToString();
            txtTitle.Text = DT_sys.Rows[0]["sys_Title"].ToString();
            txtTitle2.Text = DT_sys.Rows[0]["sys_Title2"].ToString();
            txtG1.Text = DT_sys.Rows[0]["sys_Grade1"].ToString();
            txtG2.Text = DT_sys.Rows[0]["sys_Grade2"].ToString();
            txtG3.Text = DT_sys.Rows[0]["sys_Grade3"].ToString();
            txtGL.Text = DT_sys.Rows[0]["sys_GradeL"].ToString();
            txt5.Text = DT_sys.Rows[0]["sys_Grade5"].ToString();
            txtT1.Text = DT_sys.Rows[0]["sys_Prize1"].ToString();
            txtT2.Text = DT_sys.Rows[0]["sys_Prize2"].ToString();
            txtT3.Text = DT_sys.Rows[0]["sys_Prize3"].ToString();
            txtTL.Text = DT_sys.Rows[0]["sys_PrizeL"].ToString();
            txtT5.Text = DT_sys.Rows[0]["sys_Prize5"].ToString();
        }

        /// <summary>响应单击按钮事件——重置
        ///     <remarks></remarks>
        /// </summary>
        private void btnIni_Click(object sender, EventArgs e)
        {
            Ini_Txt();
        }

        /// <summary>响应单击按钮事件——修改
        ///     <remarks></remarks>
        /// </summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            StringBuilder sbSQL = new StringBuilder("update SystemInfo set sys_TopLeft='");
            sbSQL.Append(txtTopLeft.Text + "',sys_Title='" + txtTitle.Text + "',sys_Title2='" + txtTitle2.Text);
            sbSQL.Append("',sys_Grade1='" + txtG1.Text + "',sys_Grade2='" + txtG2.Text + "',sys_Grade3='" );
            sbSQL.Append(txtG3.Text + "',sys_GradeL='" + txtGL.Text + "',sys_Grade5='"+txt5.Text+"',sys_Prize1='");
            sbSQL.Append(txtT1.Text + "',sys_Prize2='" + txtT2.Text + "',sys_Prize3='");
            sbSQL.Append(txtT3.Text + "',sys_PrizeL='" + txtTL.Text + "',sys_Prize5='" + txtT5.Text + "'");

            if (DA.ExecuteSQL(sbSQL.ToString()))
            {
                MessageBox.Show("修改系统基本设置成功！");
            }
            else
            {
                MessageBox.Show("修改系统基本设置失败！");
            }
        }
    }
}