using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Classes.User
{
    internal class UserDelete : AbstractProcess
    {
        public string username{ get; set; }
        public UserDelete(string UserN)
        {
            username = UserN;
            Process = new Process();
            DeleteUserProcess();
        }

        protected void DeleteUserProcess()
        {
            Process.StartInfo.FileName = "sudo"; // Путь к команде useradd
            Process.StartInfo.Arguments = $"userdel -r {username}"; // Аргументы команды для создания пользователя и домашней директории
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.RedirectStandardError = true;
        }
        public override void Start()
        {
            Process.Start();
            Process.WaitForExit();
        }
    }
}
