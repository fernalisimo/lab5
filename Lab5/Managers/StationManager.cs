using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab5.Managers
{
    public static class StationManager
    {

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}
