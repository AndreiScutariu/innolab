using System;
using System.Windows.Forms;

namespace TaskTrayApplication
{
    public class TaskTrayApplicationContext : ApplicationContext
    {
        readonly NotifyIcon _notifyIcon = new NotifyIcon();

        public TaskTrayApplicationContext()
        {
            var exitMenuItem = new MenuItem("Exit", Exit);

            _notifyIcon.Icon = Properties.Resources.AppIcon;
            _notifyIcon.ContextMenu = new ContextMenu(new[] {  exitMenuItem });
            _notifyIcon.Visible = true;

            _notifyIcon.DoubleClick += WhenDoubleClick;
        }

        private void WhenDoubleClick(object sender, EventArgs e)
        {
            _notifyIcon.ShowBalloonTip(3000, "Balloon title", "Balloon text", ToolTipIcon.Info);
        }

        public void ShowMessage(string message)
        {
            _notifyIcon.ShowBalloonTip(5000, "Balloon title", message, ToolTipIcon.Info);
        }
        
        void Exit(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
