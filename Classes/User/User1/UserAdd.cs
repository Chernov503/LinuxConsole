using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.User
{
    internal class UserAdd : AbstractProcess
    {
        public string username { get; set; }

        public UserAdd(string username)
        {
            this.username = username;
            Process = new Process();
            CreateUserProcessSet();
        }

        private void CreateUserProcessSet()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"useradd {username}";

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

