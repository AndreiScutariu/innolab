using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotifyForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SetBalloonTip();
        }
        private void SetBalloonTip()
        {
            var item = new NotifyIcon(components)
            {
                Visible = true,
                Icon = SystemIcons.Information
            };

            item.ShowBalloonTip(3000, "Balloon title", "Balloon text", ToolTipIcon.Info);
        }
    }
}
