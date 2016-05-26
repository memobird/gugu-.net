using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ggAPI_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绑定用户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBindUser_Click(object sender, EventArgs e)
        {
            string result = ggApiHelper.UserBind(txtGGGuid.Text, txtUserId.Text);
            var jObject = JObject.Parse(result);
            string state = jObject["showapi_res_code"].ToString();
            if (state == "1")
                MessageBox.Show("绑定成功");
            else
                MessageBox.Show("绑定失败");
        }
        /// <summary>
        /// 打印文本事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintpt_Click(object sender, EventArgs e)
        {
            string result = ggApiHelper.PrintPaper(txtGGGuidpt.Text, txtUserIdpt.Text, "T:" + Common.Base64Helper.ConvertToBase64(txtContentpt.Text));
        }

        private void btnSelectP_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtImgFile.Text = openFileDialog1.FileName;
        }
        /// <summary>
        /// 打印图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintpp_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtImgFile.Text);
            string baserimg = Common.ImageHelper.GetPoitImgBase64(img);

            string result = ggApiHelper.PrintPaper(txtGGGuidpp.Text, txtUserIdpp.Text, "P:" + baserimg);
        }

    }
}
