using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCsharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Form1());
            Form1 form1= new Form1();

            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK) {
                form1.Dispose();
                Application.Run(new Form2());
            }
        }
    }
}
