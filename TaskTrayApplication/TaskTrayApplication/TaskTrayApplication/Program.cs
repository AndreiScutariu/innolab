using System;
using System.Windows.Forms;

namespace TaskTrayApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var taskTrayApplicationContext = new TaskTrayApplicationContext();
            var socketClient = new SocketClient(taskTrayApplicationContext);
            socketClient.StartListen();
            Application.Run(taskTrayApplicationContext);
        }
    }
}