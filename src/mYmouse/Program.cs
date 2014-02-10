using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mYmouse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            int flag = GetSystemMetrics(23);//获取当前鼠标设置状态 
            if (flag == 0)//右手习惯 
            {
                SwapMouseButton(true);//设置成左手 
            }
            else//左手习惯 
            {
                SwapMouseButton(false);//设置成右手 
            }
        }

        [DllImport("user32.dll")]
        private extern static bool SwapMouseButton(bool fSwap);
        //博客地址：http：//blog.csdn.net/bluceyoung 

        [DllImport("user32.dll")]
        private extern static int GetSystemMetrics(int index);

  

    }
}
