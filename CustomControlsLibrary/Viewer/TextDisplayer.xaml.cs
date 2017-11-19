using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DocumentLector.Formats;

namespace CustomControlsLibrary.Viewer
{
    /// <summary>
    /// Interaction logic for TextDisplayer.xaml
    /// </summary>
    public partial class TextDisplayer : UserControl
    {
        public TextDisplayer()
        {
            InitializeComponent();
        }

        public void SetContent(DocumentLector.Formats.Page page)
        {
            //this._text.Inlines.Clear();
            if (page != null)
            {
                //this._text.Inlines.AddRange(page.Lines);
            }
        }
    }
}
