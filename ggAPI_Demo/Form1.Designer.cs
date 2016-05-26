namespace ggAPI_Demo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBindUser = new System.Windows.Forms.Button();
            this.txtGGGuid = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContentpt = new System.Windows.Forms.TextBox();
            this.txtGGGuidpt = new System.Windows.Forms.TextBox();
            this.txtUserIdpt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintpt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtImgFile = new System.Windows.Forms.TextBox();
            this.btnSelectP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGGGuidpp = new System.Windows.Forms.TextBox();
            this.txtUserIdpp = new System.Windows.Forms.TextBox();
            this.btnPrintpp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBindUser);
            this.groupBox1.Controls.Add(this.txtGGGuid);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绑定用户";
            // 
            // btnBindUser
            // 
            this.btnBindUser.Location = new System.Drawing.Point(137, 81);
            this.btnBindUser.Name = "btnBindUser";
            this.btnBindUser.Size = new System.Drawing.Size(75, 23);
            this.btnBindUser.TabIndex = 4;
            this.btnBindUser.Text = "确认绑定";
            this.btnBindUser.UseVisualStyleBackColor = true;
            this.btnBindUser.Click += new System.EventHandler(this.btnBindUser_Click);
            // 
            // txtGGGuid
            // 
            this.txtGGGuid.Location = new System.Drawing.Point(89, 54);
            this.txtGGGuid.Name = "txtGGGuid";
            this.txtGGGuid.Size = new System.Drawing.Size(123, 21);
            this.txtGGGuid.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(89, 26);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(123, 21);
            this.txtUserId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "设备ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContentpt);
            this.groupBox2.Controls.Add(this.txtGGGuidpt);
            this.groupBox2.Controls.Add(this.txtUserIdpt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPrintpt);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打印文本";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "文本内容";
            // 
            // txtContentpt
            // 
            this.txtContentpt.Location = new System.Drawing.Point(89, 89);
            this.txtContentpt.Multiline = true;
            this.txtContentpt.Name = "txtContentpt";
            this.txtContentpt.Size = new System.Drawing.Size(123, 69);
            this.txtContentpt.TabIndex = 5;
            // 
            // txtGGGuidpt
            // 
            this.txtGGGuidpt.Location = new System.Drawing.Point(89, 62);
            this.txtGGGuidpt.Name = "txtGGGuidpt";
            this.txtGGGuidpt.Size = new System.Drawing.Size(123, 21);
            this.txtGGGuidpt.TabIndex = 4;
            // 
            // txtUserIdpt
            // 
            this.txtUserIdpt.Location = new System.Drawing.Point(89, 34);
            this.txtUserIdpt.Name = "txtUserIdpt";
            this.txtUserIdpt.Size = new System.Drawing.Size(123, 21);
            this.txtUserIdpt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "设备ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "用户ID";
            // 
            // btnPrintpt
            // 
            this.btnPrintpt.Location = new System.Drawing.Point(137, 164);
            this.btnPrintpt.Name = "btnPrintpt";
            this.btnPrintpt.Size = new System.Drawing.Size(75, 23);
            this.btnPrintpt.TabIndex = 0;
            this.btnPrintpt.Text = "打印";
            this.btnPrintpt.UseVisualStyleBackColor = true;
            this.btnPrintpt.Click += new System.EventHandler(this.btnPrintpt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtImgFile);
            this.groupBox3.Controls.Add(this.btnSelectP);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtGGGuidpp);
            this.groupBox3.Controls.Add(this.txtUserIdpp);
            this.groupBox3.Controls.Add(this.btnPrintpp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 182);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "打印图片";
            // 
            // txtImgFile
            // 
            this.txtImgFile.Location = new System.Drawing.Point(89, 97);
            this.txtImgFile.Name = "txtImgFile";
            this.txtImgFile.Size = new System.Drawing.Size(123, 21);
            this.txtImgFile.TabIndex = 14;
            // 
            // btnSelectP
            // 
            this.btnSelectP.Location = new System.Drawing.Point(209, 96);
            this.btnSelectP.Name = "btnSelectP";
            this.btnSelectP.Size = new System.Drawing.Size(37, 23);
            this.btnSelectP.TabIndex = 13;
            this.btnSelectP.Text = "选择图片";
            this.btnSelectP.UseVisualStyleBackColor = true;
            this.btnSelectP.Click += new System.EventHandler(this.btnSelectP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "选择图片";
            // 
            // txtGGGuidpp
            // 
            this.txtGGGuidpp.Location = new System.Drawing.Point(89, 64);
            this.txtGGGuidpp.Name = "txtGGGuidpp";
            this.txtGGGuidpp.Size = new System.Drawing.Size(123, 21);
            this.txtGGGuidpp.TabIndex = 11;
            // 
            // txtUserIdpp
            // 
            this.txtUserIdpp.Location = new System.Drawing.Point(89, 32);
            this.txtUserIdpp.Name = "txtUserIdpp";
            this.txtUserIdpp.Size = new System.Drawing.Size(123, 21);
            this.txtUserIdpp.TabIndex = 10;
            // 
            // btnPrintpp
            // 
            this.btnPrintpp.Location = new System.Drawing.Point(89, 134);
            this.btnPrintpp.Name = "btnPrintpp";
            this.btnPrintpp.Size = new System.Drawing.Size(123, 23);
            this.btnPrintpp.TabIndex = 9;
            this.btnPrintpp.Text = "打印单色点位图";
            this.btnPrintpp.UseVisualStyleBackColor = true;
            this.btnPrintpp.Click += new System.EventHandler(this.btnPrintpp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "设备ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "用户ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBindUser;
        private System.Windows.Forms.TextBox txtGGGuid;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContentpt;
        private System.Windows.Forms.TextBox txtGGGuidpt;
        private System.Windows.Forms.TextBox txtUserIdpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGGGuidpp;
        private System.Windows.Forms.TextBox txtUserIdpp;
        private System.Windows.Forms.Button btnPrintpp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectP;
        private System.Windows.Forms.TextBox txtImgFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

