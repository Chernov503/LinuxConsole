using System.Diagnostics;

namespace WindowsFormsApp1.Classes.Folder
{
    internal class AllUsers : AbstractProcess
    {
        public AllUsers()
        {
            Process = new Process();
            ProcessStartInfo();
        }
        protected void ProcessStartInfo()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = "cut -d: -f1 /etc/passwd";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
        }
        public override void Start()
        {
            Process.Start();
            Process.WaitForExit();
             
            
        }

    }
}
