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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_fileName = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_dir = new System.Windows.Forms.TextBox();
            this.btn_openCheck = new System.Windows.Forms.Button();
            this.rtxb_output = new System.Windows.Forms.RichTextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "打开班级名单：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 320);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用须知";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // txb_fileName
            // 
            this.txb_fileName.Location = new System.Drawing.Point(29, 88);
            this.txb_fileName.Name = "txb_fileName";
            this.txb_fileName.Size = new System.Drawing.Size(648, 42);
            this.txb_fileName.TabIndex = 1;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(716, 85);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(157, 56);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1573, 1145);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 65);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "打开需要检查的文件夹：";
            // 
            // txb_dir
            // 
            this.txb_dir.Location = new System.Drawing.Point(29, 231);
            this.txb_dir.Name = "txb_dir";
            this.txb_dir.Size = new System.Drawing.Size(648, 42);
            this.txb_dir.TabIndex = 4;
            // 
            // btn_openCheck
            // 
            this.btn_openCheck.Location = new System.Drawing.Point(716, 229);
            this.btn_openCheck.Name = "btn_openCheck";
            this.btn_openCheck.Size = new System.Drawing.Size(157, 56);
            this.btn_openCheck.TabIndex = 5;
            this.btn_openCheck.Text = "打开";
            this.btn_openCheck.UseVisualStyleBackColor = true;
            this.btn_openCheck.Click += new System.EventHandler(this.btn_openCheck_Click);
            // 
            // rtxb_output
            // 
            this.rtxb_output.Location = new System.Drawing.Point(33, 66);
            this.rtxb_output.Name = "rtxb_output";
            this.rtxb_output.Size = new System.Drawing.Size(812, 601);
            this.rtxb_output.TabIndex = 6;
            this.rtxb_output.Text = "";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(1551, 622);
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
            this.label4.Location = new System.Drawing.Point(28, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "未交同学名单：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(15, 1145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "Version V1.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_fileName);
            this.groupBox2.Controls.Add(this.btn_openCheck);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txb_dir);
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(901, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 320);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 361);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1796, 762);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rtxb_output);
            this.tabPage1.Controls.Add(this.btn_check);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1776, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "作业查交";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ok);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1776, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "格式化命名";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(1551, 624);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(189, 65);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 1236);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学委助手";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txb_fileName;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_openCheck;
        private System.Windows.Forms.TextBox txb_dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxb_output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ok;
    }
}