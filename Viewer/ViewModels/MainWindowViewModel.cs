using System;
using System.Threading;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using GlobalDatasLibrary;
using GlobalDatasLibrary.Datas;

namespace Viewer.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region datas
        private readonly Screen _screen;
        #endregion
        #region properties
        public string AppName
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("jibril");
            }
        }
        public int UsableWidth
        {
            get
            {
                return this._screen.Width;
            }
        }

        public int UsableHeight
        {
            get
            {
                return this._screen.Usable_Height;
            }
        }
        #endregion
        #region constructors
        public MainWindowViewModel()
        {
            this._screen = Current.GetPrimaryScreen();
        }
        #endregion
        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
