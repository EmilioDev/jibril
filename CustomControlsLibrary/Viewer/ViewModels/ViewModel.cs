using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        #region datas
        protected List<string> prop_names;
        #endregion
        #region delegates & events
        public abstract event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region constructors
        public ViewModel()
        {
            this.prop_names = new List<string>();
        }
        #endregion
        #region functions
        protected abstract void RaiseProperty(string name);
        protected virtual void RaiseAllProperties()
        {
            foreach(var name in this.prop_names)
            {
                this.RaiseProperty(name);
            }
        }

        protected void SetProperties(string[] prop_names)
        {
            this.prop_names.AddRange(prop_names);
        }


        #endregion
    }
}
