using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CICOS_Helper
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            txb_fileName.Enabled = false;
            txb_dir.Enabled = false;
            label2.Text = "1. 班级名单请以 Excel 表格形式存储。\n"
                + "2. Excel 表格以\"学号\"和\"姓名\"作为列名并只保留这两列。\n"
                + "3. 将要检查的所有文件保存在一个单独的文件夹中。\n";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txb_fileName.Text = openFileDialog.FileName;
            }
        }

        private void btn_openCheck_Click(object sender, EventArgs e)
        {
            string defaultfilePath = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (defaultfilePath != "")
            {
                //设置此次默认目录为上一次选中目录  
                folder.SelectedPath = defaultfilePath;
            }
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txb_dir.Text = folder.SelectedPath;
                //记录选中的目录  
                defaultfilePath = folder.SelectedPath;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

        }
    }
}
