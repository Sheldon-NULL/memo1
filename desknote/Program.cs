using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace desknote
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //获取当前进程
            Process current = Process.GetCurrentProcess();
            //获取所有与当前进程名称相同的进程
            Process[] processArr = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processArr)
            {
                //和当前进程路径相同但ID不同
                if (process.MainModule.FileName == current.MainModule.FileName && process.Id != current.Id)
                {
                    //显示已打开的程序窗口，可搜索ShowWindowAsync的更多参数
                    ShowWindowAsync(process.MainWindowHandle, 1);
                    //将窗口放置最前端
                    SetForegroundWindow(process.MainWindowHandle);
                    //退出当前程序/进程
                    return;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
