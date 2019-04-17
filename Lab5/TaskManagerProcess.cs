using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TaskManagerProcess
    {
        private string _processName;
        private int _processId;
        private bool _responding;
        private double _cpu;
        private double _memory;
        private int _threadsActive;
        private string _user;
        private string _filePath;
        private DateTime _startTime;

        internal TaskManagerProcess(Process windowsProcess)
        {
            _processName = windowsProcess.ProcessName;
            _processId = windowsProcess.Id;
            _responding = windowsProcess.Responding;
            _cpu = 0;
            _memory = windowsProcess.PrivateMemorySize64 / 1024;
            _threadsActive = windowsProcess.Threads.Count;
            _user = windowsProcess.MachineName;
            _filePath = windowsProcess.MainModule.FileName;
            _startTime = windowsProcess.StartTime;
            _startTime = DateTime.Today;
        }

        public string ProcessName
        {
            get
            {
                return _processName;
            }
            set
            {
                _processName = value;
            }
        }

        public int ProcessId
        {
            get
            {
                return _processId;
            }
            set
            {
                _processId = value;
            }
        }

        public bool Responding
        {
            get
            {
                return _responding;
            }
            set
            {
                _responding = value;
            }
        }

        public double Cpu
        {
            get
            {
                return _cpu;
            }
            set
            {
                _cpu = value;
            }
        }

        public double Memory
        {
            get
            {
                return _memory;
            }
            set
            {
                _memory = value;
            }
        }

        public int ThreadsActive
        {
            get
            {
                return _threadsActive;
            }
            set
            {
                _threadsActive = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        public string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
    }
}
