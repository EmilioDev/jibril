using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDatasLibrary.Datas
{
    public class Screen
    {
        #region datas
        private int _width;
        private int _height;
        private string _name;

        private int _usable_width;
        private int _usable_height;
        private int _bpp;

        private bool _primary;
        #endregion

        #region properties
        /// <summary>
        /// True if this is the primary screen, false if not
        /// </summary>
        public bool Is_Primary
        {
            get
            {
                return this._primary;
            }
        }

        /// <summary>
        /// Gtes the name of the device
        /// </summary>
        public string ScreenName
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Gets the number of bits of memory asosciated with 1 pixel of data
        /// </summary>
        public int Bits_Per_Pixel
        {
            get
            {
                return this._bpp;
            }
        }

        /// <summary>
        /// Screen Width
        /// </summary>
        public int Width
        {
            get
            {
                return this._width;
            }
        }

        /// <summary>
        /// Screen Height
        /// </summary>
        public int Height
        {
            get
            {
                return this._height;
            }
        }

        /// <summary>
        /// Usable Screen Width
        /// </summary>
        public int Usable_Width
        {
            get
            {
                return this._usable_width;
            }
        }

        /// <summary>
        /// Usable Screen Height
        /// </summary>
        public int Usable_Height
        {
            get
            {
                return this._usable_height;
            }
        }
        #endregion

        #region constructors
        /// <summary>
        /// Builds the default screen from the primary screen
        /// </summary>
        public Screen()
        {
            var current_screen = System.Windows.Forms.Screen.PrimaryScreen;
            this._width = current_screen.Bounds.Width;
            this._height = current_screen.Bounds.Height;

            this._usable_height = current_screen.WorkingArea.Height;
            this._usable_width = current_screen.WorkingArea.Width;
            this._bpp = current_screen.BitsPerPixel;

            this._name = current_screen.DeviceName;
            this._primary = current_screen.Primary;
        }

        /// <summary>
        /// Creates a custom screen
        /// </summary>
        /// <param name="width">Screen width</param>
        /// <param name="height">Screen height</param>
        /// <param name="usable_width">Usable screen width</param>
        /// <param name="usable_height">Usable screen height</param>
        /// <param name="bpp">Number of bits of memory asosciated with 1 pixel of data</param>
        /// <param name="name">Screen name</param>
        /// <param name="primary">If this screen is the primary screen</param>
        public Screen(int width,int height,int usable_width,int usable_height,int bpp,string name,bool primary)
        {
            this._width = width;
            this._height = height;

            this._usable_height = usable_height;
            this._usable_width = usable_width;

            this._bpp = bpp;
            this._name = name;
            this._primary = primary;
        }

        /// <summary>
        /// Creates a screen from a System.Windows.Forms.Screen object
        /// </summary>
        /// <param name="screen"></param>
        public Screen(System.Windows.Forms.Screen screen) : this(screen.Bounds.Width, screen.Bounds.Height, screen.WorkingArea.Width, screen.WorkingArea.Height, screen.BitsPerPixel, screen.DeviceName, screen.Primary)
        {

        }
        #endregion

        #region functions
        #endregion
    }
}
