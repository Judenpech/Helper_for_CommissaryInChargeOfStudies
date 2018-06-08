using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CICOS_Helper
{
    public partial class frm_main : Form
    {
        int f1 = 0, f2 = 0;
        public frm_main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            txb_fileName.Enabled = false;
            txb_dir.Enabled = false;
            btn_check.Enabled = false;
            btn_ok.Enabled = false;
            btn_selectall.Enabled = false;
            btn_addOk.Enabled = false;
            rbtn_default.Select();
            rbtn_front.Select();
            label2.Text = "1. 班级名单请以 Excel 表格形式存储。\n\n"
                + "2. Excel 表格以\"学号\"和\"姓名\"作为列名并只保留这两列。\n\n"
                + "3. 将要检查的所有文件保存在一个单独的文件夹中。\n\n"
                + "4. 要检查的文件夹名不能带有美元符号($)。\n\n"
                + "5. 请在所有操作之前备份文件，以免因操作不当造成文件损坏。\n\n"
                + "6. 如果有任何疑问，请点击下方\"报告问题/建议\"。";
            label6.Text = "操作结果：\n";
            label7.Text = "操作结果：\n";
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
            openFileDialog.Title = "请选择导入班级名单Excel文件";
            //openFileDialog.Filter = "Excel 97-2003 工作簿|*.xls|Excel 工作簿|*.xlsx";
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
            string input = "1" + "$" + txb_fileName.Text.Trim() + "$" + txb_dir.Text.Trim();
            //Console.WriteLine(input);
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = System.Environment.CurrentDirectory + "//pyHelper.exe";
                p.StartInfo.CreateNoWindow = true;         // 不创建新窗口   
                p.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
                p.StartInfo.RedirectStandardInput = true;  // 重定向输入    
                p.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
                p.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                p.Start();
                p.StandardInput.WriteLine(input);
                rtxb_output.Text = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
            }
        }

        private void txb_fileName_TextChanged(object sender, EventArgs e)
        {
            if (txb_fileName.Text != "")
            {
                f1 = 1;
            }
            else
            {
                f1 = 0;
            }
            if (f1 == 1 && f2 == 1)
            {
                btn_check.Enabled = true;
                btn_ok.Enabled = true;
                btn_addOk.Enabled = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string input = "";
            if (rbtn_sep.Checked)
            {
                if (txb_sep.Text == "" || txb_sep.Text == "$")
                {
                    MessageBox.Show("指定分隔符不能为空或“$”！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_sep.Focus();
                }
                else
                {
                    input = "2$1$" + txb_fileName.Text.Trim() + "$" + txb_dir.Text.Trim() + "$" + txb_sep.Text.Trim();
                }
            }
            else
            {
                input = "2$2$" + txb_fileName.Text.Trim() + "$" + txb_dir.Text.Trim();
            }
            //Console.WriteLine(input);
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = System.Environment.CurrentDirectory + "//pyHelper.exe";
                p.StartInfo.CreateNoWindow = true;         // 不创建新窗口   
                p.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
                p.StartInfo.RedirectStandardInput = true;  // 重定向输入    
                p.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
                p.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                p.Start();
                p.StandardInput.WriteLine(input);
                string output = p.StandardOutput.ReadToEnd();
                rtxb_resFd.Text += output;
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
            }
        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            rtxb_output.Focus();
            rtxb_output.SelectAll();
            System.Windows.Forms.Clipboard.SetText(rtxb_output.Text);
            MessageBox.Show("内容已复制至剪贴板！");
        }

        private void rtxb_output_TextChanged(object sender, EventArgs e)
        {
            if (rtxb_output.Text == "")
            {
                btn_selectall.Enabled = false;
            }
            else
            {
                btn_selectall.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies");
        }

        private void btn_addOk_Click(object sender, EventArgs e)
        {
            string input = "";
            if (rbtn_front.Checked)
            {
                if (txb_front.Text == "")
                {
                    MessageBox.Show("扩展内容不能为空，请输入扩展内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_front.Focus();
                }
                else
                {
                    input = "3$1$" + txb_dir.Text.Trim() + "$" + txb_front.Text.Trim();
                }
            }
            if (rbtn_back.Checked)
            {
                if (txb_back.Text == "")
                {
                    MessageBox.Show("扩展内容不能为空，请输入扩展内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_back.Focus();
                }
                else
                {
                    input = "3$2$" + txb_dir.Text.Trim() + "$" + txb_back.Text.Trim();
                }
            }
            Console.WriteLine(input);
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = System.Environment.CurrentDirectory + "//pyHelper.exe";
                p.StartInfo.CreateNoWindow = true;         // 不创建新窗口   
                p.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
                p.StartInfo.RedirectStandardInput = true;  // 重定向输入    
                p.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
                p.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                p.Start();
                p.StandardInput.WriteLine(input);
                string output = p.StandardOutput.ReadToEnd();
                rtxb_resEx.Text += output;
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtxb_output.Text = "";
        }

        private void txb_dir_TextChanged(object sender, EventArgs e)
        {
            if (txb_dir.Text != "")
            {
                f2 = 1;
                btn_addOk.Enabled = true;
            }
            else
            {
                f2 = 0;
                btn_addOk.Enabled = false;
            }
            if (f1 == 1 && f2 == 1)
            {
                btn_check.Enabled = true;
                btn_ok.Enabled = true;
            }
        }
    }
}
