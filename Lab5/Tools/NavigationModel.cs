using System;

namespace Lab5.Tools
{
    internal enum ModesEnum
    {
        Main,
        PersonData
    }

    internal class NavigationModel
    {
        private readonly IContentWindow _contentWindow;
        private TaskManagerView _taskManagerWindow;

        internal NavigationModel(IContentWindow contentWindow)
        {
            _contentWindow = contentWindow;
        }

        internal void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Main:
                    _contentWindow.ContentControl.Content = _taskManagerWindow ?? (_taskManagerWindow = new TaskManagerView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

    }
}
