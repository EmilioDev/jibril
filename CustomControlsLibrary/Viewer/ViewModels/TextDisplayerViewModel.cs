using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal class TextDisplayerViewModel : ViewModel
    {
        #region datas
        #endregion
        #region events
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
