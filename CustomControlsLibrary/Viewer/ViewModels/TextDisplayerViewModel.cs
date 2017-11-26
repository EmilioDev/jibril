using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using DocumentLector;
using DocumentLector.Formats;
using System.Windows.Documents;

namespace CustomControlsLibrary.Viewer.ViewModels
{
    internal class TextDisplayerViewModel : ViewModel
    {
        #region datas
        private int _w;
        private int _h;
        #endregion
        #region properies
        public ObservableCollection<Inline> Lines { get; set; }
        public int Width
        {
            get
            {
                return this._w;
            }
            set
            {
                this._w = value;
                var pc = this.PropertyChanged;
                if (pc != null)
                    pc(this, new PropertyChangedEventArgs("Width"));
            }
        }

        public int Height
        {
            get
            {
                return this._h;
            }
            set
            {
                this._h = value;
                var pc = this.PropertyChanged;
                if (pc != null)
                    pc(this, new PropertyChangedEventArgs("Height"));
            }
        }

        public Rectangle PageDimensions
        {
            get
            {
                Rectangle r = new Rectangle();
                r.Width = this._w;
                r.Height = this._h;
                return r;
            }
            set
            {
                this.Height = Convert.ToInt32(value.Height);
                this.Width = Convert.ToInt32(value.Width);
            }
        }
        #endregion
        #region events
        public override event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region constructors
        public TextDisplayerViewModel()
        {
            this.Lines = new ObservableCollection<Inline>();
            this._h = 300;
            this._w = 300;
        }
        #endregion
        #region functions
        public void SetPage(Page page)
        {
            this.PageDimensions = page.PageDimensions;
            ObservableCollection<Inline> l = new ObservableCollection<Inline>(page.Lines);
            this.Lines = l;
        }

        protected override void RaiseProperty(string name)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
