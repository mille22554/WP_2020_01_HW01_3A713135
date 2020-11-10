using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_3A713135
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "請輸入姓名:";
            label2.Text = "你的專屬號碼:\r\n";
            button1.Text = "輸入";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToMD5();
            label2.Text = "你的專屬號碼:\r\n"+a;
        }
    }

    public static class MD5Extensions
    {
        public static string ToMD5(this string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] source = Encoding.Default.GetBytes(input);//將字串轉為Byte[]
                byte[] crypto = md5.ComputeHash(source);//進行MD5加密
                string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串

                return result;
            }
        }
    }
}
