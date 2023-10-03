using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Classes.User
{
    internal class UserSetPassword : AbstractProcess
    {
        private string password { get; set; }
        private string username { get; set; }
        public UserSetPassword(string password, string username)
        {
            this.password = password;
            this.username = username; ;
            Process = new Process();
            SetUserPasswordProcess();
        }
        private void SetUserPasswordProcess()
        {
            Process.StartInfo.FileName = "sudo";
            Process.StartInfo.Arguments = $"passwd {username}";

            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.UseShellExecute = false;
        }
        public override void Start()
        {
            Process.Start();
            // Вводим пароль для sudo
            Process.StandardInput.WriteLine(password);
            Process.StandardInput.Flush();
            Process.StandardInput.WriteLine(password);
            Process.StandardInput.Flush();
            Process.StandardInput.Close();
            // Дожидаемся завершения выполнения команды
            Process.WaitForExit();

        }
    }
}
