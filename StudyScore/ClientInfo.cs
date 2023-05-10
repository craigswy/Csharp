using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        void btnSayHello_Click(object sender, EventArgs e)
        {
            String CnName = txtChiName.Text;
            String EngName = txtEngName.Text;
            String Gender = comGender.Text;
            String Star = comStar.Text;
            MessageBox.Show("你的中文姓名是" + CnName
                + Environment.NewLine + "你的英文姓名是" + EngName
                + Environment.NewLine + "你的性別是" + Gender
                + Environment.NewLine + "你的星座是" + Star
                + Environment.NewLine + "你好啊!");
            //Console.ReadKey();
        }

        void btnSayHi_Click(object sender, EventArgs e)
        {
            String CnName = txtChiName.Text;
            String EngName = txtEngName.Text;
            String Gender = comGender.Text;
            String Star = comStar.Text;
            MessageBox.Show("你的中文姓名是" + CnName
                + Environment.NewLine + "你的英文姓名是" + EngName
                + Environment.NewLine + "你的性別是" + Gender
                + Environment.NewLine + "你的星座是" + Star
                + Environment.NewLine + "你今天過得還好嗎?");
        }
    }
}
