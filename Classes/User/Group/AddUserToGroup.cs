using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.User.Group
{
    internal class AddUserToGroup : AbstracUserToGroup
    {
        public AddUserToGroup(string username, string groupname)
        {
            base.groupname = groupname;
            base.username = username;
            Process = new Process();
            ProcessUserToGroup();
        }
        protected override void ProcessUserToGroup()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"usermod -a -G {groupname} {username}";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
        }
    }
}

