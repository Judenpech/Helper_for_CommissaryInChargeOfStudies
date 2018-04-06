namespace CICOS_Helper
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.rtxb_output = new System.Windows.Forms.RichTextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rbtn_default = new System.Windows.Forms.RadioButton();
            this.rbtn_sep = new System.Windows.Forms.RadioButton();
            this.rbtn_front = new System.Windows.Forms.RadioButton();
            this.txb_sep = new System.Windows.Forms.TextBox();
            this.txb_front = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txb_back = new System.Windows.Forms.TextBox();
            this.rbtn_back = new System.Windows.Forms.RadioButton();
            this.btn_addOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxb_resFd = new System.Windows.Forms.RichTextBox();
            this.rtxb_resEx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.txb_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openCheck = new System.Windows.Forms.Button();
            this.txb_fileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(21, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 748);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用须知";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(684, 658);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 65);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // rtxb_output
            // 
            this.rtxb_output.Location = new System.Drawing.Point(32, 99);
            this.rtxb_output.Name = "rtxb_output";
            this.rtxb_output.Size = new System.Drawing.Size(544, 929);
            this.rtxb_output.TabIndex = 6;
            this.rtxb_output.Text = "";
            this.rtxb_output.TextChanged += new System.EventHandler(this.rtxb_output_TextChanged);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(683, 963);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(189, 65);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "检查";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "未交同学名单：";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(631, 213);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(189, 65);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "重命名";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_selectall
            // 
            this.btn_selectall.Location = new System.Drawing.Point(683, 854);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(189, 65);
            this.btn_selectall.TabIndex = 9;
            this.btn_selectall.Text = "复制";
            this.btn_selectall.UseVisualStyleBackColor = true;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(39, 675);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 30);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "报告问题/建议";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rbtn_default
            // 
            this.rbtn_default.AutoSize = true;
            this.rbtn_default.Checked = true;
            this.rbtn_default.Location = new System.Drawing.Point(28, 72);
            this.rbtn_default.Name = "rbtn_default";
            this.rbtn_default.Size = new System.Drawing.Size(590, 34);
            this.rbtn_default.TabIndex = 0;
            this.rbtn_default.TabStop = true;
            this.rbtn_default.Text = "学号 姓名（默认）例：3150707001 张三";
            this.rbtn_default.UseVisualStyleBackColor = true;
            // 
            // rbtn_sep
            // 
            this.rbtn_sep.AutoSize = true;
            this.rbtn_sep.Location = new System.Drawing.Point(28, 141);
            this.rbtn_sep.Name = "rbtn_sep";
            this.rbtn_sep.Size = new System.Drawing.Size(380, 34);
            this.rbtn_sep.TabIndex = 1;
            this.rbtn_sep.Text = "指定学号姓名间分隔符：";
            this.rbtn_sep.UseVisualStyleBackColor = true;
            // 
            // rbtn_front
            // 
            this.rbtn_front.AutoSize = true;
            this.rbtn_front.Checked = true;
            this.rbtn_front.Location = new System.Drawing.Point(30, 67);
            this.rbtn_front.Name = "rbtn_front";
            this.rbtn_front.Size = new System.Drawing.Size(260, 34);
            this.rbtn_front.TabIndex = 2;
            this.rbtn_front.TabStop = true;
            this.rbtn_front.Text = "文件名前添加：";
            this.rbtn_front.UseVisualStyleBackColor = true;
            // 
            // txb_sep
            // 
            this.txb_sep.Location = new System.Drawing.Point(419, 133);
            this.txb_sep.Name = "txb_sep";
            this.txb_sep.Size = new System.Drawing.Size(72, 42);
            this.txb_sep.TabIndex = 3;
            // 
            // txb_front
            // 
            this.txb_front.Location = new System.Drawing.Point(279, 59);
            this.txb_front.Name = "txb_front";
            this.txb_front.Size = new System.Drawing.Size(521, 42);
            this.txb_front.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(507, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = " 例：3150707012+张三";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rtxb_resEx);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.btn_addOk);
            this.groupBox6.Controls.Add(this.txb_back);
            this.groupBox6.Controls.Add(this.rbtn_back);
            this.groupBox6.Controls.Add(this.txb_front);
            this.groupBox6.Controls.Add(this.rbtn_front);
            this.groupBox6.Location = new System.Drawing.Point(33, 526);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(844, 520);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "扩展命名";
            // 
            // txb_back
            // 
            this.txb_back.Location = new System.Drawing.Point(279, 147);
            this.txb_back.Name = "txb_back";
            this.txb_back.Size = new System.Drawing.Size(521, 42);
            this.txb_back.TabIndex = 9;
            // 
            // rbtn_back
            // 
            this.rbtn_back.AutoSize = true;
            this.rbtn_back.Location = new System.Drawing.Point(30, 155);
            this.rbtn_back.Name = "rbtn_back";
            this.rbtn_back.Size = new System.Drawing.Size(260, 34);
            this.rbtn_back.TabIndex = 8;
            this.rbtn_back.Text = "文件名后添加：";
            this.rbtn_back.UseVisualStyleBackColor = true;
            // 
            // btn_addOk
            // 
            this.btn_addOk.Location = new System.Drawing.Point(631, 250);
            this.btn_addOk.Name = "btn_addOk";
            this.btn_addOk.Size = new System.Drawing.Size(189, 65);
            this.btn_addOk.TabIndex = 10;
            this.btn_addOk.Text = "扩展";
            this.btn_addOk.UseVisualStyleBackColor = true;
            this.btn_addOk.Click += new System.EventHandler(this.btn_addOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(955, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 1128);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_selectall);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rtxb_output);
            this.tabPage1.Controls.Add(this.btn_check);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(912, 1061);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "作业查交";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(912, 1070);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "格式化命名";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(23, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxb_resFd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rbtn_default);
            this.groupBox3.Controls.Add(this.btn_ok);
            this.groupBox3.Controls.Add(this.rbtn_sep);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txb_sep);
            this.groupBox3.Location = new System.Drawing.Point(33, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 476);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基础命名";
            // 
            // rtxb_resFd
            // 
            this.rtxb_resFd.Location = new System.Drawing.Point(28, 296);
            this.rtxb_resFd.Name = "rtxb_resFd";
            this.rtxb_resFd.Size = new System.Drawing.Size(772, 152);
            this.rtxb_resFd.TabIndex = 8;
            this.rtxb_resFd.Text = "";
            // 
            // rtxb_resEx
            // 
            this.rtxb_resEx.Location = new System.Drawing.Point(30, 335);
            this.rtxb_resEx.Name = "rtxb_resEx";
            this.rtxb_resEx.Size = new System.Drawing.Size(770, 156);
            this.rtxb_resEx.TabIndex = 13;
            this.rtxb_resEx.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "打开需要检查的文件夹：";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(716, 117);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(157, 56);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txb_dir
            // 
            this.txb_dir.Location = new System.Drawing.Point(29, 244);
            this.txb_dir.Name = "txb_dir";
            this.txb_dir.Size = new System.Drawing.Size(648, 42);
            this.txb_dir.TabIndex = 4;
            this.txb_dir.TextChanged += new System.EventHandler(this.txb_dir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "打开班级名单：";
            // 
            // btn_openCheck
            // 
            this.btn_openCheck.Location = new System.Drawing.Point(716, 244);
            this.btn_openCheck.Name = "btn_openCheck";
            this.btn_openCheck.Size = new System.Drawing.Size(157, 56);
            this.btn_openCheck.TabIndex = 5;
            this.btn_openCheck.Text = "打开";
            this.btn_openCheck.UseVisualStyleBackColor = true;
            this.btn_openCheck.Click += new System.EventHandler(this.btn_openCheck_Click);
            // 
            // txb_fileName
            // 
            this.txb_fileName.Location = new System.Drawing.Point(29, 117);
            this.txb_fileName.Name = "txb_fileName";
            this.txb_fileName.Size = new System.Drawing.Size(648, 42);
            this.txb_fileName.TabIndex = 1;
            this.txb_fileName.TextChanged += new System.EventHandler(this.txb_fileName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_fileName);
            this.groupBox2.Controls.Add(this.btn_openCheck);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txb_dir);
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 352);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1181);
            this.panel1.TabIndex = 12;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(1940, 1253);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学委助手                                      ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RichTextBox rtxb_output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_selectall;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_sep;
        private System.Windows.Forms.RadioButton rbtn_sep;
        private System.Windows.Forms.RadioButton rbtn_default;
        private System.Windows.Forms.RadioButton rbtn_front;
        private System.Windows.Forms.TextBox txb_front;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_addOk;
        private System.Windows.Forms.TextBox txb_back;
        private System.Windows.Forms.RadioButton rbtn_back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxb_resEx;
        private System.Windows.Forms.RichTextBox rtxb_resFd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txb_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openCheck;
        private System.Windows.Forms.TextBox txb_fileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}