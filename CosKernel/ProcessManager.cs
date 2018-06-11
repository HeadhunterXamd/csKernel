using System;
using System.Collections.Generic;
using System.Text;

namespace CosKernel
{
    public class ProcessManager
    {
        private List<SystemProcess> _jobs;

        private static ProcessManager _instance;

        public ProcessManager()
        {
            _jobs = new List<SystemProcess>();
        }

        public static ProcessManager Instance
        {
            get { return _instance ?? (_instance = new ProcessManager()); }
        }

        public SystemProcess GetProcess(string name)
        {
            return _jobs.Find(x => x.name == name);
        }

        public uint CreateProcess(string name)
        {
            throw new NotImplementedException("The create process function is not implemented yet because I need to implement the runtimes!!!");
        }
    }

    public struct SystemProcess
    {
        public int PID;
        public string name;

    }
}
