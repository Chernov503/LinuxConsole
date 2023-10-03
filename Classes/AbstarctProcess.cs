using System.Diagnostics;

namespace WindowsFormsApp1.Classes
{
    abstract class AbstractProcess
    {
        protected Process Process;
        public abstract void Start();
        public string Show()
        {
            return Process.StandardOutput.ReadToEnd();
        }



    }
}
