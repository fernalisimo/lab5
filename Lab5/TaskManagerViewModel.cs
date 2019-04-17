using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TaskManagerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TaskManagerProcess> _processes;

        public ObservableCollection<TaskManagerProcess> Processes
        {
            get
            {
                return _processes;
            }
            private set
            {
                _processes = value;
                OnPropertyChanged();
            }
        }

        public TaskManagerViewModel()
        {
            _processes = new ObservableCollection<TaskManagerProcess>();
            foreach (var process in Process.GetProcesses())
            {
                _processes.Add(new TaskManagerProcess(process));
            }


            _tokenSource = new CancellationTokenSource();
            _token = _tokenSource.Token;
            StartWorkingThread();
            StationManager.StopThreads += StopWorkingThread;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
