using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Classes
{
    internal class UserInternetOn : AbstractProcess
    {
        public string username { get; set; }
        public UserInternetOn(string username)
        {
            this.username = username;
            Process = new Process();
            GetUserInternetValue();
        }
        protected void GetUserInternetValue()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"iptables -D OUTPUT -p all -m owner --uid-owner {username} -j DROP";

            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.UseShellExecute = false;
        }
        public override void Start()
        {
            Process.Start();
            Process.WaitForExit();
        }
    }
}
