using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalDatasLibrary;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal class HeaderViewModel : ViewModel
    {
        #region properties
        public string GetAppName
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("jibril");
            }
        }

        public string IconSource
        {
            get
            {
                return @"/CustomControlsLibrary;component/Resources/Jibril.png";
            }
        }
        #endregion
        #region delegates & events
        public override event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region functions
        private string GetNameInCurrentLanguaje()
        {
            return "Jibril";
        }

        protected override void RaiseProperty(string name)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
