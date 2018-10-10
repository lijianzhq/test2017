using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestThread
{
    class TestProcess
    {
        public static void Start()
        {
            StartProccess(ProcessPriorityClass.BelowNormal);
            StartProccess(ProcessPriorityClass.RealTime);
        }

        public static void StartProccess(ProcessPriorityClass priority)
        {
            Process p = new Process();
            p.StartInfo.FileName = "TestProcess.exe";
            p.Start();
            p.PriorityClass = priority;
        }
    }
}
