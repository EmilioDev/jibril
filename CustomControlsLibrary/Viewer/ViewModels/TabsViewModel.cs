using GlobalDatasLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal class TabsViewModel : ViewModel
    {
        #region properties
        public string Start
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("start");
            }
        }

        public string Msg_Delete_Page
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("remove_tab");
            }
        }

        public string Msg_Error_removing_Config
        {
            get
            {
                return Current.GetPhraseInCurrentLanguaje("config_removing_error");
            }
        }
        #endregion
        #region delegates & events
        public override event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region functions
        protected override void RaiseProperty(string name)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
