using System;
using System.Diagnostics;

namespace WindowsFormsApp1.Classes.User
{
    class GroapGetAccessToFolder : AbstractProcess
    {
        protected string folder { get; set; }
        public string access { get; set; }
        public GroapGetAccessToFolder(string folder, string access)
        {
            this.folder = folder;
            this.access = access;
            Process = new Process();
            GetUserAccessToFolder();
        }
        protected void GetUserAccessToFolder()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"chmod g{access} {folder}";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
        }
        public override void Start()
        {
            Process.Start();
            Process.WaitForExit();
        }
    }
    //TODO: Доделать права доступа
}
