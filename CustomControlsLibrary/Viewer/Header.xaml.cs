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
using CustomControlsLibrary.Viewer.ViewModels;

namespace CustomControlsLibrary.Viewer
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        private HeaderViewModel _vm;
        public Header()
        {
            InitializeComponent();
            this._vm = new HeaderViewModel();
            this.DataContext = this._vm;
        }

        #region delegates & events
        public delegate void MinimizeWindowDelegate(object sender);
        public delegate void MaximizeWindowDelegate(object sender);

        #endregion

        private void buttonMinimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMaximize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
