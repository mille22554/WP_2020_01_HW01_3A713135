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
            label2.Text = "";
            button1.Text = "輸入";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToMD5();
            label2.Text = a;
        }
    }

    public static class MD5Extensions
    {
        public static string ToMD5(this string str)
        {
            using (var cryptoMD5 = System.Security.Cryptography.MD5.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(str);
                var hash = cryptoMD5.ComputeHash(bytes);
                var md5 = BitConverter.ToString(hash)
                  .Replace("-", String.Empty)
                  .ToUpper();

                return md5;
            }
        }
    }
}
