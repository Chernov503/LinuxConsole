using System.Diagnostics;

namespace WindowsFormsApp1.Classes.User.Group
{
    internal class DeleteUserFromGroup : AbstracUserToGroup
    {
        public DeleteUserFromGroup(string username, string groupname)
        {
            base.groupname = groupname;
            base.username = username;
            Process = new Process();
            ProcessUserToGroup();
        }
        protected override void ProcessUserToGroup()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"gpasswd -d {username} {groupname}";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
        }
    }
}



