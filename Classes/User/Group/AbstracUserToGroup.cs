using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.User
{
    abstract class AbstracUserToGroup : AbstractProcess
    {
        protected string groupname { get; set; }
        public string username { get; set; }
        protected abstract void ProcessUserToGroup();

        public override void Start()
        {
            Process.Start();
            Process.WaitForExit();
        }

    }
}
