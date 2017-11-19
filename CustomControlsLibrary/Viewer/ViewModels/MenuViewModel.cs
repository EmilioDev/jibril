using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalDatasLibrary;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal class MenuViewModel : ViewModel
    {
        #region delegates & events
        public override event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region properties
        public string File
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("file");
            }
        }

        public string Home
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("home");
            }
        }

        public string Comment
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("comment");
            }
        }

        public string View
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("view");
            }
        }

        public string Form
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("form");
            }
        }

        public string Protect
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("protect");
            }
        }

        public string Share
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("share");
            }
        }

        public string Help
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("help");
            }
        }
        #endregion
        #region functions
        protected override void RaiseProperty(string name)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
