using System.ComponentModel;
using System.Windows;

namespace Lab5.Tools
{
    internal interface ILoaderOwner :INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsEnabled { get; set; }
    }
}
