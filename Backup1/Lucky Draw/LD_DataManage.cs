using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky_Draw
{
    public partial class LD_DataManage : Form
    {
        DataAccess DA = new DataAccess();
        StringBuilder sbSQL = new StringBuilder();

        public LD_DataManage()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks></remarks>
        /// </summary>
        private void LD_DataManage_Load(object sender, EventArgs e)
        {
            Bind_DG();
        }

        /// <summary>自定义事件——为DataGrid绑定数据
        ///     <remarks></remarks>
        /// </summary>
        private void Bind_DG()
        {
            try
            {
                string strSQL = "select stuID as 卡号,stuName as 姓名 from StuInfo";
                DataTable DT = DA.GetDataTable(strSQL);
                DG.DataSource = DT;
                DG.Refresh();
                if (DG.Rows.Count < 1)
                {
                    btnModify.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDeleteAll.Enabled = false;
                }
                else
                {
                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }
            }
            catch
            { }
        }

        /// <summary>单选按钮事件——打开文件
        ///     <remarks></remarks>
        /// </summary>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofdExcel.FileName;
            }
        }

        /// <summary>单选按钮事件——导入数据
        ///     <remarks></remarks>
        /// </summary>
        private void btnLendIN_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = DA.LendInDT(txtFile.Text.Trim());
                int j = 0;
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    sbSQL = new StringBuilder("insert into StuInfo(stuName) values('");
                    sbSQL.Append(DT.Rows[i]["姓名"].ToString());
                    sbSQL.Append( "')");
                    if (DA.ExecuteSQL(sbSQL.ToString()))
                    {
                        j++;
                    }
                }
                MessageBox.Show("导入数据成功，共导入" + j.ToString() + "条记录！");
                DataAccess.DataIsChange = true;
                Bind_DG();
            }
            catch(Exception ex)
            {
                MessageBox.Show("导入数据失败，请确认你要导入的excel表格式正确！");
            }
        }

        /// <summary>DataGrid事件——单击事件
        ///     <remarks></remarks>
        /// </summary>
        private void DG_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG.Rows.Count >= 1)
                {
                    DataGridViewRow DGrow = DG.CurrentRow;
                    txtID.Text = DGrow.Cells[0].Value.ToString();
                    txtName.Text = DGrow.Cells[1].Value.ToString();
                }
            }
            catch
            { }
        }

        /// <summary>响应单击按钮事件——清空
        ///     <remarks></remarks>
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        /// <summary>响应单击按钮事件——添加
        ///     <remarks></remarks>
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sbSQL = new StringBuilder("insert into StuInfo(stuName) values('");
                sbSQL.Append(txtName.Text.Trim() + "')");
                if (DA.ExecuteSQL(sbSQL.ToString()))
                {
                    lblMessage.Text = "添加数据成功！";
                    DataAccess.DataIsChange = true;
                    Bind_DG();
                }
                else
                {
                    lblMessage.Text = "添加数据失败，请重试！";
                }
            }
            catch
            { }
        }

        /// <summary>响应单击按钮事件——修改
        ///     <remarks></remarks>
        /// </summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update StuInfo set stuName='" + txtName.Text.Trim() + "' where stuId=" + int.Parse(DG.CurrentRow.Cells[0].Value.ToString());
                if (DA.ExecuteSQL(sql))
                {
                    lblMessage.Text = "修改数据成功！";
                    DataAccess.DataIsChange = true;
                    Bind_DG();
                }
                else
                {
                    lblMessage.Text = "修改数据失败，请重试！";
                }
            }
            catch
            { }
        }

        /// <summary>响应单击按钮事件——删除
        ///     <remarks></remarks>
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sbSQL = new StringBuilder("delete from StuInfo where stuID=");
                sbSQL.Append(int.Parse(DG.CurrentRow.Cells[0].Value.ToString()));
                if (DA.ExecuteSQL(sbSQL.ToString()))
                {
                    lblMessage.Text = "删除数据成功！";
                    DataAccess.DataIsChange = true;
                    Bind_DG();
                }
                else
                {
                    lblMessage.Text = "删除数据失败，请重试！";
                }
            }
            catch
            { }
        }

        /// <summary>响应单击按钮事件——删除所有数据
        ///     <remarks></remarks>
        /// </summary>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除所有数据吗？", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    sbSQL = new StringBuilder("delete from StuInfo");
                    if (DA.ExecuteSQL(sbSQL.ToString()))
                    {
                        lblMessage.Text = "删除所有数据成功！";
                        DataAccess.DataIsChange = true;
                        Bind_DG();
                    }
                    else
                    {
                        lblMessage.Text = "删除所有数据失败，请重试！";
                    }
                }
            }
            catch
            { }
        }


    }
}