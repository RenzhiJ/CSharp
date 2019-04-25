using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//确定
            if (textBox3.Text == "abc" && textBox4.Text == "123")
            {
                MessageBox.Show("登录成功", "提示");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            else if (textBox3.Text == "" || textBox4.Text == "") {//判断用户名或密码是否为空
                EroDialog("用户名或密码不能为空");
            }
            else
            {//输入其他用户名或密码不正确提示  因为指定用户名密码可以登录
                EroDialog("用户名或密码不正确");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }




        private void EroDialog(string a) //建立一个函数用来显示错误信息
        {
            DialogResult er = MessageBox.Show(a + "\r\n点击[是]重新输入，点击[否]退出程序，点击[取消]不修改", "错误",
                                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (er == DialogResult.Yes)
            { //对于密码和账号是否从新输入
                label1.Text = "";
                label2.Text = "";
            }
            else if (er == DialogResult.No)
            {

            DialogResult sss= MessageBox.Show("确定退出程序？","提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sss == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                    return;
            } 
          }

      
    }
 }



